using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using InventarioApp.Services;

namespace InventarioApp.Pages;

public class EliminarModel : PageModel
{
    private readonly ProductoService _productoService;

    public EliminarModel(ProductoService productoService)
    {
        _productoService = productoService;
    }

    public IActionResult OnGet(int id)
    {
        _productoService.Eliminar(id);
        return RedirectToPage("/Index");
    }
}