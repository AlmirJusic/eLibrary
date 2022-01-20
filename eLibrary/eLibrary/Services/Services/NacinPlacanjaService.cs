using AutoMapper;
using eLibrary.Database;
using eLibrary.Model.Requests.NacinPlacanja;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eLibrary.Services.Services
{
    public class NacinPlacanjaService : BaseCRUDService<eLibrary.Model.NacinPlacanja, NacinPlacanjaSearchRequest, eLibrary.Database.Models.NacinPlacanja, NacinPlacanjaInsertRequest, NacinPlacanjaInsertRequest>
    {
        public NacinPlacanjaService(eLibraryContext db, IMapper mapper) : base(db, mapper)
        {
        }
        public override List<eLibrary.Model.NacinPlacanja> Get(NacinPlacanjaSearchRequest search)
        {
            var query = _db.NacinPlacanja.AsQueryable();

            if (!string.IsNullOrWhiteSpace(search?.Naziv))
            {
                query = query.Where(x => x.Naziv.ToLower().Contains(search.Naziv.ToLower()));
            }

            var list = query.ToList();
            return _mapper.Map<List<eLibrary.Model.NacinPlacanja>>(list);
        }
    }
}
