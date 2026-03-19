using InventarioApp.Models;
namespace InventarioApp.Services;


public class ProductoService
{
    private List<Producto> _productos = new();
    private int _nextId = 1;

    // Retorna todos los productos
    public List<Producto> ObtenerTodos() => _productos;

    // Agrega un nuevo producto
    public void Agregar(Producto producto)
    {
        producto.Id = _nextId++;
        _productos.Add(producto);
    }

    // Elimina un producto por su Id
    public void Eliminar(int id)
    {
        var producto = _productos.FirstOrDefault(p => p.Id == id);
        if (producto != null)
            _productos.Remove(producto);
    }

    // Calcula el valor total de todo el inventario
    public decimal ObtenerValorInventario()
        => _productos.Sum(p => p.ValorTotal);

}