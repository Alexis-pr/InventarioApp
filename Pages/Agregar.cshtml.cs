using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using InventarioApp.Models;
using InventarioApp.Interfaces;

namespace InventarioApp.Pages;

public class AgregarModel : PageModel
{
    private readonly IProductoService  _productoService;

    public AgregarModel(IProductoService  productoService)
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