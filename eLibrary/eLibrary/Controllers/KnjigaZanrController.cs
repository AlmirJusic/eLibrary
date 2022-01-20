using eLibrary.Model.Requests.KnjigaZanr;
using eLibrary.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eLibrary.Controllers
{
    public class KnjigaZanrController : BaseCRUDController<eLibrary.Model.KnjigaZanr, eLibrary.Model.KnjigaZanr, KnjigaZanrRequest, KnjigaZanrRequest>
    {
        public KnjigaZanrController(ICRUDService<eLibrary.Model.KnjigaZanr, eLibrary.Model.KnjigaZanr, KnjigaZanrRequest, KnjigaZanrRequest> service) : base(service)
        {

        }

    }
}
