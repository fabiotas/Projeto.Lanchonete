using Lanchonete.Web.DAO;
using Lanchonete.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lanchonete.Web.Controllers
{
    public class ComodoController : Controller
    {
        // GET: Comodo
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Form()
        {
            ViewBag.Comodo = new Comodo();
            UsuarioDAO dao = new UsuarioDAO();
            IList<Usuario> usuarios = dao.Lista();
            ViewBag.Usuarios = usuarios;
            return View();
        }

        [HttpPost]
        public ActionResult Adiciona(Comodo comodo)
        {
            ComodoDAO dao = new ComodoDAO();
            dao.Adiciona(comodo);
            return RedirectToAction("Index");
        }
    }
}