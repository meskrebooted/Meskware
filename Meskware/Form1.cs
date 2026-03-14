using System;
using System.IO;
using System.Windows.Forms;

namespace Meskware
{
    public partial class Form1 : Form
    {
        private readonly Libreria _libreria;
        private readonly PersistenzaJson _persistenza;
        private readonly string _percorso;

        public Form1()
        {
            InitializeComponent();
            _libreria = new Libreria();
            _persistenza = new PersistenzaJson();
            _percorso = Path.Combine(Application.StartupPath, "dati.json");
            AggiornaLista();
        }

        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            var titolo = txtTitolo.Text.Trim();
            if (string.IsNullOrWhiteSpace(titolo))
            {
                MessageBox.Show("Inserisci un titolo.");
                return;
            }

            if (chkScontato.Checked)
            {
                _libreria.Aggiungi(new GiocoScontato(titolo, numPrezzo.Value, (int)numSconto.Value));
            }
            else
            {
                _libreria.Aggiungi(titolo, numPrezzo.Value);
            }

            txtTitolo.Clear();
            numPrezzo.Value = 0;
            numSconto.Value = 0;
            chkScontato.Checked = false;
            AggiornaLista();
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            _persistenza.Salva(_percorso, _libreria);
            MessageBox.Show("Salvataggio completato.");
        }

        private void btnCarica_Click(object sender, EventArgs e)
        {
            _persistenza.Carica(_percorso, _libreria);
            AggiornaLista();
            MessageBox.Show("Caricamento completato.");
        }

        private void AggiornaLista()
        {
            lstGiochi.Items.Clear();
            foreach (var gioco in _libreria.Giochi)
            {
                lstGiochi.Items.Add(gioco.ToString());
            }

            lblTotale.Text = string.Format("Totale: {0:0.00} euro", _libreria.TotaleValore());
        }
    }
}
