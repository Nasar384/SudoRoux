using Microsoft.AspNetCore.Mvc;
using System;
using Web.BLL.Interfaces.Services;
using Web.Models;

namespace Web.Controllers
{
    public class HomeController : BaseWebController
    {

        private readonly ISubscriptionService _subscriptionService;
        public HomeController(ISubscriptionService subscriptionService)
        {
            _subscriptionService = subscriptionService;
        }
        public IActionResult Index()
        {
            _subscriptionService.Load();
            return View(_subscriptionService.SubscriberModel);
        }



        [HttpPost]
        public IActionResult Index(SubscriberDTO subscriber)
        {
            if (ModelState.IsValid)
            {
                if (subscriber.DateOfBirth.Date > DateTime.Today)
                {
                    ModelState.AddModelError(nameof(subscriber.DateOfBirth), "Date of Birth cannot be in the future");
                }
                else
                {
                    ViewData["Success"] = null;
                    ViewData["Error"] = null;
                    _subscriptionService.SubscriberModel = subscriber;
                    if (_subscriptionService.Subscribe(out string msg))
                    {
                        ModelState.Clear();
                        ViewData["Success"] = msg;
                    }
                    else
                    {
                        ViewData["Error"] = msg;
                    }
                }
            }
            return View(_subscriptionService.SubscriberModel);
        }

    }
}
