using EFMotoman.Models;
using EFMotoman.Repository.IRepository;

namespace EFMotoman.Repository
{
    public interface IInventarioRepository : IRepository<Inventario>
    {
        Task<Inventario> Update(Inventario entity);
    }
}
