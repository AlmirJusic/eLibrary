using eLibrary.Model.Requests.Zanr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eLibrary.Services.Interfaces
{
    public interface IZanrService : ICRUDService<Model.Zanr, ZanrSearchRequest, ZanrInsertRequest, ZanrInsertRequest>
    {
    }
}
