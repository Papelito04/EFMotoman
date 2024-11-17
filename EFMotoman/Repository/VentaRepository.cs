using EFMotoman.Data;
using EFMotoman.Models;

namespace EFMotoman.Repository
{
    public class VentaRepository : Repository<Venta>, IVentaRepository
    {
        private readonly MMContext _db;

        public VentaRepository(MMContext db) : base(db)
        {
            _db = db;
        }
        public async Task<Venta> Update(Venta entity)
        {
            _db.Ventas.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }
    }
}
