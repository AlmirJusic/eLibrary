using AutoMapper;
using eLibrary.Database;
using eLibrary.Model.Requests.Uloga;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eLibrary.Services.Services
{
    public class UlogaService : BaseCRUDService<eLibrary.Model.Uloga, UlogaSearchRequest, eLibrary.Database.Models.Uloga, UlogaInsertRequest, UlogaInsertRequest>
    {
        public UlogaService(eLibraryContext db, IMapper mapper) : base(db, mapper)
        {
        }
        public override List<eLibrary.Model.Uloga> Get(UlogaSearchRequest search)
        {
            var query = _db.Uloga.AsQueryable();

            if (!string.IsNullOrWhiteSpace(search?.NazivUloge))
            {
                query = query.Where(x => x.NazivUloge.ToLower().Contains(search.NazivUloge.ToLower()));
            }

            var list = query.ToList();
            return _mapper.Map<List<eLibrary.Model.Uloga>>(list);
        }
    }
}
