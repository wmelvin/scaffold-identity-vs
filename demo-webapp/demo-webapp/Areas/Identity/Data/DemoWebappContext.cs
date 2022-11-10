using demo_webapp.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace demo_webapp.Data;

public class DemoWebappContext : IdentityDbContext<DemoWebappUser>
{
    private readonly string _dbPath;

    //public DemoWebappContext(DbContextOptions<DemoWebappContext> options)
    //    : base(options)
    //{
    //}

    //protected override void OnModelCreating(ModelBuilder builder)
    //{
    //    base.OnModelCreating(builder);
    //    // Customize the ASP.NET Identity model and override the defaults if needed.
    //    // For example, you can rename the ASP.NET Identity table names and more.
    //    // Add your customizations after calling base.OnModelCreating(builder);
    //}
    public DemoWebappContext(IConfiguration config)
    {
        var path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
        _dbPath = Path.Join(path, config.GetConnectionString("UserDbFilename"));
    }
    
    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={_dbPath}");

}
