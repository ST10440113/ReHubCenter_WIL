using System.ComponentModel.DataAnnotations;

namespace ReHubCenter_WIL.Models
{
    public class WorkshopBooking
    {
        [Key] public int WorkshopBookingID { get; set; }

        [Display(Name = "First Name")] public string FirstName { get; set; }
        public string Surname { get; set; }

        public int Age { get; set; }

        [Display(Name = "Phone Number")] public string PhoneNumber { get; set; }

        [Display(Name = "Email Address")] public string EmailAddress { get; set; }

        [Display(Name = "Date and Time")] public DateTime Date_and_Time { get; set; }

        [Display(Name = "Optional Notes")] public string? OptionalNotes { get; set; }
    }
}

