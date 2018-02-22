using GespolPolicial.Test.FactoriaTests;
using GestionPolicial.Domain.Factorias;
using GestionPolicial.Domain.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GespolPolicial.Test.Repository
{
    /// <summary>
    /// Descripción resumida de DeleteTest
    /// </summary>
    [TestClass]
    public class RepositoryTest
    {
        
        [TestMethod]
        public void TestDelete()
        {
            var target = new MemoryRepository();
            var persona = Factoria<Persona>.Get();
            persona.Id = 1;
            target.Create(persona);
            var policia = Factoria<Policia>.Get();
            policia.Id = 2;

            target.Create(policia);
            target.Delete(c=>c.Id==2);
        }

        [TestMethod]
        public void TestFind()
        {
            var target = new MemoryRepository();
            var persona = Factoria<Persona>.Get();
            persona.Id = 1;
            target.Create(persona);
            var policia = Factoria<Policia>.Get();
            policia.Id = 2;
            target.Create(policia);
            var result = target.Find(c => c.Id == 2);
            Assert.AreEqual(2,result.Id);

            
        }
        [TestMethod]
        public void TestUpdate()
        {
            var target = new MemoryRepository();
            var persona = Factoria<Persona>.Get();
            persona.Id = 1;
            target.Create(persona);
            var policia = Factoria<Policia>.Get();
            policia.Id = 2;
            target.Create(policia);
            policia.NumeroPlaca = 1234;

            var result = target.Update(policia);
    

        }
    }

    
}
