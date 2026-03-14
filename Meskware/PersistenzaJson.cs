using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace Meskware
{
    public sealed class PersistenzaJson
    {
        public void Salva(string percorsoFile, Libreria libreria)
        {
            var dto = new List<GiocoDto>();
            foreach (var g in libreria.Giochi)
            {
                var tipo = g is GiocoScontato ? "scontato" : "base";
                var sconto = g is GiocoScontato gs ? gs.ScontoPercentuale : 0;

                dto.Add(new GiocoDto
                {
                    Titolo = g.Titolo,
                    PrezzoBase = g.PrezzoBase,
                    Tipo = tipo,
                    ScontoPercentuale = sconto
                });
            }

            var json = JsonSerializer.Serialize(dto, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(percorsoFile, json);
        }

        public void Carica(string percorsoFile, Libreria libreria)
        {
            if (!File.Exists(percorsoFile))
            {
                libreria.Sostituisci(new List<Gioco>());
                return;
            }

            var json = File.ReadAllText(percorsoFile);
            var dto = JsonSerializer.Deserialize<List<GiocoDto>>(json);
            var giochi = new List<Gioco>();

            foreach (var item in dto ?? new List<GiocoDto>())
            {
                if (string.Equals(item.Tipo, "scontato", StringComparison.OrdinalIgnoreCase))
                {
                    giochi.Add(new GiocoScontato(item.Titolo, item.PrezzoBase, item.ScontoPercentuale));
                }
                else
                {
                    giochi.Add(new Gioco(item.Titolo, item.PrezzoBase));
                }
            }

            libreria.Sostituisci(giochi);
        }
    }

    public sealed class GiocoDto
    {
        public string Titolo { get; set; }
        public decimal PrezzoBase { get; set; }
        public string Tipo { get; set; }
        public int ScontoPercentuale { get; set; }
    }
}
