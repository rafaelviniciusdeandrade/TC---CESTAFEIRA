using Microsoft.AspNetCore.Mvc;
using CestaFeira.Web.Services.Interfaces;
using System.Threading.Tasks;

namespace CestaFeira.Web.Controllers
{
    public class LojaController : Controller
    {
        private readonly ILojaService _lojaService;

        // Construtor que injeta o serviço de loja
        public LojaController(ILojaService lojaService)
        {
            _lojaService = lojaService;
        }

        // Exibe todas as lojas cadastradas
        public async Task<IActionResult> Index()
        {
            var lojas = await _lojaService.ConsultarLojas();
            return View(lojas);
        }

        // (Opcional) Exibe detalhes de uma loja específica
        public async Task<IActionResult> Detalhes(Guid id)
        {
            var loja = await _lojaService.ConsultarLojaPorId(id);
            if (loja == null)
            {
                return NotFound();
            }
            return View(loja);
        }
    }
}
