using System;
using System.Linq.Expressions;
using GestionPolicial.Domain.Model;

namespace GespolPolicial.Test
{
    public class ClaseMetodos
    {
        public void metodo1()
        {

        }

        public int metodo2(string s)
        {
            return 0;
        }

        public void metodo3(string s, int i)
        {
            //throw new NotImplementedException();
        }

        public void metodo4(string s, int i, bool b =true)
        {
            // throw new NotImplementedException();
        }

        public void metodoAction(Action<string> nombre)
        {
            
        }

        public void metodoAction2(Action<Datos> datos)
        {
            datos.Invoke(new Datos());
        }

        public void metodoFunction(Func<int,int> funcion)
        {
            var result = funcion.Invoke(0);
        }

        public void metodoExpression(Expression<Func<EntityBase, bool>> predicate)
        {
            var result = predicate.Compile();
        }
    }
}