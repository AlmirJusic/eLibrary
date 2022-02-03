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
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class RecommendationsController : ControllerBase
    {
        private readonly IRecommendedService _repository;
        public RecommendationsController(IRecommendedService repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult RecommendedProduct(int id)
        {
            try
            {
                return Ok(_repository.RecommendedProduct(id));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
    }
}
