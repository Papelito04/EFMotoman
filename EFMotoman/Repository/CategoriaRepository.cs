using EFMotoman.Data;
using EFMotoman.Models;
using EFMotoman.Repository.IRepository;

namespace EFMotoman.Repository
{
    public class CategoriaRepository : Repository<Categoria>, ICategoriaRepository
    {
        private readonly MMContext _db;

        public CategoriaRepository(MMContext db) : base(db)
        {
            _db = db;
        }
        public async Task<Categoria> Update(Categoria entity)
        {
            _db.Categorias.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }
    }
}
