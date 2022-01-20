using eLibrary.Model.Requests.Placanje;
using eLibrary.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eLibrary.Controllers
{
    public class PlacanjeController : BaseCRUDController<eLibrary.Model.Placanje, PlacanjeSearchRequest, PlacanjeInsertRequest, PlacanjeInsertRequest>
    {
        public PlacanjeController(ICRUDService<eLibrary.Model.Placanje, PlacanjeSearchRequest, PlacanjeInsertRequest, PlacanjeInsertRequest> service) : base(service)
        {

        }

    }
}
