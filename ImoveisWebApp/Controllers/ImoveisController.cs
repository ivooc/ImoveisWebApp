using ImoveisWebApp.Application.Interfaces;
using ImoveisWebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace ImoveisWebApp.Controllers
{
    public class ImoveisController : Controller
    {
        private readonly IMockImoveisApi _mockImoveisApi;

        public ImoveisController(IMockImoveisApi mockImoveisApi)
        {
            _mockImoveisApi = mockImoveisApi;
        }

        // GET: Imoveis/Listar
        public async Task<ActionResult> Listar()
        {
            var imoveis = await _mockImoveisApi.ObterTodosOsImoveisAsync();
            return View(imoveis);
        }

        // GET: Imoveis/Detalhes/5
        public async Task<ActionResult> Detalhes(int id)
        {
            var imovel = await _mockImoveisApi.ObterImovelPorIdAsync(id);
            return View(imovel);
        }

        // GET: Imoveis/Cadastrar
        public ActionResult Cadastrar()
        {
            return View();
        }

        // POST: Imoveis/Cadastrar
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Cadastrar(Imovel imovel)
        {
            try
            {
                await _mockImoveisApi.CadastrarImovelAsync(imovel);
                return RedirectToAction(nameof(Listar));
            }
            catch
            {
                return View();
            }
        }

        // GET: Imoveis/Alterar/5
        public async Task<ActionResult> Alterar(int id)
        {
            return await Detalhes(id);
        }

        // POST: Imoveis/Alterar/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Alterar(int id, Imovel imovel)
        {
            try
            {
                await _mockImoveisApi.AlterarImovelPorIdAsync(id, imovel);
                return RedirectToAction(nameof(Listar));
            }
            catch
            {
                return View();
            }
        }

        // GET: Imoveis/Excluir/5
        public async Task<ActionResult> Excluir(int id)
        {
            return await Detalhes(id);
        }

        // POST: Imoveis/Excluir/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Excluir(int id, IFormCollection collection)
        {
            try
            {
                await _mockImoveisApi.RemoverImovelPorIdAsync(id);
                return RedirectToAction(nameof(Listar));
            }
            catch
            {
                return View();
            }
        }
    }
}