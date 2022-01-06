using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eLibrary.Services.Interfaces
{
    public interface IService<T,TSearch>
    {
        List<T> Get(TSearch search);
        T GetById(int id);
    }
}
