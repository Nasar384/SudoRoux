using System;
using Web.DAL.Interfaces;
using Web.DAL.Models;

namespace Web.DAL.Repositories
{
    public class SubscriptionRepository : ISubscriptionRepository
    {
        private readonly IRequestHandler _requestHandler;
        public SubscriptionRepository(string endpointUrl)
             : this(new RequestHandler(endpointUrl))
        {

        }
        public SubscriptionRepository(IRequestHandler requestHandler)
        {
            _requestHandler = requestHandler;
        }

        public bool Subscribe(Subscriber subscriber)
        {
            bool result;
            try
            {
                _requestHandler.Post("Subscription", subscriber);
                result = true;
            }
            catch (Exception)
            {
                //Log Here
                result = false;
            }
            return result;

        }
    }
}
