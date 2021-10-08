using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;
using Web.BLL.Configurations;
using Web.BLL.Interfaces.Models;
using Web.BLL.Interfaces.Services;
using Web.DAL.Interfaces;
using Web.DAL.Models;
using Web.DAL.Repositories;

namespace Web.BLL.Services
{
    public class SubscriptionService : ISubscriptionService
    {
        private readonly ISubscriptionRepository _subscriptionRepository;

        public ISubscriberModel SubscriberModel { get; set; }

        public SubscriptionService(IOptions<ApiConfig> options, ISubscriberModel subscriberModel)
            : this(new SubscriptionRepository(options.Value.EndpointUrl), subscriberModel)
        {

        }
        // For unit testing
        public SubscriptionService(ISubscriptionRepository subscriptionRepository, ISubscriberModel subscriberModel)
        {
            _subscriptionRepository = subscriptionRepository;
            SubscriberModel = subscriberModel;
        }



        public void Load()
        {
            SubscriberModel.DateOfBirth = DateTime.Now.AddYears(-20);
            SubscriberModel.Subscribed = true;
            SubscriberModel.EmailAddress = "";
            SubscriberModel.FirstName = "";
            SubscriberModel.LastName = "";
        }
        public bool Subscribe(out string message)
        {
            bool result;
            if (_subscriptionRepository.Subscribe(GetModel()))
            {
                message = "Subscribed successfully";
                result = true;
                Load();
            }
            else
            {
                message = "an error occurred while subscribing please contact the administrator";
                result = false;
            }
            return result;
        }

        //TODO: use Mapper
        private Subscriber GetModel()
        {
            Subscriber subscriber = null;
            if (null != SubscriberModel)
            {
                subscriber = new Subscriber()
                {
                    DateOfBirth = SubscriberModel.DateOfBirth,
                    EmailAddress = SubscriberModel.EmailAddress,
                    FirstName = SubscriberModel.FirstName,
                    LastName = SubscriberModel.LastName,
                    Subscribed = SubscriberModel.Subscribed
                };
            }
            return subscriber;


        }
    }
}
