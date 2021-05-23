using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RideShare.Models
{

    public class Address
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long AddressId { get; set; }
        public string UnitNo { get; set; }
        public string StreetNo { get; set; }
        public string StreetName { get; set; }
        public string AddressLine2 { get; set; }
        public string PostalCode { get; set; }
        public long CityId { get; set; }
        public long ProvinceId { get; set; }
        public long CountryId { get; set; }
    }
}
