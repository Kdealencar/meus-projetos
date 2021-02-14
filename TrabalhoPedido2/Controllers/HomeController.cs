using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TrabalhoPedido2.Models;

namespace TrabalhoPedido2.Controllers
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

        public IActionResult Registro_Item()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Registro_Item(ItemPedido item){
           Dados.PedidoAtual.Incluir(item);
           return View("Confirme");
        }

        public IActionResult Salvar(){
            List<ItemPedido> l= Dados.PedidoAtual.Listar();
            return View(l);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
