using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Xml.Serialization;
using GespolPolicial.Test.FactoriaTests;
using GestionPolicial.Domain.Model;

namespace GespolPolicial.Test.Repository
{
    public class FileRepository:IRepository<EntityBase>
    {
        public const string FileName = @"c:\tmp\datos.xml";
        public  void SerializeObject()
        { 
            var serializer = new XmlSerializer(typeof(List<EntityBase>));
            using (var stream = File.OpenWrite(FileName))
            {
                serializer.Serialize(stream, lista);
            }
        }

        public void Deserialize()
        {
            if (!System.IO.File.Exists(FileName))
            {
                return;
            }
            var serializer = new XmlSerializer(typeof(List<EntityBase>));
            using (var stream = File.OpenRead(FileName))
            {
                var other = (List<EntityBase>)(serializer.Deserialize(stream));
                lista.Clear();
                lista.AddRange(other);
            }
        }
      
        private List<EntityBase> lista;
        public FileRepository()
        {
            
            lista = new List<EntityBase>();
            Deserialize();
        }

        ~FileRepository()
        {
            SerializeObject();
        }
        public void Dispose()
        {
            SerializeObject();
            lista.Clear();

        }

        public EntityBase Find(Expression<Func<EntityBase, bool>> predicate)
        {
            var result = lista.FirstOrDefault(predicate.Compile());
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