using Microsoft.EntityFrameworkCore;
using BuildManager.core.Models;
using Microsoft.EntityFrameworkCore.Query;

namespace BuildManager.API.Data
{
    public class AppDBContext :DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options) {
        }
        public DbSet<Project> Projects => Set<Project>();
    }
}
