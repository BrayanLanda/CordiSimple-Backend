using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CordiSimple.Models;
using Microsoft.EntityFrameworkCore;

namespace CordiSimple.Data
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        
        public DbSet<User> Users { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Booking> Bookings { get; set; }
    }
}