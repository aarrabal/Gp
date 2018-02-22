using GestionPolicial.Domain.Model;

namespace GestionPolicial.Domain.Factorias
{
    public class FactoriaUsuario
    {
        public static Usuario GetUsuario()
        {
            return new Usuario();
        }
    }
}
