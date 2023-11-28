using MvcLab4.Models;
using MvcLab4.Context;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<AcademyContext>(options => {
    options.UseSqlite("Data Source=Context/AcademyDB.db");
});


var app = builder.Build();

// using var scope = app.Services.CreateScope();
// var services = scope.ServiceProvider;
// try
// {
//     var context = services.GetRequiredService<AcademyContext>();
//     context.Database.EnsureCreated();
// }
// catch (Exception ex)
// {
//     Console.WriteLine(ex.Message);
// }

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
    pattern: "{controller=TheCtrl}/{action=Index}/{id?}");

app.Run();