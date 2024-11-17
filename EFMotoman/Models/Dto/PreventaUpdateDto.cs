namespace EFMotoman.Models.Dto
{
    public class PreventaUpdateDto
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; } // Clave foránea
        public DateTime Fecha { get; set; }
    }
}
