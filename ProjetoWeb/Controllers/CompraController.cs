using ProjetoWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoWeb.Controllers
{
    public class CompraController : Controller
    {
        public List<Compra> Customers = new List<Compra>
        {
              new Compra {Id = 1, NumeroProduto = 1234},
              new Compra {Id = 2, NumeroProduto = 4321},
              new Compra {Id = 3, NumeroProduto = 1324},

        };

        // GET: Cadastros
        public ActionResult Index()
        {
            return View(Customers);
        }

        public ActionResult Details(int id)
        {
            var Compra = Customers.SingleOrDefault(c => c.Id == id);


            if (Compra == null)
                return HttpNotFound();

            return View(Compra);
        }
    }
}