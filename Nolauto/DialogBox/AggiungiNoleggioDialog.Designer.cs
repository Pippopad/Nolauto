namespace Nolauto.DialogBox
{
    partial class AggiungiNoleggioDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtTarga = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKilowatt = new System.Windows.Forms.NumericUpDown();
            this.txtPostiCapacita = new System.Windows.Forms.NumericUpDown();
            this.lblPostiCapacita = new System.Windows.Forms.Label();
            this.btnAggiungi = new System.Windows.Forms.Button();
            this.btnSelezionaVeicolo = new System.Windows.Forms.Button();
            this.btnSelezionaCliente = new System.Windows.Forms.Button();
            this.dtpDataInizio = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.txtKilowatt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPostiCapacita)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Veicolo:";
            // 
            // txtTarga
            // 
            this.txtTarga.Location = new System.Drawing.Point(59, 10);
            this.txtTarga.Name = "txtTarga";
            this.txtTarga.ReadOnly = true;
            this.txtTarga.Size = new System.Drawing.Size(97, 20);
            this.txtTarga.TabIndex = 1;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(59, 36);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(97, 20);
            this.txtMarca.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cliente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Numero giorni:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Data inizio:";
            // 
            // txtKilowatt
            // 
            this.txtKilowatt.Location = new System.Drawing.Point(131, 89);
            this.txtKilowatt.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.txtKilowatt.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtKilowatt.Name = "txtKilowatt";
            this.txtKilowatt.Size = new System.Drawing.Size(74, 20);
            this.txtKilowatt.TabIndex = 9;
            this.txtKilowatt.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtPostiCapacita
            // 
            this.txtPostiCapacita.Location = new System.Drawing.Point(131, 115);
            this.txtPostiCapacita.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.txtPostiCapacita.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtPostiCapacita.Name = "txtPostiCapacita";
            this.txtPostiCapacita.Size = new System.Drawing.Size(74, 20);
            this.txtPostiCapacita.TabIndex = 11;
            this.txtPostiCapacita.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblPostiCapacita
            // 
            this.lblPostiCapacita.AutoSize = true;
            this.lblPostiCapacita.Location = new System.Drawing.Point(13, 117);
            this.lblPostiCapacita.Name = "lblPostiCapacita";
            this.lblPostiCapacita.Size = new System.Drawing.Size(37, 13);
            this.lblPostiCapacita.TabIndex = 10;
            this.lblPostiCapacita.Text = "Costo:";
            // 
            // btnAggiungi
            // 
            this.btnAggiungi.Location = new System.Drawing.Point(131, 141);
            this.btnAggiungi.Name = "btnAggiungi";
            this.btnAggiungi.Size = new System.Drawing.Size(75, 23);
            this.btnAggiungi.TabIndex = 12;
            this.btnAggiungi.Text = "Aggiungi";
            this.btnAggiungi.UseVisualStyleBackColor = true;
            this.btnAggiungi.Click += new System.EventHandler(this.btnAggiungi_Click);
            // 
            // btnSelezionaVeicolo
            // 
            this.btnSelezionaVeicolo.Location = new System.Drawing.Point(163, 8);
            this.btnSelezionaVeicolo.Name = "btnSelezionaVeicolo";
            this.btnSelezionaVeicolo.Size = new System.Drawing.Size(43, 23);
            this.btnSelezionaVeicolo.TabIndex = 13;
            this.btnSelezionaVeicolo.Text = "...";
            this.btnSelezionaVeicolo.UseVisualStyleBackColor = true;
            // 
            // btnSelezionaCliente
            // 
            this.btnSelezionaCliente.Location = new System.Drawing.Point(163, 34);
            this.btnSelezionaCliente.Name = "btnSelezionaCliente";
            this.btnSelezionaCliente.Size = new System.Drawing.Size(43, 23);
            this.btnSelezionaCliente.TabIndex = 14;
            this.btnSelezionaCliente.Text = "...";
            this.btnSelezionaCliente.UseVisualStyleBackColor = true;
            // 
            // dtpDataInizio
            // 
            this.dtpDataInizio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataInizio.Location = new System.Drawing.Point(121, 62);
            this.dtpDataInizio.MinDate = new System.DateTime(System.DateTime.Today.Year, System.DateTime.Today.Month, System.DateTime.Today.Day + 1);
            this.dtpDataInizio.Name = "dtpDataInizio";
            this.dtpDataInizio.Size = new System.Drawing.Size(84, 20);
            this.dtpDataInizio.TabIndex = 15;
            // 
            // AggiungiNoleggioDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(217, 171);
            this.Controls.Add(this.dtpDataInizio);
            this.Controls.Add(this.btnSelezionaCliente);
            this.Controls.Add(this.btnSelezionaVeicolo);
            this.Controls.Add(this.btnAggiungi);
            this.Controls.Add(this.txtPostiCapacita);
            this.Controls.Add(this.lblPostiCapacita);
            this.Controls.Add(this.txtKilowatt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTarga);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AggiungiNoleggioDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Aggiungi Noleggio";
            ((System.ComponentModel.ISupportInitialize)(this.txtKilowatt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPostiCapacita)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTarga;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown txtKilowatt;
        private System.Windows.Forms.NumericUpDown txtPostiCapacita;
        private System.Windows.Forms.Label lblPostiCapacita;
        private System.Windows.Forms.Button btnAggiungi;
        private System.Windows.Forms.Button btnSelezionaVeicolo;
        private System.Windows.Forms.Button btnSelezionaCliente;
        private System.Windows.Forms.DateTimePicker dtpDataInizio;
    }
}