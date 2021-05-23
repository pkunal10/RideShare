using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RideShare.Models;

namespace RideShare
{
    public class RideSharedbContext:DbContext
    {
        public RideSharedbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<City> Cities { get; set; }
        public DbSet<Province> Provinces { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Address> Addresses { get; set; }
    }
}
