using eLibrary.Model.Requests.Korisnik;
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
    //[Authorize]
    ////govori da pozivi u ovom kontroleru trebaju biti logirani, naprotiv vraca 401
    ////ako to nema, pozivi su otvoreni za izvrsavanje
    /////takodjer "puca" na dijelu registracije mobilne aplikacije...error 401 ne moze se registrovi, ako predthodno nije prijavljen
    // sto nije logicno!
    [Route("api/[controller]")]
    [ApiController]
    public class KorisnikController : ControllerBase
    {

        private readonly IKorisnikService _service;
        public KorisnikController(IKorisnikService service)
        {
            _service = service;
        }

        
        [HttpGet]
        public List<Model.Korisnik> Get([FromQuery] KorisnikSearchRequest request)
        {
            return _service.Get(request);
        }


        
        [HttpPost]
        public Model.Korisnik Insert(KorisnikInsertRequest request)
        {
            return _service.Insert(request);
        }
        
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _service.Delete(id);
        }

        
        [HttpPut("{id}")]
        public Model.Korisnik Update(int id, [FromBody] KorisnikUpdateRequest request)
        {
            return _service.Update(id, request);
        }
        
        [HttpGet("{id}")]
        public Model.Korisnik GetById(int id)
        {
            return _service.GetbyId(id);
        }
        

    }
}
