using Microsoft.Extensions.DependencyInjection;
using AutoMapper;
//using AutoMapper.Extensions.Microsoft.DependencyInjection;
using MediatR;
//using MediatR.Extensions.Microsoft.DependencyInjection;
using Microsoft.AspNetCore.Routing;
using System.Reflection;

using IPS.Domain.Models;
using IPS.Domain.Interfaces;
using IPS.Infra.Data.Context;
using IPS.Infra.Data.Repositories;
using IPS.Infra.Data.Seeding;
using IPS.Application.Core.v1.Course.Query;



namespace IPS.Infra.IoC;
public class DependencyContainer {
    public static void AddInfrastructure(IServiceCollection services){

        services.AddMediatR(Assembly.GetExecutingAssembly());


        services.AddScoped<ICourseRepository, CourseRepository>();
        services.AddScoped<ICourse, Course>();
        //services.AddScoped<ISender>();
        services.AddMediatR(typeof(GetAllCoursesQuery).GetTypeInfo().Assembly);
        services.AddScoped<IGetAllCoursesQueryHandler,GetAllCoursesQueryHandler>();
        services.AddScoped(typeof(GetAllCoursesQuery));
        services.AddScoped(typeof(ICourseRepository), typeof(CourseRepository));
        services.AddScoped<SeedDatabase>();
        services.AddScoped<IApplicationDbContext, ApplicationDbContext>();
    }
}