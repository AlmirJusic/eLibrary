using AutoMapper;
using eLibrary.Database;
using eLibrary.Model.Requests.Placanje;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eLibrary.Services.Services
{
    public class PlacanjeService : BaseCRUDService<eLibrary.Model.Placanje, PlacanjeSearchRequest, eLibrary.Database.Models.Placanje, PlacanjeInsertRequest, PlacanjeInsertRequest>
    {
        public PlacanjeService(eLibraryContext db, IMapper mapper) : base(db, mapper)
        {
        }
        public override List<eLibrary.Model.Placanje> Get(PlacanjeSearchRequest search)
        {
            var query = _db.Placanje.AsQueryable();

            if (!string.IsNullOrWhiteSpace(search?.ImePrezime))
            {
                query = query.Where(x => x.ImePrezime.ToLower().Contains(search.ImePrezime.ToLower()));
            }
            if (search?.NacinPlacanja_ID.HasValue == true)
            {
                query = query.Where(x => x.NacinPlacanja_ID == search.NacinPlacanja_ID);
            }

            var list = query.ToList();
            return _mapper.Map<List<eLibrary.Model.Placanje>>(list);
        }
    }
}
