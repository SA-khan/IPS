using Microsoft.EntityFrameworkCore;

using IPS.Domain.Models;
using IPS.Domain.Interfaces;
using IPS.Infra.Data.Context;

namespace IPS.Infra.Data.Seeding;

public class SeedDatabase {
    public static void SeedData(IApplicationDbContext context)
    {
        context.Database?.Migrate();
        var course1 = new Course { Name = "Maths" };
        context.Courses.Add(course1);
        context.SaveChanges();
    }
}