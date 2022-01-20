using eLibrary.Model.Requests.PrijedlogKnjige;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eLibrary.Services.Interfaces
{
    public interface IPrijedlogKnjigeService : ICRUDService<Model.PrijedlogKnjige, PrijedlogKnjigeSearchRequest, PrijedlogKnjigeInsertRequest, PrijedlogKnjigeInsertRequest>
    {
    }
}
