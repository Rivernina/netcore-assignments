using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BellaSalon.Models
{
    public class Appointment
    {
        public Appointment()
        {
            ID = Guid.NewGuid();
        }
        public Guid ID { get; set; }

        [Required(ErrorMessage = "Please enter Full name")]
        [RegularExpression(@"^[a-zA-Z ]+$",
                    ErrorMessage = "For a name, use letters only please")]
        public string Customer { get; set; }

        public string Date { get; set; }

        [Required(ErrorMessage = "Please enter valid Time")]
        [RegularExpression(@"\d{2,2}/\d{2,2}/\d{4,4} \d{2,2}:\d{2,2}:\d{2,2}",
            ErrorMessage = "Invalid Time")]
        public string Time { get; set; }

        [Required(ErrorMessage = "Please enter Service Provider")]
        [RegularExpression(@"^[a-zA-Z ]+$",
                    ErrorMessage = "For your Service Provider, use letters only please")]
        public string ServiceProvider { get; set; }

    }
}
