using GestionPolicial.Domain.Model;

namespace GestionPolicial.Domain.Factorias
{
    public class FactoriaPolicia
    {
        public static Policia GetPolicia()
        {
            return new Policia();
        }
    }
}
