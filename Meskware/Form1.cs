using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
            // Salva e carica sempre nello stesso file locale dell'app.
            _percorso = Path.Combine(Application.StartupPath, "dati.json");
            cmbCategoria.SelectedIndex = 0;
            cmbOrdinamento.SelectedIndex = 0;
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

            var categoria = (cmbCategoria.SelectedItem as string) ?? "Base";
            if (chkScontato.Checked)
            {
                // Se spuntato, crea direttamente la versione scontata.
                _libreria.Aggiungi(new GiocoScontato(titolo, categoria, numPrezzo.Value, (int)numSconto.Value));
            }
            else
            {
                _libreria.Aggiungi(titolo, categoria, numPrezzo.Value);
            }

            txtTitolo.Clear();
            numPrezzo.Value = 0;
            numSconto.Value = 0;
            chkScontato.Checked = false;
            cmbCategoria.SelectedIndex = 0;
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
            if (chkScontato.Checked)
            {
                aggiornato = new GiocoScontato(titolo, categoria, numPrezzo.Value, (int)numSconto.Value);
            }
            else
            {
                aggiornato = new Gioco(titolo, categoria, numPrezzo.Value);
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
                cmbCategoria.SelectedIndex = 0;
            }
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
            // Ridisegna la lista da zero per tenerla allineata ai dati reali.
            var selezionato = lstGiochi.SelectedItem as Gioco;
            lstGiochi.Items.Clear();

            var ricerca = txtRicerca.Text.Trim();
            IEnumerable<Gioco> giochi = _libreria.Giochi;
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

            lblTotale.Text = string.Format("Totale: {0:0.00} euro", _libreria.TotaleValore());
        }

        private void lstGiochi_SelectedIndexChanged(object sender, EventArgs e)
        {
            var gioco = lstGiochi.SelectedItem as Gioco;
            if (gioco == null)
            {
                return;
            }

            txtTitolo.Text = gioco.Titolo;
            numPrezzo.Value = gioco.PrezzoBase;
            var indiceCategoria = cmbCategoria.Items.IndexOf(gioco.Categoria);
            cmbCategoria.SelectedIndex = indiceCategoria >= 0 ? indiceCategoria : 0;

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

        private void txtRicerca_TextChanged(object sender, EventArgs e)
        {
            AggiornaLista();
        }

        private void cmbOrdinamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            AggiornaLista();
        }

        private void chkDecrescente_CheckedChanged(object sender, EventArgs e)
        {
            AggiornaLista();
        }

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

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
