using CleanArchMvc.Application.Interfaces;
using CleanArchMVC.Application.Interfaces;
using CleanArchMVC.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchMVC.WebUi.Controllers
{
    public class CategoriaController : Controller
    {
        private readonly ICategoriaServico _categoriaServico;
        public CategoriaController(ICategoriaServico categoriaService)
        {
            _categoriaServico = categoriaService;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
          return View(await _categoriaServico.GetCategoriasAsync());
        }
    }
}
