using System;
using System.Collections.Generic;
using System.Text;
using Web.BLL.Interfaces.Models;

namespace Web.BLL.Interfaces.Services
{
    public interface ISubscriptionService
    {
        ISubscriberModel SubscriberModel { get; set; }
        void Load();
        bool Subscribe(out string message);
    }
}
