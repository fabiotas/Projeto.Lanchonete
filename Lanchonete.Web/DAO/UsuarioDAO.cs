using Lanchonete.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lanchonete.Web.DAO
{
    public class UsuarioDAO
    {

        public void Adiciona(Usuario usuario)
        {
            using (var context = new BaseContext())
            {
                context.Usuarios.Add(usuario);
                context.SaveChanges();
            }
        }


        public IList<Usuario> Lista()
        {
            using (var contexto = new BaseContext())
            {
                return contexto.Usuarios.ToList();
            }
        }
    }
}