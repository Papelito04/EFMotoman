namespace EFMotoman.Models
{
    public class Preventa
    {
        public Preventa()
        {
            PreVentaProductos = new HashSet<PreventaProducto>();
        }

        public int Id{ get; set; }
        public int UsuarioId { get; set; } // Clave foránea
        public Usuario Usuario { get; set; } // Relación con Usuario
        public DateTime Fecha { get; set; }
        //public ICollection<Producto> Productos { get; set; } 


        public Venta Venta { get; set; }

        public ICollection<PreventaProducto> PreVentaProductos { get; set; }

        public Preventa(int id, int usuarioId, DateTime fecha)
        {
            Id = id;
            UsuarioId = usuarioId;
            Fecha = fecha;
        }
    }
}
