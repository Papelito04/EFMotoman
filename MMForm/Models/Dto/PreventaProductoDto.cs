namespace EFMotoman.Models.Dto
{
    public class PreventaProductoDto
    {

        public int Id { get; set; }
        public int PreventaId { get; set; }

        public int ProductoId { get; set; }

        public int Cantidad { get; set; }
    }
}
