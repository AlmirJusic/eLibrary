using eLibrary.Model.Requests.Drzava;
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
    
    public class DrzavaController : BaseCRUDController<eLibrary.Model.Drzava, DrzavaSearchRequest, DrzavaInsertRequest, DrzavaInsertRequest>
    {
        public DrzavaController(ICRUDService<eLibrary.Model.Drzava, DrzavaSearchRequest, DrzavaInsertRequest, DrzavaInsertRequest> service) : base(service)
        {

        }

    }
}
