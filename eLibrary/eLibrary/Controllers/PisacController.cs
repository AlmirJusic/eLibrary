using eLibrary.Model.Requests.Pisac;
using eLibrary.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eLibrary.Controllers
{
    public class PisacController : BaseCRUDController<eLibrary.Model.Pisac, PisacSearchRequest, PisacInsertRequest, PisacInsertRequest>
    {
        public PisacController(ICRUDService<eLibrary.Model.Pisac, PisacSearchRequest, PisacInsertRequest, PisacInsertRequest> service) : base(service)
        {

        }

    }
}
