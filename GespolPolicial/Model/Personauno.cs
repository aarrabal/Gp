using System;

namespace GespolPolicial.Test.Model
{
    public class Personauno
    {
        public int Id;

        public IDocumentodeIdentificacion DocumentoIdentificacion;

        public DateTime FechaNacimiento;

        public int Edad
        {
            get
            {
                return System.DateTime.Now.Year - FechaNacimiento.Year;
            }
        }




    }
}