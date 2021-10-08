using API.BLL.Interfaces.Models;
using API.BLL.Interfaces.Services;
using API.DAL;
using API.DAL.Entities;
using API.DAL.Interfaces;
using System.Threading.Tasks;

namespace API.BLL.Services
{
    public class SubscriptionService : ISubscriptionService
    {
        private readonly IUnitOfWork _unitOfWork;

        public SubscriptionService()
            : this(new UnitOfWork())
        {

        }
        // For unit testing
        public SubscriptionService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public ISubscriberModel Subscriber { get; set; }
        public async Task SubscribeAsync()
        {
            await _unitOfWork.Subscribers.CreateAsync(GetModel());
        }

        //TODO: use Mapper
        private Subscriber GetModel()
        {
            Subscriber subscriber = null;
            if (null != Subscriber)
            {
                subscriber = new Subscriber()
                {
                    DateOfBirth = Subscriber.DateOfBirth,
                    EmailAddress = Subscriber.EmailAddress,
                    FirstName = Subscriber.FirstName,
                    LastName = Subscriber.LastName,
                    Subscribed = Subscriber.Subscribed
                };
            }
            return subscriber;


        }
    }
}
