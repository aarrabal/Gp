using GestionPolicial.Domain.Model;
using GestionPolicial.Domain.Model.Documentos;

namespace GestionPolicial.Domain.Factorias
{
    public class FactoriaNie
    {
        public static Nie GetNie()
        {
            return new Nie();
        }
    }
}
