using CadastroAlunos.Models;
using Microsoft.AspNetCore.Mvc;

namespace CadastroAlunos.Controllers
{
    public class AlunoController : Controller
    {
        // GET: /Aluno/Cadastrar
        // Retorna o formulário vazio
        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        // POST: /Aluno/Cadastrar
        // Recebe os dados do formulário e valida com ModelState
        [HttpPost]
        public IActionResult Cadastrar(Aluno aluno)
        {
            if (ModelState.IsValid)
            {
                // Dados válidos -> redireciona para a página de confirmação
                return View("Confirmacao", aluno);
            }

            // Se chegou aqui, algum campo está inválido
            // Retorna o formulário mostrando os erros
            return View(aluno);
        }
    }
}
