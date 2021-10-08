using System;
using System.ComponentModel.DataAnnotations;
using Web.BLL.Interfaces.Models;

namespace Web.Models
{
    public class SubscriberDTO : ISubscriberModel
    {
        [Display(Name = "First Name")]
        [Required]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        [Required]
        public string LastName { get; set; }
        [EmailAddress]
        [Display(Name = "Email Address")]
        [Required]
        public string EmailAddress { get; set; }
        [Display(Name = "Subscribe")]
        public bool Subscribed { get; set; }
        [Display(Name = "Date Of Birth")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
    }
}
