using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GespolPolicial.Test
{
    /// <summary>
    /// Descripción resumida de MethodTest
    /// </summary>
    [TestClass]
    public class MethodTest
    {
    
        [TestMethod]
        public void TestMethod1()
        {
            var target = new ClaseMetodos();
            target.metodo1();
          int result = target.metodo2("2");
            target.metodo3("2",4);
            target.metodo4("2",4,true);
            target.metodoAction(s => {});
            target.metodoAction(delegate(string s) { });
            target.metodoAction2(s =>
            {
                var q = s;


            });
            target.metodoFunction(i => { return i+1;});
            
            
        }
       
    }
}
