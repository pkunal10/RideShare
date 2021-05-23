using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RideShare.Models;
using RideShare.Services;

namespace RideShare.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AddressController : ControllerBase
    {
        private readonly IAddressService _addressService;

        public AddressController(IAddressService addressService)
        {
            _addressService = addressService;
        }

        [HttpGet]
        public IActionResult GetAddress()
        {
            List<Address> address = _addressService.GetAllAddress();
            if (address.Count <= 0) return NotFound();

            return Ok(address);
        }
    }
}
