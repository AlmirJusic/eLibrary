using AutoMapper;
using eLibrary.Database;
using eLibrary.Model.Requests.Drzava;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eLibrary.Services.Services
{
    public class DrzavaService : BaseCRUDService<eLibrary.Model.Drzava, DrzavaSearchRequest, eLibrary.Database.Models.Drzava, DrzavaInsertRequest, DrzavaInsertRequest>
    {
        public DrzavaService(eLibraryContext db, IMapper mapper) : base(db, mapper)
        {
        }
        public override List<eLibrary.Model.Drzava> Get(DrzavaSearchRequest search)
        {
            var query = _db.Drzava.AsQueryable();

            if (!string.IsNullOrWhiteSpace(search?.NazivDrzave))
            {
                query = query.Where(x => x.NazivDrzave.ToLower().Contains(search.NazivDrzave.ToLower()));
            }

            var list = query.ToList();
            return _mapper.Map<List<eLibrary.Model.Drzava>>(list);
        }
    }
}
