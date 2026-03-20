using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using InventarioApp.Interfaces;
namespace InventarioApp.Pages;

public class EliminarModel : PageModel
{
    private readonly IProductoService  _productoService;

    public EliminarModel(IProductoService  productoService)
    {
        _productoService = productoService;
    }

    public IActionResult OnGet(int id)
    {
        _productoService.Eliminar(id);
        return RedirectToPage("/Index");
    }
}