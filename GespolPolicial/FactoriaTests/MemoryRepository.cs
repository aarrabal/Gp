using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using GestionPolicial.Domain.Model;

namespace GespolPolicial.Test.FactoriaTests
{
    public class MemoryRepository : IRepository<EntityBase>
    {
        private List<EntityBase> lista;
        public MemoryRepository()
        {
            lista = new List<EntityBase>();
        }
        public void Dispose()
        {
            lista.Clear();
            
        }

        public EntityBase Find(Expression<Func<EntityBase, bool>> predicate)
        {
            var result= lista.FirstOrDefault(predicate.Compile());
            return result;
        }

        public EntityBase Create(EntityBase t)
        {
            lista.Add(t);
            return t;
        }

        public int Delete(Expression<Func<EntityBase, bool>> predicate)
        {
            var result = lista.Where(predicate.Compile()).ToList();
            foreach (var item in result)
            {
                lista.Remove(item);
            }

            return result.Count();
        }

        public bool Update(EntityBase t)
        {
            var item = lista.FirstOrDefault(c => c.Id == t.Id);
            lista.Remove(item);
            lista.Add(item);
            return true;
          
        }

     
    }
}