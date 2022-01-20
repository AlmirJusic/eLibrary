using eLibrary.Model.Requests.KupovinaKnjige;
using eLibrary.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eLibrary.Controllers
{
    public class KupovinaKnjigeController : BaseCRUDController<eLibrary.Model.KupovinaKnjige, KupovinaKnjigeSearchRequest, KupovinaKnjigeInsertRequest, KupovinaKnjigeInsertRequest>
    {
        public KupovinaKnjigeController(ICRUDService<eLibrary.Model.KupovinaKnjige, KupovinaKnjigeSearchRequest, KupovinaKnjigeInsertRequest, KupovinaKnjigeInsertRequest> service) : base(service)
        {

        }

    }
}
