using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RideShare.Models;

namespace RideShare.Services
{
    public class AddressService:IAddressService
    {
        private readonly RideSharedbContext _context;
        public AddressService (RideSharedbContext context)
        {
            _context = context;
        }        

        public List<Address> GetAllAddress()
        {
            return _context.Addresses.ToList();
        }
    }
}
