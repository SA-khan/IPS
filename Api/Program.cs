using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

using IPS.Domain.Interfaces;
using IPS.Infra.Data.Context;
using IPS.Infra.Data.Seeding;
using IPS.Infra.IoC;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();
builder.Services.AddRazorPages().AddRazorRuntimeCompilation();

// Conneting DB
string connectionString = builder.Configuration.GetConnectionString("IPS_DB_Connection");
builder.Services.AddDbContext<ApplicationDbContext>(opts => opts.UseSqlServer(connectionString));

builder.Services.AddSwaggerGen(opts => {
    opts.SwaggerDoc("v1", new OpenApiInfo { Title = "Investment Portfolio System", Version = "v1" });
});

DependencyContainer.AddInfrastructure(builder.Services);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.UseSwagger();
app.UseSwaggerUI(options => {
    options.SwaggerEndpoint("/swagger/v1/swagger.json", "Investment Portfolio System API");
});

using(var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<IApplicationDbContext>();
    SeedDatabase.SeedData(context);
}


app.Run();
