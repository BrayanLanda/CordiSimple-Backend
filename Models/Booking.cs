using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CordiSimple.Models
{
    public class Booking
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }

        [ForeignKey("Event")]
        public int EventId { get; set; }

        [Required]
        [Range(0, double.MaxValue)]
        public decimal Price { get; set; }

        [Required]
        public int People { get; set; }
        
        public decimal TotalPrice => Price * People;

        //Navegation Properties
        public User User { get; set; }
        public Event Event { get; set; }
    }
}