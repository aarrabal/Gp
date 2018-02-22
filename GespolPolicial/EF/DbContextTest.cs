using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using GestionPolicial.Domain.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GespolPolicial.Test.EF
{
    /// <summary>
    /// Instalación de EF
    /// http://www.entityframeworktutorial.net/code-first/setup-entity-framework-code-first-environment.aspx
    /// Crear DBContext
    /// http://www.entityframeworktutorial.net/code-first/simple-code-first-example.aspx
    /// </summary>
    [TestClass]
    public class DbContextTest
    {
       

        [TestMethod]
        public void TestGenerarDBContext()
        {
            var target = new GestionPolicialContextCustomName();
            {
               /* var persona = new Persona();
                persona.FechaNacimiento = new DateTime();
                */
                var persona = new Persona {FechaNacimiento = new DateTime()};
                target.Personas.Add(persona);
                target.SaveChanges();
                var result = target.Personas.Count();
                Assert.Inconclusive("Verificar que el nomrbre que se ha generado es: GestionPolicial ");
            }
        }


        [TestMethod]
        public void TestDefaultName()
        {
            var target = new GestionPolicialContextDefaultName();
            {
                /* var persona = new Persona();
                 persona.FechaNacimiento = new DateTime();
                 */
                var persona = new Persona { FechaNacimiento = new DateTime() };
                target.Personas.Add(persona);
                target.SaveChanges();
                var result = target.Personas.Count();
               Assert.Inconclusive("Verificar que el nomrbre que se ha generado es: GespolPolicial.Test.EF.GestionPolicialContextCustomName");
            }
        }
    }
}
