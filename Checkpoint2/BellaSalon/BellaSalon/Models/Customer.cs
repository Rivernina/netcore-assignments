using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BellaSalon.Models
{
    public class Customer
    {
        public Customer()
        {
            ID = Guid.NewGuid();
        }
        public Guid ID { get; set; }

        [Required(ErrorMessage = "Please enter Full name")]
        [RegularExpression(@"^[a-zA-Z ]+$",
                    ErrorMessage = "For a name, use letters only please")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter customer's phone number")]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$",
            ErrorMessage = "Invalid Phone number")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Please enter Customer's Email")]
        [RegularExpression(@"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z",
        ErrorMessage = "Please enter correct email address")]
        public string Email { get; set; }
    }
}
