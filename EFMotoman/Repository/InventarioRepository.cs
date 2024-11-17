using EFMotoman.Data;
using EFMotoman.Models;

namespace EFMotoman.Repository
{
    public class InventarioRepository : Repository<Inventario>, IInventarioRepository
    {
        private readonly MMContext _db;

        public InventarioRepository(MMContext db) : base(db)
        {
            _db = db;
        }
        public async Task<Inventario> Update(Inventario entity)
        {
            _db.Inventarios.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }
    }
}
