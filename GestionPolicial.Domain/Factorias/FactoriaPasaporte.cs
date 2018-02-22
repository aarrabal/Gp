using GestionPolicial.Domain.Model;
using GestionPolicial.Domain.Model.Documentos;

namespace GestionPolicial.Domain.Factorias
{
    public class FactoriaPasaporte
    {
        public static Pasaporte GetPasaport()
        {
            return new Pasaporte();
        }
    }
}

