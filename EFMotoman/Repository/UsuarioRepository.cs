using EFMotoman.Data;
using EFMotoman.Models;

namespace EFMotoman.Repository
{
    public class UsuarioRepository : Repository<Usuario>, IUsuarioRepository
    {
        private readonly MMContext _db;

        public UsuarioRepository(MMContext db) : base(db)
        {
            _db = db;
        }
        public async Task<Usuario> Update(Usuario entity)
        {
            _db.Usuarios.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }
    }
}
