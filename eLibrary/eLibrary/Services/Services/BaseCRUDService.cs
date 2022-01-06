using AutoMapper;
using eLibrary.Database;
using eLibrary.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eLibrary.Services.Services
{
    public class BaseCRUDService<TModel, TSearch, TDatabase, TInsert, TUpdate> : BaseService<TModel, TSearch, TDatabase>, ICRUDService<TModel, TSearch, TInsert, TUpdate> where TDatabase : class
    {
        public BaseCRUDService(eLibraryContext db, IMapper mapper) : base(db, mapper)
        {
        }

        public virtual TModel Insert(TInsert request)
        {
            var entity = _mapper.Map<TDatabase>(request);
            _db.Set<TDatabase>().Add(entity);
            _db.SaveChanges();

            return _mapper.Map<TModel>(entity);
        }

        public virtual TModel Update(int id, TUpdate request)
        {
            var entity = _db.Set<TDatabase>().Find(id);
            _mapper.Map(request, entity);
            _db.Set<TDatabase>().Attach(entity);
            _db.Set<TDatabase>().Update(entity);

            _db.SaveChanges();

            return _mapper.Map<TModel>(entity);
        }
        public virtual void Delete(int id)
        {
            var entity = _db.Set<TDatabase>().Find(id);
            _db.Remove(entity);
            _db.SaveChanges();

        }
    }
}
