namespace GestionPolicial.Domain.Model.Documentos
{
    public class Pasaporte:IDocumentoIdentificacion
    {
        public string Pais { get; set; }
        public string NumeroDocumento { get; set; }
    }
}