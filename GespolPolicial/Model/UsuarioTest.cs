using GestionPolicial.Domain.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GespolPolicial.Test.Model
{
    /// <summary>
    /// Descripción resumida de UnitTest1
    /// </summary>
    [TestClass]
    public class UsuarioTest
    {
        [TestMethod]
        public void TestUsuarioTest()
        {
            var target = new Usuario();
            target.NombreUsuario = "Alex";
            target.Password = "wewefw";
        }
    }
}
