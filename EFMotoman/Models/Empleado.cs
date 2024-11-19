namespace EFMotoman.Models
{
    public class Empleado : Persona
    {
        public Empleado()
        {
            Usuario = new Usuario();
        }

        public string AreaDeTrabajo { get; set; }
        public string Cargo { get; set; }
        public Usuario Usuario { get; set; }

        public Empleado(int id, string cedula, string correo, string direccion, int edad, DateTime fechaNac, string primerNombre, string segundoNombre, string primerApellido, string segundoApellido, string telefono, string areaDeTrabajo, string cargo, Usuario usuario): base(id,  cedula,  correo,  direccion,  edad,  fechaNac,  primerNombre,  segundoNombre,  primerApellido,  segundoApellido,  telefono)
        {
            AreaDeTrabajo = areaDeTrabajo;
            Cargo = cargo;
            Usuario = usuario;
        }
    }
}
