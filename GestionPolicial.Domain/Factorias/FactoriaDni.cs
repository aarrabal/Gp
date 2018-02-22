using GestionPolicial.Domain.Model.Documentos;

namespace GestionPolicial.Domain.Factorias
{
    public class FactoriaDni
    {
        public static Dni GetDni()
        {
            return new Dni();
        }
    }
}

