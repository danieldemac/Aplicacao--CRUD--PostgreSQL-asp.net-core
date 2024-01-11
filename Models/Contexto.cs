namespace Microsoft.EntityFrameworkCore;

namespace CRUD_PostgreSQL.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options)
            :base(options)
        {
        }

        public DbSet<Produto> Produtos {get; set;}
    }
}
