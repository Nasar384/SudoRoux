using API.BLL.Interfaces.Services;
using API.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    public class SubscriptionController : BaseApiController
    {
        private readonly ISubscriptionService _subscriptionService;
        public SubscriptionController(ISubscriptionService subscriptionService)
        {
            _subscriptionService = subscriptionService;
        }
        [HttpPost]
        public async Task<IActionResult> Subscribe(SubscriberDTO subscriberDTO)
        {
            _subscriptionService.Subscriber = subscriberDTO;
            await _subscriptionService.SubscribeAsync();
            return NoContent();

        }
    }
}
