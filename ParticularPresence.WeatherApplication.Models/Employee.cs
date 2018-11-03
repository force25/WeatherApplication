using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParticularPresence.WeatherApplication.Models
{
    public class Employee
    {
        [Required]
        public int EmployeeId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string Country { get; set; }
        [Required]
        public long TelephoneNo { get; set; }
        [Required]
        public string Role { get; set; }
        [Required]
        public string EmailAddress { get; set; }
        [Required]
        public string AddressLocation { get; set; }
    }
}
