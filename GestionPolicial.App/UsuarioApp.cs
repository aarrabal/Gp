using System;
using System.Linq.Expressions;
using GestionPolicial.Dal.Repository;
using GestionPolicial.Domain.Model;

namespace GestionPolicial.Application
{
    public class UsuarioApp
    {
        private UsuarioRepository UsuarioRep { get; set; }

        public UsuarioApp()
        {
            UsuarioRep = new UsuarioRepository();
        }
        public Usuario Find(Expression<Func<Usuario, bool>> predicate)
        {
            return UsuarioRep.Find(predicate);
        }

        public Usuario Create(Usuario t)
        {
            return UsuarioRep.Create(t);
        }


        public int Delete(Expression<Func<Usuario, bool>> predicate)
        {
            return UsuarioRep.Delete(predicate);
        }

        public bool Update(Usuario t, int id)
        {
            
            return UsuarioRep.Update(t,id);
        }

        public bool Login(Usuario usuario)
        {
            return UsuarioRep.Login(usuario);
        }
    }

}

