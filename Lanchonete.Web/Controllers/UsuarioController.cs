using Lanchonete.Web.DAO;
using Lanchonete.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lanchonete.Web.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario
        public ActionResult Index()
        {
            UsuarioDAO dao = new UsuarioDAO();
            IList<Usuario> usuarios = dao.Lista();
            ViewBag.Usuarios = usuarios;
            return View();
        }

        public ActionResult Form()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Adiciona(Usuario usuario)
        {
            UsuarioDAO dao = new UsuarioDAO();
            dao.Adiciona(usuario);
            return RedirectToAction("Index");
        }
    }
}