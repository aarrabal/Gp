using System;

namespace GespolPolicial.Test.Model
{
    public class PersonaNueva
    {
   
        public string Campo;
        private string _propiedad;
        public string Propiedad
        {
            get
            {
                return "hola"+_propiedad;
            }
            set
            {
                _propiedad = value;
            }
        }

        public string Nombre { get; set; }
        public int Edad { get; set; }

        public PersonaNueva()
        {

        }

        public PersonaNueva(string nombre)
        {
            Nombre = nombre;
        
        }
        public int calcularAnioNacimiento()
        {
            return DateTime.Now.Year - Edad;
        }
    }
}