using System.Threading.Tasks;

namespace API.DAL.Interfaces
{
    public interface IRepository<T> where T : class
    {

        Task CreateAsync(T entity);

    }
}
