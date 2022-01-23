using eLibrary.Model.Requests.Korisnik;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eLibrary.Services.Interfaces
{
    public interface IKorisnikService
    {


        public List<Model.Korisnik> Get(KorisnikSearchRequest search);
        public Model.Korisnik GetbyId(int id);

        public Model.Korisnik Insert(KorisnikInsertRequest request);

        public Model.Korisnik Update(int id, KorisnikUpdateRequest request);

        public Model.Korisnik Authenticiraj(string username, string pass);

        public  void Delete(int id);

    }
}
