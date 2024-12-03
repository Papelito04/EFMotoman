using EFMotoman.Models.Dto;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMForm
{
    public class Helpers
    {
        static PersonaDto PersonaToUpdate = new PersonaDto();
        private List<PersonaDto> listaPersonas = new List<PersonaDto>();
        private List<EmpleadoDto> listaEmpleados = new List<EmpleadoDto>();
        private List<UsuarioDto> listaUsuarios = new List<UsuarioDto>();
        private List<CategoriaDto> listaCategorias = new List<CategoriaDto>();
        private List<ProductoDto> listaProductos = new List<ProductoDto>();
        private List<ProveedorDto> listaProveedores = new List<ProveedorDto>();
        private List<InventarioDto> listaInventarios = new List<InventarioDto>();
        private List<FacturaDto> listaFacturas = new List<FacturaDto>();
        private List<NotificacionDto> listaNotificaciones = new List<NotificacionDto>();
        private List<PreventaDto> listaPreventas = new List<PreventaDto>();
        private List<PreventaProductoDto> listaPreventaProductos = new List<PreventaProductoDto>();
        private List<VentaDto> listaVentas = new List<VentaDto>();


        public List<PersonaDto> RetornarPersonas() => listaPersonas;
        public List<EmpleadoDto> RetornarEmpleados() => listaEmpleados; 
        public List<UsuarioDto> RetornarUsuarios() => listaUsuarios; 
        public List<CategoriaDto> RetornarCategorias() => listaCategorias; 
        public List<ProductoDto> RetornarProductos() => listaProductos; 
        public List<ProveedorDto> RetornarProveedores() => listaProveedores; 
        public List<InventarioDto> RetornarInventarios() => listaInventarios; 
        public List<FacturaDto> RetornarFacturas() => listaFacturas; 
        public List<NotificacionDto> RetornarNotificaciones() => listaNotificaciones; 
        public List<PreventaDto> RetornarPreventas() => listaPreventas;
        public List<PreventaProductoDto> RetornarPreventaProductos() => listaPreventaProductos;
        public List<VentaDto> RetornarVentas() => listaVentas;








        private async Task<List<T>> FetchData<T>(string url)
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    var jsonData = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<List<T>>(jsonData);
                }
                else
                {
                    MessageBox.Show($"No se puede obtener los datos: {response.StatusCode}");
                    return new List<T>();
                }
            }
        }

        public async Task GetAllPersonas()
        {
            listaPersonas = await FetchData<PersonaDto>("https://localhost:7126/api/persona");
        }

        public async Task GetAllEmpleados()
        {
            listaEmpleados = await FetchData < EmpleadoDto>("https://localhost:7126/api/empleado");
        }

        public async Task GetAllUsuarios()
        {
            listaUsuarios = await FetchData<UsuarioDto>("https://localhost:7126/api/usuario");
        }

        public async Task GetAllCategorias()
        {
            listaCategorias = await FetchData<CategoriaDto>("https://localhost:7126/api/categoria");
        }

        public async Task GetAllProductos()
        {
            listaProductos = await FetchData<ProductoDto>("https://localhost:7126/api/producto");
        }

        public async Task GetAllProveedores()
        {
            listaProveedores = await FetchData<ProveedorDto>("https://localhost:7126/api/proveedor");
        }
        public async Task GetAllInventarios()
        {
            listaInventarios = await FetchData<InventarioDto>("https://localhost:7126/api/inventario");
        }
        public async Task GetAllFacturas()
        {

            listaFacturas = await FetchData<FacturaDto>("https://localhost:7126/api/factura");
        }
        public async Task GetAllNotificaciones()
        {
            listaNotificaciones = await FetchData<NotificacionDto>("https://localhost:7126/api/notificacion");
        }
        public async Task GetAllPreventas()
        {
            listaPreventas= await FetchData<PreventaDto>("https://localhost:7126/api/preventa");
        }

        public async Task GetAllPreventaProductos()
        {
            listaPreventaProductos = await FetchData<PreventaProductoDto>("https://localhost:7126/api/preventaproducto");
        }
        public async Task GetAllVentas()
        { 
            listaVentas = await FetchData<VentaDto>("https://localhost:7126/api/venta");
        }


    }
}
