using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Hotsite.Models;

namespace Hotsite.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }


[HttpPost]
public IActionResult Cadastrar(Interesse cad)
{
    DatabaseService dbs = new DatabaseService();
    bool success = dbs.CadastraInteresse(cad);
    if (success)
    {
        return RedirectToAction("Index");
    }
    else
    {
        // Mostra menssagem de erro  usando JavaScript
        ViewBag.ErrorMessage = "Ocorreu um erro ao cadastrar o interesse. Por favor, tente novamente.";
    }
    return View("Index", cad);
}



    }
}
