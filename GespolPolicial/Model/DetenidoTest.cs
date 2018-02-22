using System;
using GestionPolicial.Domain.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GespolPolicial.Test.Model
{
    /// <summary>
    /// Descripción resumida de DetenidoTest
    /// </summary>
    [TestClass]
    public class DetenidoTest
    {
        [TestMethod]
        public void TestDetenido()
        {
            var target = new Detenido();
            target.FechaDetencion = new DateTime();
            target.MotivoDetencion = Motivo.Robo;

        }
    }
}
