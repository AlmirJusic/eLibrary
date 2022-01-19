using AutoMapper;
using eLibrary.Database;
using eLibrary.Model.Requests.Zanr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eLibrary.Services.Services
{
    public class ZanrService : BaseCRUDService<eLibrary.Model.Zanr, ZanrSearchRequest, eLibrary.Database.Models.Zanr, ZanrInsertRequest, ZanrInsertRequest>
    {
        public ZanrService(eLibraryContext db, IMapper mapper) : base(db, mapper)
        {
        }
        public override List<eLibrary.Model.Zanr> Get(ZanrSearchRequest search)
        {
            var query = _db.Zanr.AsQueryable();

            if (!string.IsNullOrWhiteSpace(search?.NazivZanra))
            {
                query = query.Where(x => x.NazivZanra.ToLower().Contains(search.NazivZanra.ToLower()));
            }

            var list = query.ToList();
            return _mapper.Map<List<eLibrary.Model.Zanr>>(list);
        }
    }
}
