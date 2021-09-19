using Entities.Concrete;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=Directory; integrated security=true;");
        }

        public SqlConnection baglan()
        {
            SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=Directory;Integrated Security=True");
            baglanti.Open();
            return (baglanti);
        }

        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Information> Informations { get; set; }
    }
}
