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
            this.chkInLibreria = new System.Windows.Forms.CheckBox();
            this.numSconto = new System.Windows.Forms.NumericUpDown();
            this.btnAggiungi = new System.Windows.Forms.Button();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblRicerca = new System.Windows.Forms.Label();
            this.txtRicerca = new System.Windows.Forms.TextBox();
            this.lblImmagine = new System.Windows.Forms.Label();
            this.btnImmagine = new System.Windows.Forms.Button();
            this.lblOrdinamento = new System.Windows.Forms.Label();
            this.cmbOrdinamento = new System.Windows.Forms.ComboBox();
            this.chkDecrescente = new System.Windows.Forms.CheckBox();
            this.lblVista = new System.Windows.Forms.Label();
            this.cmbVista = new System.Windows.Forms.ComboBox();
            this.lblAnteprima = new System.Windows.Forms.Label();
            this.picAnteprima = new System.Windows.Forms.PictureBox();
            this.lstGiochi = new System.Windows.Forms.ListBox();
            this.btnModifica = new System.Windows.Forms.Button();
            this.btnElimina = new System.Windows.Forms.Button();
            this.btnSalva = new System.Windows.Forms.Button();
            this.btnCarica = new System.Windows.Forms.Button();
            this.lblTotale = new System.Windows.Forms.Label();
            this.lblTitolo = new System.Windows.Forms.Label();
            this.lblPrezzo = new System.Windows.Forms.Label();
            this.lblSconto = new System.Windows.Forms.Label();
            this.pnlAuth = new System.Windows.Forms.Panel();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtLoginPassword = new System.Windows.Forms.TextBox();
            this.lblAuthPassword = new System.Windows.Forms.Label();
            this.txtLoginUser = new System.Windows.Forms.TextBox();
            this.lblAuthUtente = new System.Windows.Forms.Label();
            this.lblAuthTitolo = new System.Windows.Forms.Label();
            this.pnlApp = new System.Windows.Forms.Panel();
            this.lblUtenteCorrente = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numPrezzo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSconto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnteprima)).BeginInit();
            this.pnlAuth.SuspendLayout();
            this.pnlApp.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTitolo
            // 
            this.txtTitolo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(45)))), ((int)(((byte)(64)))));
            this.txtTitolo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTitolo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(212)))), ((int)(((byte)(223)))));
            this.txtTitolo.Location = new System.Drawing.Point(12, 31);
            this.txtTitolo.Name = "txtTitolo";
            this.txtTitolo.Size = new System.Drawing.Size(280, 24);
            this.txtTitolo.TabIndex = 0;
            // 
            // numPrezzo
            // 
            this.numPrezzo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.numPrezzo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(45)))), ((int)(((byte)(64)))));
            this.numPrezzo.DecimalPlaces = 2;
            this.numPrezzo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(212)))), ((int)(((byte)(223)))));
            this.numPrezzo.Location = new System.Drawing.Point(310, 31);
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
            this.chkScontato.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(212)))), ((int)(((byte)(223)))));
            this.chkScontato.Location = new System.Drawing.Point(400, 12);
            this.chkScontato.Name = "chkScontato";
            this.chkScontato.Size = new System.Drawing.Size(78, 21);
            this.chkScontato.TabIndex = 2;
            this.chkScontato.Text = "Scontato";
            this.chkScontato.UseVisualStyleBackColor = true;
            // 
            // chkInLibreria
            // 
            this.chkInLibreria.AutoSize = true;
            this.chkInLibreria.BackColor = System.Drawing.Color.Transparent;
            this.chkInLibreria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(212)))), ((int)(((byte)(223)))));
            this.chkInLibreria.Location = new System.Drawing.Point(400, 39);
            this.chkInLibreria.Name = "chkInLibreria";
            this.chkInLibreria.Size = new System.Drawing.Size(82, 21);
            this.chkInLibreria.TabIndex = 3;
            this.chkInLibreria.Text = "In libreria";
            this.chkInLibreria.UseVisualStyleBackColor = false;
            // 
            // numSconto
            // 
            this.numSconto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.numSconto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(45)))), ((int)(((byte)(64)))));
            this.numSconto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(212)))), ((int)(((byte)(223)))));
            this.numSconto.Location = new System.Drawing.Point(310, 90);
            this.numSconto.Name = "numSconto";
            this.numSconto.Size = new System.Drawing.Size(60, 24);
            this.numSconto.TabIndex = 4;
            // 
            // btnAggiungi
            // 
            this.btnAggiungi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAggiungi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(104)))), ((int)(((byte)(168)))));
            this.btnAggiungi.FlatAppearance.BorderSize = 0;
            this.btnAggiungi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAggiungi.ForeColor = System.Drawing.Color.White;
            this.btnAggiungi.Location = new System.Drawing.Point(12, 133);
            this.btnAggiungi.Name = "btnAggiungi";
            this.btnAggiungi.Size = new System.Drawing.Size(100, 26);
            this.btnAggiungi.TabIndex = 5;
            this.btnAggiungi.Text = "Aggiungi";
            this.btnAggiungi.UseVisualStyleBackColor = false;
            this.btnAggiungi.Click += new System.EventHandler(this.btnAggiungi_Click);
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(45)))), ((int)(((byte)(64)))));
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(212)))), ((int)(((byte)(223)))));
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Items.AddRange(new object[] {
            "Base",
            "DLC",
            "Early Access"});
            this.cmbCategoria.Location = new System.Drawing.Point(12, 90);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(248, 25);
            this.cmbCategoria.TabIndex = 6;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(212)))), ((int)(((byte)(223)))));
            this.lblCategoria.Location = new System.Drawing.Point(12, 70);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(65, 17);
            this.lblCategoria.TabIndex = 12;
            this.lblCategoria.Text = "Categoria";
            // 
            // lblRicerca
            // 
            this.lblRicerca.AutoSize = true;
            this.lblRicerca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(212)))), ((int)(((byte)(223)))));
            this.lblRicerca.Location = new System.Drawing.Point(587, 31);
            this.lblRicerca.Name = "lblRicerca";
            this.lblRicerca.Size = new System.Drawing.Size(50, 17);
            this.lblRicerca.TabIndex = 14;
            this.lblRicerca.Text = "Ricerca";
            // 
            // txtRicerca
            // 
            this.txtRicerca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(45)))), ((int)(((byte)(64)))));
            this.txtRicerca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRicerca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(212)))), ((int)(((byte)(223)))));
            this.txtRicerca.Location = new System.Drawing.Point(643, 31);
            this.txtRicerca.Name = "txtRicerca";
            this.txtRicerca.Size = new System.Drawing.Size(232, 24);
            this.txtRicerca.TabIndex = 7;
            this.txtRicerca.TextChanged += new System.EventHandler(this.txtRicerca_TextChanged);
            // 
            // lblImmagine
            // 
            this.lblImmagine.AutoSize = true;
            this.lblImmagine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(212)))), ((int)(((byte)(223)))));
            this.lblImmagine.Location = new System.Drawing.Point(397, 70);
            this.lblImmagine.Name = "lblImmagine";
            this.lblImmagine.Size = new System.Drawing.Size(65, 17);
            this.lblImmagine.TabIndex = 15;
            this.lblImmagine.Text = "Immagine";
            // 
            // btnImmagine
            // 
            this.btnImmagine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(75)))), ((int)(((byte)(111)))));
            this.btnImmagine.FlatAppearance.BorderSize = 0;
            this.btnImmagine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImmagine.ForeColor = System.Drawing.Color.White;
            this.btnImmagine.Location = new System.Drawing.Point(400, 95);
            this.btnImmagine.Name = "btnImmagine";
            this.btnImmagine.Size = new System.Drawing.Size(140, 26);
            this.btnImmagine.TabIndex = 8;
            this.btnImmagine.Text = "Seleziona";
            this.btnImmagine.UseVisualStyleBackColor = false;
            this.btnImmagine.Click += new System.EventHandler(this.btnImmagine_Click);
            // 
            // lblOrdinamento
            // 
            this.lblOrdinamento.AutoSize = true;
            this.lblOrdinamento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(212)))), ((int)(((byte)(223)))));
            this.lblOrdinamento.Location = new System.Drawing.Point(564, 95);
            this.lblOrdinamento.Name = "lblOrdinamento";
            this.lblOrdinamento.Size = new System.Drawing.Size(72, 17);
            this.lblOrdinamento.TabIndex = 16;
            this.lblOrdinamento.Text = "Ordina per";
            // 
            // cmbOrdinamento
            // 
            this.cmbOrdinamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(45)))), ((int)(((byte)(64)))));
            this.cmbOrdinamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrdinamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbOrdinamento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(212)))), ((int)(((byte)(223)))));
            this.cmbOrdinamento.FormattingEnabled = true;
            this.cmbOrdinamento.Items.AddRange(new object[] {
            "Titolo",
            "Categoria",
            "Prezzo"});
            this.cmbOrdinamento.Location = new System.Drawing.Point(643, 92);
            this.cmbOrdinamento.Name = "cmbOrdinamento";
            this.cmbOrdinamento.Size = new System.Drawing.Size(140, 25);
            this.cmbOrdinamento.TabIndex = 10;
            this.cmbOrdinamento.SelectedIndexChanged += new System.EventHandler(this.cmbOrdinamento_SelectedIndexChanged);
            // 
            // chkDecrescente
            // 
            this.chkDecrescente.AutoSize = true;
            this.chkDecrescente.BackColor = System.Drawing.Color.Transparent;
            this.chkDecrescente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(212)))), ((int)(((byte)(223)))));
            this.chkDecrescente.Location = new System.Drawing.Point(789, 94);
            this.chkDecrescente.Name = "chkDecrescente";
            this.chkDecrescente.Size = new System.Drawing.Size(98, 21);
            this.chkDecrescente.TabIndex = 11;
            this.chkDecrescente.Text = "Decrescente";
            this.chkDecrescente.UseVisualStyleBackColor = false;
            this.chkDecrescente.CheckedChanged += new System.EventHandler(this.chkDecrescente_CheckedChanged);
            // 
            // lblVista
            // 
            this.lblVista.AutoSize = true;
            this.lblVista.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(212)))), ((int)(((byte)(223)))));
            this.lblVista.Location = new System.Drawing.Point(600, 64);
            this.lblVista.Name = "lblVista";
            this.lblVista.Size = new System.Drawing.Size(36, 17);
            this.lblVista.TabIndex = 17;
            this.lblVista.Text = "Vista";
            // 
            // cmbVista
            // 
            this.cmbVista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(45)))), ((int)(((byte)(64)))));
            this.cmbVista.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbVista.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(212)))), ((int)(((byte)(223)))));
            this.cmbVista.FormattingEnabled = true;
            this.cmbVista.Items.AddRange(new object[] {
            "Tutti",
            "Catalogo",
            "Libreria"});
            this.cmbVista.Location = new System.Drawing.Point(643, 61);
            this.cmbVista.Name = "cmbVista";
            this.cmbVista.Size = new System.Drawing.Size(95, 25);
            this.cmbVista.TabIndex = 12;
            this.cmbVista.SelectedIndexChanged += new System.EventHandler(this.cmbVista_SelectedIndexChanged);
            // 
            // lblAnteprima
            // 
            this.lblAnteprima.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAnteprima.AutoSize = true;
            this.lblAnteprima.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(212)))), ((int)(((byte)(223)))));
            this.lblAnteprima.Location = new System.Drawing.Point(662, 170);
            this.lblAnteprima.Name = "lblAnteprima";
            this.lblAnteprima.Size = new System.Drawing.Size(68, 17);
            this.lblAnteprima.TabIndex = 18;
            this.lblAnteprima.Text = "Anteprima";
            // 
            // picAnteprima
            // 
            this.picAnteprima.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picAnteprima.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(45)))), ((int)(((byte)(64)))));
            this.picAnteprima.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picAnteprima.Location = new System.Drawing.Point(662, 190);
            this.picAnteprima.Name = "picAnteprima";
            this.picAnteprima.Size = new System.Drawing.Size(246, 291);
            this.picAnteprima.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAnteprima.TabIndex = 18;
            this.picAnteprima.TabStop = false;
            this.picAnteprima.Click += new System.EventHandler(this.picAnteprima_Click);
            // 
            // lstGiochi
            // 
            this.lstGiochi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstGiochi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(45)))), ((int)(((byte)(64)))));
            this.lstGiochi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstGiochi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(212)))), ((int)(((byte)(223)))));
            this.lstGiochi.FormattingEnabled = true;
            this.lstGiochi.ItemHeight = 17;
            this.lstGiochi.Location = new System.Drawing.Point(12, 190);
            this.lstGiochi.Name = "lstGiochi";
            this.lstGiochi.Size = new System.Drawing.Size(634, 291);
            this.lstGiochi.TabIndex = 10;
            this.lstGiochi.SelectedIndexChanged += new System.EventHandler(this.lstGiochi_SelectedIndexChanged);
            // 
            // btnModifica
            // 
            this.btnModifica.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnModifica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(125)))), ((int)(((byte)(92)))));
            this.btnModifica.FlatAppearance.BorderSize = 0;
            this.btnModifica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifica.ForeColor = System.Drawing.Color.White;
            this.btnModifica.Location = new System.Drawing.Point(230, 520);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(100, 28);
            this.btnModifica.TabIndex = 14;
            this.btnModifica.Text = "Modifica";
            this.btnModifica.UseVisualStyleBackColor = false;
            this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);
            // 
            // btnElimina
            // 
            this.btnElimina.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnElimina.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(65)))), ((int)(((byte)(60)))));
            this.btnElimina.FlatAppearance.BorderSize = 0;
            this.btnElimina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnElimina.ForeColor = System.Drawing.Color.White;
            this.btnElimina.Location = new System.Drawing.Point(340, 520);
            this.btnElimina.Name = "btnElimina";
            this.btnElimina.Size = new System.Drawing.Size(100, 28);
            this.btnElimina.TabIndex = 15;
            this.btnElimina.Text = "Elimina";
            this.btnElimina.UseVisualStyleBackColor = false;
            this.btnElimina.Click += new System.EventHandler(this.btnElimina_Click);
            // 
            // btnSalva
            // 
            this.btnSalva.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSalva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(75)))), ((int)(((byte)(111)))));
            this.btnSalva.FlatAppearance.BorderSize = 0;
            this.btnSalva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalva.ForeColor = System.Drawing.Color.White;
            this.btnSalva.Location = new System.Drawing.Point(12, 520);
            this.btnSalva.Name = "btnSalva";
            this.btnSalva.Size = new System.Drawing.Size(100, 28);
            this.btnSalva.TabIndex = 12;
            this.btnSalva.Text = "Salva JSON";
            this.btnSalva.UseVisualStyleBackColor = false;
            this.btnSalva.Click += new System.EventHandler(this.btnSalva_Click);
            // 
            // btnCarica
            // 
            this.btnCarica.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCarica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(75)))), ((int)(((byte)(111)))));
            this.btnCarica.FlatAppearance.BorderSize = 0;
            this.btnCarica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarica.ForeColor = System.Drawing.Color.White;
            this.btnCarica.Location = new System.Drawing.Point(120, 520);
            this.btnCarica.Name = "btnCarica";
            this.btnCarica.Size = new System.Drawing.Size(100, 28);
            this.btnCarica.TabIndex = 13;
            this.btnCarica.Text = "Carica JSON";
            this.btnCarica.UseVisualStyleBackColor = false;
            this.btnCarica.Click += new System.EventHandler(this.btnCarica_Click);
            // 
            // lblTotale
            // 
            this.lblTotale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotale.AutoSize = true;
            this.lblTotale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(212)))), ((int)(((byte)(223)))));
            this.lblTotale.Location = new System.Drawing.Point(460, 526);
            this.lblTotale.Name = "lblTotale";
            this.lblTotale.Size = new System.Drawing.Size(88, 17);
            this.lblTotale.TabIndex = 19;
            this.lblTotale.Text = "Totale: 0 euro";
            // 
            // lblTitolo
            // 
            this.lblTitolo.AutoSize = true;
            this.lblTitolo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(212)))), ((int)(((byte)(223)))));
            this.lblTitolo.Location = new System.Drawing.Point(12, 12);
            this.lblTitolo.Name = "lblTitolo";
            this.lblTitolo.Size = new System.Drawing.Size(41, 17);
            this.lblTitolo.TabIndex = 9;
            this.lblTitolo.Text = "Titolo";
            // 
            // lblPrezzo
            // 
            this.lblPrezzo.AutoSize = true;
            this.lblPrezzo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(212)))), ((int)(((byte)(223)))));
            this.lblPrezzo.Location = new System.Drawing.Point(310, 12);
            this.lblPrezzo.Name = "lblPrezzo";
            this.lblPrezzo.Size = new System.Drawing.Size(47, 17);
            this.lblPrezzo.TabIndex = 10;
            this.lblPrezzo.Text = "Prezzo";
            // 
            // lblSconto
            // 
            this.lblSconto.AutoSize = true;
            this.lblSconto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(212)))), ((int)(((byte)(223)))));
            this.lblSconto.Location = new System.Drawing.Point(310, 70);
            this.lblSconto.Name = "lblSconto";
            this.lblSconto.Size = new System.Drawing.Size(48, 17);
            this.lblSconto.TabIndex = 11;
            this.lblSconto.Text = "Sconto";
            // 
            // pnlAuth
            // 
            this.pnlAuth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(40)))), ((int)(((byte)(56)))));
            this.pnlAuth.Controls.Add(this.btnRegister);
            this.pnlAuth.Controls.Add(this.btnLogin);
            this.pnlAuth.Controls.Add(this.txtLoginPassword);
            this.pnlAuth.Controls.Add(this.lblAuthPassword);
            this.pnlAuth.Controls.Add(this.txtLoginUser);
            this.pnlAuth.Controls.Add(this.lblAuthUtente);
            this.pnlAuth.Controls.Add(this.lblAuthTitolo);
            this.pnlAuth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAuth.Location = new System.Drawing.Point(0, 0);
            this.pnlAuth.Name = "pnlAuth";
            this.pnlAuth.Size = new System.Drawing.Size(920, 600);
            this.pnlAuth.TabIndex = 20;
            this.pnlAuth.Visible = false;
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(75)))), ((int)(((byte)(111)))));
            this.btnRegister.FlatAppearance.BorderSize = 0;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(486, 320);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(100, 28);
            this.btnRegister.TabIndex = 6;
            this.btnRegister.Text = "Registra";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(104)))), ((int)(((byte)(168)))));
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(366, 320);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(100, 28);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Accedi";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtLoginPassword
            // 
            this.txtLoginPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(45)))), ((int)(((byte)(64)))));
            this.txtLoginPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLoginPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(212)))), ((int)(((byte)(223)))));
            this.txtLoginPassword.Location = new System.Drawing.Point(366, 270);
            this.txtLoginPassword.Name = "txtLoginPassword";
            this.txtLoginPassword.Size = new System.Drawing.Size(220, 24);
            this.txtLoginPassword.TabIndex = 4;
            this.txtLoginPassword.UseSystemPasswordChar = true;
            // 
            // lblAuthPassword
            // 
            this.lblAuthPassword.AutoSize = true;
            this.lblAuthPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(212)))), ((int)(((byte)(223)))));
            this.lblAuthPassword.Location = new System.Drawing.Point(363, 252);
            this.lblAuthPassword.Name = "lblAuthPassword";
            this.lblAuthPassword.Size = new System.Drawing.Size(64, 17);
            this.lblAuthPassword.TabIndex = 3;
            this.lblAuthPassword.Text = "Password";
            // 
            // txtLoginUser
            // 
            this.txtLoginUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(45)))), ((int)(((byte)(64)))));
            this.txtLoginUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLoginUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(212)))), ((int)(((byte)(223)))));
            this.txtLoginUser.Location = new System.Drawing.Point(366, 218);
            this.txtLoginUser.Name = "txtLoginUser";
            this.txtLoginUser.Size = new System.Drawing.Size(220, 24);
            this.txtLoginUser.TabIndex = 2;
            // 
            // lblAuthUtente
            // 
            this.lblAuthUtente.AutoSize = true;
            this.lblAuthUtente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(212)))), ((int)(((byte)(223)))));
            this.lblAuthUtente.Location = new System.Drawing.Point(363, 200);
            this.lblAuthUtente.Name = "lblAuthUtente";
            this.lblAuthUtente.Size = new System.Drawing.Size(46, 17);
            this.lblAuthUtente.TabIndex = 1;
            this.lblAuthUtente.Text = "Utente";
            // 
            // lblAuthTitolo
            // 
            this.lblAuthTitolo.AutoSize = true;
            this.lblAuthTitolo.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblAuthTitolo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(212)))), ((int)(((byte)(223)))));
            this.lblAuthTitolo.Location = new System.Drawing.Point(360, 140);
            this.lblAuthTitolo.Name = "lblAuthTitolo";
            this.lblAuthTitolo.Size = new System.Drawing.Size(118, 37);
            this.lblAuthTitolo.TabIndex = 0;
            this.lblAuthTitolo.Text = "Accesso";
            // 
            // pnlApp
            // 
            this.pnlApp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(40)))), ((int)(((byte)(56)))));
            this.pnlApp.Controls.Add(this.lblUtenteCorrente);
            this.pnlApp.Controls.Add(this.picAnteprima);
            this.pnlApp.Controls.Add(this.lblAnteprima);
            this.pnlApp.Controls.Add(this.cmbVista);
            this.pnlApp.Controls.Add(this.lblVista);
            this.pnlApp.Controls.Add(this.chkDecrescente);
            this.pnlApp.Controls.Add(this.cmbOrdinamento);
            this.pnlApp.Controls.Add(this.lblOrdinamento);
            this.pnlApp.Controls.Add(this.btnImmagine);
            this.pnlApp.Controls.Add(this.lblImmagine);
            this.pnlApp.Controls.Add(this.txtRicerca);
            this.pnlApp.Controls.Add(this.lblRicerca);
            this.pnlApp.Controls.Add(this.lblSconto);
            this.pnlApp.Controls.Add(this.lblPrezzo);
            this.pnlApp.Controls.Add(this.lblTitolo);
            this.pnlApp.Controls.Add(this.lblCategoria);
            this.pnlApp.Controls.Add(this.lblTotale);
            this.pnlApp.Controls.Add(this.btnCarica);
            this.pnlApp.Controls.Add(this.btnSalva);
            this.pnlApp.Controls.Add(this.btnElimina);
            this.pnlApp.Controls.Add(this.btnModifica);
            this.pnlApp.Controls.Add(this.lstGiochi);
            this.pnlApp.Controls.Add(this.cmbCategoria);
            this.pnlApp.Controls.Add(this.btnAggiungi);
            this.pnlApp.Controls.Add(this.numSconto);
            this.pnlApp.Controls.Add(this.chkInLibreria);
            this.pnlApp.Controls.Add(this.chkScontato);
            this.pnlApp.Controls.Add(this.numPrezzo);
            this.pnlApp.Controls.Add(this.txtTitolo);
            this.pnlApp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlApp.Location = new System.Drawing.Point(0, 0);
            this.pnlApp.Name = "pnlApp";
            this.pnlApp.Size = new System.Drawing.Size(920, 600);
            this.pnlApp.TabIndex = 21;
            // 
            // lblUtenteCorrente
            // 
            this.lblUtenteCorrente.AutoSize = true;
            this.lblUtenteCorrente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(212)))), ((int)(((byte)(223)))));
            this.lblUtenteCorrente.Location = new System.Drawing.Point(587, 138);
            this.lblUtenteCorrente.Name = "lblUtenteCorrente";
            this.lblUtenteCorrente.Size = new System.Drawing.Size(49, 17);
            this.lblUtenteCorrente.TabIndex = 22;
            this.lblUtenteCorrente.Text = "Utente:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(40)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(920, 600);
            this.Controls.Add(this.pnlApp);
            this.Controls.Add(this.pnlAuth);
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
            ((System.ComponentModel.ISupportInitialize)(this.picAnteprima)).EndInit();
            this.pnlAuth.ResumeLayout(false);
            this.pnlAuth.PerformLayout();
            this.pnlApp.ResumeLayout(false);
            this.pnlApp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtTitolo;
        private System.Windows.Forms.NumericUpDown numPrezzo;
        private System.Windows.Forms.CheckBox chkScontato;
        private System.Windows.Forms.CheckBox chkInLibreria;
        private System.Windows.Forms.NumericUpDown numSconto;
        private System.Windows.Forms.Button btnAggiungi;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblRicerca;
        private System.Windows.Forms.TextBox txtRicerca;
        private System.Windows.Forms.Label lblImmagine;
        private System.Windows.Forms.Button btnImmagine;
        private System.Windows.Forms.Label lblOrdinamento;
        private System.Windows.Forms.ComboBox cmbOrdinamento;
        private System.Windows.Forms.CheckBox chkDecrescente;
        private System.Windows.Forms.Label lblVista;
        private System.Windows.Forms.ComboBox cmbVista;
        private System.Windows.Forms.Label lblAnteprima;
        private System.Windows.Forms.PictureBox picAnteprima;
        private System.Windows.Forms.ListBox lstGiochi;
        private System.Windows.Forms.Button btnModifica;
        private System.Windows.Forms.Button btnElimina;
        private System.Windows.Forms.Button btnSalva;
        private System.Windows.Forms.Button btnCarica;
        private System.Windows.Forms.Label lblTotale;
        private System.Windows.Forms.Label lblTitolo;
        private System.Windows.Forms.Label lblPrezzo;
        private System.Windows.Forms.Label lblSconto;
        private System.Windows.Forms.Panel pnlAuth;
        private System.Windows.Forms.Label lblAuthTitolo;
        private System.Windows.Forms.Label lblAuthUtente;
        private System.Windows.Forms.TextBox txtLoginUser;
        private System.Windows.Forms.Label lblAuthPassword;
        private System.Windows.Forms.TextBox txtLoginPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Panel pnlApp;
        private System.Windows.Forms.Label lblUtenteCorrente;
    }
}

