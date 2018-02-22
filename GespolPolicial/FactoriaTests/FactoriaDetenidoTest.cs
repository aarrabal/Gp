using GestionPolicial.Domain.Factorias;
using GestionPolicial.Domain.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GespolPolicial.Test.FactoriaTests
{
    /// <summary>
    /// Descripción resumida de FactoriaDetenidoTest
    /// </summary>
    [TestClass]
    public class FactoriaDetenidoTest
    {

        [TestMethod]
        public void TestFactoriaDetenido()
        {
            var target = FactoriaDetenido.GetDetenido();
            Assert.IsInstanceOfType(target,typeof(Detenido));
        }
    }
}
