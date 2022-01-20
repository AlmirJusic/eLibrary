using AutoMapper;
using eLibrary.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eLibrary.Mapping
{
    public class eLibraryProfile : Profile
    {
        public eLibraryProfile()
        {

            //Drzava
            CreateMap<Drzava, Model.Requests.Drzava.DrzavaInsertRequest>().ReverseMap();
            CreateMap<Drzava, Model.Drzava>().ReverseMap();
            //Grad
            CreateMap<Grad, Model.Requests.Grad.GradInsertRequest>().ReverseMap();
            CreateMap<Grad, Model.Grad>().ReverseMap();
            //Zanr
            CreateMap<Zanr, Model.Requests.Zanr.ZanrInsertRequest>().ReverseMap();
            CreateMap<Zanr, Model.Zanr>().ReverseMap();
            //Uloga
            CreateMap<Uloga, Model.Requests.Uloga.UlogaInsertRequest>().ReverseMap();
            CreateMap<Uloga, Model.Uloga>().ReverseMap();
            //Spol
            CreateMap<Spol, Model.Spol>().ReverseMap();
            //Pisac
            CreateMap<Pisac, Model.Requests.Pisac.PisacInsertRequest>().ReverseMap();
            CreateMap<Pisac, Model.Pisac>().ReverseMap();
            //Knjiga
            CreateMap<Knjiga, Model.Requests.Knjiga.KnjigaInsertRequest>().ReverseMap();
            CreateMap<Knjiga, Model.Knjiga>().ReverseMap();
            //Korisnik
            CreateMap<Korisnik, Model.Requests.Korisnik.KorisnikInsertRequest>().ReverseMap();
            CreateMap<Korisnik, Model.Korisnik>().ReverseMap();
            //KnjigaPisac
            CreateMap<KnjigaPisac, Model.Requests.KnjigaPisac.KnjigaPisacRequest>().ReverseMap();
            CreateMap<KnjigaPisac, Model.KnjigaPisac>().ReverseMap();
            //KnjigaPisac
            CreateMap<KnjigaZanr, Model.Requests.KnjigaZanr.KnjigaZanrRequest>().ReverseMap();
            CreateMap<KnjigaZanr, Model.KnjigaZanr>().ReverseMap();
            //KorisnikKnjigaKomentar
            CreateMap<KorisnikKnjigaKomentar, Model.Requests.KorisnikKnjigaKomentar.KorisnikKnjigaKomentarRequest>().ReverseMap();
            CreateMap<KorisnikKnjigaKomentar, Model.KorisnikKnjigaKomentar>().ReverseMap();
            //KorisnikKnjigaOcjena
            CreateMap<KorisnikKnjigaOcjena, Model.Requests.KorisnikKnjigaOcjena.KorisnikKnjigaOcjenaRequest>().ReverseMap();
            CreateMap<KorisnikKnjigaOcjena, Model.KorisnikKnjigaOcjena>().ReverseMap();
            //NacinPlacanja
            CreateMap<NacinPlacanja, Model.Requests.NacinPlacanja.NacinPlacanjaInsertRequest>().ReverseMap();
            CreateMap<NacinPlacanja, Model.NacinPlacanja>().ReverseMap();
            //Placanje
            CreateMap<Placanje, Model.Requests.Placanje.PlacanjeInsertRequest>().ReverseMap();
            CreateMap<Placanje, Model.Placanje>().ReverseMap();
            //KupovinaKnjige
            CreateMap<KupovinaKnjige, Model.Requests.KupovinaKnjige.KupovinaKnjigeInsertRequest>().ReverseMap();
            CreateMap<KupovinaKnjige, Model.KupovinaKnjige>().ReverseMap();
            //PrijedlogKnjige
            CreateMap<PrijedlogKnjige, Model.Requests.PrijedlogKnjige.PrijedlogKnjigeInsertRequest>().ReverseMap();
            CreateMap<PrijedlogKnjige, Model.PrijedlogKnjige>().ReverseMap();


        }
    }
}
