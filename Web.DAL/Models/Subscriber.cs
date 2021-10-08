using Newtonsoft.Json;
using System;

namespace Web.DAL.Models
{
    public class Subscriber
    {
        [JsonProperty(PropertyName = "firstName")]
        public string FirstName { get; set; }
        [JsonProperty(PropertyName = "last_name")]
        public string LastName { get; set; }
        [JsonProperty(PropertyName = "emailAddress")]
        public string EmailAddress { get; set; }
        [JsonProperty(PropertyName = "subscribed")]
        public bool Subscribed { get; set; }
        [JsonProperty(PropertyName = "dob")]
        public DateTime DateOfBirth { get; set; }
    }
}
