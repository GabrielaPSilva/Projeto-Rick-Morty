using AutoMapper;
using RickLocalization.Data.Entities;
using RickLocalization.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RickLocalization.Web.AutoMaper
{
    public class DomainToViewModel : Profile
    {
        public DomainToViewModel()
        {
            CreateMap<Rick, RickViewModel>();
            CreateMap<Dimension, DimensionsViewModel>();
            CreateMap<Trip, TripViewModel>();
            CreateMap<Morty, MortyViewModel>();
        }
    }
}
