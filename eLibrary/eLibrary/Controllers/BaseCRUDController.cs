using eLibrary.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eLibrary.Controllers
{
    public class BaseCRUDController<T, TSearch, TInsert, TUpdate> : BaseController<T, TSearch>
    {
        private readonly ICRUDService<T, TSearch, TInsert, TUpdate> _crudService;
        public BaseCRUDController(ICRUDService<T, TSearch, TInsert, TUpdate> service) : base(service)
        {
            _crudService = service;
        }

        [HttpPost]
        public T Insert(TInsert request)
        {
            return _crudService.Insert(request);
        }

        [HttpPut("{id}")]
        public T Update(int id, TUpdate request)
        {
            return _crudService.Update(id, request);
        }
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _crudService.Delete(id);
        }
    }
}
