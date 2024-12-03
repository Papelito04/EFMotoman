using EFMotoman.Models.Dto;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMForm
{
    public class Helpers
    {
        static PersonaDto PersonaToUpdate = new PersonaDto();
        static List<PersonaDto> listaPersonas = new List<PersonaDto>();
        static List<EmpleadoDto> listaEmpleados = new List<EmpleadoDto>();
        static List<UsuarioDto> listaUsuarios = new List<UsuarioDto>();
        static List<CategoriaDto> listaCategorias = new List<CategoriaDto>();
        static List<ProductoDto> listaProductos = new List<ProductoDto>();
        static List<ProveedorDto> listaProveedores = new List<ProveedorDto>();
        static List<InventarioDto> listaInventarios = new List<InventarioDto>();
        static List<FacturaDto> listaFacturas = new List<FacturaDto>();
        static List<NotificacionDto> listaNotificaciones = new List<NotificacionDto>();
        static List<PreventaDto> listaPreventas = new List<PreventaDto>();
        static List<PreventaProductoDto> listaPreventaProductos = new List<PreventaProductoDto>();
        static List<VentaDto> listaVentas = new List<VentaDto>();
        public async void GetAllPersonas()
        {
            List<PersonaDto> persons = new List<PersonaDto>();

            using (var client = new HttpClient())
            {
                using(var response = await client.GetAsync("https://localhost:7126/api/persona"))
                {
                    if ( response.IsSuccessStatusCode )
                    {
                        var personas = await response.Content.ReadAsStringAsync();
                        var displayData_Per = JsonConvert.DeserializeObject<List<PersonaDto>>(personas);

                        persons = displayData_Per.ToList();
                        listaPersonas = persons;
                    }
                    else
                    {
                        MessageBox.Show($"No se puede obtener la lista de personas: {response.StatusCode}");
                    }
                }
            }
        }

        public async void GetAllEmpleados()
        {
            List<EmpleadoDto> employes = new List<EmpleadoDto>();

            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync("https://localhost:7126/api/empleado"))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var empleados = await response.Content.ReadAsStringAsync();
                        var displayData_Emp = JsonConvert.DeserializeObject<List<EmpleadoDto>>(empleados);

                        employes = displayData_Emp.ToList();
                        listaEmpleados = employes;
                    }
                    else
                    {
                        MessageBox.Show($"No se puede obtener la lista de personas: {response.StatusCode}");
                    }
                }
            }
        }

        public async void GetAllUsuarios()
        {
            List<UsuarioDto> users = new List<UsuarioDto>();

            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync("https://localhost:7126/api/usuario"))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var usuarios = await response.Content.ReadAsStringAsync();
                        var displayData_Usr = JsonConvert.DeserializeObject<List<UsuarioDto>>(usuarios);

                        users = displayData_Usr.ToList();
                        listaUsuarios = users;
                    }
                    else
                    {
                        MessageBox.Show($"No se puede obtener la lista de personas: {response.StatusCode}");
                    }
                }
            }
        }

        public async void GetAllCategorias()

        {
            List<CategoriaDto> categories = new List<CategoriaDto>();

            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync("https://localhost:7126/api/categoria"))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var categorias = await response.Content.ReadAsStringAsync();
                        var displayData_Cat = JsonConvert.DeserializeObject<List<CategoriaDto>>(categorias);

                        categories = displayData_Cat.ToList();
                        listaCategorias = categories;
                    }
                    else
                    {
                        MessageBox.Show($"No se puede obtener la lista de categorias: {response.StatusCode}");
                    }
                }
            }
        }

        public async void GetAllProductos()

        {
            List<ProductoDto> products= new List<ProductoDto>();

            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync("https://localhost:7126/api/producto"))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var productos= await response.Content.ReadAsStringAsync();
                        var displayData_Prd = JsonConvert.DeserializeObject<List<ProductoDto>>(productos);

                        products= displayData_Prd.ToList();
                        listaProductos= products;
                    }
                    else
                    {
                        MessageBox.Show($"No se puede obtener la lista de productos: {response.StatusCode}");
                    }
                }
            }
        }

        public async void GetAllProveedores()

        {
            List<ProveedorDto> providers = new List<ProveedorDto>();

            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync("https://localhost:7126/api/proveedor"))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var proveedores= await response.Content.ReadAsStringAsync();
                        var displayData_Prv = JsonConvert.DeserializeObject<List<ProveedorDto>>(proveedores);

                        providers = displayData_Prv.ToList();
                        listaProveedores = providers;
                    }
                    else
                    {
                        MessageBox.Show($"No se puede obtener la lista de proveedores: {response.StatusCode}");
                    }
                }
            }
        }
        public async void GetAllInventarios()
        {
            List<InventarioDto> inventorys = new List<InventarioDto>();

            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync("https://localhost:7126/api/inventario"))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var inventarios = await response.Content.ReadAsStringAsync();
                        var displayData_Inv = JsonConvert.DeserializeObject<List<InventarioDto>>(inventarios);

                        inventorys = displayData_Inv.ToList();
                        listaInventarios = inventorys;
                    }
                    else
                    {
                        MessageBox.Show($"No se puede obtener la lista de inventarios: {response.StatusCode}");
                    }
                }
            }
        }
        public async void GetAllFacturas()
        {
            List<FacturaDto> bills = new List<FacturaDto>();

            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync("https://localhost:7126/api/factura"))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var facturas = await response.Content.ReadAsStringAsync();
                        var displayData_Fac = JsonConvert.DeserializeObject<List<FacturaDto>>(facturas);

                        bills = displayData_Fac.ToList();
                        listaFacturas = bills;
                    }
                    else
                    {
                        MessageBox.Show($"No se puede obtener la lista de facturas: {response.StatusCode}");
                    }
                }
            }
        }
        public async void GetAllNotificaciones()
        {
            List<NotificacionDto> notifications= new List<NotificacionDto>();

            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync("https://localhost:7126/api/notificacion"))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var notificaciones= await response.Content.ReadAsStringAsync();
                        var displayData_Not = JsonConvert.DeserializeObject<List<NotificacionDto>>(notificaciones);

                        notifications = displayData_Not.ToList();
                        listaNotificaciones= notifications;
                    }
                    else
                    {
                        MessageBox.Show($"No se puede obtener la lista de notificaciones: {response.StatusCode}");
                    }
                }
            }
        }
        public async void GetAllPreventas()
        {
            List<PreventaDto> presells= new List<PreventaDto>();

            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync("https://localhost:7126/api/preventa"))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var preventas= await response.Content.ReadAsStringAsync();
                        var displayData_Prvt = JsonConvert.DeserializeObject<List<PreventaDto>>(preventas);

                        presells = displayData_Prvt.ToList();
                        listaPreventas= presells;
                    }
                    else
                    {
                        MessageBox.Show($"No se puede obtener la lista de preventas: {response.StatusCode}");
                    }
                }
            }
        }

        public async void GetAllPreventaProductos()
        {
            List<PreventaProductoDto> presellProducts = new List<PreventaProductoDto>();

            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync("https://localhost:7126/api/preventaproducto"))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var preventaProductos = await response.Content.ReadAsStringAsync();
                        var displayData_PrvtPrd = JsonConvert.DeserializeObject<List<PreventaProductoDto>>(preventaProductos);

                        presellProducts = displayData_PrvtPrd.ToList();
                        listaPreventaProductos = presellProducts;
                    }
                    else
                    {
                        MessageBox.Show($"No se puede obtener la lista de preventas-productos: {response.StatusCode}");
                    }
                }
            }
        }
        public async void GetAllVentas()
        {
            List<VentaDto> sells = new List<VentaDto>();

            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync("https://localhost:7126/api/venta"))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var ventas= await response.Content.ReadAsStringAsync();
                        var displayData_PrvtPrd = JsonConvert.DeserializeObject<List<VentaDto>>(ventas);

                        sells = displayData_PrvtPrd.ToList();
                        listaVentas = sells;
                    }
                    else
                    {
                        MessageBox.Show($"No se puede obtener la lista de ventas: {response.StatusCode}");
                    }
                }
            }
        }


    }
}
