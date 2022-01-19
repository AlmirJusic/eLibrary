using eLibrary.Model.Requests.Drzava;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eLibrary.Services.Interfaces
{
    public interface IDrzavaService : ICRUDService<Model.Drzava, DrzavaSearchRequest, DrzavaInsertRequest, DrzavaInsertRequest>
    {
    }
}
