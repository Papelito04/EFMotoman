namespace EFMotoman.Models
{
    public class Notificacion
    {
        public int Id{ get; set; }
        public string Mensaje { get; set; }
        public DateTime Fecha { get; set; }

        public int InventarioId { get; set; } // Clave foránea
        public Inventario Inventario { get; set; }

        public int UsuarioId { get; set; } // Clave foránea
        public Usuario Usuario { get; set; } // Relación uno a muchos con Usuario

        public Notificacion()
        {
        }

        public Notificacion(int id, string mensaje, DateTime fecha, int inventarioId, int usuarioId)
        {
            Id = id;
            Mensaje = mensaje;
            Fecha = fecha;
            InventarioId = inventarioId;
            UsuarioId = usuarioId;
        }
    }
}
