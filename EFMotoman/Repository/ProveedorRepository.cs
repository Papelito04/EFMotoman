using EFMotoman.Data;
using EFMotoman.Models;

namespace EFMotoman.Repository
{
    public class ProveedorRepository : Repository<Proveedor>, IProveedorRepository
    {
        private readonly MMContext _db;

        public ProveedorRepository(MMContext db) : base(db)
        {
            _db = db;
        }
        public async Task<Proveedor> Update(Proveedor entity)
        {
            _db.Proveedores.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }
    }
}
