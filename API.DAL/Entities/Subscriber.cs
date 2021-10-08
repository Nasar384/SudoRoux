using API.DAL.Helpers;
using API.Shared.constants;
using Newtonsoft.Json;
using System;

namespace API.DAL.Entities
{
    public class Subscriber
    {
        [JsonProperty(PropertyName = SubscriptionJsonProperties.FirstName)]
        public string FirstName { get; set; }
        [JsonProperty(PropertyName = SubscriptionJsonProperties.LastName)]
        public string LastName { get; set; }
        [JsonProperty(PropertyName = SubscriptionJsonProperties.EmailAddress)]
        public string EmailAddress { get; set; }
        [JsonProperty(PropertyName = SubscriptionJsonProperties.Subscribed)]
        public bool Subscribed { get; set; }
        [JsonProperty(PropertyName = SubscriptionJsonProperties.DateOfBirth)]
        [JsonConverter(typeof(CustomDateConverter))]
        public DateTime DateOfBirth { get; set; }
    }
}
