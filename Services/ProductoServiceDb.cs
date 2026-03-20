using InventarioApp.Data;
using InventarioApp.Interfaces;
using InventarioApp.Models;

namespace InventarioApp.Services;

public class ProductoServiceDb : IProductoService
{
     private readonly AppDbContext _context;

       public ProductoServiceDb(AppDbContext context)
    {
        _context = context;
    }

    public List<Producto> ObtenerTodos()
        => _context.Productos.ToList();

     public void Agregar(Producto producto)
    {
        _context.Productos.Add(producto);
        _context.SaveChanges();
    }

    public void Eliminar(int id)
    {
        var producto = _context.Productos.FirstOrDefault(p => p.Id == id);
        if (producto != null)
        {
            _context.Productos.Remove(producto);
            _context.SaveChanges();
        }
    }

     public void Actualizar(Producto producto)
    {
        var existente = _context.Productos.FirstOrDefault(p => p.Id == producto.Id);
        if (existente != null)
        {
            existente.Nombre = producto.Nombre;
            existente.Precio = producto.Precio;
            existente.Cantidad = producto.Cantidad;
            _context.SaveChanges();
        }
    }

 public Producto? ObtenerPorId(int id)
        => _context.Productos.FirstOrDefault(p => p.Id == id);

    public List<Producto> Buscar(string termino)
        => _context.Productos
            .Where(p => p.Nombre.Contains(termino))
            .ToList();

    public decimal ObtenerValorInventario()
        => _context.Productos.Sum(p => p.Precio * p.Cantidad);
}








