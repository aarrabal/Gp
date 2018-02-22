using System;
using System.Xml.Serialization;

namespace GestionPolicial.Domain.Model
{
    [XmlInclude(typeof(Policia))]
    [Serializable]
    
    public abstract class EntityBase
    {
        public int Id { get; set; }
    
    }
}