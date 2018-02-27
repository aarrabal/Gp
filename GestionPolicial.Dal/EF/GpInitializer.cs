using System.Data.Entity;
using GestionPolicial.Domain.Model;

namespace GestionPolicial.Dal.EF
{
    public class GpInitializer : DropCreateDatabaseAlways<GpContext>
    {
       
        protected override void Seed(GpContext context)
        {
           context.Usuarios.Add(new Usuario() {NombreUsuario = "admin", Password = "admin"});
            base.Seed(context);

        }
    }
}