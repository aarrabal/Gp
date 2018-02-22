using GestionPolicial.Domain.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GespolPolicial.Test.Model
{
    /// <summary>
    /// Descripción resumida de PoliciaTest
    /// </summary>
    [TestClass]
    public class PoliciaTest
    {
        [TestMethod]
        public void TestPolicia()
        {
            var target = new Policia
            {
                NumeroPlaca = 2332
            };
        }

    }
}
