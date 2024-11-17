using EFMotoman.Models;
using EFMotoman.Repository.IRepository;

namespace EFMotoman.Repository
{
    public interface IPreventaRepository : IRepository<Preventa>
    {
        Task<Preventa> Update(Preventa entity);
    }
}
