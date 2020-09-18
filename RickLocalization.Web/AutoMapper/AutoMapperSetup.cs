using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RickLocalization.Web.AutoMaper
{
    public static class AutoMapperSetup
    {
        public static void AddAutoMapperSetup(this IServiceCollection services)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

            services.AddAutoMapper(typeof(DomainToViewModel), typeof(ViewModelToDomain)); 
            services.AddAutoMapper(typeof(ViewModelToDomain), typeof(DomainToViewModel));
        }
    }
}
