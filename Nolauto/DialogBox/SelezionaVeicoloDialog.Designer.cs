namespace Nolauto.DialogBox
{
    partial class SelezionaVeicoloDialog
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
            this.lstVeicoli = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstVeicoli
            // 
            this.lstVeicoli.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstVeicoli.FormattingEnabled = true;
            this.lstVeicoli.Location = new System.Drawing.Point(0, 0);
            this.lstVeicoli.Name = "lstVeicoli";
            this.lstVeicoli.Size = new System.Drawing.Size(283, 309);
            this.lstVeicoli.TabIndex = 0;
            this.lstVeicoli.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstVeicoli_MouseDoubleClick);
            // 
            // SelezionaVeicoloDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 309);
            this.Controls.Add(this.lstVeicoli);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelezionaVeicoloDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Seleziona Veicolo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstVeicoli;
    }
}