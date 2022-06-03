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
        public ActionResult Cadastrar(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Imoveis/Alterar/5
        public ActionResult Alterar(int id)
        {
            return View();
        }

        // POST: Imoveis/Alterar/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Alterar(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Imoveis/Excluir/5
        public ActionResult Excluir(int id)
        {
            return View();
        }

        // POST: Imoveis/Excluir/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Excluir(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}