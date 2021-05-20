using Buffet.Models.Buffet.Cliente;
using BuffetWeb.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BuffetWeb.Controllers.Cliente
{
    public class ClienteController : Controller
    {
        private readonly ClienteService _clienteService;

        public ClienteController(ClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        public IActionResult adicionarClientes()
        {
            var viewModel = new adicionarClientesViewModels();
            return View(viewModel);
        }
        public IActionResult editarClientes()
        {
            var viewModel = new  editarClientesViewModels();
            return View(viewModel);
        }
        public IActionResult listagemClientes()
        {
            var viewModel = new listagemClienteViewModels();
            
            return View(viewModel);
        }
        public IActionResult removerClientes()
        {
            var viewModel = new removerClientesViewModels();
            return View(viewModel);
        }
    }
}