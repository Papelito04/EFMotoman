using EFMotoman.Models;
using EFMotoman.Repository.IRepository;

namespace EFMotoman.Repository
{
    public interface IFacturaRepository : IRepository<Factura>
    {
        Task<Factura> Update(Factura entity);
    }
}
