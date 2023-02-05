using Mentor.DAL;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
var conString = builder.Configuration["ConnectionStrings:Default"];
builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(conString));
var app = builder.Build();
app.UseStaticFiles();
app.MapControllerRoute("default", "{controller=Course}/{action=Index}/{id?}");

app.Run();
