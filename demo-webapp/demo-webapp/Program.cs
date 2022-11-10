using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using demo_webapp.Data;
using demo_webapp.Areas.Identity.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<DemoWebappContext>();

//builder.Services.AddDefaultIdentity<DemoWebappUser>(options => options.SignIn.RequireConfirmedAccount = true)
//    .AddEntityFrameworkStores<DemoWebappContext>();
builder.Services.AddDefaultIdentity<DemoWebappUser>()
    .AddEntityFrameworkStores<DemoWebappContext>();


builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseStaticFiles();

app.UseAuthentication();

if (app.Environment.IsDevelopment()) 
{
    app.UseDeveloperExceptionPage();
}

app.MapRazorPages();
app.MapDefaultControllerRoute();

app.Run();
