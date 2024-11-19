namespace EFMotoman.Models
{
    public class Venta
    {
        public Venta()
        {
            Factura = new Factura();
        }

        public int Id { get; set; }
        public int PreventaId { get; set; }
        public Preventa Preventa { get; set; }
        public double Total { get; set; }

        public Factura Factura { get; set; }

        public Venta(int id, int preventaId, double total)
        {
            Id = id;
            PreventaId = preventaId;
            Total = total;
        }
    }
}
