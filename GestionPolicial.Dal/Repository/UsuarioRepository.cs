using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using GestionPolicial.Dal.EF;
using GestionPolicial.Domain.Model;

namespace GestionPolicial.Dal.Repository
{
    public class UsuarioRepository : IUsuarioRepository<Usuario>
    {
       private GpContext Context { get; set; }

        public UsuarioRepository()
        {
            Context = new GpContext();
        }

        public Usuario Find(Expression<Func<Usuario, bool>> predicate)
        {
         return  Context.Usuarios.FirstOrDefault(predicate);
          
          
        }

        public Usuario Create(Usuario t)
        {
          var result = Context.Usuarios.Add(t);
            commit();
            return result;

        }
    

    public int Delete(Expression<Func<Usuario, bool>> predicate)
    {
        var result =  Context.Usuarios.Remove(Find(predicate)).Id;
        commit();
        return result;
    }

        public bool Update(Usuario t, int id)
        {
           var persona= Find(p => p.Id == id);
            if (persona == null) return false;
            persona.NombreUsuario = t.NombreUsuario;
            persona.Password = t.Password;
            commit();
            
            return true;

        }

        public void commit()
        {
            Context.SaveChanges();
        }

        public bool Login(Usuario usuario)
        {
            var result = Find(p => p.NombreUsuario == usuario.NombreUsuario && p.Password == usuario.Password);
            if (result != null) return true;
            else return false;
        }
    }
}
