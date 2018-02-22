using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using GestionPolicial.Domain.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GespolPolicial.Test.EF
{
    /// <summary>
    /// Descripción resumida de GpContextTest
    /// </summary>
    [TestClass]
    public class GpContextTest
    {
      

        [TestMethod]
        public void TestContext()
        {
            var target = new GpContext();
            {
                /* var persona = new Persona();
                 persona.FechaNacimiento = new DateTime();
                 */
                var persona = new Persona {FechaNacimiento = new DateTime(2000,09,01)};
                target.Personas.Add(persona);
                target.SaveChanges();


                var policia = new Policia {NumeroPlaca = 5};
                target.Policias.Add(policia);
                target.SaveChanges();               
            }
        }
    }
}
