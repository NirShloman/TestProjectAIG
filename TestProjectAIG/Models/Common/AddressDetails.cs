using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectAIG.Models.Common
{
    public class AddressDetails : BasePersonalDetails
    {
        public string FullAddress { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public int HouseNumber { get; set; }
        public int ApartmentNumber { get; set; }
        public int Floor { get; set; }
    }
}