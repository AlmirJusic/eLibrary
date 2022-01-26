using AutoMapper;
using eLibrary.Database;
using eLibrary.Model.Requests.PrijedlogKnjige;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eLibrary.Services.Services
{
    public class PrijedlogKnjigeService : BaseCRUDService<eLibrary.Model.PrijedlogKnjige, PrijedlogKnjigeSearchRequest, eLibrary.Database.Models.PrijedlogKnjige, PrijedlogKnjigeInsertRequest, PrijedlogKnjigeInsertRequest>
    {
        public PrijedlogKnjigeService(eLibraryContext db, IMapper mapper) : base(db, mapper)
        {
        }
        public override List<eLibrary.Model.PrijedlogKnjige> Get(PrijedlogKnjigeSearchRequest search)
        {
            var query = _db.PrijedlogKnjige.Include(x=>x.Korisnik).AsQueryable();

            if (!string.IsNullOrWhiteSpace(search?.NazivPrijedlogaKnjige))
            {
                query = query.Where(x => x.NazivPrijedlogaKnjige.ToLower().Contains(search.NazivPrijedlogaKnjige.ToLower()));
            }
           

            var list = query.ToList();
            return _mapper.Map<List<eLibrary.Model.PrijedlogKnjige>>(list);
        }
    }
}

