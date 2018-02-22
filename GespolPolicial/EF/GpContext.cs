using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using GestionPolicial.Domain.Model;

namespace GespolPolicial.Test.EF
{
    public class GpContext : DbContext
    {
        public GpContext() : base("GestionPolicialEjemplo")
        {
            //Database.SetInitializer<GpContext>(new CreateDatabaseIfNotExists<GpContext>());

            Database.SetInitializer<GpContext>(new DropCreateDatabaseIfModelChanges<GpContext>());
            //Database.SetInitializer<GpContext>(new DropCreateDatabaseAlways<GpContext>());
            //Database.SetInitializer<GpContext>(new GpInitializer());
        }
        /// <summary>
        /// 
        ///Especificaciones del modelo que se va a crear.
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Policia>().HasKey(p => p.Id);
            //modelBuilder.Entity<Persona>().Ignore(p => p.Edad);
            //modelBuilder.Configurations.Add(new ComplexTypeConfiguration<Persona>());
            //Configure domain classes using modelBuilder here..

        }
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Policia> Policias { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Detenido> Detenidos { get; set; }

    }
    public class GpInitializer : CreateDatabaseIfNotExists<GpContext>
    {
       
        protected override void Seed(GpContext context)
        {
            context.Usuarios.Add(new Usuario() {NombreUsuario = "admin", Password = "admin"});
            base.Seed(context);

        }
    }
}