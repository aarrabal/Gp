using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace GestionPolicial.Domain.Model
{
    public class Detenido : Persona
    {
        [Column(name: "FechaDeDetencion", TypeName = "datetime2")]
        public DateTime FechaDetencion { 
        get;
        set;
    }

    public Motivo MotivoDetencion;
    }
}