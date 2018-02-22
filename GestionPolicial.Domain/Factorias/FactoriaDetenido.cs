using GestionPolicial.Domain.Model;

namespace GestionPolicial.Domain.Factorias
{
   public class FactoriaDetenido
    {
        public static Detenido GetDetenido()
        {
            return new Detenido();
        }
    }
}
