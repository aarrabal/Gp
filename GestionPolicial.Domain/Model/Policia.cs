﻿using System;
using System.Xml.Serialization;

namespace GestionPolicial.Domain.Model
{
    [Serializable]
    public class Policia:Persona
    {
        public int NumeroPlaca { get; set; }
        public Policia()
        {
            
        }
    }
    
}