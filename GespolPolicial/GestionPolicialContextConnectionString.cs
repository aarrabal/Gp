using System.Data.Entity;
using GestionPolicial.Domain.Model;

namespace GespolPolicial.Test
{
    public class GestionPolicialContextConnectionString:DbContext
    {

        public GestionPolicialContextConnectionString():base("name=GestionPolicialConnectionString")
        {
          
        }
        public DbSet<Persona> Personas { get; set; }
    }
}