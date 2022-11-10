using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using demo_webapp.Data;
using demo_webapp.Areas.Identity.Data;

var builder = WebApplication.CreateBuilder(args);

//var connectionString = builder.Configuration.GetConnectionString("AuthContextConnection") 
//    ?? throw new InvalidOperationException("Connection string 'AuthContextConnection' not found.");

var appdata_path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
string connectionString = $"Data Source={Path.Join(appdata_path, "demo-webapp-auth.sqlite")}";

builder.Services.AddDbContext<AuthContext>(options =>
    options.UseSqlite(connectionString));

builder.Services.AddDefaultIdentity<AuthUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<AuthContext>();

builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseStaticFiles();

if (app.Environment.IsDevelopment()) 
{
    app.UseDeveloperExceptionPage();
}

app.MapDefaultControllerRoute();
app.MapRazorPages();
app.UseAuthentication();;

app.Run();
