using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

using IPS.Domain.Models;

namespace IPS.Domain.Interfaces;

public interface IApplicationDbContext  {
    public DbSet<Course> Courses { get; set; }
    public DatabaseFacade? Database { get; set; }
    public int SaveChanges();
}