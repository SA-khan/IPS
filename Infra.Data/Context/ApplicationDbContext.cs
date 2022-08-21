
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

using IPS.Domain.Models;
using IPS.Domain.Interfaces;

namespace IPS.Infra.Data.Context;
public class ApplicationDbContext : DbContext, IApplicationDbContext {
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> opts) : base(opts)
    {
        
    }
    public DbSet<Course> Courses { get; set; }
    //[NotMapped]
    public DatabaseFacade? Database { get; set; }
    public override int SaveChanges(){
        return base.SaveChanges();
    }
}