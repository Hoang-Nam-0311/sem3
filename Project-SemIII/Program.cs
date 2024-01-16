using Microsoft.CodeAnalysis.Options;
using Microsoft.EntityFrameworkCore;
using Project_Sem3.Models;
using Project_SemIII.Middlewares;
using static Project_SemIII.Areas.Admin.Controllers.LoginController;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.



builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<ProjectDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("Data")));


builder.Services.AddDistributedMemoryCache();

builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(30);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseSession();
app.UseMiddleware<AuthencationMiddleware>();
app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
      name: "areas",
      pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
    );
});
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
