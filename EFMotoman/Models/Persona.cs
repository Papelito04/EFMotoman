namespace EFMotoman.Models
{
    public class Persona
    {
        public Persona()
        {
        }

        public int Id { get; set; }
        public string Cedula { get; set; }
        public string Correo { get; set; }
        public string Direccion { get; set; }
        public int Edad { get; set; }
        public DateTime FechaNac { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public string Telefono { get; set; }



        public Persona(int id, string cedula, string correo, string direccion, int edad, DateTime fechaNac, string primerNombre, string segundoNombre, string primerApellido, string segundoApellido, string telefono)
        {
            Id = id;
            Cedula = cedula;
            Correo = correo;
            Direccion = direccion;
            Edad = edad;
            FechaNac = fechaNac;
            PrimerNombre = primerNombre;
            SegundoNombre = segundoNombre;
            PrimerApellido = primerApellido;
            SegundoApellido = segundoApellido;
            Telefono = telefono;
        }
    }
}
