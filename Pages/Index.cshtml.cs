using Microsoft.AspNetCore.Mvc.RazorPages;
using InventarioApp.Models;
using InventarioApp.Services;

namespace InventarioApp.Pages;

public class IndexModel : PageModel
{
    private readonly ProductoService _productoService;

    // ASP.NET inyecta el servicio automáticamente 💉
    public IndexModel(ProductoService productoService)
    {
        _productoService = productoService;
    }

    public List<Producto> Productos { get; set; } = new();
    public decimal ValorTotalInventario { get; set; }

    public void OnGet()
    {
        Productos = _productoService.ObtenerTodos();
        ValorTotalInventario = _productoService.ObtenerValorInventario();
    }
}