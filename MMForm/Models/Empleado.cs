namespace EFMotoman.Models
{
    public class Empleado : Persona
    {
        public string AreaDeTrabajo { get; set; }
        public string Cargo { get; set; }
        public Usuario Usuario { get; set; }
    }
}
