using EFMotoman.Data;
using EFMotoman.Models;

namespace EFMotoman.Repository
{
    public class EmpleadoRepository : Repository<Empleado>, IEmpleadoRepository
    {
        private readonly MMContext _db;

        public EmpleadoRepository(MMContext db) : base(db)
        {
            _db = db;
        }
        public async Task<Empleado> Update(Empleado entity)
        {
            _db.Empleados.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }
    }
}
