using System;

namespace GestionPolicial.Domain.Model
{
    public class Detenido:Persona
    {
        public DateTime FechaDetencion;
        public Motivo MotivoDetencion;
    }
}