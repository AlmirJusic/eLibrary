using eLibrary.Model.Requests.KnjigaPisac;
using eLibrary.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eLibrary.Controllers
{
    public class KnjigaPisacController : BaseCRUDController<eLibrary.Model.KnjigaPisac, eLibrary.Model.KnjigaPisac, KnjigaPisacRequest, KnjigaPisacRequest>
    {
        public KnjigaPisacController(ICRUDService<eLibrary.Model.KnjigaPisac, eLibrary.Model.KnjigaPisac, KnjigaPisacRequest, KnjigaPisacRequest> service) : base(service)
        {

        }

    }
}
