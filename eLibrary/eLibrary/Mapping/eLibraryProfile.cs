using AutoMapper;
using eLibrary.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eLibrary.Mapping
{
    public class FixItProfile : Profile
    {
        public FixItProfile()
        {


            CreateMap<Drzava, Model.Requests.Drzava.DrzavaInsertRequest>().ReverseMap();
            CreateMap<Drzava, Model.Drzava>().ReverseMap();
        }
    }
}
