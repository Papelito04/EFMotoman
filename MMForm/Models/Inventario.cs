﻿namespace EFMotoman.Models
{
    public class Inventario
    {
        public int Id { get; set; }
        public int Cantidad { get; set; }
        public int ProductoId { get; set; }
        public Producto Producto { get; set; }
        public int UmbralBajaExistencia { get; set; }

        public ICollection<Notificacion> Notificaciones { get; set; }

    }

}
