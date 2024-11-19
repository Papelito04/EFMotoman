using EFMotoman.Models;
using Microsoft.EntityFrameworkCore;

namespace EFMotoman.Data
{
    public class MMContext : DbContext
    {
        public MMContext(DbContextOptions<MMContext> options) : base(options)
        {

        }

        public DbSet<Persona> Personas { get; set; }

        public DbSet<Empleado> Empleados { get; set; }

        public DbSet<Categoria> Categorias { get; set; }

        public DbSet<Factura> Facturas { get; set; }

        public DbSet<Inventario> Inventarios { get; set; }

        public DbSet<Notificacion> Notificaciones { get; set; }

        public DbSet<Preventa> Preventas { get; set; }

        public DbSet<PreventaProducto> PreventaProductos { get; set; }

        public DbSet<Producto> Productos { get; set; }

        public DbSet<Proveedor> Proveedores { get; set; }

        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Venta> Ventas { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configuración de la herencia Persona -> Empleado (TPT)
            modelBuilder.Entity<Persona>(entity =>
            {
                entity.ToTable("Personas");
                entity.HasKey(p => p.Id);
            });

            modelBuilder.Entity<Empleado>(entity =>
            {
                entity.ToTable("Empleados");

                entity.Property(e => e.AreaDeTrabajo)
                      .IsRequired()
                      .HasMaxLength(100);

                entity.Property(e => e.Cargo)
                      .IsRequired()
                      .HasMaxLength(100);

                entity.HasOne(e => e.Usuario)
                      .WithOne(u => u.Empleado)
                      .HasForeignKey<Usuario>(u => u.EmpleadoId)
                      .OnDelete(DeleteBehavior.Cascade);
            });

            // Configuración de PreventaProducto con ID independiente
            modelBuilder.Entity<PreventaProducto>(entity =>
            {
                entity.ToTable("PreventaProductos");

                // ID auto-incrementable para la entidad
                entity.HasKey(pp => pp.Id); // Establecer el Id como la clave primaria

                // Definir las relaciones entre Preventa y Producto
                entity.HasOne(pp => pp.PreVenta)
                      .WithMany(p => p.PreVentaProductos)
                      .HasForeignKey(pp => pp.PreventaId)
                      .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(pp => pp.Producto)
                      .WithMany(p => p.PreVentaProductos)
                      .HasForeignKey(pp => pp.ProductoId)
                      .OnDelete(DeleteBehavior.Cascade);
            });

            // Configuración de las demás relaciones
            modelBuilder.Entity<Producto>()
                .HasOne(p => p.Categoria)
                .WithMany(c => c.Productos)
                .HasForeignKey(p => p.CategoriaId);

            modelBuilder.Entity<Producto>()
                .HasOne(p => p.Inventario)
                .WithOne(i => i.Producto)
                .HasForeignKey<Inventario>(i => i.ProductoId);

            modelBuilder.Entity<Producto>()
                .HasOne(p => p.Proveedor)
                .WithMany(pr => pr.Productos)
                .HasForeignKey(p => p.ProveedorId);

            modelBuilder.Entity<Preventa>()
                .HasOne(p => p.Usuario)
                .WithMany(u => u.Preventas)
                .HasForeignKey(p => p.UsuarioId);

            modelBuilder.Entity<Factura>()
                .HasOne(f => f.Venta)
                .WithOne(v => v.Factura)
                .HasForeignKey<Factura>(f => f.VentaId);

            modelBuilder.Entity<Venta>()
                .HasOne(v => v.Preventa)
                .WithOne(p => p.Venta)
                .HasForeignKey<Venta>(v => v.PreventaId);

            modelBuilder.Entity<Inventario>()
                .HasOne(i => i.Producto)
                .WithOne(p => p.Inventario)
                .HasForeignKey<Inventario>(i => i.ProductoId);

            modelBuilder.Entity<Notificacion>()
                .HasOne(n => n.Inventario)
                .WithMany(i => i.Notificaciones)
                .HasForeignKey(n => n.InventarioId);

            modelBuilder.Entity<Notificacion>()
                .HasOne(n => n.Usuario)
                .WithMany(u => u.Notificaciones)
                .HasForeignKey(n => n.UsuarioId);

            base.OnModelCreating(modelBuilder);
        }








    }
}
