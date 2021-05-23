using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RideShare.Models;

namespace RideShare.Services
{
    public interface IAddressService
    {
        public List<Address> GetAllAddress();
    }
}
