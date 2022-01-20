using AutoMapper;
using eLibrary.Database;
using eLibrary.Model.Requests.KupovinaKnjige;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eLibrary.Services.Services
{
    public class KupovinaKnjigeService : BaseCRUDService<eLibrary.Model.KupovinaKnjige, KupovinaKnjigeSearchRequest, eLibrary.Database.Models.KupovinaKnjige, KupovinaKnjigeInsertRequest, KupovinaKnjigeInsertRequest>
    {
        public KupovinaKnjigeService(eLibraryContext db, IMapper mapper) : base(db, mapper)
        {
        }
        public override List<eLibrary.Model.KupovinaKnjige> Get(KupovinaKnjigeSearchRequest search)
        {
            var query = _db.KupovinaKnjige.AsQueryable();

            
            if (search?.Knjiga_ID.HasValue == true)
            {
                query = query.Where(x => x.Knjiga_ID == search.Knjiga_ID);
            }
            if (search?.Korisnik_ID.HasValue == true)
            {
                query = query.Where(x => x.Korisnik_ID == search.Korisnik_ID);
            }

            var list = query.ToList();
            return _mapper.Map<List<eLibrary.Model.KupovinaKnjige>>(list);
        }
    }
}
