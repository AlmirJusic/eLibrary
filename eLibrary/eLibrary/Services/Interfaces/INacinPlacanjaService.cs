using eLibrary.Model.Requests.NacinPlacanja;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eLibrary.Services.Interfaces
{
    public interface INacinPlacanjaService : ICRUDService<Model.NacinPlacanja, NacinPlacanjaSearchRequest, NacinPlacanjaInsertRequest, NacinPlacanjaInsertRequest>
    {
    }
}
