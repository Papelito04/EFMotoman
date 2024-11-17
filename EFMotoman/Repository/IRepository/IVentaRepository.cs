using EFMotoman.Models;
using EFMotoman.Repository.IRepository;

namespace EFMotoman.Repository
{
    public interface IVentaRepository : IRepository<Venta>
    {
        Task<Venta> Update(Venta entity);
    }
}
