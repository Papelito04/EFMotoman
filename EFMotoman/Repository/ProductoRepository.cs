using EFMotoman.Data;
using EFMotoman.Models;

namespace EFMotoman.Repository
{
    public class ProductoRepository : Repository<Producto>, IProductoRepository
    {
        private readonly MMContext _db;

        public ProductoRepository(MMContext db) : base(db)
        {
            _db = db;
        }
        public async Task<Producto> Update(Producto entity)
        {
            _db.Productos.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }
    }
}
