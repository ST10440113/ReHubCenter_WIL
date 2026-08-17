using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ReHubCenter_WIL.Models
{
    public class IndividualBooking
    {
        [Key]public int IndividualBookingID { get; set; }

        [Display(Name = "First Name")] public string FirstName { get; set; }
        public string Surname { get; set; }

        public string Category { get; set; }

        [Display(Name = "Phone Number")] public string PhoneNumber { get; set; }

        [Display(Name = "Email Address")] public string EmailAddress { get; set; }

        [Display(Name = "Date and Time")] public DateTime Date_and_Time { get; set; }

        [Display(Name = "Optional Notes")] public string? OptionalNotes { get; set; }
    }
}
