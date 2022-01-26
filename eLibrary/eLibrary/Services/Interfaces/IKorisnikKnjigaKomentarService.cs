using eLibrary.Model.Requests.KorisnikKnjigaKomentar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eLibrary.Services.Interfaces
{
    public interface IKorisnikKnjigaKomentarService : ICRUDService<Model.KorisnikKnjigaKomentar, KorisnikKnjigaKomentarSearchRequest, KorisnikKnjigaKomentarInsertRequest, KorisnikKnjigaKomentarInsertRequest>
    {
    }
}
