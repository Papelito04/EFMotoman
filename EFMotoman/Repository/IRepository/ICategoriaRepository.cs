using EFMotoman.Models;
using EFMotoman.Repository.IRepository;

namespace EFMotoman.Repository
{
    public interface ICategoriaRepository : IRepository<Categoria>
    {
        Task<Categoria> Update(Categoria entity);
    
    }
}
