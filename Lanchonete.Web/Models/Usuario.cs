using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lanchonete.Web.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        //Apenas teste
        public string Email { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }

        public ICollection<Comodo> comodos { get; set; }

    }
}