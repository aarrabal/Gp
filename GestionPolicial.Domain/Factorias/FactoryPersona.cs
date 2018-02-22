using GestionPolicial.Domain.Model;

namespace GestionPolicial.Domain.Factorias
{
    public class FactoryPersona
    {
        public static Persona GetPersona()
        {
            return new Persona();
        }
    }
}