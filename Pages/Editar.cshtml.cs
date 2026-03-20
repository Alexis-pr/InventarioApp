using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using InventarioApp.Models;

using InventarioApp.Interfaces;
namespace InventarioApp.Pages;

public class EditarModel : PageModel
{
    private readonly IProductoService  _productoService;

    public EditarModel(IProductoService  productoService)
    {
        _productoService = productoService;
    }

    [BindProperty]
    public Producto Producto { get; set; } = new();

    public IActionResult OnGet(int id)
    {
        var producto = _productoService.ObtenerPorId(id);

        if (producto == null)
            return RedirectToPage("/Index");

        Producto = producto;
        return Page();
    }

    public IActionResult OnPost()
    {
        if (!ModelState.IsValid)
            return Page();

        _productoService.Actualizar(Producto);
        return RedirectToPage("/Index");
    }
}