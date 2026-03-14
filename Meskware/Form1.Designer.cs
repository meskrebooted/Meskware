namespace Meskware
{
    partial class Form1
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
            this.txtTitolo = new System.Windows.Forms.TextBox();
            this.numPrezzo = new System.Windows.Forms.NumericUpDown();
            this.chkScontato = new System.Windows.Forms.CheckBox();
            this.numSconto = new System.Windows.Forms.NumericUpDown();
            this.btnAggiungi = new System.Windows.Forms.Button();
            this.lstGiochi = new System.Windows.Forms.ListBox();
            this.btnSalva = new System.Windows.Forms.Button();
            this.btnCarica = new System.Windows.Forms.Button();
            this.lblTotale = new System.Windows.Forms.Label();
            this.lblTitolo = new System.Windows.Forms.Label();
            this.lblPrezzo = new System.Windows.Forms.Label();
            this.lblSconto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numPrezzo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSconto)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTitolo
            // 
            this.txtTitolo.Location = new System.Drawing.Point(12, 31);
            this.txtTitolo.Name = "txtTitolo";
            this.txtTitolo.Size = new System.Drawing.Size(180, 20);
            this.txtTitolo.TabIndex = 0;
            // 
            // numPrezzo
            // 
            this.numPrezzo.DecimalPlaces = 2;
            this.numPrezzo.Location = new System.Drawing.Point(208, 31);
            this.numPrezzo.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numPrezzo.Name = "numPrezzo";
            this.numPrezzo.Size = new System.Drawing.Size(80, 20);
            this.numPrezzo.TabIndex = 1;
            // 
            // chkScontato
            // 
            this.chkScontato.AutoSize = true;
            this.chkScontato.Location = new System.Drawing.Point(304, 33);
            this.chkScontato.Name = "chkScontato";
            this.chkScontato.Size = new System.Drawing.Size(68, 17);
            this.chkScontato.TabIndex = 2;
            this.chkScontato.Text = "Scontato";
            this.chkScontato.UseVisualStyleBackColor = true;
            // 
            // numSconto
            // 
            this.numSconto.Location = new System.Drawing.Point(385, 31);
            this.numSconto.Name = "numSconto";
            this.numSconto.Size = new System.Drawing.Size(60, 20);
            this.numSconto.TabIndex = 3;
            // 
            // btnAggiungi
            // 
            this.btnAggiungi.Location = new System.Drawing.Point(462, 29);
            this.btnAggiungi.Name = "btnAggiungi";
            this.btnAggiungi.Size = new System.Drawing.Size(100, 23);
            this.btnAggiungi.TabIndex = 4;
            this.btnAggiungi.Text = "Aggiungi";
            this.btnAggiungi.UseVisualStyleBackColor = true;
            this.btnAggiungi.Click += new System.EventHandler(this.btnAggiungi_Click);
            // 
            // lstGiochi
            // 
            this.lstGiochi.FormattingEnabled = true;
            this.lstGiochi.Location = new System.Drawing.Point(12, 70);
            this.lstGiochi.Name = "lstGiochi";
            this.lstGiochi.Size = new System.Drawing.Size(550, 212);
            this.lstGiochi.TabIndex = 5;
            // 
            // btnSalva
            // 
            this.btnSalva.Location = new System.Drawing.Point(12, 300);
            this.btnSalva.Name = "btnSalva";
            this.btnSalva.Size = new System.Drawing.Size(100, 28);
            this.btnSalva.TabIndex = 6;
            this.btnSalva.Text = "Salva JSON";
            this.btnSalva.UseVisualStyleBackColor = true;
            this.btnSalva.Click += new System.EventHandler(this.btnSalva_Click);
            // 
            // btnCarica
            // 
            this.btnCarica.Location = new System.Drawing.Point(128, 300);
            this.btnCarica.Name = "btnCarica";
            this.btnCarica.Size = new System.Drawing.Size(100, 28);
            this.btnCarica.TabIndex = 7;
            this.btnCarica.Text = "Carica JSON";
            this.btnCarica.UseVisualStyleBackColor = true;
            this.btnCarica.Click += new System.EventHandler(this.btnCarica_Click);
            // 
            // lblTotale
            // 
            this.lblTotale.AutoSize = true;
            this.lblTotale.Location = new System.Drawing.Point(260, 308);
            this.lblTotale.Name = "lblTotale";
            this.lblTotale.Size = new System.Drawing.Size(70, 13);
            this.lblTotale.TabIndex = 8;
            this.lblTotale.Text = "Totale: 0 euro";
            // 
            // lblTitolo
            // 
            this.lblTitolo.AutoSize = true;
            this.lblTitolo.Location = new System.Drawing.Point(12, 12);
            this.lblTitolo.Name = "lblTitolo";
            this.lblTitolo.Size = new System.Drawing.Size(33, 13);
            this.lblTitolo.TabIndex = 9;
            this.lblTitolo.Text = "Titolo";
            // 
            // lblPrezzo
            // 
            this.lblPrezzo.AutoSize = true;
            this.lblPrezzo.Location = new System.Drawing.Point(205, 12);
            this.lblPrezzo.Name = "lblPrezzo";
            this.lblPrezzo.Size = new System.Drawing.Size(39, 13);
            this.lblPrezzo.TabIndex = 10;
            this.lblPrezzo.Text = "Prezzo";
            // 
            // lblSconto
            // 
            this.lblSconto.AutoSize = true;
            this.lblSconto.Location = new System.Drawing.Point(382, 12);
            this.lblSconto.Name = "lblSconto";
            this.lblSconto.Size = new System.Drawing.Size(41, 13);
            this.lblSconto.TabIndex = 11;
            this.lblSconto.Text = "Sconto";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 342);
            this.Controls.Add(this.lblSconto);
            this.Controls.Add(this.lblPrezzo);
            this.Controls.Add(this.lblTitolo);
            this.Controls.Add(this.lblTotale);
            this.Controls.Add(this.btnCarica);
            this.Controls.Add(this.btnSalva);
            this.Controls.Add(this.lstGiochi);
            this.Controls.Add(this.btnAggiungi);
            this.Controls.Add(this.numSconto);
            this.Controls.Add(this.chkScontato);
            this.Controls.Add(this.numPrezzo);
            this.Controls.Add(this.txtTitolo);
            this.Name = "Form1";
            this.Text = "Meskware - Versione semplice";
            ((System.ComponentModel.ISupportInitialize)(this.numPrezzo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSconto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtTitolo;
        private System.Windows.Forms.NumericUpDown numPrezzo;
        private System.Windows.Forms.CheckBox chkScontato;
        private System.Windows.Forms.NumericUpDown numSconto;
        private System.Windows.Forms.Button btnAggiungi;
        private System.Windows.Forms.ListBox lstGiochi;
        private System.Windows.Forms.Button btnSalva;
        private System.Windows.Forms.Button btnCarica;
        private System.Windows.Forms.Label lblTotale;
        private System.Windows.Forms.Label lblTitolo;
        private System.Windows.Forms.Label lblPrezzo;
        private System.Windows.Forms.Label lblSconto;
    }
}

