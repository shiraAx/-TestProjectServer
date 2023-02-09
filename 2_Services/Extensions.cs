using _3_Repository.Interfaces;
using _3_Repository;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _3_Repository.Entities;
using _2_Services.Models;
using _3_Repository.Repositories;

namespace _2_Services
{
    public static class Extensions
    {
        public static void AddRepoDependencies(this IServiceCollection services)
        {
            services.AddScoped<IChildRepository, ChildRepository>();
            services.AddScoped<IParentRepository, ParentRepository>();



            MapperConfiguration config = new MapperConfiguration(a =>
            {
                a.CreateMap<Child, ChildModel>().ReverseMap();
                a.CreateMap<Parent, ParentModel>().ReverseMap();
            });


            IMapper Mapper = config.CreateMapper();

            services.AddSingleton(Mapper);



            services.AddDbContext<IDataSource, SQLDataSource>();

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

        }




    }
}
