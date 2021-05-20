using Microsoft.AspNetCore.Mvc;

namespace BuffetWeb.Controllers.Cliente
{
    public class ClienteController : Controller
    {
        public IActionResult adicionarClientes()
        {
            return View();
        }
        public IActionResult editarClientes()
        {
            return View();
        }
        public IActionResult listagemClientes()
        {
            return View();
        }
        public IActionResult removerClientes()
        {
            return View();
        }
    }
}