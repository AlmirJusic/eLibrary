using eLibrary.Model.Requests.Pisac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eLibrary.Services.Interfaces
{
    public interface IPisacService : ICRUDService<Model.Pisac, PisacSearchRequest, PisacInsertRequest, PisacInsertRequest>
    {
    }
}
