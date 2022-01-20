using eLibrary.Model.Requests.KorisnikKnjigaOcjena;
using eLibrary.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eLibrary.Controllers
{
    public class KorisnikKnjigaOcjenaController : BaseCRUDController<eLibrary.Model.KorisnikKnjigaOcjena, eLibrary.Model.KorisnikKnjigaOcjena, KorisnikKnjigaOcjenaRequest, KorisnikKnjigaOcjenaRequest>
    {
        public KorisnikKnjigaOcjenaController(ICRUDService<eLibrary.Model.KorisnikKnjigaOcjena, eLibrary.Model.KorisnikKnjigaOcjena, KorisnikKnjigaOcjenaRequest, KorisnikKnjigaOcjenaRequest> service) : base(service)
        {

        }

    }
}
