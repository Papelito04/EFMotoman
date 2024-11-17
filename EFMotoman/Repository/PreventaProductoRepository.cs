using EFMotoman.Data;
using EFMotoman.Models;

namespace EFMotoman.Repository
{
    public class PreventaProductoRepository : Repository<PreventaProducto>, IPreventaProductoRepository
    {
        private readonly MMContext _db;

        public PreventaProductoRepository(MMContext db) : base(db)
        {
            _db = db;
        }
        public async Task<PreventaProducto> Update(PreventaProducto entity)
        {
            _db.PreventaProductos.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }
    }
}
