using eLibrary.Model.Requests.Uloga;
using eLibrary.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eLibrary.Controllers
{
    public class UlogaController : BaseCRUDController<eLibrary.Model.Uloga, UlogaSearchRequest, UlogaInsertRequest, UlogaInsertRequest>
    {
        public UlogaController(ICRUDService<eLibrary.Model.Uloga, UlogaSearchRequest, UlogaInsertRequest, UlogaInsertRequest> service) : base(service)
        {

        }

    }
}
