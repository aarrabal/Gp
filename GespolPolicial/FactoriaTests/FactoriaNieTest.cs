using GestionPolicial.Domain.Factorias;
using GestionPolicial.Domain.Model.Documentos;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GespolPolicial.Test.FactoriaTests
{
    /// <summary>
    /// Descripción resumida de FactoriaNieTest
    /// </summary>
    [TestClass]
    public class FactoriaNieTest
    {
        [TestMethod]
        public void TestFactoriaNie()
        {
            var target = FactoriaNie.GetNie();
            Assert.IsInstanceOfType(target,typeof(Nie));
        }
    }
}
