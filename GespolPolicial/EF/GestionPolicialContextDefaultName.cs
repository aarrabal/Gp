using System.Data.Entity;
using GestionPolicial.Domain.Model;

namespace GespolPolicial.Test.EF
{
    /// <summary>
    /// Coge por defecto el nombre de la clase con todos los namespace.
    /// </summary>

    public class GestionPolicialContextDefaultName : DbContext
    {
        public GestionPolicialContextDefaultName() : base()
        {

        }
        public DbSet<Persona> Personas { get; set; }

    }
}