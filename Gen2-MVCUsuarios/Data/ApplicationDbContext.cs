using Gen2_MVCUsuarios.Models;
using Microsoft.EntityFrameworkCore;

namespace Gen2_MVCUsuarios.Data
{
    public class ApplicationDbContext : DbContext
    {
        //Migracion del modelo a la base da datos
        public DbSet<Usuarios> Usuarios { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {
        }

    }
}
