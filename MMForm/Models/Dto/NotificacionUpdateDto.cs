namespace EFMotoman.Models.Dto
{
    public class NotificacionUpdateDto
    {

        public int Id { get; set; }
        public string Mensaje { get; set; }
        public DateTime Fecha { get; set; }

        public int InventarioId { get; set; } // Clave foránea
        public int UsuarioId { get; set; } // Clave foránea
    }
}
