﻿namespace EFMotoman.Models.Dto
{
    public class InventarioUpdateDto
    {

        public int Id { get; set; }
        public int Cantidad { get; set; }
        public int ProductoId { get; set; }
        public int UmbralBajaExistencia { get; set; }
    }
}