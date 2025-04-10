﻿
using eLibrary.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eLibrary.Controllers
{
    public class SpolController : BaseCRUDController<Model.Spol, Model.Spol, Model.Spol, Model.Spol>
    {
        public SpolController(ICRUDService<Model.Spol, Model.Spol, Model.Spol, Model.Spol> _service) : base(_service)
        {
        }
    }
}
