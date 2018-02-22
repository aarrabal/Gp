using System;

namespace GestionPolicial.Domain.Model.Documentos
{
    public class Dni : IDocumentoIdentificacion
    {
        public const string Correspondencia = "TRWAGMYFPDXBNJZSQVHLCKE";
        public const string Pais = "España";
        private string _numeroDoc;
        public string NumeroDocumento
        {
            get { return _numeroDoc; }
            set
            {
                var letra =  LetraDNI(value);
                _numeroDoc=$"{value}{letra}";
            }
        }

        public char? LetraDNI(string dni)
        {
            int n;
            if((dni == null) || (dni.Length < 8 || dni.Length>9) || (!int.TryParse(dni.Substring(0, 8),
                   out n))) throw new ExceptionDni();

            //if ((dni == null) || (dni.Length != 8) || (!int.TryParse(dni, out n)))
            if ( dni.Length == 8)
            {
                return GetLetra(dni);
            }

            if (dni.Length == 9)
                return checkLetra(dni);


            return Correspondencia[n % 23];
        }

        private char? checkLetra(string dni)
        {
            var letra = GetLetra(dni.Substring(0, 7));
            if (letra != char.Parse(dni.Substring(8, 1)))
            {
                throw new ExceptionDniLetraIncorrecta();


            }

            return null;
        }

        private  char GetLetra(string dni)
        {
            int n;
            int.TryParse(dni.Substring(0, 7), out n);
            return Correspondencia[n % 23];
 
            
        }
    }

    public  class ExceptionDniLetraIncorrecta : Exception
    {
        public ExceptionDniLetraIncorrecta():base("La letra del DNI no es correcta")
        {
            
        }
    }

    public class ExceptionDni : Exception
    {
        public ExceptionDni():base("El DNI debe contener 8 dígitos.")
        {
      
        }
    }
}