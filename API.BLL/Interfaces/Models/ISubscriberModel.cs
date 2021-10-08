using System;

namespace API.BLL.Interfaces.Models
{
    public interface ISubscriberModel
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string EmailAddress { get; set; }
        bool Subscribed { get; set; }
        DateTime DateOfBirth { get; set; }
    }
}
