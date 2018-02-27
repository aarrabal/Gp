using System.ComponentModel.DataAnnotations;

namespace GestionPolicial.Domain.Model.Documentos
{
    public class Pasaporte: DocumentoIdentificacionBase
    {
        public string Pais { get; set; }
        [Key]
        public string NumeroDocumento { get; set; }
    }
}