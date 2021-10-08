using API.BLL.Interfaces.Models;
using API.Shared.constants;
using System;
using System.Text.Json.Serialization;

namespace API.Models
{
    public class SubscriberDTO : ISubscriberModel
    {
        [JsonPropertyName(SubscriptionJsonProperties.FirstName)]
        public string FirstName { get; set; }
        [JsonPropertyName(SubscriptionJsonProperties.LastName)]
        public string LastName { get; set; }
        [JsonPropertyName(SubscriptionJsonProperties.EmailAddress)]
        public string EmailAddress { get; set; }
        [JsonPropertyName(SubscriptionJsonProperties.Subscribed)]
        public bool Subscribed { get; set; }
        [JsonPropertyName(SubscriptionJsonProperties.DateOfBirth)]
        public DateTime DateOfBirth { get; set; }
    }
}
