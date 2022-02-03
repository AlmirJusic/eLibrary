using eLibrary.Model.Requests.PrijedlogKnjige;
using eLibrary.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eLibrary.Controllers
{
    
    public class PrijedlogKnjigeController : BaseCRUDController<eLibrary.Model.PrijedlogKnjige, PrijedlogKnjigeSearchRequest, PrijedlogKnjigeInsertRequest, PrijedlogKnjigeInsertRequest>
    {
        public PrijedlogKnjigeController(ICRUDService<eLibrary.Model.PrijedlogKnjige, PrijedlogKnjigeSearchRequest, PrijedlogKnjigeInsertRequest, PrijedlogKnjigeInsertRequest> service) : base(service)
        {

        }

    }
}
