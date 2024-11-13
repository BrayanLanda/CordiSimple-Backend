using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CordiSimple.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(50)]
        public string Name { get; set; }

        [Required, EmailAddress, StringLength(100)]
        public string Email { get; set; }

        [Required, StringLength(20)]
        public string Password { get; set; }

        public UserRole MyProperty { get; set; } = UserRole.USER;
        
        public List<Booking> Bookings { get; set; }

    }
}