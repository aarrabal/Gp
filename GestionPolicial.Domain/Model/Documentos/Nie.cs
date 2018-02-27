using System;
using System.ComponentModel.DataAnnotations;

namespace GestionPolicial.Domain.Model.Documentos
{
    public class Nie :  DocumentoIdentificacionBase
    {
        public const string Correspondencia = "TRWAGMYFPDXBNJZSQVHLCKE";
        public string Pais { get; set; }
        private string _numeroDoc;
        [Key]
        public string NumeroDocumento
        {
            get { return _numeroDoc; }
            set
            {
                var letra = LetraNie(value);
                _numeroDoc = $"{value}{letra}";
            }
        }

        public char? LetraNie(string nie)
        {
            int n;

            //Linea original, editado en caso practico 
            //if ((nie == null) || (nie.Length != 8) || ((char.ToUpper(nie[0]) != 'X') && (char.ToUpper(nie[0]) != 'Y') && (char.ToUpper(nie[0]) != 'Z')) || (!int.TryParse(nie.Substring(1), out n)))
            if ((nie == null) || (nie.Length < 8 || nie.Length > 9) ||
                ((char.ToUpper(nie[0]) != 'X') && (char.ToUpper(nie[0]) != 'Y') && (char.ToUpper(nie[0]) != 'Z')) ||
                (!int.TryParse(nie.Substring(1, 7), out n)))
            {
                throw new NieException("El NIE debe comenzar con la letra X, Y o Z seguida de 7 dígitos.");
            }


            var letra = new char();
            switch (char.ToUpper(nie[0]))
            {
                case 'X':
                    letra = Correspondencia[n % 23];
                    break;
                case 'Y':
                    letra = Correspondencia[(10000000 + n) % 23];
                    break;
                case 'Z':
                    letra = Correspondencia[(20000000 + n) % 23];
                    break;

            }

            if (nie.Length == 8)
            {
                return letra;
            }

            if (nie.Length == 9)
            {
                checkLetraNie(nie, letra);
            }

            return null;

        }

        private char? checkLetraNie(string nie, char letra)
        {
          
            if (letra != char.Parse(nie.Substring(8, 1)))
            {
                throw new ExceptionNieLetraIncorrecta();


            }

            return null;
        }
    }

   public class ExceptionNieLetraIncorrecta : Exception
    {
    }

    public class NieException : Exception
    {
        public NieException(string elNieDebeComenzarConLaLetraXYOZSeguidaDeDígitos)
        {
            
        }

    }
}
