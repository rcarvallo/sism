using Pomelo.EntityFrameworkCore.MySql;
using Microsoft.EntityFrameworkCore;
using sism.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddScoped<sismActual.Services.AveragePerDayService>();

builder.Services.AddDbContext<CermetpesajeContext>(options =>
    options.UseMySql(builder.Configuration.GetConnectionString("conexion"), ServerVersion.Parse("5.6.22 - mysql")))
        .AddDbContext<ParshallContext>(options =>
    options.UseMySql(builder.Configuration.GetConnectionString("conexionParshall"), ServerVersion.Parse("5.6.22 - mysql")));


var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();