using EFMotoman.Models;
using EFMotoman.Repository.IRepository;

namespace EFMotoman.Repository
{
    public interface IProductoRepository : IRepository<Producto>
    {
        Task<Producto> Update(Producto entity);
    }
}
