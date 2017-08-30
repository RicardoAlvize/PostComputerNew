using ProjetoWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoWeb.Controllers
{
    public class CadastrosController : Controller
    {
        public List<Cadastro> Customers = new List<Cadastro>
        {
            new Cadastro {Id = 1,Nome = "Ricardo",Sobrenome = "Alvize",Cpf = 1111111,Telefone = 92119535},
            new Cadastro {Id = 2,Nome = "Fulano",Sobrenome = "jubis",Cpf = 2222222,Telefone = 8896572},
            new Cadastro {Id = 3,Nome = "sicrano",Sobrenome = "Jubileiu",Cpf = 2222222,Telefone = 8896572},
        };

        // GET: Cadastros
        public ActionResult Index()
        {
            return View(Customers);
        }

        public ActionResult Details(int id)
        {
            var cadastro = Customers.SingleOrDefault(c => c.Id == id);
            

            if (cadastro == null)
                return HttpNotFound();

            return View(cadastro);
        }
    }
}