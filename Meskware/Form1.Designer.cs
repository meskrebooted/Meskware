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
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblRicerca = new System.Windows.Forms.Label();
            this.txtRicerca = new System.Windows.Forms.TextBox();
            this.lblOrdinamento = new System.Windows.Forms.Label();
            this.cmbOrdinamento = new System.Windows.Forms.ComboBox();
            this.chkDecrescente = new System.Windows.Forms.CheckBox();
            this.lstGiochi = new System.Windows.Forms.ListBox();
            this.btnModifica = new System.Windows.Forms.Button();
            this.btnElimina = new System.Windows.Forms.Button();
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
            this.txtTitolo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTitolo.BackColor = System.Drawing.Color.White;
            this.txtTitolo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTitolo.Location = new System.Drawing.Point(12, 31);
            this.txtTitolo.Name = "txtTitolo";
            this.txtTitolo.Size = new System.Drawing.Size(260, 24);
            this.txtTitolo.TabIndex = 0;
            // 
            // numPrezzo
            // 
            this.numPrezzo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.numPrezzo.BackColor = System.Drawing.Color.White;
            this.numPrezzo.DecimalPlaces = 2;
            this.numPrezzo.Location = new System.Drawing.Point(286, 31);
            this.numPrezzo.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numPrezzo.Name = "numPrezzo";
            this.numPrezzo.Size = new System.Drawing.Size(80, 24);
            this.numPrezzo.TabIndex = 1;
            // 
            // chkScontato
            // 
            this.chkScontato.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chkScontato.AutoSize = true;
            this.chkScontato.BackColor = System.Drawing.Color.Transparent;
            this.chkScontato.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.chkScontato.Location = new System.Drawing.Point(382, 33);
            this.chkScontato.Name = "chkScontato";
            this.chkScontato.Size = new System.Drawing.Size(78, 21);
            this.chkScontato.TabIndex = 2;
            this.chkScontato.Text = "Scontato";
            this.chkScontato.UseVisualStyleBackColor = true;
            // 
            // numSconto
            // 
            this.numSconto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.numSconto.BackColor = System.Drawing.Color.White;
            this.numSconto.Location = new System.Drawing.Point(463, 31);
            this.numSconto.Name = "numSconto";
            this.numSconto.Size = new System.Drawing.Size(60, 24);
            this.numSconto.TabIndex = 3;
            // 
            // btnAggiungi
            // 
            this.btnAggiungi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAggiungi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnAggiungi.FlatAppearance.BorderSize = 0;
            this.btnAggiungi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAggiungi.ForeColor = System.Drawing.Color.White;
            this.btnAggiungi.Location = new System.Drawing.Point(535, 29);
            this.btnAggiungi.Name = "btnAggiungi";
            this.btnAggiungi.Size = new System.Drawing.Size(100, 26);
            this.btnAggiungi.TabIndex = 4;
            this.btnAggiungi.Text = "Aggiungi";
            this.btnAggiungi.UseVisualStyleBackColor = false;
            this.btnAggiungi.Click += new System.EventHandler(this.btnAggiungi_Click);
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbCategoria.BackColor = System.Drawing.Color.White;
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Items.AddRange(new object[] {
            "Base",
            "DLC",
            "Early Access"});
            this.cmbCategoria.Location = new System.Drawing.Point(12, 74);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(260, 25);
            this.cmbCategoria.TabIndex = 5;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(99)))), ((int)(((byte)(104)))));
            this.lblCategoria.Location = new System.Drawing.Point(12, 55);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(65, 17);
            this.lblCategoria.TabIndex = 12;
            this.lblCategoria.Text = "Categoria";
            // 
            // lblRicerca
            // 
            this.lblRicerca.AutoSize = true;
            this.lblRicerca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(99)))), ((int)(((byte)(104)))));
            this.lblRicerca.Location = new System.Drawing.Point(286, 55);
            this.lblRicerca.Name = "lblRicerca";
            this.lblRicerca.Size = new System.Drawing.Size(50, 17);
            this.lblRicerca.TabIndex = 14;
            this.lblRicerca.Text = "Ricerca";
            // 
            // txtRicerca
            // 
            this.txtRicerca.BackColor = System.Drawing.Color.White;
            this.txtRicerca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRicerca.Location = new System.Drawing.Point(286, 74);
            this.txtRicerca.Name = "txtRicerca";
            this.txtRicerca.Size = new System.Drawing.Size(237, 24);
            this.txtRicerca.TabIndex = 6;
            this.txtRicerca.TextChanged += new System.EventHandler(this.txtRicerca_TextChanged);
            // 
            // lblOrdinamento
            // 
            this.lblOrdinamento.AutoSize = true;
            this.lblOrdinamento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(99)))), ((int)(((byte)(104)))));
            this.lblOrdinamento.Location = new System.Drawing.Point(286, 104);
            this.lblOrdinamento.Name = "lblOrdinamento";
            this.lblOrdinamento.Size = new System.Drawing.Size(72, 17);
            this.lblOrdinamento.TabIndex = 15;
            this.lblOrdinamento.Text = "Ordina per";
            // 
            // cmbOrdinamento
            // 
            this.cmbOrdinamento.BackColor = System.Drawing.Color.White;
            this.cmbOrdinamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrdinamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbOrdinamento.FormattingEnabled = true;
            this.cmbOrdinamento.Items.AddRange(new object[] {
            "Titolo",
            "Categoria",
            "Prezzo"});
            this.cmbOrdinamento.Location = new System.Drawing.Point(286, 122);
            this.cmbOrdinamento.Name = "cmbOrdinamento";
            this.cmbOrdinamento.Size = new System.Drawing.Size(140, 25);
            this.cmbOrdinamento.TabIndex = 7;
            this.cmbOrdinamento.SelectedIndexChanged += new System.EventHandler(this.cmbOrdinamento_SelectedIndexChanged);
            // 
            // chkDecrescente
            // 
            this.chkDecrescente.AutoSize = true;
            this.chkDecrescente.BackColor = System.Drawing.Color.Transparent;
            this.chkDecrescente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.chkDecrescente.Location = new System.Drawing.Point(444, 125);
            this.chkDecrescente.Name = "chkDecrescente";
            this.chkDecrescente.Size = new System.Drawing.Size(98, 21);
            this.chkDecrescente.TabIndex = 8;
            this.chkDecrescente.Text = "Decrescente";
            this.chkDecrescente.UseVisualStyleBackColor = false;
            this.chkDecrescente.CheckedChanged += new System.EventHandler(this.chkDecrescente_CheckedChanged);
            // 
            // lstGiochi
            // 
            this.lstGiochi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstGiochi.BackColor = System.Drawing.Color.White;
            this.lstGiochi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstGiochi.FormattingEnabled = true;
            this.lstGiochi.ItemHeight = 17;
            this.lstGiochi.Location = new System.Drawing.Point(12, 155);
            this.lstGiochi.Name = "lstGiochi";
            this.lstGiochi.Size = new System.Drawing.Size(623, 155);
            this.lstGiochi.TabIndex = 9;
            this.lstGiochi.SelectedIndexChanged += new System.EventHandler(this.lstGiochi_SelectedIndexChanged);
            // 
            // btnModifica
            // 
            this.btnModifica.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnModifica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnModifica.FlatAppearance.BorderSize = 0;
            this.btnModifica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifica.ForeColor = System.Drawing.Color.White;
            this.btnModifica.Location = new System.Drawing.Point(244, 340);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(100, 28);
            this.btnModifica.TabIndex = 12;
            this.btnModifica.Text = "Modifica";
            this.btnModifica.UseVisualStyleBackColor = false;
            this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);
            // 
            // btnElimina
            // 
            this.btnElimina.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnElimina.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnElimina.FlatAppearance.BorderSize = 0;
            this.btnElimina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnElimina.ForeColor = System.Drawing.Color.White;
            this.btnElimina.Location = new System.Drawing.Point(360, 340);
            this.btnElimina.Name = "btnElimina";
            this.btnElimina.Size = new System.Drawing.Size(100, 28);
            this.btnElimina.TabIndex = 13;
            this.btnElimina.Text = "Elimina";
            this.btnElimina.UseVisualStyleBackColor = false;
            this.btnElimina.Click += new System.EventHandler(this.btnElimina_Click);
            // 
            // btnSalva
            // 
            this.btnSalva.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSalva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.btnSalva.FlatAppearance.BorderSize = 0;
            this.btnSalva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalva.ForeColor = System.Drawing.Color.White;
            this.btnSalva.Location = new System.Drawing.Point(12, 340);
            this.btnSalva.Name = "btnSalva";
            this.btnSalva.Size = new System.Drawing.Size(100, 28);
            this.btnSalva.TabIndex = 10;
            this.btnSalva.Text = "Salva JSON";
            this.btnSalva.UseVisualStyleBackColor = false;
            this.btnSalva.Click += new System.EventHandler(this.btnSalva_Click);
            // 
            // btnCarica
            // 
            this.btnCarica.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCarica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.btnCarica.FlatAppearance.BorderSize = 0;
            this.btnCarica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarica.ForeColor = System.Drawing.Color.White;
            this.btnCarica.Location = new System.Drawing.Point(128, 340);
            this.btnCarica.Name = "btnCarica";
            this.btnCarica.Size = new System.Drawing.Size(100, 28);
            this.btnCarica.TabIndex = 11;
            this.btnCarica.Text = "Carica JSON";
            this.btnCarica.UseVisualStyleBackColor = false;
            this.btnCarica.Click += new System.EventHandler(this.btnCarica_Click);
            // 
            // lblTotale
            // 
            this.lblTotale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotale.AutoSize = true;
            this.lblTotale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.lblTotale.Location = new System.Drawing.Point(500, 347);
            this.lblTotale.Name = "lblTotale";
            this.lblTotale.Size = new System.Drawing.Size(88, 17);
            this.lblTotale.TabIndex = 16;
            this.lblTotale.Text = "Totale: 0 euro";
            // 
            // lblTitolo
            // 
            this.lblTitolo.AutoSize = true;
            this.lblTitolo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(99)))), ((int)(((byte)(104)))));
            this.lblTitolo.Location = new System.Drawing.Point(12, 12);
            this.lblTitolo.Name = "lblTitolo";
            this.lblTitolo.Size = new System.Drawing.Size(41, 17);
            this.lblTitolo.TabIndex = 9;
            this.lblTitolo.Text = "Titolo";
            // 
            // lblPrezzo
            // 
            this.lblPrezzo.AutoSize = true;
            this.lblPrezzo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(99)))), ((int)(((byte)(104)))));
            this.lblPrezzo.Location = new System.Drawing.Point(286, 12);
            this.lblPrezzo.Name = "lblPrezzo";
            this.lblPrezzo.Size = new System.Drawing.Size(47, 17);
            this.lblPrezzo.TabIndex = 10;
            this.lblPrezzo.Text = "Prezzo";
            // 
            // lblSconto
            // 
            this.lblSconto.AutoSize = true;
            this.lblSconto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(99)))), ((int)(((byte)(104)))));
            this.lblSconto.Location = new System.Drawing.Point(460, 12);
            this.lblSconto.Name = "lblSconto";
            this.lblSconto.Size = new System.Drawing.Size(48, 17);
            this.lblSconto.TabIndex = 11;
            this.lblSconto.Text = "Sconto";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(647, 382);
            this.Controls.Add(this.chkDecrescente);
            this.Controls.Add(this.cmbOrdinamento);
            this.Controls.Add(this.lblOrdinamento);
            this.Controls.Add(this.txtRicerca);
            this.Controls.Add(this.lblRicerca);
            this.Controls.Add(this.lblSconto);
            this.Controls.Add(this.lblPrezzo);
            this.Controls.Add(this.lblTitolo);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblTotale);
            this.Controls.Add(this.btnCarica);
            this.Controls.Add(this.btnSalva);
            this.Controls.Add(this.btnElimina);
            this.Controls.Add(this.btnModifica);
            this.Controls.Add(this.lstGiochi);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.btnAggiungi);
            this.Controls.Add(this.numSconto);
            this.Controls.Add(this.chkScontato);
            this.Controls.Add(this.numPrezzo);
            this.Controls.Add(this.txtTitolo);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Meskware";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblRicerca;
        private System.Windows.Forms.TextBox txtRicerca;
        private System.Windows.Forms.Label lblOrdinamento;
        private System.Windows.Forms.ComboBox cmbOrdinamento;
        private System.Windows.Forms.CheckBox chkDecrescente;
        private System.Windows.Forms.ListBox lstGiochi;
        private System.Windows.Forms.Button btnModifica;
        private System.Windows.Forms.Button btnElimina;
        private System.Windows.Forms.Button btnSalva;
        private System.Windows.Forms.Button btnCarica;
        private System.Windows.Forms.Label lblTotale;
        private System.Windows.Forms.Label lblTitolo;
        private System.Windows.Forms.Label lblPrezzo;
        private System.Windows.Forms.Label lblSconto;
    }
}

