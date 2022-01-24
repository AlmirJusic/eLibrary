using AutoMapper;
using eLibrary.Database;
using eLibrary.Model.Requests.Pisac;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eLibrary.Services.Services
{
    public class PisacService : BaseCRUDService<eLibrary.Model.Pisac, PisacSearchRequest, eLibrary.Database.Models.Pisac, PisacInsertRequest, PisacInsertRequest>
    {
        public PisacService(eLibraryContext db, IMapper mapper) : base(db, mapper)
        {
        }
        public override List<eLibrary.Model.Pisac> Get(PisacSearchRequest search)
        {
            var query = _db.Pisac.Include(x=>x.Grad).AsQueryable();

            if (!string.IsNullOrWhiteSpace(search?.Ime))
            {
                query = query.Where(x => x.Ime.ToLower().Contains(search.Ime.ToLower()));
            }
            if (!string.IsNullOrWhiteSpace(search?.Prezime))
            {
                query = query.Where(x => x.Prezime.ToLower().Contains(search.Prezime.ToLower()));
            }

            var list = query.ToList();
            return _mapper.Map<List<eLibrary.Model.Pisac>>(list);
        }
    }
}

