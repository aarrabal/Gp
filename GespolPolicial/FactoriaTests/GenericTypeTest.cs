using System.Text;
using GestionPolicial.Domain.Factorias;
using GestionPolicial.Domain.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GespolPolicial.Test.FactoriaTests
{
    /// <summary>
    /// Descripción resumida de GenericTypeTest
    /// </summary>
    [TestClass]
    public class GenericTypeTest
    {
      
        [TestMethod]
        public void TestMethod1()
        {
            var targetPersona =  Factoria<Persona>.Get();
            var targetPolicia = Factoria<Policia>.Get();
            Assert.IsInstanceOfType(targetPersona,typeof(Persona));
            Assert.IsInstanceOfType(targetPolicia,typeof(Policia));
        }
    }
}
