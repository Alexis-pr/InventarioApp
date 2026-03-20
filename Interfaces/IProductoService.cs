using InventarioApp.Models;

namespace InventarioApp.Interfaces;

public interface IProductoService
{
    List<Producto> ObtenerTodos();
    void Agregar(Producto producto);
    void Eliminar(int id);
    void Actualizar(Producto producto);
    Producto? ObtenerPorId(int id);
    List<Producto> Buscar(string termino);
    decimal ObtenerValorInventario();
}
