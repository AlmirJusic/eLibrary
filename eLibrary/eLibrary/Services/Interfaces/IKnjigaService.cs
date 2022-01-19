using eLibrary.Model.Requests.Knjiga;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eLibrary.Services.Interfaces
{
    public interface IKnjigaService : ICRUDService<Model.Knjiga, KnjigaSearchRequest, KnjigaInsertRequest, KnjigaInsertRequest>
    {
    }
}
