using PostGetModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PostGetModel.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var pessoa = new Pessoa { PessoaID = 1, Nome = "Michaell Gasparini", Twitter = "@michaellrg" };

            //ViewData["key"] or ViewBag.Key
            /* ViewBag.PessoaID = pessoa.PessoaID;
             ViewBag.Nome = pessoa.Nome;
             ViewBag.Twitter = pessoa.Twitter;*/
            return View(pessoa);
        }

        [HttpPost]
        public ActionResult Lista(Pessoa pessoa)
        {

            
            return View(pessoa);
        }
    }
}