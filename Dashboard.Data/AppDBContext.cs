using Dashboard.Data.Data;
using Microsoft.EntityFrameworkCore;

namespace Dashboard.Data
{
    public class AppDBContext : DbContext
    {
        string _connectionString = "Server=.\\SQL2022;Initial Catalog=CucumberStudio-Dashboard;Integrated Security=True;TrustServerCertificate=True;";

        public DbSet<Project> Project { get; set; }

        public DbSet<TestRun> TestRun { get; set; }

        public DbSet<TestGroup> TestGroup { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }
    }
}
