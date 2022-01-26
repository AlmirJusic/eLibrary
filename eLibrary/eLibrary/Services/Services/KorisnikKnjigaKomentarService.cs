using AutoMapper;
using eLibrary.Database;
using eLibrary.Model.Requests.KorisnikKnjigaKomentar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace eLibrary.Services.Services
{
    public class KorisnikKnjigaKomentarService : BaseCRUDService<eLibrary.Model.KorisnikKnjigaKomentar, KorisnikKnjigaKomentarSearchRequest, eLibrary.Database.Models.KorisnikKnjigaKomentar, KorisnikKnjigaKomentarInsertRequest, KorisnikKnjigaKomentarInsertRequest>
    {
        public KorisnikKnjigaKomentarService(eLibraryContext db, IMapper mapper) : base(db, mapper)
        {
        }
        public override List<eLibrary.Model.KorisnikKnjigaKomentar> Get(KorisnikKnjigaKomentarSearchRequest search)
        {
            var query = _db.KorisnikKnjigaKomentar.Include(x => x.Knjiga).Include(x=>x.Korisnik).AsQueryable();
            

            if (!string.IsNullOrWhiteSpace(search?.SadrzajKomentara))
            {
                query = query.Where(x => x.SadrzajKomentara.ToLower().Contains(search.SadrzajKomentara.ToLower()));
            }
            if (!string.IsNullOrWhiteSpace(search?.Knjiga_ID.ToString()))
            {
                query = query.Where(x => x.Knjiga_ID == search.Knjiga_ID);
            }


            var list = query.ToList();
            return _mapper.Map<List<eLibrary.Model.KorisnikKnjigaKomentar>>(list);
        }
    }
}
