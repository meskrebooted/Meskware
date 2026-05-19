using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Meskware
{
    public partial class Form1 : Form
    {
        #region Campi
        private readonly Libreria _libreria;
        private readonly PersistenzaJson _persistenza;
        private const string CartellaImmagini = "immagini";
        private const string CartellaUtenti = "utenti";
        private string _percorsoImmagineSelezionata = string.Empty;
        private string _utenteCorrente = string.Empty;
        private string _hashCorrente = string.Empty;
        private string _percorsoUtente = string.Empty;
        #endregion

        public Form1()
        {
            InitializeComponent();
            _libreria = new Libreria();
            _persistenza = new PersistenzaJson();
            cmbCategoria.SelectedIndex = 0;
            cmbOrdinamento.SelectedIndex = 0;
            cmbVista.SelectedIndex = 0;
            ImpostaStatoAutenticazione(false);
        }

        #region Autenticazione
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!TryLeggiCredenziali(out var username, out var password))
            {
                return;
            }

            var percorso = PercorsoUtente(username);
            var dati = _persistenza.CaricaUtente(percorso);
            if (dati == null)
            {
                MessageBox.Show("Utente non trovato.");
                return;
            }

            var hash = HashPassword(password);
            if (!string.Equals(dati.PasswordHash, hash, StringComparison.Ordinal))
            {
                MessageBox.Show("Password errata.");
                return;
            }

            _utenteCorrente = dati.Username ?? username;
            _hashCorrente = hash;
            _percorsoUtente = percorso;
            _persistenza.ApplicaGiochi(dati, _libreria);
            lblUtenteCorrente.Text = string.Format("Utente: {0}", _utenteCorrente);
            AggiornaLista();
            ImpostaStatoAutenticazione(true);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (!TryLeggiCredenziali(out var username, out var password))
            {
                return;
            }

            var percorso = PercorsoUtente(username);
            if (File.Exists(percorso))
            {
                MessageBox.Show("Utente già registrato.");
                return;
            }

            var hash = HashPassword(password);
            _libreria.Sostituisci(new List<Gioco>());
            _persistenza.SalvaUtente(percorso, username, hash, _libreria);

            _utenteCorrente = username;
            _hashCorrente = hash;
            _percorsoUtente = percorso;
            lblUtenteCorrente.Text = string.Format("Utente: {0}", _utenteCorrente);
            AggiornaLista();
            ImpostaStatoAutenticazione(true);
        }

        private void ImpostaStatoAutenticazione(bool autenticato)
        {
            pnlAuth.Visible = !autenticato;
            pnlApp.Visible = autenticato;
            AcceptButton = autenticato ? btnAggiungi : btnLogin;
            if (!autenticato)
            {
                txtLoginUser.Clear();
                txtLoginPassword.Clear();
            }
        }

        private bool TryLeggiCredenziali(out string username, out string password)
        {
            username = txtLoginUser.Text.Trim();
            password = txtLoginPassword.Text;
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Inserisci utente e password.");
                return false;
            }

            return true;
        }

        private string PercorsoUtente(string username)
        {
            var nomeFile = NormalizzaNomeFile(username);
            var cartella = Path.Combine(Application.StartupPath, CartellaUtenti);
            Directory.CreateDirectory(cartella);
            return Path.Combine(cartella, string.Format("{0}.json", nomeFile));
        }

        private static string NormalizzaNomeFile(string username)
        {
            // Rimuove caratteri non validi per i nomi file.
            var invalidi = Path.GetInvalidFileNameChars();
            var pulito = new string(username.Where(c => !invalidi.Contains(c)).ToArray());
            return string.IsNullOrWhiteSpace(pulito) ? "utente" : pulito;
        }

        private static string HashPassword(string password)
        {
            // Hash locale per evitare password in chiaro.
            using (var sha = SHA256.Create())
            {
                var bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(password));
                return Convert.ToBase64String(bytes);
            }
        }
        #endregion

        #region Gestione giochi
        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            var titolo = txtTitolo.Text.Trim();
            if (string.IsNullOrWhiteSpace(titolo))
            {
                MessageBox.Show("Inserisci un titolo.");
                return;
            }

            if (numPrezzo.Value < 0)
            {
                MessageBox.Show("Il prezzo non può essere negativo.");
                return;
            }

            var categoria = (cmbCategoria.SelectedItem as string) ?? "Base";
            var percorsoImmagine = _percorsoImmagineSelezionata;
            var inLibreria = chkInLibreria.Checked;

            if (chkScontato.Checked)
            {
                _libreria.Aggiungi(new GiocoScontato(
                    titolo,
                    categoria,
                    numPrezzo.Value,
                    (int)numSconto.Value,
                    percorsoImmagine,
                    inLibreria));
            }
            else
            {
                _libreria.Aggiungi(new Gioco(
                    titolo,
                    categoria,
                    numPrezzo.Value,
                    percorsoImmagine,
                    inLibreria));
            }

            // Reset campi
            txtTitolo.Clear();
            numPrezzo.Value = 0;
            numSconto.Value = 0;
            chkScontato.Checked = false;
            chkInLibreria.Checked = false;
            cmbCategoria.SelectedIndex = 0;
            _percorsoImmagineSelezionata = string.Empty;
            AggiornaAnteprima(string.Empty);
            AggiornaLista();
        }


        private void btnModifica_Click(object sender, EventArgs e)
        {
            var selezionato = lstGiochi.SelectedItem as Gioco;
            if (selezionato == null)
            {
                MessageBox.Show("Seleziona un gioco da modificare.");
                return;
            }

            var indice = TrovaIndiceGioco(selezionato);
            if (indice < 0)
            {
                MessageBox.Show("Il gioco selezionato non è più disponibile.");
                return;
            }

            var titolo = txtTitolo.Text.Trim();
            if (string.IsNullOrWhiteSpace(titolo))
            {
                MessageBox.Show("Inserisci un titolo.");
                return;
            }

            Gioco aggiornato;
            var categoria = (cmbCategoria.SelectedItem as string) ?? "Base";
            var percorsoImmagine = _percorsoImmagineSelezionata;
            var inLibreria = chkInLibreria.Checked;
            if (chkScontato.Checked)
            {
                aggiornato = new GiocoScontato(titolo, categoria, numPrezzo.Value, (int)numSconto.Value, percorsoImmagine, inLibreria);
            }
            else
            {
                aggiornato = new Gioco(titolo, categoria, numPrezzo.Value, percorsoImmagine, inLibreria);
            }

            _libreria.SostituisciAt(indice, aggiornato);
            AggiornaLista();
            if (lstGiochi.Items.Contains(aggiornato))
            {
                lstGiochi.SelectedItem = aggiornato;
            }
        }

        private void btnElimina_Click(object sender, EventArgs e)
        {
            var selezionato = lstGiochi.SelectedItem as Gioco;
            if (selezionato == null)
            {
                MessageBox.Show("Seleziona un gioco da eliminare.");
                return;
            }

            var indice = TrovaIndiceGioco(selezionato);
            if (indice < 0)
            {
                MessageBox.Show("Il gioco selezionato non è più disponibile.");
                return;
            }

            _libreria.RimuoviAt(indice);
            AggiornaLista();

            if (lstGiochi.Items.Count > 0)
            {
                lstGiochi.SelectedIndex = Math.Min(indice, lstGiochi.Items.Count - 1);
            }
            else
            {
                txtTitolo.Clear();
                numPrezzo.Value = 0;
                numSconto.Value = 0;
                chkScontato.Checked = false;
                chkInLibreria.Checked = false;
                cmbCategoria.SelectedIndex = 0;
                _percorsoImmagineSelezionata = string.Empty;
                AggiornaAnteprima(string.Empty);
            }
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(_percorsoUtente))
            {
                MessageBox.Show("Accedi prima di salvare.");
                return;
            }

            _persistenza.SalvaUtente(_percorsoUtente, _utenteCorrente, _hashCorrente, _libreria);
            MessageBox.Show("Salvataggio completato.");
        }

        private void btnCarica_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(_percorsoUtente))
            {
                MessageBox.Show("Accedi prima di caricare.");
                return;
            }

            var dati = _persistenza.CaricaUtente(_percorsoUtente);
            if (dati == null)
            {
                MessageBox.Show("File utente non trovato.");
                return;
            }

            _persistenza.ApplicaGiochi(dati, _libreria);
            AggiornaLista();
            MessageBox.Show("Caricamento completato.");
        }
        #endregion

        #region Filtri e lista
        private void AggiornaLista()
        {
            // Ridisegna la lista da zero per tenerla allineata ai dati reali.
            var selezionato = lstGiochi.SelectedItem as Gioco;
            lstGiochi.Items.Clear();

            var ricerca = txtRicerca.Text.Trim();
            IEnumerable<Gioco> giochi = _libreria.Giochi;
            var vista = (cmbVista.SelectedItem as string) ?? "Tutti";
            switch (vista)
            {
                case "Catalogo":
                    giochi = giochi.Where(g => !g.InLibreria);
                    break;
                case "Libreria":
                    giochi = giochi.Where(g => g.InLibreria);
                    break;
            }
            if (!string.IsNullOrWhiteSpace(ricerca))
            {
                giochi = giochi.Where(g =>
                    g.Titolo.IndexOf(ricerca, StringComparison.CurrentCultureIgnoreCase) >= 0
                    || g.Categoria.IndexOf(ricerca, StringComparison.CurrentCultureIgnoreCase) >= 0);
            }

            var ordinamento = (cmbOrdinamento.SelectedItem as string) ?? "Titolo";
            switch (ordinamento)
            {
                case "Categoria":
                    giochi = chkDecrescente.Checked
                        ? giochi.OrderByDescending(g => g.Categoria, StringComparer.CurrentCultureIgnoreCase)
                            .ThenByDescending(g => g.Titolo, StringComparer.CurrentCultureIgnoreCase)
                        : giochi.OrderBy(g => g.Categoria, StringComparer.CurrentCultureIgnoreCase)
                            .ThenBy(g => g.Titolo, StringComparer.CurrentCultureIgnoreCase);
                    break;
                case "Prezzo":
                    giochi = chkDecrescente.Checked
                        ? giochi.OrderByDescending(g => g.CalcolaPrezzo())
                        : giochi.OrderBy(g => g.CalcolaPrezzo());
                    break;
                default:
                    giochi = chkDecrescente.Checked
                        ? giochi.OrderByDescending(g => g.Titolo, StringComparer.CurrentCultureIgnoreCase)
                        : giochi.OrderBy(g => g.Titolo, StringComparer.CurrentCultureIgnoreCase);
                    break;
            }

            foreach (var gioco in giochi)
            {
                lstGiochi.Items.Add(gioco);
            }

            if (selezionato != null && lstGiochi.Items.Contains(selezionato))
            {
                lstGiochi.SelectedItem = selezionato;
            }

            var totaleCatalogo = _libreria.Giochi.Count;
            var totaleLibreria = _libreria.Giochi.Count(g => g.InLibreria);
            var spesa = _libreria.Giochi.Where(g => g.InLibreria).Sum(g => g.CalcolaPrezzo());
            lblTotale.Text = string.Format("Cat: {0} | Lib: {1} | Spesa: {2:0.00}€", totaleCatalogo, totaleLibreria, spesa);
        }

        private void lstGiochi_SelectedIndexChanged(object sender, EventArgs e)
        {
            var gioco = lstGiochi.SelectedItem as Gioco;
            if (gioco == null)
            {
                _percorsoImmagineSelezionata = string.Empty;
                AggiornaAnteprima(string.Empty);
                return;
            }

            txtTitolo.Text = gioco.Titolo;
            numPrezzo.Value = gioco.PrezzoBase;
            var indiceCategoria = cmbCategoria.Items.IndexOf(gioco.Categoria);
            cmbCategoria.SelectedIndex = indiceCategoria >= 0 ? indiceCategoria : 0;
            _percorsoImmagineSelezionata = gioco.PercorsoImmagine ?? string.Empty;
            AggiornaAnteprima(gioco.PercorsoImmagine);
            chkInLibreria.Checked = gioco.InLibreria;

            var scontato = gioco as GiocoScontato;
            if (scontato != null)
            {
                chkScontato.Checked = true;
                numSconto.Value = scontato.ScontoPercentuale;
            }
            else
            {
                chkScontato.Checked = false;
                numSconto.Value = 0;
            }
        }

        private void btnImmagine_Click(object sender, EventArgs e)
        {
            using (var dialog = new OpenFileDialog())
            {
                dialog.Filter = "Immagini|*.png;*.jpg;*.jpeg;*.bmp;*.gif";
                dialog.Title = "Seleziona un'immagine";
                if (dialog.ShowDialog(this) == DialogResult.OK)
                {
                    var percorsoSalvato = SalvaImmagineInCartella(dialog.FileName);
                    _percorsoImmagineSelezionata = percorsoSalvato;
                    AggiornaAnteprima(percorsoSalvato);
                }
            }
        }

        private void txtRicerca_TextChanged(object sender, EventArgs e)
        {
            AggiornaLista();
        }

        private void cmbOrdinamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            AggiornaLista();
        }

        private void cmbVista_SelectedIndexChanged(object sender, EventArgs e)
        {
            AggiornaLista();
        }

        private void chkDecrescente_CheckedChanged(object sender, EventArgs e)
        {
            AggiornaLista();
        }
        #endregion

        #region Immagini
        private void AggiornaAnteprima(string percorso)
        {
            if (picAnteprima.Image != null)
            {
                picAnteprima.Image.Dispose();
                picAnteprima.Image = null;
            }

            var percorsoEffettivo = RisolviPercorsoImmagine(percorso);
            if (string.IsNullOrWhiteSpace(percorsoEffettivo) || !File.Exists(percorsoEffettivo))
            {
                return;
            }

            // Carica in memoria per evitare lock sul file.
            using (var stream = new FileStream(percorsoEffettivo, FileMode.Open, FileAccess.Read))
            using (var immagine = Image.FromStream(stream))
            {
                picAnteprima.Image = new Bitmap(immagine);
            }
        }

        private string SalvaImmagineInCartella(string percorsoOriginale)
        {
            if (string.IsNullOrWhiteSpace(percorsoOriginale) || !File.Exists(percorsoOriginale))
            {
                return string.Empty;
            }

            var cartella = Path.Combine(Application.StartupPath, CartellaImmagini);
            Directory.CreateDirectory(cartella);

            var nomeFile = Path.GetFileName(percorsoOriginale);
            var destinazione = Path.Combine(cartella, nomeFile);
            if (string.Equals(Path.GetFullPath(percorsoOriginale), Path.GetFullPath(destinazione), StringComparison.OrdinalIgnoreCase))
            {
                return Path.Combine(CartellaImmagini, Path.GetFileName(destinazione));
            }
            if (File.Exists(destinazione))
            {
                // Aggiunge un suffisso numerico se il nome è già usato.
                var baseName = Path.GetFileNameWithoutExtension(nomeFile);
                var estensione = Path.GetExtension(nomeFile);
                var indice = 1;
                do
                {
                    destinazione = Path.Combine(cartella, string.Format("{0}-{1}{2}", baseName, indice, estensione));
                    indice++;
                }
                while (File.Exists(destinazione));
            }

            File.Copy(percorsoOriginale, destinazione, false);
            return Path.Combine(CartellaImmagini, Path.GetFileName(destinazione));
        }

        private string RisolviPercorsoImmagine(string percorso)
        {
            if (string.IsNullOrWhiteSpace(percorso))
            {
                return string.Empty;
            }

            return Path.IsPathRooted(percorso)
                ? percorso
                : Path.Combine(Application.StartupPath, percorso);
        }
        #endregion

        #region Utilita
        private int TrovaIndiceGioco(Gioco gioco)
        {
            if (gioco == null)
            {
                return -1;
            }

            for (var i = 0; i < _libreria.Giochi.Count; i++)
            {
                if (ReferenceEquals(_libreria.Giochi[i], gioco))
                {
                    return i;
                }
            }

            return -1;
        }
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            txtLoginUser.Select();
        }

        private void picAnteprima_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtTitolo.Clear();
            numPrezzo.Value = 0;
            numSconto.Value = 0;
            chkScontato.Checked = false;
            chkInLibreria.Checked = false;
            cmbCategoria.SelectedIndex = 0;
            _percorsoImmagineSelezionata = string.Empty;
            AggiornaAnteprima(string.Empty);

        }

        private void numPrezzo_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
