using GameWallet.Models;
using GameWallet.Repositorio;
using Microsoft.AspNetCore.Mvc;

namespace GameWallet.Controllers
{
    public class gwContatoController : Controller
    {
        private readonly IgwContatoRepositorio _contatoRepositorio;
        public gwContatoController(IgwContatoRepositorio contatoRepositorio)
        {
            _contatoRepositorio = contatoRepositorio;
        }

        public IActionResult Index()
        {
            List<gwContatoModel> usuarios = _contatoRepositorio.MandaBuscaLadrao();


            return View(usuarios);
        }

        public IActionResult Criar()
        {
            return View();
        }

        public IActionResult Editar()
        {
            return View();
        }

        public IActionResult ExcluirConfirmacao()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Criar(gwContatoModel usuario) 
        {
            _contatoRepositorio.Adicionar(usuario);
            return RedirectToAction("Index");
        }
    }
}
