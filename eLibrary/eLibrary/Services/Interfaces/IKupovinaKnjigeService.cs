using eLibrary.Model.Requests.KupovinaKnjige;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eLibrary.Services.Interfaces
{
    public interface IKupovinaKnjigeService : ICRUDService<Model.KupovinaKnjige, KupovinaKnjigeSearchRequest, KupovinaKnjigeInsertRequest, KupovinaKnjigeInsertRequest>
    {
    }
}
