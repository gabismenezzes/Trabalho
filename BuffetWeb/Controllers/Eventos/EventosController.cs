using Microsoft.AspNetCore.Mvc;

namespace BuffetWeb.Controllers.Eventos
{
    public class EventosController: Controller
    {
        public IActionResult adicionarEventos()
        {
            return View();
        }
        public IActionResult editarEventos()
        {
            return View();
        }
        public IActionResult eventoRemover()
        {
            return View();
        }
        public IActionResult listagemEventos()
        {
            return View();
        }
    }
}