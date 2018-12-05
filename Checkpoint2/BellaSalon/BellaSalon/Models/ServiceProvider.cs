using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BellaSalon.Models
{
    public class ServiceProvider
    {
        public ServiceProvider()
        {
            ID = Guid.NewGuid();
        }
        public Guid ID { get; set; }

        [Required(ErrorMessage = "Please enter Service Provider")]
        [RegularExpression(@"^[a-zA-Z ]+$",
           ErrorMessage = "For your Service Provider, use letters only please")]
        public string Name { get; set; }
    }
}
;