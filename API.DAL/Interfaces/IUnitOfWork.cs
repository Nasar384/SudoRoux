using API.DAL.Entities;

namespace API.DAL.Interfaces
{
    public interface IUnitOfWork
    {
        IRepository<Subscriber> Subscribers { get; }
    }
}
