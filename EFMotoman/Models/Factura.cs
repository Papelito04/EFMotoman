namespace EFMotoman.Models
{
    public class Factura
    {
        public int Id { get; set; }
        public int VentaId { get; set; } // Clave foránea a Venta
        public Venta Venta { get; set; } // Relación de Composición con Venta
        public DateTime Fecha { get; set; }

        public Factura(int id, int ventaId, DateTime fecha)
        {
            Id = id;
            VentaId = ventaId;
            Fecha = fecha;
        }

        public Factura()
        {
        }
    }
}
