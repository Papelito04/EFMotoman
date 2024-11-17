namespace EFMotoman.Models.Dto
{
    public class ProductoDto
    {

        public int Id { get; set; }
        public string Nombre { get; set; }
        public double Costo { get; set; }
        public double PrecioVenta { get; set; }

        public int CategoriaId { get; set; } // Relación con Categoria (clave foránea)

        public int ProveedorId { get; set; } // Relación uno-a-muchos
    }
}
