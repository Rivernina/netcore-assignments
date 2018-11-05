using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BellaSalon.Models
{
    public class AppointmentResponse
    {
        [Required(ErrorMessage = "Please enter Full name")]
        [RegularExpression(@"^[a-zA-Z ]+$",
                    ErrorMessage = "For a name, use letters only please")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter customer's phone number")]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$",
            ErrorMessage = "Invalid Phone number")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Please enter Customer's Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter Service Provider")]
        [RegularExpression(@"^[a-zA-Z]+$",
            ErrorMessage = "For your Service Provider, use letters only please")]
        public string ServiceProvider { get; set; }

        public string Appointment { get; set; }
    }
}
