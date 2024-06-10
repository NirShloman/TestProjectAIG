using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectAIG.Models
{
    public class HomeInsuranceDetails : BasePersonalDetails
    {
        public string Address { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public int HouseNumber { get; set; }
        public int ApartmentNumber { get; set; }
        public int Floor { get; set; }
        public string HomeType { get; set; }
        public int HomeAge { get; set; }
        public double HomeSize { get; set; }
    }
}