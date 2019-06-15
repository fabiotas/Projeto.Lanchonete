using Lanchonete.Web.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Lanchonete.Web.DAO
{
    public class BaseContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Comodo> Comodos { get; set; }



    }
}