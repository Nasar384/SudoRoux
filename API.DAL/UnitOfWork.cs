using API.DAL.Entities;
using API.DAL.Interfaces;

namespace API.DAL
{
    public class UnitOfWork : IUnitOfWork
    {

        private Repository<Subscriber> subscribers { get; set; }
        public IRepository<Subscriber> Subscribers => subscribers ?? (subscribers = new Repository<Subscriber>());
    }
}
