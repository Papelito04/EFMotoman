namespace EFMotoman.Models
{
    public class Inventario
    {
        public Inventario()
        {
            Notificaciones = new HashSet<Notificacion>();
        }

        public int Id { get; set; }
        public int Cantidad { get; set; }
        public int ProductoId { get; set; }
        public Producto Producto { get; set; }
        public int UmbralBajaExistencia { get; set; }

        public ICollection<Notificacion> Notificaciones { get; set; }

        public Inventario(int id, int cantidad, int productoId, int umbralBajaExistencia)
        {
            Id = id;
            Cantidad = cantidad;
            ProductoId = productoId;
            UmbralBajaExistencia = umbralBajaExistencia;
        }


    }

}
