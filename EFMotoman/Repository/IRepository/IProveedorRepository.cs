using EFMotoman.Models;
using EFMotoman.Repository.IRepository;

namespace EFMotoman.Repository
{
    public interface IProveedorRepository : IRepository<Proveedor>
    {
        Task<Proveedor> Update(Proveedor entity);
    }
}
