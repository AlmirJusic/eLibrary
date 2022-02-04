using eLibrary.Database.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace eLibrary.Database
{
    public class eLibraryContext : DbContext
    {
        public eLibraryContext(DbContextOptions<eLibraryContext> options) : base(options){ }

        public eLibraryContext()
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<PrijedlogKnjige>()

                   .HasOne(pt => pt.Korisnik)

                  .WithMany()

                 .HasForeignKey(pt => pt.Korisnik_ID)

                  .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<KorisnikKnjigaOcjena>()
                .HasOne(p => p.Korisnik).WithMany().HasForeignKey(p => p.Korisnik_ID)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<KupovinaKnjige>()
                .HasOne(p => p.Korisnik).WithMany().HasForeignKey(p => p.Korisnik_ID)
                .OnDelete(DeleteBehavior.Restrict);


            SeedDrzave(modelBuilder);
            SeedGradove(modelBuilder);
            SeedSpolove(modelBuilder);
            SeedPisce(modelBuilder);
            SeedUloge(modelBuilder);
            SeedZanrove(modelBuilder);
            SeedKorisnike(modelBuilder);
            SeedKnjige(modelBuilder);
            SeedPrijedlogKnjige(modelBuilder);
            SeedKorisnikKnjigaKomentar(modelBuilder);
            SeedKorisnikKnjigaOcjena(modelBuilder);
            SeedKupovinaKnjige(modelBuilder);
            SeedNacinPlacanja(modelBuilder);
            SeedPlacanje(modelBuilder);
            
    }
        public DbSet<Drzava> Drzava { get; set; }
        public DbSet<Grad> Grad { get; set; }
        public DbSet<Knjiga> Knjiga { get; set; }
        public DbSet<Pisac> Pisac { get; set; }
        public DbSet<Korisnik> Korisnik { get; set; }
        public DbSet<Spol> Spol { get; set; }
        public DbSet<Uloga> Uloga { get; set; }
        public DbSet<KorisnikKnjigaKomentar> KorisnikKnjigaKomentar { get; set; }
        public DbSet<KorisnikKnjigaOcjena> KorisnikKnjigaOcjena { get; set; }
        public DbSet<KupovinaKnjige> KupovinaKnjige { get; set; }
        public DbSet<PrijedlogKnjige> PrijedlogKnjige { get; set; }
        public DbSet<Zanr> Zanr { get; set; }
        public DbSet<NacinPlacanja> NacinPlacanja { get; set; }
        public DbSet<Placanje> Placanje { get; set; }

        


        private void SeedPlacanje(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Placanje>().HasData(
                new Placanje { Placanje_ID=1, NacinPlacanja_ID=2,UkupnaCijena=49.99 },
                new Placanje 
                { 
                    Placanje_ID=2, 
                    NacinPlacanja_ID=1,
                    UkupnaCijena=25,
                    ImePrezime="Almir Jusic",
                    BrojKreditneKartice = "1234555522223333",
                    DatumPlacanja=DateTime.Now,
                    CVV="123"
                },
                new Placanje { Placanje_ID = 3, NacinPlacanja_ID = 2, UkupnaCijena = 21.50 },
                new Placanje
                {
                    Placanje_ID = 4,
                    NacinPlacanja_ID = 1,
                    UkupnaCijena = 25,
                    ImePrezime = "Meho Mehic",
                    BrojKreditneKartice = "1111222233334444",
                    DatumPlacanja = DateTime.Now,
                    CVV = "999"
                }
                );
        }

        private void SeedNacinPlacanja(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<NacinPlacanja>().HasData(
                new NacinPlacanja { NacinPlacanja_ID = 1, Naziv = "Placanje bankovnom karticom." },
                new NacinPlacanja { NacinPlacanja_ID = 2, Naziv = "PayPal" }
                );
                
        }

        private void SeedKupovinaKnjige(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<KupovinaKnjige>().HasData(
                new KupovinaKnjige
                {
                    KupovinaKnjige_ID = 1,
                    Korisnik_ID = 2,
                    Knjiga_ID = 1,
                    DatumKupovine = DateTime.Now,
                    Odobreno=true
                },
                new KupovinaKnjige
                {
                    KupovinaKnjige_ID = 2,
                    Korisnik_ID = 2,
                    Knjiga_ID = 3,
                    DatumKupovine = DateTime.Now,
                    Odobreno=false
                },
                new KupovinaKnjige
                {
                    KupovinaKnjige_ID = 3,
                    Korisnik_ID = 2,
                    Knjiga_ID = 2,
                    DatumKupovine = DateTime.Now,
                    Odobreno=true
                }
                );
        }

        private void SeedKorisnikKnjigaOcjena(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<KorisnikKnjigaOcjena>().HasData(
                new KorisnikKnjigaOcjena
                {
                    KorisnikKnjigaOcjena_ID = 1,
                    Korisnik_ID = 2,
                    Knjiga_ID = 3,
                    Ocjena = 4.5,
                    DatumOcjene = DateTime.Now
                },
                new KorisnikKnjigaOcjena
                {
                    KorisnikKnjigaOcjena_ID = 2,
                    Korisnik_ID = 2,
                    Knjiga_ID = 2,
                    Ocjena = 4.9,
                    DatumOcjene = DateTime.Now
                },
                new KorisnikKnjigaOcjena
                {
                    KorisnikKnjigaOcjena_ID = 3,
                    Korisnik_ID = 2,
                    Knjiga_ID = 1,
                    Ocjena = 4.1,
                    DatumOcjene = DateTime.Now
                }
                );
        }

        private void SeedKorisnikKnjigaKomentar(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<KorisnikKnjigaKomentar>().HasData(
                new KorisnikKnjigaKomentar
                {
                    KorisnikKnjigaKomentar_ID = 1,
                    Korisnik_ID = 2,
                    Knjiga_ID = 3,
                    DatumKomentara = DateTime.Now,
                    SadrzajKomentara = "Knjiga je sasvim okeej!"
                },
                new KorisnikKnjigaKomentar
                {
                    KorisnikKnjigaKomentar_ID = 2,
                    Korisnik_ID = 2,
                    Knjiga_ID = 2,
                    DatumKomentara = DateTime.Now,
                    SadrzajKomentara = "Knjiga je užasno dosadna!"
                },
                new KorisnikKnjigaKomentar
                {
                    KorisnikKnjigaKomentar_ID = 3,
                    Korisnik_ID = 2,
                    Knjiga_ID = 1,
                    DatumKomentara = DateTime.Now,
                    SadrzajKomentara = "Preporucujem knjiguu!"
                }
                );
        }

        private void SeedPrijedlogKnjige(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PrijedlogKnjige>().HasData(
                new PrijedlogKnjige 
                { 
                    PrijedlogKnjige_ID=1,
                    Korisnik_ID=2,
                    NazivPrijedlogaKnjige="Zeleno busenje",
                    DatumPrijedloga=DateTime.Now,
                    Odgovoren=true,Pregledan=true,
                    Opis="Ovaj zahtjev je odobren!" 
                },
                new PrijedlogKnjige
                {
                    PrijedlogKnjige_ID = 2,
                    Korisnik_ID = 2,
                    NazivPrijedlogaKnjige = "Orlovi rano lete",
                    DatumPrijedloga = DateTime.Now,
                    Odgovoren = false,
                    Pregledan = false,
                    Opis = "Cekanje na zahtjev!"
                }
                );
        }

        

        private void SeedKnjige(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Knjiga>().HasData(
                 new Knjiga
                 {
                     Knjiga_ID = 1,
                     NazivKnjige = "Na Drini cuprija",
                     Slika = null,
                     Cijena = 49.99,
                     Ocjena = 5.0,
                     Opis = "Priča počinje s uvjetima života u Višegradu prije nego što je most sagrađen, a onda se nastavlja na njegovu izgradnju u 16. stoljeću. Nakon toga govori o životu u kasabi koji je usko vezan uz most. Preko njega prolaze putnici, trgovci i mještani. Svaki veliki događaj, bio sretan ili ne, obilježava se prelaskom preko mosta. ",
                     PDF = "nadrinicuprija.pdf",
                     PDFDodan = true,
                     DatumIzdavanja = DateTime.Now,
                     Pisac_ID=1,
                     Zanr_ID=1
                     


                 },
                 new Knjiga
                 {
                     Knjiga_ID = 2,
                     NazivKnjige = "Dnevnik Ane Frank",
                     Slika = null,
                     Cijena = 39.99,
                     Ocjena = 4.7,
                     Opis = "Annin dnevnik pisan je u vremenskom razdoblju od 1942 do 1944. godine, najteža vremena Drugog svjetskog rata u Europi. Kamo god krenuli, Hitlerova je vojska širila otrov antisemitizma i rasne mržnje. ",
                     PDF = "dnevnikanefrank.pdf",
                     PDFDodan = true,
                     DatumIzdavanja = DateTime.Now,
                     Pisac_ID=2,
                     Zanr_ID=2
                 },
                 new Knjiga
                 {
                     Knjiga_ID = 3,
                     NazivKnjige = "Pjesme",
                     Slika = null,
                     Cijena = 10,
                     Ocjena = 4.4,
                     Opis = "Ovo su pjesme Sidran Abdulaha ",
                     PDF = "1001noc.pdf",
                     PDFDodan = true,
                     DatumIzdavanja = DateTime.Now,
                     Pisac_ID=3,
                     Zanr_ID=3,
                     
                 }
                 );
        }

        private void SeedKorisnike(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Korisnik>().HasData(
                 new Korisnik
                 {
                     Korisnik_ID = 1,
                     Spol_ID = 1,
                     DatumRodjenja = DateTime.Now,
                     Email = "admin@gmail.com",
                     Ime = "Admin",
                     Prezime = "Admin",
                     Uloga_ID = 1,
                     Username = "admin",
                     Grad_ID = 1,
                     Slika= null,
                     PasswordHash = "YAWTUq0ie8c0tBtxDe8Cv5BcEkU=",
                     PasswordSalt = "2347UVaXDf0JXS/13WCCdg=="
                 },
                 new Korisnik
                 {
                     Korisnik_ID = 2,
                     Spol_ID = 1,
                     DatumRodjenja = DateTime.Now,
                     Email = "korisnik@gmail.com",
                     Ime = "Korisnik",
                     Prezime = "Korisnik",
                     Uloga_ID = 2,
                     Username = "korisnik",
                     Grad_ID = 3,
                     Slika = null,
                     PasswordHash = "S27pePLiy7wnHja89giP/L4RQ6s=",
                     PasswordSalt = "S5felu6ihLLEtjNKQZMaSA=="
                 },
                 new Korisnik
                 {
                     Korisnik_ID = 3,
                     Spol_ID = 1,
                     DatumRodjenja = DateTime.Now,
                     Email = "almir.jusic@edu.fit.ba",
                     Ime = "Almir",
                     Prezime = "Jusic",
                     Uloga_ID = 1,
                     Username = "almir",
                     Grad_ID = 3,
                     Slika = null,
                     PasswordHash = "Y/rtFbnRSgQ53PX3+w9lEoqiJ2s=",
                     PasswordSalt = "WqHzH1hIBtmsewpNDEpeGg=="
                 }
                 );
        }

        private void SeedZanrove(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Zanr>().HasData(
                 new Zanr { Zanr_ID = 1, NazivZanra = "Horor" },
                 new Zanr { Zanr_ID = 2, NazivZanra = "Romantika" },
                 new Zanr { Zanr_ID = 3, NazivZanra = "Novela" },
                 new Zanr { Zanr_ID = 4, NazivZanra = "Naucna Fantastika" }
                 );
        }

        private void SeedUloge(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Uloga>().HasData(
                new Uloga { Uloga_ID = 1, NazivUloge = "Administrator", Opis = "Ovaj uloga je administrator!" },
                new Uloga { Uloga_ID = 2, NazivUloge = "Korisnik", Opis = "Ovaj uloga je obicni korisnik!" }
                );
        }

        private void SeedPisce(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pisac>().HasData(
                new Pisac { Pisac_ID=1,Ime="Abdulah",Prezime="Sidran",DatumRodjenja=DateTime.Now,Grad_ID=1 },
                new Pisac { Pisac_ID = 2, Ime = "Ivo", Prezime = "Andric", DatumRodjenja = DateTime.Now, Grad_ID = 4 },
                new Pisac { Pisac_ID = 3, Ime = "Mak", Prezime = "Dizdar", DatumRodjenja = DateTime.Now, Grad_ID = 3 },
                new Pisac { Pisac_ID = 4, Ime = "Ana", Prezime = "Frank", DatumRodjenja = DateTime.Now, Grad_ID = 2 }
                );
        }

        private void SeedSpolove(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Spol>().HasData(
                new Spol { Spol_ID=1, OznakaSpola="M" },
                new Spol { Spol_ID = 2, OznakaSpola = "Ž" }
                );
        }

        private void SeedGradove(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Grad>().HasData(
                new Grad { Grad_ID=1, NazivGrada="Sarajevo", Drzava_ID=1},
                new Grad { Grad_ID=2, NazivGrada="Zagreb", Drzava_ID=2},
                new Grad { Grad_ID=3, NazivGrada="Ankara", Drzava_ID=3},
                new Grad { Grad_ID=4, NazivGrada="Barselona", Drzava_ID=4}
                );
        }

        private void SeedDrzave(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Drzava>().HasData(
                new Drzava { Drzava_ID=1,NazivDrzave="Bosna i Hercegovina"},
                new Drzava { Drzava_ID = 2, NazivDrzave = "Hrvatska" },
                new Drzava { Drzava_ID = 3, NazivDrzave = "Turska" },
                new Drzava { Drzava_ID = 4, NazivDrzave = "Spanija" }
                );
        }
        
    }
}
