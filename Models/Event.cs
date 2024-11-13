using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CordiSimple.Models
{
    public class Event
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required, StringLength(100)]
        public string Place { get; set; }

        [Required, StringLength(255)]
        public string Description { get; set; }

        public List<Booking> Bookings { get; set; }

    }
}