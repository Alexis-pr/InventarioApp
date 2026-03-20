using System.ComponentModel.DataAnnotations;

namespace InventarioApp.Models;

public class Producto
{
    public int Id { get; set; }

    [Required(ErrorMessage = "El nombre es obligatorio")]
    [StringLength(100, ErrorMessage = "Máximo 100 caracteres")]
    public string Nombre { get; set; } = string.Empty;

    [Required(ErrorMessage = "El precio es obligatorio")]
    [Range(0.01, double.MaxValue, ErrorMessage = "El precio debe ser mayor a 0")]
    public decimal Precio { get; set; }

    [Required(ErrorMessage = "La cantidad es obligatoria")]
/*     [Range(0, int.MaxValue, ErrorMessage = "La cantidad no puede ser negativa")] */
    [Range(1,int.MaxValue,ErrorMessage ="La cantidad debe de ser mayor a 1")]
    public int Cantidad { get; set; }

    public decimal ValorTotal => Precio * Cantidad;
}