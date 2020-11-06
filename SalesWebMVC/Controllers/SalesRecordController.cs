using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SalesWebMVC.Controllers
{
    public class SalesRecordController : Controller
    {

        //index da pagina de pesquisa
        public IActionResult Index()
        {
            return View();
        }

        //pesquisa simples
        public IActionResult SimpleSearch()
        {
            return View();
        }
        //pesquisa de grupo
        public IActionResult GroupingSearch()
        {
            return View();
        }
    }
}
