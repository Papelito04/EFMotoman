
using EFMotoman.Data;
using Microsoft.EntityFrameworkCore;
using EFMotoman;
using EFMotoman.Repository;
using EFMotoman.Repository.IRepository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<MMContext>(optins =>
{
    optins.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});


builder.Services.AddControllers().AddNewtonsoftJson();




builder.Services.AddControllers();

builder.Services.AddAutoMapper(typeof(MappingConfig));

builder.Services.AddScoped<ICategoriaRepository, CategoriaRepository>();

builder.Services.AddScoped<IEmpleadoRepository, EmpleadoRepository>();

builder.Services.AddScoped<IFacturaRepository, FacturaRepository>();

builder.Services.AddScoped<IInventarioRepository, InventarioRepository>();

builder.Services.AddScoped<INotificacionRepository, NotificacionRepository>();

builder.Services.AddScoped<IPersonaRepository, PersonaRepository>();

builder.Services.AddScoped<IPreventaProductoRepository, PreventaProductoRepository>();

builder.Services.AddScoped<IPreventaRepository, PreventaRepository>();

builder.Services.AddScoped<IProductoRepository, ProductoRepository>();

builder.Services.AddScoped<IProveedorRepository, ProveedorRepository>();

builder.Services.AddScoped<IUsuarioRepository, UsuarioRepository>();

builder.Services.AddScoped<IVentaRepository, VentaRepository>();

builder.Services.AddMvc(option => option.EnableEndpointRouting = false)
    .SetCompatibilityVersion(Microsoft.AspNetCore.Mvc.CompatibilityVersion.Version_3_0)
    .AddNewtonsoftJson(opt => opt.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
