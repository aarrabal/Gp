using System;
using System.ComponentModel.DataAnnotations.Schema;
using GestionPolicial.Domain.Model.Documentos;

namespace GestionPolicial.Domain.Model
{
    /// <summary>
    /// Configurar base de datos entidad por atributos.
    /// http://www.entityframeworktutorial.net/code-first/configure-classes-in-code-first.aspx
    /// </summary>
    public class Persona:EntityBase
    {
       [Column("FechaDeNacimiento", TypeName ="datetime2")]
        public DateTime FechaNacimiento { get; set; }
        public IDocumentoIdentificacion DocumentoIdentificacion { get; set; }

        public int Edad
        {
            get { return DateTime.Now.Year - FechaNacimiento.Year; }
            set { }
        }
    }
}