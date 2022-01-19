using eLibrary.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eLibrary.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController<T, TSearch> : ControllerBase
    {
        protected readonly IService<T, TSearch> _service;

        public BaseController(IService<T, TSearch> service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<List<T>> Get([FromQuery] TSearch request)
        {
            return _service.Get(request);
        }

        [HttpGet("{id}")]
        public ActionResult<T> GetById(int id)
        {
            return _service.GetById(id);
        }
    }
    
}
