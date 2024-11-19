namespace EFMotoman.Models.Dto
{
    public class UsuarioUpdateDto
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int Rol { get; set; }


        // Relación uno a uno: 'Empleado' privado, accesible por el método.
        public int EmpleadoId { get; set; } // Clave foránea
    }
}
