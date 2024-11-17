using EFMotoman.Models;
using EFMotoman.Repository.IRepository;

namespace EFMotoman.Repository
{
    public interface IPersonaRepository : IRepository<Persona>
    {
        Task<Persona> Update(Persona entity);
    }
}
