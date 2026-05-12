using System;
using System.Collections.Generic;
using System.Linq;

namespace Meskware
{
    public class Gioco
    {
        public string Titolo { get; set; }
        public decimal PrezzoBase { get; set; }

        public Gioco()
        {
            Titolo = string.Empty;
        }

        public Gioco(string titolo, decimal prezzoBase)
        {
            Titolo = titolo;
            PrezzoBase = prezzoBase;
        }

        public virtual decimal CalcolaPrezzo()
        {
            // Prezzo base: le classi derivate possono ridefinire la logica.
            return PrezzoBase;
        }

        public override string ToString()
        {
            return string.Format("{0} - {1:0.00} euro", Titolo, CalcolaPrezzo());
        }
    }

    public class GiocoScontato : Gioco
    {
        public int ScontoPercentuale { get; set; }

        public GiocoScontato()
            : base()
        {
        }

        public GiocoScontato(string titolo, decimal prezzoBase, int scontoPercentuale)
            : base(titolo, prezzoBase)
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
            return string.Format("{0} [sconto {1}%] - {2:0.00} euro", Titolo, ScontoPercentuale, CalcolaPrezzo());
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
            Aggiungi(new Gioco(titolo, prezzoBase));
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
