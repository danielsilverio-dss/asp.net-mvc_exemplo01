using Fiap.Exemplo01.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap.Exemplo01.MVC.Controllers
{
    public class AlunoController : Controller
    {
        // GET: Aluno
        public ActionResult Cadastro(Aluno aluno)
        {

            return View();
        }

        [HttpPost]
        public ActionResult Salvar(Aluno aluno)
        {
            ViewBag.nomeAluno = aluno.Nome;
            ViewBag.dataAluno = aluno.Data;
            ViewBag.salarioAluno = aluno.Salario;
            TempData["mensagem"] = "Aluno Registrado!";
            return View(aluno);
        }
    }
}