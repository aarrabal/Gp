using GestionPolicial.Domain.Model.Documentos;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GespolPolicial.Test.Model
{
    /// <summary>
    /// Descripción resumida de NieTest
    /// </summary>
    [TestClass]
    public class NieTest
    {

        [TestMethod]
        public void TestNie()
        {
            var target = new Nie {Pais = "Nigeria"};

        }
        [TestMethod]
        [ExpectedException(typeof(NieException))]
        public void TestErrorLongitud()
        {
            var target = new Nie();
            target.NumeroDocumento = "22222223453534";
            var result = target.NumeroDocumento;

       

        }
        [TestMethod]
        [ExpectedException(typeof(ExceptionNieLetraIncorrecta))]
        public void TestErrorLetra()
        {
            var target = new Nie();
            target.NumeroDocumento = "X0223150J";
            var result = target.NumeroDocumento;



        }
        [TestMethod]
        public void TestGenerarLetraNie()
        {
            var target = new Nie();
            target.NumeroDocumento = "X0223150";
            var result = target.NumeroDocumento;
            Assert.AreEqual("X0223150G", result);

        }
        [TestMethod]
        public void TestComprobarLetraNie()
        {
            var target = new Nie();
            target.NumeroDocumento = "X0223150G";
            var result = target.NumeroDocumento;
            Assert.AreEqual("X0223150G", result);

        }

    }
}
    

