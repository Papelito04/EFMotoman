namespace EFMotoman.Models
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public double Costo { get; set; }
        public double PrecioVenta { get; set; }

        public int CategoriaId { get; set; }
        public Categoria category = null;

        public Inventario Inventario { get; set; }
        public int ProveedorId { get; set; }
        public Proveedor provider = new Proveedor();

        public ICollection<PreventaProducto> PreVentaProductos { get; set; }  // Relación con la tabla intermedia

        public Producto()
        {
            PreVentaProductos = new HashSet<PreventaProducto>();
        }

        public Producto(Proveedor provider,int id, string nombre, double costo, double precioVenta, int categoriaId,  int proveedorId)
        {
            Id = id;
            Nombre = nombre;
            Costo = costo;
            PrecioVenta = precioVenta;
            CategoriaId = categoriaId;
            this.provider = provider;
            category = new Categoria(); 
        }
    }

}
