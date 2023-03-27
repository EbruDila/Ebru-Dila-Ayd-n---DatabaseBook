using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookEbruDilaAydın.Models
{
    public class BookDatabase : DbContext
    {
        public DbSet<Books> Books { get; set; }
        public DbSet<Publishers> Publishers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=LAPTOP-NO5JIK9J\\SQLEXPRESS;Database=BookDatabase;Trusted_Connection=True;;Trust Server Certificate=true");
        }
        

    }
}
