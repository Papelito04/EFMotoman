using EFMotoman.Models;
using EFMotoman.Repository.IRepository;

namespace EFMotoman.Repository
{
    public interface INotificacionRepository : IRepository<Notificacion>
    {
        Task<Notificacion> Update(Notificacion entity);
    }
}
