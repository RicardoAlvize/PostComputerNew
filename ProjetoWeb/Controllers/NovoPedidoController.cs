using ProjetoWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoWeb.Controllers
{
    public class NovoPedidoController : Controller
    {
        public List<NovoPedido> Customers = new List<NovoPedido>
        {
            new NovoPedido {Id = 1, Produto = "Produto - 1" },
            new NovoPedido {Id = 2, Produto = "Produto - 2" },
            new NovoPedido {Id = 3, Produto = "Produto - 3" },
            new NovoPedido {Id = 4, Produto = "Produto - 4" },
        };

        // GET: Cadastros
        public ActionResult Index()
        {
            return View(Customers);
        }

        public ActionResult Details(int id)
        {
            var NovoPedido = Customers.SingleOrDefault(c => c.Id == id);


            if (NovoPedido == null)
                return HttpNotFound();

            return View(NovoPedido);
        }
    }
}