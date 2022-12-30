using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nolauto
{
    public static class GestoreSalvataggi
    {
        class DatiSalvataggio
        {
            public List<Veicolo> veicoli { get; set; }
            public List<Cliente> clienti { get; set; }
            public List<Noleggio> noleggi { get; set; }
        };

        public static string PercorsoFile;
        public static string ProjectsDir { get; } = Path.Combine(Application.StartupPath, "Projects");

        public static void Inizializza(string percorsoFile = "")
        {
            if (!Directory.Exists(ProjectsDir))
                Directory.CreateDirectory(ProjectsDir);

            PercorsoFile = percorsoFile;
            if (Helper.ControlloStringa(percorsoFile)) Apri();
            else Nuovo();
        }

        public static void Nuovo()
        {
            PercorsoFile = "";

            GestoreVeicoli.Inizializza();
            GestoreClienti.Inizializza();
            GestoreNoleggi.Inizializza();
        }

        public static bool Apri()
        {
            if (!Helper.ControlloStringa(PercorsoFile)) return false;

            var json = File.ReadAllText(PercorsoFile);
            try
            {
                DatiSalvataggio dati = JsonConvert.DeserializeObject<DatiSalvataggio>(json);

                GestoreVeicoli.Inizializza(dati.veicoli);
                GestoreClienti.Inizializza(dati.clienti);
                GestoreNoleggi.Inizializza(dati.noleggi);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static void Salva()
        {
            if (!Helper.ControlloStringa(PercorsoFile)) return;

            DatiSalvataggio dati = new DatiSalvataggio()
            {
                veicoli = GestoreVeicoli.GetAll(),
                clienti = GestoreClienti.GetAll(),
                noleggi = GestoreNoleggi.GetAll(),
            };

            var json = JsonConvert.SerializeObject(dati, Formatting.Indented);
            File.WriteAllText(PercorsoFile, json);
        }
    }

    public class BaseClassConverter : CustomCreationConverter<Veicolo>
    {
        private TipoVeicolo _currentObjectType;

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jobj = JObject.ReadFrom(reader);
            _currentObjectType = jobj["__tipo__"].ToObject<TipoVeicolo>();
            return base.ReadJson(jobj.CreateReader(), objectType, existingValue, serializer);
        }

        public override Veicolo Create(Type objectType)
        {
            switch (_currentObjectType)
            {
                case TipoVeicolo.Automobile:
                    return new Automobile();
                case TipoVeicolo.Furgone:
                    return new Furgone();
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
