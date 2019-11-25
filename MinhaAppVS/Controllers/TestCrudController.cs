using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MinhaAppVS.Modulos.Vendas.Data;
using MinhaAppVS.Modulos.Vendas.Models;

namespace MinhaAppVS.Controllers
{
    public class TestCrudController : Controller
    {
        private readonly MeuDbContext _contexto;


        public TestCrudController(MeuDbContext contexto)
        {
            _contexto = contexto;
        }

        public IActionResult Index()
        {
            var aluno = new Aluno()
            {
                Nome = "Breno",
                DataNascimento = DateTime.Now,
                Email = "Brenodotnet@gmail.com"
            };

            _contexto.Alunos.Add(aluno);
            _contexto.SaveChanges();


            var aluno2 = _contexto.Alunos.Find(aluno.Id);

            var aluno3 = _contexto.Alunos.FirstOrDefault(a => a.Email == "Brenodotnet@gmail.com");

            var aluno4 = _contexto.Alunos.Where(x => x.Nome == "Breno");

            aluno.Nome = "João";

            _contexto.Alunos.Update(aluno);
            _contexto.SaveChanges();


            _contexto.Alunos.Remove(aluno);
            _contexto.SaveChanges();

            return View("_Layout");
        }
    }
}