namespace EFMotoman.Models.Dto
{
    public class PreventaCreateDto
    {
        public int UsuarioId { get; set; } // Clave foránea
        public Usuario Usuario { get; set; } // Relación con Usuario
        public DateTime Fecha { get; set; }
    }
}
