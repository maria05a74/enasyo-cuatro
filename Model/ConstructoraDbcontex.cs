
using Microsoft.EntityFrameworkCore;

namespace intentocuatro.Model
{
    public class ConstructoraDbcontex : DbContext
    {
        public DbSet<Cliente> clientes { get; set; }
        public DbSet<Proyecto> proyectos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-LV3F03K;Initial Catalog=INTENTOCUATRO-db;Integrated Security=True;User ID=sa;Password=0918273456;");
        }
    }

   



}
