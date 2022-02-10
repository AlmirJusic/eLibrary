using eLibrary.Model.Requests.Grad;
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
    
    public class GradController : BaseCRUDController<eLibrary.Model.Grad, GradSearchRequest, GradInsertRequest, GradInsertRequest>
    {
        public GradController(ICRUDService<eLibrary.Model.Grad, GradSearchRequest, GradInsertRequest, GradInsertRequest> service) : base(service)
        {

        }

    }
}
