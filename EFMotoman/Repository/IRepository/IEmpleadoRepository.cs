using EFMotoman.Models;
using EFMotoman.Repository.IRepository;

namespace EFMotoman.Repository
{
    public interface IEmpleadoRepository : IRepository<Empleado>
    {
        Task<Empleado> Update(Empleado entity);
    }
}
