using System;
using GestionPolicial.Domain.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GespolPolicial.Test.Model
{
    [TestClass]
    public class PersonaTest
    {
        /// <summary>
        /// Comprobar que las propiedades se le asiganan los valores correctos y son del tipo correcto.
        /// </summary>
        [TestMethod]
        public void PersonaPropiedadesTest()
        {

            var target = new Persona
            {
                Id = 2,
                FechaNacimiento = new DateTime(2000, 01, 01),
               // DocumentoIdentificacion = 1234
            };



            Assert.AreEqual(typeof(Persona),target.GetType());
            Assert.IsInstanceOfType(target,typeof(Persona));
        }
    }
}
