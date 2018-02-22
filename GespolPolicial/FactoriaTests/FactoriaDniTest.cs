using GestionPolicial.Domain.Factorias;
using GestionPolicial.Domain.Model.Documentos;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GespolPolicial.Test.FactoriaTests
{
    /// <summary>
    /// Descripción resumida de TestFactoriaDni
    /// </summary>
    [TestClass]
    public class FactoriaDniTest
    {
       
        [TestMethod]
        public void TestFactoryDni()
        {
            var target = FactoriaDni.GetDni();
            Assert.IsInstanceOfType(target,typeof(Dni));
        }
    }
}
