using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GestionPolicial.Domain.Model
{
    [Table("usuarios")]
    public class Usuario:Policia
    {
        [Column("Username", TypeName = "nvarchar")]
     
        [MaxLength(120)]
        public string NombreUsuario { get; set; }
        public string Password { get; set; }
    }
}