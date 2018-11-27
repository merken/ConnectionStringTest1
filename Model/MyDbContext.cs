using Microsoft.EntityFrameworkCore;

namespace ConnectionStringTest1.Model
{
    //This is the inherited class to provide a connection string, please use DbContextOptionsBuilder instead
    public class MyDbContext : MyContext
    {
        private readonly string connectionString;
        public MyDbContext(string connectionString) : base()
        {
            this.connectionString = connectionString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer(connectionString);
            }
        }
    }
}