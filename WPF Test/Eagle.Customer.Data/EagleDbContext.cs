using Eagle.CustomerApp.Model;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;
namespace Eagle.CustomerApp.Data
{
    public class EagleDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }

        public EagleDbContext()
        {
        }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            Console.WriteLine(Path.Combine(GetDatabaseDirectory(), "EagleTestDb.db"));
            SqliteConnectionStringBuilder connectionString = new()
            {
                DataSource = Path.Combine(GetDatabaseDirectory(), "EagleTestDb.db"),
                Mode = SqliteOpenMode.ReadWriteCreate,
            };
            optionsBuilder.UseSqlite(connectionString.ToString());
        }

        /// <summary>
        /// Implemented this to make sure we find the proper database file path for test purposes
        /// </summary>
        /// <returns>Path where Database directory exists</returns>
        private string GetDatabaseDirectory()
        {
            var directory = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            var wpfTextIndex = directory.LastIndexOf("WPF Test\\", StringComparison.CurrentCultureIgnoreCase);
            return Path.Combine(directory.Substring(0, wpfTextIndex + 8), "Database");

        }

    }
}
