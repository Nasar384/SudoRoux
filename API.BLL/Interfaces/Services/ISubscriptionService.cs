using API.BLL.Interfaces.Models;
using System.Threading.Tasks;

namespace API.BLL.Interfaces.Services
{
    public interface ISubscriptionService
    {
        Task SubscribeAsync();
        ISubscriberModel Subscriber { get; set; }
    }
}
