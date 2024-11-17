using EFMotoman.Models;
using EFMotoman.Repository.IRepository;

namespace EFMotoman.Repository
{
    public interface IUsuarioRepository : IRepository<Usuario>
    {
        Task<Usuario> Update(Usuario entity);
    }
}
