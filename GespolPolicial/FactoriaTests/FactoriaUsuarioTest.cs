using GestionPolicial.Domain.Factorias;
using GestionPolicial.Domain.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GespolPolicial.Test.FactoriaTests
{
    /// <summary>
    /// Descripción resumida de FactoriaUsuarioTest
    /// </summary>
    [TestClass]
    public class FactoriaUsuarioTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var target = FactoriaUsuario.GetUsuario();
            Assert.IsInstanceOfType(target,typeof(Usuario));
        }
    }
}
