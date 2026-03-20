using InventarioApp.Models;
using InventarioApp.Interfaces;

namespace InventarioApp.Services;


public class ProductoService : IProductoService{
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


    public void Actualizar(Producto producto)
    {
        var existente = _productos.FirstOrDefault(p=> p.Id == producto.Id);
        if(existente != null)
        {
            existente.Nombre = producto.Nombre;
            existente.Precio = producto.Precio;
            existente.Cantidad = producto.Cantidad;
        }
    }

    public Producto? ObtenerPorId( int id)
        =>_productos.FirstOrDefault(p => p.Id == id);

        
    public List<Producto> Buscar(string termino)
        =>_productos.Where(p => p.Nombre.Contains(termino, StringComparison.OrdinalIgnoreCase)).ToList();
    





}