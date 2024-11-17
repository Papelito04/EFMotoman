using EFMotoman.Models;
using EFMotoman.Repository.IRepository;

namespace EFMotoman.Repository
{
    public interface IPreventaProductoRepository : IRepository<PreventaProducto>
    {
        Task<PreventaProducto> Update(PreventaProducto entity);
    }
}
