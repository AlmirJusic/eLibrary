using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eLibrary.Database.Models
{
    public class Korisnik
    {
        [Key]
        public int Korisnik_ID { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public DateTime DatumRodjenja { get; set; }

        public byte[]? Slika { get; set; }

        [ForeignKey(nameof(Spol))]
        public int Spol_ID { get; set; }
        public virtual Spol Spol { get; set; }

        [ForeignKey(nameof(Grad))]
        public int Grad_ID { get; set; }
        public virtual Grad Grad { get; set; }

        [ForeignKey(nameof(Uloga))]
        public int Uloga_ID { get; set; }
        public virtual Uloga Uloga { get; set; }

        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public string PasswordSalt { get; set; }
    }
}
