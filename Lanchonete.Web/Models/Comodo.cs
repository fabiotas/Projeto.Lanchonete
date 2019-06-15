using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Lanchonete.Web.Models
{
    public class Comodo
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int qtdeComponente { get; set; }
        public int IndAtivo { get; set; }

        [ForeignKey("Usuario")]
        public int IdUsuario { get; set; }

        public virtual Usuario Usuario { get; set; }

    }
}