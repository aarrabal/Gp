using System.Data.Entity;
using GestionPolicial.Domain.Model;
using GestionPolicial.Domain.Model.Documentos;

namespace GestionPolicial.Dal.EF
{
    public class GpContext : DbContext
    {
        /// <summary>
        /// Database.SetInitializer<GpContext>(new CreateDatabaseIfNotExists<GpContext>());</GpContext></GpContext>
        // Database.SetInitializer<GpContext>(new GpInitializer());
        // Database.SetInitializer<GpContext>(new DropCreateDatabaseIfModelChanges<GpContext>());
        /// </summary>
        public GpContext() : base("name=GestionPolicialEjemplo")
        {


            Database.SetInitializer<GpContext>(new GpInitializer());

        }
        /// <summary>
        /// 
        ///Especificaciones del modelo que se va a crear.
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Policia>().HasKey(p => p.Id);
            modelBuilder.Entity<Persona>().Ignore(p => p.FechaNacimiento);
            //modelBuilder.Entity<Persona>().Ignore(p => p.Edad);
            //modelBuilder.Configurations.Add(new ComplexTypeConfiguration<Persona>());
            //Configure domain classes using modelBuilder here..

        }
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Policia> Policias { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Detenido> Detenidos { get; set; }

        public DbSet<Dni> Dnis { get; set; }
        public DbSet<Nie> Nies { get; set; }
        public DbSet<Pasaporte> Pasaportes { get; set; }
        
    }
}