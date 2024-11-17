namespace EFMotoman.Models
{
    public class Producto
    {
        public int Id{ get; set; }
        public string Nombre { get; set; }
        public double Costo { get; set; }
        public double PrecioVenta { get; set; }

        public int CategoriaId { get; set; } // Relación con Categoria (clave foránea)
        public Categoria Categoria { get; set; }

        public Inventario Inventario { get; set; } // Relación de Composición con Inventario
        public int ProveedorId { get; set; } // Relación uno-a-muchos
        public Proveedor Proveedor { get; set; }
        public ICollection<PreventaProducto> PreVentaProductos { get; set; }

    }
}
