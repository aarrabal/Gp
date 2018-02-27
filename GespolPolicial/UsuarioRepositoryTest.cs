using System;
using System.Text;
using System.Collections.Generic;
using GestionPolicial.Application;
using GestionPolicial.Domain.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GespolPolicial.Test
{
    /// <summary>
    /// Descripción resumida de PersonaRepositoryTeast
    /// </summary>
    [TestClass]
    public class UsuarioRepositoryTest
    {
        [TestMethod]
        public void TestCreate()
        {
            var target = new Usuario{NombreUsuario = "Paco", Password = "admin"};
            var app = new UsuarioApp();
            var result =  app.Create(target);
            Assert.AreEqual(target, result);
        }

        [TestMethod]
        public void TestDelete()
        {
            var target = new Usuario {NombreUsuario = "Arrabal", Password = "admin1"};
            var app = new UsuarioApp();
            var created= app.Create(target);
            var result = app.Delete(p => p.Id == created.Id);
            Assert.AreEqual(result,1);
        }
        [TestMethod]
        public void TestFind()
        {
            var target = new Usuario { NombreUsuario = "Antonio", Password = "admin1" };
            var app = new UsuarioApp();
            var created = app.Create(target);
            var result = app.Find(p => p.Id == created.Id);
            Assert.AreEqual(result, created);
        }
        [TestMethod]
        public void TestUpdate()
        {
            var target = new Usuario { NombreUsuario = "Pepe", Password = "1234" };
            var app = new UsuarioApp();
            var created = app.Create(target);
            var result = app.Update(new Usuario {NombreUsuario = "Vegita", Password = "admin"}, created.Id);
            Assert.IsTrue(result);
        }
    }
}
