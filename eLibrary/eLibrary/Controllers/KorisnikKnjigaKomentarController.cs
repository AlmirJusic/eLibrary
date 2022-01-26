using eLibrary.Model.Requests.KorisnikKnjigaKomentar;
using eLibrary.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eLibrary.Controllers
{
    public class KorisnikKnjigaKomentarController : BaseCRUDController<eLibrary.Model.KorisnikKnjigaKomentar, KorisnikKnjigaKomentarSearchRequest, KorisnikKnjigaKomentarInsertRequest, KorisnikKnjigaKomentarInsertRequest>
    {
        public KorisnikKnjigaKomentarController(ICRUDService<eLibrary.Model.KorisnikKnjigaKomentar, KorisnikKnjigaKomentarSearchRequest, KorisnikKnjigaKomentarInsertRequest, KorisnikKnjigaKomentarInsertRequest> service) : base(service)
        {

        }

    }
}
