using GestionPolicial.Domain.Model.Documentos;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GespolPolicial.Test.Model
{
    /// <summary>
    /// Descripción resumida de TestPasaporte
    /// </summary>
    [TestClass]
    public class PasaporteTest
    {
  
        #region Atributos de prueba adicionales
        //
        // Puede usar los siguientes atributos adicionales conforme escribe las pruebas:
        //
        // Use ClassInitialize para ejecutar el código antes de ejecutar la primera prueba en la clase
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup para ejecutar el código una vez ejecutadas todas las pruebas en una clase
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Usar TestInitialize para ejecutar el código antes de ejecutar cada prueba 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup para ejecutar el código una vez ejecutadas todas las pruebas
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void TestMethod1()
        {
            var target = new Pasaporte
            {
                Pais = "Etiopia"
            };
        }
    }
}
