namespace EFMotoman.Models.Dto
{
    public class InventarioCreateDto
    {

        public int Cantidad { get; set; }
        public int ProductoId { get; set; }
        public int UmbralBajaExistencia { get; set; }
    }
}
