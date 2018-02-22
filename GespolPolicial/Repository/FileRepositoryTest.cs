using GestionPolicial.Domain.Factorias;
using GestionPolicial.Domain.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GespolPolicial.Test.Repository
{
    /// <summary>
    /// Descripción resumida de FileRepositoryTest
    /// </summary>
    [TestClass]
    public class FileRepositoryTest
    {
        ~FileRepositoryTest()
        {

        }
    
        [TestMethod]
        public void RepositoryFileTest()
        {
            var target = new FileRepository();
            var policia1 = Factoria<Policia>.Get();
            policia1.Id = 4;
            target.Create(policia1);
 
        }
    }
}
