using AutoMapper;
using eLibrary.Database;
using eLibrary.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eLibrary.Services.Services
{
    public class BaseService<TModel, TSearch, TDatabase> : IService<TModel, TSearch> where TDatabase : class
    {
        protected readonly eLibraryContext _db;
        protected readonly IMapper _mapper;

        public BaseService(eLibraryContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public virtual List<TModel> Get(TSearch search)
        {
            var list = _db.Set<TDatabase>().ToList();
            return _mapper.Map<List<TModel>>(list);
        }

        public virtual TModel GetById(int id)
        {
            var entity = _db.Set<TDatabase>().Find(id);
            return _mapper.Map<TModel>(entity);

        }
    }
}
