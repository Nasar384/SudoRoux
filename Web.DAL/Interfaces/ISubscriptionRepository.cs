using Web.DAL.Models;

namespace Web.DAL.Interfaces
{
    public interface ISubscriptionRepository
    {
        bool Subscribe(Subscriber subscriber);
    }
}
