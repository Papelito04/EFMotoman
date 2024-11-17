using AutoMapper;
using EFMotoman.Models;
using EFMotoman.Models.Dto;

namespace EFMotoman
{
    public class MappingConfig : Profile
    {
        public MappingConfig()
        {
            CreateMap<Categoria, CategoriaDto>().ReverseMap();
            CreateMap<Categoria, CategoriaCreateDto>().ReverseMap();
            CreateMap<Categoria, CategoriaUpdateDto>().ReverseMap();

            CreateMap<Empleado, EmpleadoDto>().ReverseMap();
            CreateMap<Empleado, EmpleadoCreateDto>().ReverseMap();
            CreateMap<Empleado, EmpleadoUpdateDto>().ReverseMap();

            CreateMap<Factura, FacturaDto>().ReverseMap();
            CreateMap<Factura, FacturaCreateDto>().ReverseMap();
            CreateMap<Factura, FacturaUpdateDto>().ReverseMap();

            CreateMap<Inventario, InventarioDto>().ReverseMap();
            CreateMap<Inventario, InventarioCreateDto>().ReverseMap();
            CreateMap<Inventario, InventarioUpdateDto>().ReverseMap();

            CreateMap<Notificacion, NotificacionDto>().ReverseMap();
            CreateMap<Notificacion, NotificacionCreateDto>().ReverseMap();
            CreateMap<Notificacion, NotificacionUpdateDto>().ReverseMap();

            CreateMap<Persona, PersonaDto>().ReverseMap();
            CreateMap<Persona, PersonaCreateDto>().ReverseMap();
            CreateMap<Persona, PersonaUpdateDto>().ReverseMap();

            CreateMap<PreventaProducto, PreventaProductoDto>().ReverseMap();
            CreateMap<PreventaProducto, PreventaProductoCreateDto>().ReverseMap();
            CreateMap<PreventaProducto, PreventaProductoUpdateDto>().ReverseMap();

            CreateMap<Preventa, PreventaDto>().ReverseMap();
            CreateMap<Preventa, PreventaCreateDto>().ReverseMap();
            CreateMap<Preventa, PreventaUpdateDto>().ReverseMap();

            CreateMap<Producto, ProductoDto>().ReverseMap();
            CreateMap<Producto, ProductoCreateDto>().ReverseMap();
            CreateMap<Producto, ProductoUpateDto>().ReverseMap();

            CreateMap<Proveedor, ProveedorDto>().ReverseMap();
            CreateMap<Proveedor, ProveedorCreateDto>().ReverseMap();
            CreateMap<Proveedor, ProveedorUpdateDto>().ReverseMap();

            CreateMap<Usuario, UsuarioDto>().ReverseMap();
            CreateMap<Usuario, UsuarioCreateDto>().ReverseMap();
            CreateMap<Usuario, UsuarioUpdateDto>().ReverseMap();

            CreateMap<Venta, VentaDto>().ReverseMap();
            CreateMap<Venta, VentaCreateDto>().ReverseMap();
            CreateMap<Venta, VentasUpdateDto>().ReverseMap();

        }
    }
}
