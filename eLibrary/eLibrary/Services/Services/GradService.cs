using AutoMapper;
using eLibrary.Database;
using eLibrary.Model.Requests.Grad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace eLibrary.Services.Services
{
    public class GradService : BaseCRUDService<eLibrary.Model.Grad, GradSearchRequest, eLibrary.Database.Models.Grad, GradInsertRequest, GradInsertRequest>
    {
        public GradService(eLibraryContext db, IMapper mapper) : base(db, mapper)
        {
        }
        public override List<eLibrary.Model.Grad> Get(GradSearchRequest search)
        {
            var query = _db.Grad.Include(x => x.Drzava).AsQueryable();
            

            if (!string.IsNullOrWhiteSpace(search?.NazivGrada))
            {
                query = query.Where(x => x.NazivGrada.ToLower().Contains(search.NazivGrada.ToLower()));
            }
            if (!string.IsNullOrWhiteSpace(search?.NazivDrzave))
            {
                query = query.Where(x => x.Drzava.NazivDrzave.ToLower().Contains(search.NazivDrzave.ToLower()));
            }

            var list = query.ToList();
            return _mapper.Map<List<eLibrary.Model.Grad>>(list);
        }
    }
}
