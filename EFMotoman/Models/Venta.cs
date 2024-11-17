namespace EFMotoman.Models
{
    public class Venta
    {
        public int Id { get; set; }
        public int PreventaId { get; set; }
        public Preventa Preventa { get; set; }
        public double Total { get; set; }

        public Factura Factura { get; set; }
    }
}
