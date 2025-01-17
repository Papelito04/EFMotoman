﻿namespace EFMotoman.Models
{
    public class Usuario
    {
        public Usuario()
        {

            Preventas = new HashSet<Preventa>();
            Notificaciones = new HashSet<Notificacion>();
        }

        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int Rol { get; set; }


        // Relación uno a uno: 'Empleado' privado, accesible por el método.
        public int EmpleadoId { get; set; }
        public Empleado employed = null;


        public ICollection<Preventa> Preventas { get; set; }

        public ICollection<Notificacion> Notificaciones { get; set; }

        public Usuario(int id, string username, string password, int rol, int empleadoId)
        {
            Id = id;
            Username = username;
            Password = password;
            Rol = rol;
            employed = new Empleado();
            //a
        }
    }
}
