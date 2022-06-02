using Microsoft.AspNetCore.Mvc;

namespace ImoveisWebApp.Controllers
{
    public class ImoveisController : Controller
    {
        // GET: Imoveis/Listar
        public ActionResult Listar()
        {
            return View();
        }

        // GET: Imoveis/Detalhes/5
        public ActionResult Detalhes(int id)
        {
            return View();
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

        // GET: Imoveis/Remover/5
        public ActionResult Remover(int id)
        {
            return View();
        }

        // POST: Imoveis/Remover/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Remover(int id, IFormCollection collection)
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