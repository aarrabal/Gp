namespace GestionPolicial.Domain.Model
{
    public class Usuario:Policia
    {
        public string NombreUsuario { get; set; }
        public string Password { get; set; }
    }
}