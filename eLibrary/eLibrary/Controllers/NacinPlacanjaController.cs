using eLibrary.Model.Requests.NacinPlacanja;
using eLibrary.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eLibrary.Controllers
{
    public class NacinPlacanjaController : BaseCRUDController<eLibrary.Model.NacinPlacanja, NacinPlacanjaSearchRequest, NacinPlacanjaInsertRequest, NacinPlacanjaInsertRequest>
    {
        public NacinPlacanjaController(ICRUDService<eLibrary.Model.NacinPlacanja, NacinPlacanjaSearchRequest, NacinPlacanjaInsertRequest, NacinPlacanjaInsertRequest> service) : base(service)
        {

        }

    }
}
