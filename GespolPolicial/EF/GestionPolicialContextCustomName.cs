using System.Data.Entity;
using GestionPolicial.Domain.Model;

namespace GespolPolicial.Test.EF
{
    public class GestionPolicialContextCustomName:DbContext
    {
        public GestionPolicialContextCustomName(): base("GestionPolicialCustomName")
        {
            
        }
        public DbSet<Persona> Personas { get; set; }

    }
}