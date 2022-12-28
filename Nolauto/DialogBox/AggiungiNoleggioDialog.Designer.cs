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
            this.txtVeicolo = new System.Windows.Forms.TextBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumeroGiorni = new System.Windows.Forms.NumericUpDown();
            this.txtCosto = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAggiungi = new System.Windows.Forms.Button();
            this.btnSelezionaVeicolo = new System.Windows.Forms.Button();
            this.btnSelezionaCliente = new System.Windows.Forms.Button();
            this.dtpDataInizio = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroGiorni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCosto)).BeginInit();
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
            // txtVeicolo
            // 
            this.txtVeicolo.Location = new System.Drawing.Point(59, 10);
            this.txtVeicolo.Name = "txtVeicolo";
            this.txtVeicolo.ReadOnly = true;
            this.txtVeicolo.Size = new System.Drawing.Size(129, 20);
            this.txtVeicolo.TabIndex = 1;
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(59, 36);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.ReadOnly = true;
            this.txtCliente.Size = new System.Drawing.Size(129, 20);
            this.txtCliente.TabIndex = 3;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Numero giorni:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Data inizio:";
            // 
            // txtNumeroGiorni
            // 
            this.txtNumeroGiorni.Location = new System.Drawing.Point(162, 89);
            this.txtNumeroGiorni.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.txtNumeroGiorni.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtNumeroGiorni.Name = "txtNumeroGiorni";
            this.txtNumeroGiorni.Size = new System.Drawing.Size(74, 20);
            this.txtNumeroGiorni.TabIndex = 6;
            this.txtNumeroGiorni.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtCosto
            // 
            this.txtCosto.Location = new System.Drawing.Point(162, 115);
            this.txtCosto.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.txtCosto.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(74, 20);
            this.txtCosto.TabIndex = 7;
            this.txtCosto.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Costo:";
            // 
            // btnAggiungi
            // 
            this.btnAggiungi.Location = new System.Drawing.Point(162, 141);
            this.btnAggiungi.Name = "btnAggiungi";
            this.btnAggiungi.Size = new System.Drawing.Size(75, 23);
            this.btnAggiungi.TabIndex = 8;
            this.btnAggiungi.Text = "Aggiungi";
            this.btnAggiungi.UseVisualStyleBackColor = true;
            this.btnAggiungi.Click += new System.EventHandler(this.btnAggiungi_Click);
            // 
            // btnSelezionaVeicolo
            // 
            this.btnSelezionaVeicolo.Location = new System.Drawing.Point(194, 8);
            this.btnSelezionaVeicolo.Name = "btnSelezionaVeicolo";
            this.btnSelezionaVeicolo.Size = new System.Drawing.Size(43, 23);
            this.btnSelezionaVeicolo.TabIndex = 2;
            this.btnSelezionaVeicolo.Text = "...";
            this.btnSelezionaVeicolo.UseVisualStyleBackColor = true;
            this.btnSelezionaVeicolo.Click += new System.EventHandler(this.btnSelezionaVeicolo_Click);
            // 
            // btnSelezionaCliente
            // 
            this.btnSelezionaCliente.Location = new System.Drawing.Point(194, 34);
            this.btnSelezionaCliente.Name = "btnSelezionaCliente";
            this.btnSelezionaCliente.Size = new System.Drawing.Size(43, 23);
            this.btnSelezionaCliente.TabIndex = 4;
            this.btnSelezionaCliente.Text = "...";
            this.btnSelezionaCliente.UseVisualStyleBackColor = true;
            this.btnSelezionaCliente.Click += new System.EventHandler(this.btnSelezionaCliente_Click);
            // 
            // dtpDataInizio
            // 
            this.dtpDataInizio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataInizio.Location = new System.Drawing.Point(141, 62);
            this.dtpDataInizio.MinDate = new System.DateTime(2022, 12, 28, 0, 0, 0, 0);
            this.dtpDataInizio.Name = "dtpDataInizio";
            this.dtpDataInizio.Size = new System.Drawing.Size(95, 20);
            this.dtpDataInizio.TabIndex = 5;
            // 
            // AggiungiNoleggioDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 171);
            this.Controls.Add(this.dtpDataInizio);
            this.Controls.Add(this.btnSelezionaCliente);
            this.Controls.Add(this.btnSelezionaVeicolo);
            this.Controls.Add(this.btnAggiungi);
            this.Controls.Add(this.txtCosto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNumeroGiorni);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtVeicolo);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AggiungiNoleggioDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Aggiungi Noleggio";
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroGiorni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCosto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtVeicolo;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown txtNumeroGiorni;
        private System.Windows.Forms.NumericUpDown txtCosto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAggiungi;
        private System.Windows.Forms.Button btnSelezionaVeicolo;
        private System.Windows.Forms.Button btnSelezionaCliente;
        private System.Windows.Forms.DateTimePicker dtpDataInizio;
    }
}