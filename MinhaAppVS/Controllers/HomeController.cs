using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MinhaAppVS.Models;
using MinhaAppVS.Modulos.Vendas.Data;

namespace MinhaAppVS.Controllers
{
    [Route("")]
    [Route("gestao-clientes")]
    public class HomeController : Controller
    {
        private IPedidoRepository _pedidoRepository;

        //Injeção de dependencia
        //public HomeController(IPedidoRepository pedidoRepository)
        //{
        //    _pedidoRepository = pedidoRepository;
        //}

        [Route("")]
        [Route("pagina-inicial")]
        [Route("pagina-inicial/{id:int}/{categoria:guid}")]
        public IActionResult Index(int id, Guid categoria)
        {

           

            var filme = new Filme()
            {
              Titulo = "Oi",
              DataLancamento = DateTime.Now,
              Genero = null,
              Avaliacao = 10,
              valor = 2000
        
            };

            return RedirectToAction("Privacy", filme);

            //return View();
        }

        [Route("Sobre")]
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        [Route("Contato")]
        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }


        [Route("privacidade")]
        [Route("politica-privacidade")]
        public IActionResult Privacy([FromServices] IPedidoRepository _pedidoRepository, Filme filme)
        {

            var pedido = _pedidoRepository.ObterPedido();


            // return Json("{ 'nome': 'Breno'}");

            //var fileBytes = System.IO.File.ReadAllBytes(@"C:\Site\cardapio_.txt");
            //var filename = "Ola.txt";
            //return File(fileBytes, System.Net.Mime.MediaTypeNames.Application.Octet, filename);

            if (ModelState.IsValid)
            {

            }

            foreach (var item in ModelState.Values.SelectMany(x => x.Errors))
            {
                Console.WriteLine(item.ErrorMessage);
            }

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        [Route("erro-encontrado")]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
