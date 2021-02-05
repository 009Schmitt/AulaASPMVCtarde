using AulaAspNETMVCTarde.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace AulaAspNETMVCTarde.Controllers
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
            var funcionario = new Funcionario
            {
                IdFuncionario = 1,
                Nome = "Seu Quincas",
                Cpf = "792.485.744-96",
                Funcao = "Dono de buteco"
            };

            //ViewData["IdFuncionario"] = funcionario.IdFuncionario;
            //ViewData["Nome"] = funcionario.Nome;
            //ViewData["Cpf"] = funcionario.Cpf;
            //ViewData["Funcao"] = funcionario.Funcao;

            ViewBag.IdFuncionario = funcionario.IdFuncionario;
            ViewBag.Nome = funcionario.Nome;
            ViewBag.Cpf = funcionario.Cpf;
            ViewBag.Funcao = funcionario.Funcao;

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastro(int id,string nome,string cpf,string funcao)
        {
            ViewBag.IdFuncionario = id;
            ViewBag.Nome = nome;
            ViewBag.Cpf = cpf;
            ViewBag.Funcao = funcao;
            
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
