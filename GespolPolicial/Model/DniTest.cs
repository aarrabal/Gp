using GestionPolicial.Domain.Model.Documentos;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GespolPolicial.Test.Model
{
    /// <summary>
    /// Descripción resumida de DNITest
    /// </summary>
    [TestClass]
    public class DniTest
    {
  

        [TestMethod]
        [ExpectedException(typeof(ExceptionDni))]
        public void TestDnIKo()
        {
         var target = new Dni();
            target.NumeroDocumento = "4545786G";

        }
        [TestMethod]
        public void TestDniGetLetra()
        {
            var target = new Dni();
        target.NumeroDocumento = "33333333";
            var result = target.NumeroDocumento;

        Assert.AreEqual("33333333N",result);
            
        }

        [TestMethod]
        public void TestDniLetraCorrecta()
        {
            var target = new Dni();

           target.NumeroDocumento = "33333333N";
            var result = target.NumeroDocumento;
           Assert.AreEqual("33333333N", result);

        }
        [TestMethod]
        [ExpectedException(typeof(ExceptionDniLetraIncorrecta))]
        public void TestDniLetraIncorrecta()
        {
            var target = new Dni();
            var result = target.NumeroDocumento = "33333333Z";
           

        }
    }
}
