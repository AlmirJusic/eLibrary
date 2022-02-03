using AutoMapper;
using eLibrary.Database;
using eLibrary.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eLibrary.Model;

namespace eLibrary.Services.Services
{
    public class RecomendedService:IRecommendedService
    {
        private readonly eLibraryContext _context;
        private readonly IMapper _mapper;
        public RecomendedService(eLibraryContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        Dictionary<int, List<Database.Models.KorisnikKnjigaOcjena>> proizvodi = new Dictionary<int, List<Database.Models.KorisnikKnjigaOcjena>>();

        private List<Database.Models.Knjiga> LoadSimilar(int proizvodid)
        {
            LoadOtherProduct(proizvodid);
            List<Database.Models.KorisnikKnjigaOcjena> ratingOfCurrent = _context.KorisnikKnjigaOcjena.Where(x => x.Knjiga_ID == proizvodid).OrderBy(x => x.Korisnik_ID).ToList();

            List<Database.Models.KorisnikKnjigaOcjena> ratings1 = new List<Database.Models.KorisnikKnjigaOcjena>();
            List<Database.Models.KorisnikKnjigaOcjena> ratings2 = new List<Database.Models.KorisnikKnjigaOcjena>();
            List<Database.Models.Knjiga> recommendedProduct = new List<Database.Models.Knjiga>();

            foreach (var product in proizvodi)
            {
                foreach (Database.Models.KorisnikKnjigaOcjena rating in ratingOfCurrent)
                {
                    if (product.Value.Where(w => w.Korisnik_ID == rating.Korisnik_ID).Count() > 0)
                    {
                        ratings1.Add(rating);
                        ratings2.Add(product.Value.Where(w => w.Korisnik_ID == rating.Korisnik_ID).First());
                    }
                }
                double similarity = GetSimilarity(ratings1, ratings2);
                if (similarity > 0.5)
                {
                    recommendedProduct.Add(_context.Knjiga.Where(w => w.Knjiga_ID == product.Key).FirstOrDefault());
                }
                ratings1.Clear();
                ratings2.Clear();
            }
            return recommendedProduct;
        }

        private double GetSimilarity(List<Database.Models.KorisnikKnjigaOcjena> ratings1, List<Database.Models.KorisnikKnjigaOcjena> ratings2)
        {
            if (ratings1.Count != ratings2.Count)
            {
                return 0;
            }
            double x = 0, y1 = 0, y2 = 0;
            for (int i = 0; i < ratings1.Count; i++)
            {
                x += ratings1[i].Ocjena * ratings2[i].Ocjena;
                y1 += ratings1[i].Ocjena * ratings1[i].Ocjena;
                y2 += ratings2[i].Ocjena * ratings2[i].Ocjena;
            }
            y1 = Math.Sqrt(y1);
            y2 = Math.Sqrt(y2);

            double y = y1 * y2;
            if (y == 0)
                return 0;
            return x / y;
        }
        private void LoadOtherProduct(int proizvodid)
        {
            List<Database.Models.Knjiga> list = _context.Knjiga.Where(w => w.Knjiga_ID != proizvodid).ToList();
            List<Database.Models.KorisnikKnjigaOcjena> ratings = new List<Database.Models.KorisnikKnjigaOcjena>();
            foreach (var item in list)
            {
                ratings = _context.KorisnikKnjigaOcjena.Where(w => w.Knjiga_ID == item.Knjiga_ID).OrderBy(w => w.Knjiga_ID).ToList();
                if (ratings.Count > 0)
                {
                    proizvodi.Add(item.Knjiga_ID, ratings);
                }
            }

        }

        public List<eLibrary.Model.Knjiga> RecommendedProduct(int proizvodid)
        {

            var tmp = LoadSimilar(proizvodid);
            return _mapper.Map<List<eLibrary.Model.Knjiga>>(tmp);

        }
    }
}

