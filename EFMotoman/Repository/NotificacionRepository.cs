using EFMotoman.Data;
using EFMotoman.Models;

namespace EFMotoman.Repository
{
    public class NotificacionRepository : Repository<Notificacion>, INotificacionRepository
    {
        private readonly MMContext _db;

        public NotificacionRepository(MMContext db) : base(db)
        {
            _db = db;
        }
        public async Task<Notificacion> Update(Notificacion entity)
        {
            _db.Notificaciones.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }
    }
}
