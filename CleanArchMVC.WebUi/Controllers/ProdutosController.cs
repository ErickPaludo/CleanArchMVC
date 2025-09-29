using CleanArchMvc.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchMVC.WebUi.Controllers
{
    public class ProdutosController : Controller
    {
        private readonly IProdutoServico _produtoServico;
        public ProdutosController(IProdutoServico produtoServico)
        {
            _produtoServico = produtoServico;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var p = await _produtoServico.GetProducts();
            return View(p);
        }
    }
}
