using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eLibrary.Services.Interfaces
{
    public interface IRecommendedService
    {
        List<eLibrary.Model.Knjiga> RecommendedProduct(int id);

    }
}
