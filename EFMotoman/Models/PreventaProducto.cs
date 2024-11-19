using System.ComponentModel.DataAnnotations.Schema;

namespace EFMotoman.Models
{
    public class PreventaProducto
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int PreventaId { get; set; }
        public Preventa PreVenta { get; set; }

        public int ProductoId { get; set; }
        public Producto Producto { get; set; }

        public int Cantidad { get; set; }

        public PreventaProducto()
        {
        }

        public PreventaProducto(int id, int preventaId, int productoId, int cantidad)
        {
            Id = id;
            PreventaId = preventaId;
            ProductoId = productoId;
            Cantidad = cantidad;
        }
    }

}
