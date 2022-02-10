using eLibrary.Model.Requests.Zanr;
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
    
    public class ZanrController : BaseCRUDController<eLibrary.Model.Zanr, ZanrSearchRequest, ZanrInsertRequest, ZanrInsertRequest>
    {
        public ZanrController(ICRUDService<eLibrary.Model.Zanr, ZanrSearchRequest, ZanrInsertRequest, ZanrInsertRequest> service) : base(service)
        {

        }

    }
}
