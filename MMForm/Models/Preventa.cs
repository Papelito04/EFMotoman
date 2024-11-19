namespace EFMotoman.Models
{
    public class Preventa
    {
        public int Id{ get; set; }
        public int UsuarioId { get; set; } // Clave foránea
        public Usuario Usuario { get; set; } // Relación con Usuario
        public DateTime Fecha { get; set; }
        //public ICollection<Producto> Productos { get; set; } 


        public Venta Venta { get; set; }

        public ICollection<PreventaProducto> PreVentaProductos { get; set; }

    }
}
