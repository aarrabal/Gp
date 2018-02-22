using GestionPolicial.Domain.Factorias;
using GestionPolicial.Domain.Model.Documentos;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GespolPolicial.Test.FactoriaTests
{
    /// <summary>
    /// Descripción resumida de FactoriaPasaporteTest
    /// </summary>
    [TestClass]
    public class FactoriaPasaporteTest
    {
        [TestMethod]
        public void TestPasaporteTest()
        {
            var target = FactoriaPasaporte.GetPasaport();
            //comprobacion (el contenido actual, el que espera)
            Assert.IsInstanceOfType(target, typeof(Pasaporte));
        }
    }
}
