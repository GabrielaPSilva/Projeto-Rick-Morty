using AutoMapper;
using RickLocalization.Data.Entities;
using RickLocalization.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RickLocalization.Web.AutoMaper
{
    public class ViewModelToDomain : Profile
    {
        public ViewModelToDomain()
        {
            CreateMap<RickViewModel, Rick>();
            CreateMap<MortyViewModel, Morty>();
            CreateMap<DimensionsViewModel, Dimension>();
            CreateMap<TripViewModel, Trip>();
        }
    }
}
