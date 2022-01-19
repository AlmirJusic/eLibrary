using eLibrary.Model.Requests.Uloga;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eLibrary.Services.Interfaces
{
    public interface IUlogaService : ICRUDService<Model.Uloga, UlogaSearchRequest, UlogaInsertRequest, UlogaInsertRequest>
    {
    }
}
