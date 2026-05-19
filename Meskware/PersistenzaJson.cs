using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace Meskware
{
    public sealed class PersistenzaJson
    {
        public void SalvaUtente(string percorsoFile, string username, string passwordHash, Libreria libreria)
        {
            var dto = new List<GiocoDto>();
            foreach (var g in libreria.Giochi)
            {
                var tipo = g is GiocoScontato ? "scontato" : "base";
                var sconto = g is GiocoScontato gs ? gs.ScontoPercentuale : 0;

                dto.Add(new GiocoDto
                {
                    Titolo = g.Titolo,
                    Categoria = g.Categoria,
                    PrezzoBase = g.PrezzoBase,
                    Tipo = tipo,
                    ScontoPercentuale = sconto,
                    PercorsoImmagine = g.PercorsoImmagine,
                    InLibreria = g.InLibreria
                });
            }

            var dati = new UtenteDto
            {
                Username = username,
                PasswordHash = passwordHash,
                Giochi = dto
            };

            var json = JsonSerializer.Serialize(dati, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(percorsoFile, json);
        }

        public UtenteDto CaricaUtente(string percorsoFile)
        {
            if (!File.Exists(percorsoFile))
            {
                return null;
            }

            var json = File.ReadAllText(percorsoFile);
            return JsonSerializer.Deserialize<UtenteDto>(json);
        }

        public void ApplicaGiochi(UtenteDto dati, Libreria libreria)
        {
            var dto = dati?.Giochi ?? new List<GiocoDto>();
            var giochi = new List<Gioco>();

            // Ricostruisce i tipi corretti (base/scontato) partendo dal campo Tipo.
            foreach (var item in dto)
            {
                var categoria = string.IsNullOrWhiteSpace(item.Categoria) ? "Base" : item.Categoria;
                var percorsoImmagine = item.PercorsoImmagine ?? string.Empty;
                var inLibreria = item.InLibreria;
                if (string.Equals(item.Tipo, "scontato", StringComparison.OrdinalIgnoreCase))
                {
                    giochi.Add(new GiocoScontato(item.Titolo, categoria, item.PrezzoBase, item.ScontoPercentuale, percorsoImmagine, inLibreria));
                }
                else
                {
                    giochi.Add(new Gioco(item.Titolo, categoria, item.PrezzoBase, percorsoImmagine, inLibreria));
                }
            }

            libreria.Sostituisci(giochi);
        }
    }

    public sealed class UtenteDto //SHA-256
    {
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public List<GiocoDto> Giochi { get; set; }
    }

    public sealed class GiocoDto
    {
        public string Titolo { get; set; }
        public string Categoria { get; set; }
        public decimal PrezzoBase { get; set; }
        public string Tipo { get; set; }
        public int ScontoPercentuale { get; set; }
        public string PercorsoImmagine { get; set; }
        public bool InLibreria { get; set; }
    }
}
