namespace EFMotoman.Models.Dto
{
    public class FacturaCreateDto
    {

        public int VentaId { get; set; } // Clave foránea a Venta
        public DateTime Fecha { get; set; }
    }
}
