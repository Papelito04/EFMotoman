using EFMotoman.Data;
using EFMotoman.Models;

namespace EFMotoman.Repository
{
    public class FacturaRepository : Repository<Factura>, IFacturaRepository
    {
        private readonly MMContext _db;

        public FacturaRepository(MMContext db) : base(db)
        {
            _db = db;
        }
        public async Task<Factura> Update(Factura entity)
        {
            _db.Facturas.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }
    }
}
