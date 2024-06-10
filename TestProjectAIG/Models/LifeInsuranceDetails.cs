using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectAIG.Models
{
    public class LifeInsuranceDetails : BasePersonalDetails
    {
        public List<string> Hobbies { get; set; }
        public string Occupation { get; set; }
        public double Risk { get; set; }
    }
}