namespace EFMotoman.Models.Dto
{
    public class FacturaDto
    {
        public int Id { get; set; }
        public int VentaId { get; set; } // Clave foránea a Venta
        public DateTime Fecha { get; set; }
    }
}
