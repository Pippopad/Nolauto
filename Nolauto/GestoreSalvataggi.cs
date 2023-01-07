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
        struct DatiSalvataggio
        {
            public List<Veicolo> veicoli { get; set; }
            public List<Cliente> clienti { get; set; }
            public List<NoleggioSalvataggio> noleggi { get; set; }
        };

        struct NoleggioSalvataggio
        {
            public int Id { get; set; }
            public DateTime DataInizio { get; set; }
            public int NumeroGiorni { get; set; }
            public double Costo { get; set; }
            public string Cliente { get; set; }
            public string Veicolo { get; set; }
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

                List<Noleggio> noleggi = new List<Noleggio>();
                bool valido = true;
                dati.noleggi.ForEach((noleggio) =>
                {
                    noleggi.Add(new Noleggio()
                    {
                        Id = noleggio.Id,
                        DataInizio = noleggio.DataInizio,
                        NumeroGiorni = noleggio.NumeroGiorni,
                        Costo = noleggio.Costo,
                        Cliente = GestoreClienti.Get(noleggio.Cliente),
                        Veicolo = GestoreVeicoli.Get(noleggio.Veicolo),
                    });

                    valido &= noleggi.Last().Cliente != null && noleggi.Last().Veicolo != null;
                });
                if (!valido) return false;

                GestoreNoleggi.Inizializza(noleggi);

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

            List<NoleggioSalvataggio> noleggi = new List<NoleggioSalvataggio>();
            GestoreNoleggi.GetAll().ForEach((noleggio) => {
                noleggi.Add(new NoleggioSalvataggio()
                {
                    Id = noleggio.Id,
                    DataInizio = noleggio.DataInizio,
                    NumeroGiorni = noleggio.NumeroGiorni,
                    Costo = noleggio.Costo,
                    Cliente = noleggio.Cliente.CodiceFiscale,
                    Veicolo = noleggio.Veicolo.Targa,
                });
            });

            DatiSalvataggio dati = new DatiSalvataggio()
            {
                veicoli = GestoreVeicoli.GetAll(),
                clienti = GestoreClienti.GetAll(),
                noleggi = noleggi,
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
