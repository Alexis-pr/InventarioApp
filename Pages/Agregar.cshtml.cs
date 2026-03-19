using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using InventarioApp.Models;
using InventarioApp.Services;

namespace InventarioApp.Pages;

public class AgregarModel : PageModel
{
    private readonly ProductoService _productoService;

    public AgregarModel(ProductoService productoService)
    {
        _productoService = productoService;
    }

    [BindProperty]
    public Producto Producto { get; set; } = new();

    public void OnGet() { }

    public IActionResult OnPost()
    {
        if (!ModelState.IsValid)
            return Page();

        _productoService.Agregar(Producto);
        return RedirectToPage("/Index");
    }
}