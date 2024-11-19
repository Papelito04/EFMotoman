namespace EFMotoman.Models
{
    public class Proveedor
    {
        public int Id{ get; set; }
        public string contacto { get; set; }
        public int estado { get; set; }
        public string nombre { get; set; }


        public ICollection<Producto> Productos { get; set; }

        public Proveedor()
        {
            Productos = new HashSet<Producto>();
        }

        public Proveedor(int id, string contacto, int estado, string nombre)
        {
            Id = id;
            this.contacto = contacto;
            this.estado = estado;
            this.nombre = nombre;
        }
    }
}
