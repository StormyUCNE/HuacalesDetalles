using System.ComponentModel.DataAnnotations;
namespace HuacalesDetalles.Models;
public class EntradasHuacales
{
    [Key]
    public int EntradaId { get; set; }

    [Required(ErrorMessage = "Campo Obligatorio")]
    public DateTime Fecha { get; set; } = DateTime.Today;

    [Required(ErrorMessage = "Campo Obligatorio")]
    public string Nombre { get; set; } = string.Empty;
    public ICollection<DetalleHuacales> ListaHuacales { get; set; } = new List<DetalleHuacales>();
}