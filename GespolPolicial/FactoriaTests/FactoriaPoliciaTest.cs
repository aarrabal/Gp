using GestionPolicial.Domain.Factorias;
using GestionPolicial.Domain.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GespolPolicial.Test.FactoriaTests
{
    /// <summary>
    /// Descripción resumida de UnitTest1
    /// </summary>
    [TestClass]
    public class FactoriaPoliciaTest
    {

        [TestMethod]
        public void TestFactoriaPolicia()
        {
            var target = FactoriaPolicia.GetPolicia();
            Assert.IsInstanceOfType(target,typeof(Policia));
        }
    }
}
