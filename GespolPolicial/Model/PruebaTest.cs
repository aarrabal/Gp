using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GespolPolicial.Test.Model
{
    /// <summary>
    /// Descripción resumida de PruebaTest
    /// </summary>
    [TestClass]
    public class PruebaTest
    {
        [TestMethod]
        public void TestMethod1()
        {
           //Arrange
            var target = new PersonaNueva();
            target.Nombre = "Alex";
            target.Edad = 19;
            //Action
            var result = target.calcularAnioNacimiento();
            //Assert
            Assert.AreEqual(2018-19,result);
        }

        [TestMethod]
        public void TestPropiedad()
        {
            var target = new PersonaNueva();
            target.Campo = "valorCampo";
            target.Propiedad = "valorPropiedad";

        }

        [TestMethod]
        public void TestCtor()
        {
            var target = new PersonaNueva("Alex");
        }

        [TestMethod]
        public void TestPersona()
        {
            //arange
            var target = new Personauno();
            target.FechaNacimiento= new DateTime(2000,01,01);
            
            //action
            var result = target.Edad;

            //asert
            Assert.AreEqual(18,result);

        }
    }
}
