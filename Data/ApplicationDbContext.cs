using Microsoft.EntityFrameworkCore;
using TestProyecto1.Models;

namespace TestProyecto1.Data
{
    public class ApplicationDbContext : DbContext // hereda de la clase DBContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            //Constructor de la clase
        }


        //Instacias de los modelos
        public DbSet<Medicos> Med { get; set; }
        public DbSet<Clinicas> Clinic { get; set; }

        public DbSet<Pacientes> Pac
        {
            get; set;
        }
        public DbSet<Inyecciones> Inyec { get; set; }
        public DbSet<Efectos> Efec { get; set; }
    }
}
