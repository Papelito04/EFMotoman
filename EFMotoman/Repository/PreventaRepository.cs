using EFMotoman.Data;
using EFMotoman.Models;

namespace EFMotoman.Repository
{
    public class PreventaRepository : Repository<Preventa>, IPreventaRepository
    {
        private readonly MMContext _db;

        public PreventaRepository(MMContext db) : base(db)
        {
            _db = db;
        }
        public async Task<Preventa> Update(Preventa entity)
        {
            _db.Preventas.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }
    }
}
