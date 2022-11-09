using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace demo_webapp.Data
{
    public class UploadContext : IdentityDbContext
    {
        public DbSet<Upload> Uploads => Set<Upload>();

        public string DbPath { get; set; }

        public UploadContext()
        {
            var path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            DbPath = Path.Join(path, "demo-webapp.sqlite");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");
    }
}
