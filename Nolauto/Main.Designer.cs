namespace Nolauto
{
    partial class Main
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuovoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvaComeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.esciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstVeicoli = new System.Windows.Forms.ListView();
            this.colTarga = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMarca = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTariffa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colKilowatt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstNoleggi = new System.Windows.Forms.ListView();
            this.colId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDataInizio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNumeroGiorni = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCosto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCliente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPostiCapacita = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mainMenu.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(781, 24);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuovoToolStripMenuItem,
            this.apriToolStripMenuItem,
            this.salvaToolStripMenuItem,
            this.salvaComeToolStripMenuItem,
            this.esciToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // nuovoToolStripMenuItem
            // 
            this.nuovoToolStripMenuItem.Name = "nuovoToolStripMenuItem";
            this.nuovoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nuovoToolStripMenuItem.Text = "&Nuovo";
            // 
            // apriToolStripMenuItem
            // 
            this.apriToolStripMenuItem.Name = "apriToolStripMenuItem";
            this.apriToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.apriToolStripMenuItem.Text = "&Apri";
            // 
            // salvaToolStripMenuItem
            // 
            this.salvaToolStripMenuItem.Name = "salvaToolStripMenuItem";
            this.salvaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salvaToolStripMenuItem.Text = "&Salva";
            // 
            // salvaComeToolStripMenuItem
            // 
            this.salvaComeToolStripMenuItem.Name = "salvaComeToolStripMenuItem";
            this.salvaComeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salvaComeToolStripMenuItem.Text = "Sa&lva come...";
            // 
            // esciToolStripMenuItem
            // 
            this.esciToolStripMenuItem.Name = "esciToolStripMenuItem";
            this.esciToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.esciToolStripMenuItem.Text = "&Esci";
            this.esciToolStripMenuItem.Click += new System.EventHandler(this.esciToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstVeicoli);
            this.groupBox1.Location = new System.Drawing.Point(13, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(373, 323);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Veicoli";
            // 
            // lstVeicoli
            // 
            this.lstVeicoli.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colTarga,
            this.colMarca,
            this.colTariffa,
            this.colKilowatt,
            this.colPostiCapacita});
            this.lstVeicoli.FullRowSelect = true;
            this.lstVeicoli.GridLines = true;
            this.lstVeicoli.HideSelection = false;
            this.lstVeicoli.Location = new System.Drawing.Point(6, 19);
            this.lstVeicoli.MultiSelect = false;
            this.lstVeicoli.Name = "lstVeicoli";
            this.lstVeicoli.Size = new System.Drawing.Size(361, 298);
            this.lstVeicoli.TabIndex = 0;
            this.lstVeicoli.UseCompatibleStateImageBehavior = false;
            this.lstVeicoli.View = System.Windows.Forms.View.Details;
            // 
            // colTarga
            // 
            this.colTarga.Text = "Targa";
            // 
            // colMarca
            // 
            this.colMarca.Text = "Marca";
            this.colMarca.Width = 103;
            // 
            // colTariffa
            // 
            this.colTariffa.Text = "Tariffa";
            this.colTariffa.Width = 55;
            // 
            // colKilowatt
            // 
            this.colKilowatt.Text = "Kilowatt";
            this.colKilowatt.Width = 50;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstNoleggi);
            this.groupBox2.Location = new System.Drawing.Point(392, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(377, 323);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Noleggi";
            // 
            // lstNoleggi
            // 
            this.lstNoleggi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colId,
            this.colDataInizio,
            this.colNumeroGiorni,
            this.colCosto,
            this.colCliente});
            this.lstNoleggi.FullRowSelect = true;
            this.lstNoleggi.GridLines = true;
            this.lstNoleggi.HideSelection = false;
            this.lstNoleggi.Location = new System.Drawing.Point(6, 19);
            this.lstNoleggi.MultiSelect = false;
            this.lstNoleggi.Name = "lstNoleggi";
            this.lstNoleggi.Size = new System.Drawing.Size(365, 298);
            this.lstNoleggi.TabIndex = 0;
            this.lstNoleggi.UseCompatibleStateImageBehavior = false;
            this.lstNoleggi.View = System.Windows.Forms.View.Details;
            // 
            // colId
            // 
            this.colId.Text = "Id";
            this.colId.Width = 27;
            // 
            // colDataInizio
            // 
            this.colDataInizio.Text = "Data Inizio";
            this.colDataInizio.Width = 73;
            // 
            // colNumeroGiorni
            // 
            this.colNumeroGiorni.Text = "Numero Giorni";
            this.colNumeroGiorni.Width = 84;
            // 
            // colCosto
            // 
            this.colCosto.Text = "Costo";
            // 
            // colCliente
            // 
            this.colCliente.Text = "Cliente";
            this.colCliente.Width = 116;
            // 
            // colPostiCapacita
            // 
            this.colPostiCapacita.Text = "Posti/Capacità";
            this.colPostiCapacita.Width = 87;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 363);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.mainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.mainMenu;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nolauto";
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuovoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem apriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvaComeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem esciToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lstVeicoli;
        private System.Windows.Forms.ColumnHeader colTarga;
        private System.Windows.Forms.ColumnHeader colMarca;
        private System.Windows.Forms.ColumnHeader colTariffa;
        private System.Windows.Forms.ColumnHeader colKilowatt;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView lstNoleggi;
        private System.Windows.Forms.ColumnHeader colId;
        private System.Windows.Forms.ColumnHeader colDataInizio;
        private System.Windows.Forms.ColumnHeader colNumeroGiorni;
        private System.Windows.Forms.ColumnHeader colCosto;
        private System.Windows.Forms.ColumnHeader colCliente;
        private System.Windows.Forms.ColumnHeader colPostiCapacita;
    }
}

