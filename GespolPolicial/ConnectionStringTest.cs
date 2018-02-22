using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using GestionPolicial.Domain.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GespolPolicial.Test
{
    /// <summary>
    /// Descripción resumida de ConnectionStringTest
    /// </summary>
    [TestClass]
    public class ConnectionStringTest
    {

        [TestMethod]
        public void TestMethod1()
        {
            var target = new GestionPolicialContextConnectionString();
            {
                /* var persona = new Persona();
                 persona.FechaNacimiento = new DateTime();
                 */
                var persona = new Persona {FechaNacimiento = new DateTime()};
                target.Personas.Add(persona);
                target.SaveChanges();
                var result = target.Personas.Count();
               
            }
        }

    }
}

