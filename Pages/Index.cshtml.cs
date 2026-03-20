using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using InventarioApp.Models;

using InventarioApp.Interfaces;
namespace InventarioApp.Pages;

public class IndexModel : PageModel
{
    private readonly IProductoService _productoService;

    public IndexModel(IProductoService  productoService)
    {
        _productoService = productoService;
    }

    public List<Producto> Productos { get; set; } = new();
    public decimal ValorTotalInventario { get; set; }

    [BindProperty(SupportsGet = true)]
    public string? Busqueda { get; set; }

    public void OnGet()
    {
        Productos = string.IsNullOrEmpty(Busqueda)
            ? _productoService.ObtenerTodos()
            : _productoService.Buscar(Busqueda);

        ValorTotalInventario = _productoService.ObtenerValorInventario();
    }
}


