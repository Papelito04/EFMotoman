using EFMotoman.Data;
using EFMotoman.Models;

namespace EFMotoman.Repository
{
    public class PersonaRepository : Repository<Persona>, IPersonaRepository
    {
        private readonly MMContext _db;

        public PersonaRepository(MMContext db) : base(db)
        {
            _db = db;
        }
        public async Task<Persona> Update(Persona entity)
        {
            _db.Personas.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }
    }
}
