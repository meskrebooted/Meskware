using System;
using System.Collections.Generic;
using System.Linq;

namespace Meskware
{
    public class Gioco
    {
        public string Titolo { get; set; }
        public string Categoria { get; set; }
        public decimal PrezzoBase { get; set; }
        public string PercorsoImmagine { get; set; }
        public bool InLibreria { get; set; }

        public Gioco()
        {
            Titolo = string.Empty;
            Categoria = "Base";
            PercorsoImmagine = string.Empty;
            InLibreria = false;
        }

        public Gioco(string titolo, string categoria, decimal prezzoBase)
            : this(titolo, categoria, prezzoBase, string.Empty, false)
        {
        }

        public Gioco(string titolo, string categoria, decimal prezzoBase, string percorsoImmagine)
            : this(titolo, categoria, prezzoBase, percorsoImmagine, false)
        {
        }

        public Gioco(string titolo, string categoria, decimal prezzoBase, string percorsoImmagine, bool inLibreria)
        {
            Titolo = titolo;
            Categoria = string.IsNullOrWhiteSpace(categoria) ? "Base" : categoria;
            PrezzoBase = prezzoBase;
            PercorsoImmagine = percorsoImmagine ?? string.Empty;
            InLibreria = inLibreria;
        }

        public virtual decimal CalcolaPrezzo()
        {
            // Prezzo base: le classi derivate possono ridefinire la logica.
            return PrezzoBase;
        }

        public override string ToString()
        {
            return string.Format("{0} ({1}) - {2:0.00} euro", Titolo, Categoria, CalcolaPrezzo());
        }
    }

    public class GiocoScontato : Gioco
    {
        public int ScontoPercentuale { get; set; }

        public GiocoScontato()
            : base()
        {
        }

        public GiocoScontato(string titolo, string categoria, decimal prezzoBase, int scontoPercentuale)
            : this(titolo, categoria, prezzoBase, scontoPercentuale, string.Empty, false)
        {
        }

        public GiocoScontato(string titolo, string categoria, decimal prezzoBase, int scontoPercentuale, string percorsoImmagine)
            : this(titolo, categoria, prezzoBase, scontoPercentuale, percorsoImmagine, false)
        {
        }

        public GiocoScontato(string titolo, string categoria, decimal prezzoBase, int scontoPercentuale, string percorsoImmagine, bool inLibreria)
            : base(titolo, categoria, prezzoBase, percorsoImmagine, inLibreria)
        {
            // Limita sempre lo sconto tra 0% e 100%.
            ScontoPercentuale = Math.Max(0, Math.Min(100, scontoPercentuale));
        }

        public override decimal CalcolaPrezzo()
        {
            var prezzo = PrezzoBase * (100 - ScontoPercentuale) / 100m;
            return Math.Round(prezzo, 2);
        }

        public override string ToString()
        {
            return string.Format("{0} ({1}) [sconto {2}%] - {3:0.00} euro", Titolo, Categoria, ScontoPercentuale, CalcolaPrezzo());
        }
    }

    public class Libreria
    {
        private readonly List<Gioco> _giochi = new List<Gioco>();

        public IReadOnlyList<Gioco> Giochi
        {
            // Espone la lista in sola lettura per evitare modifiche esterne.
            get { return _giochi.AsReadOnly(); }
        }

        public void Aggiungi(Gioco gioco)
        {
            if (gioco == null)
            {
                throw new ArgumentNullException(nameof(gioco));
            }

            _giochi.Add(gioco);
        }

        public void Aggiungi(string titolo, decimal prezzoBase)
        {
            Aggiungi(new Gioco(titolo, "Base", prezzoBase));
        }

        public void Aggiungi(string titolo, string categoria, decimal prezzoBase)
        {
            Aggiungi(new Gioco(titolo, categoria, prezzoBase));
        }

        public void SostituisciAt(int indice, Gioco gioco)
        {
            if (gioco == null)
            {
                throw new ArgumentNullException(nameof(gioco));
            }

            if (indice < 0 || indice >= _giochi.Count)
            {
                throw new ArgumentOutOfRangeException(nameof(indice));
            }

            _giochi[indice] = gioco;
        }

        public void RimuoviAt(int indice)
        {
            if (indice < 0 || indice >= _giochi.Count)
            {
                throw new ArgumentOutOfRangeException(nameof(indice));
            }

            _giochi.RemoveAt(indice);
        }

        public decimal TotaleValore()
        {
            return _giochi.Sum(g => g.CalcolaPrezzo());
        }

        public void Sostituisci(IEnumerable<Gioco> giochi)
        {
            _giochi.Clear();
            _giochi.AddRange(giochi ?? Enumerable.Empty<Gioco>());
        }
    }
}
