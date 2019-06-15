using Lanchonete.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lanchonete.Web.DAO
{
    public class ComodoDAO
    {
        public void Adiciona(Comodo comodos)
        {
            using (var context = new BaseContext())
            {
                context.Comodos.Add(comodos);
                context.SaveChanges();
            }
        }


        public IList<Comodo> Lista()
        {
            using (var contexto = new BaseContext())
            {
                return contexto.Comodos.ToList();
            }
        }
    }
}