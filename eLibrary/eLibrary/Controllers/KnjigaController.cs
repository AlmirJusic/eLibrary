using eLibrary.Model.Requests.Knjiga;
using eLibrary.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eLibrary.Controllers
{
    public class KnjigaController : BaseCRUDController<eLibrary.Model.Knjiga, KnjigaSearchRequest, KnjigaInsertRequest, KnjigaInsertRequest>
    {
        public KnjigaController(ICRUDService<eLibrary.Model.Knjiga, KnjigaSearchRequest, KnjigaInsertRequest, KnjigaInsertRequest> service) : base(service)
        {

        }

    }
}
