using AutoMapper;
using eLibrary.Database;
using eLibrary.Model.Requests.Knjiga;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eLibrary.Services.Services
{
    public class KnjigaService : BaseCRUDService<eLibrary.Model.Knjiga, KnjigaSearchRequest, eLibrary.Database.Models.Knjiga, KnjigaInsertRequest, KnjigaInsertRequest>
    {
        public KnjigaService(eLibraryContext db, IMapper mapper) : base(db, mapper)
        {
        }
        public override List<eLibrary.Model.Knjiga> Get(KnjigaSearchRequest search)
        {
            var query = _db.Knjiga.Include(x=>x.Pisac).Include(x=>x.Zanr).AsQueryable();

            if (!string.IsNullOrWhiteSpace(search?.NazivKnjige))
            {
                query = query.Where(x => x.NazivKnjige.ToLower().Contains(search.NazivKnjige.ToLower()));
            }
            if (!string.IsNullOrWhiteSpace(search?.Pisac))
            {
                query = query.Where(x => x.Pisac.Ime.ToLower().Contains(search.Pisac.ToLower())|| x.Pisac.Prezime.ToLower().Contains(search.Pisac.ToLower()));
            }
            if (!string.IsNullOrWhiteSpace(search?.Zanr_ID.ToString()))
            {
                query = query.Where(x => x.Zanr_ID == search.Zanr_ID);
            }


            var list = query.ToList();
            return _mapper.Map<List<eLibrary.Model.Knjiga>>(list);
        }
    }
}
