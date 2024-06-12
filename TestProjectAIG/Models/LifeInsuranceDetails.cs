using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProjectAIG.Models.Common;

namespace TestProjectAIG.Models
{
    public class LifeInsuranceDetails : BasePersonalDetails
    {
        [Required(ErrorMessage = "תחביבים הם שדה חובה")]
        public List<string> Hobbies { get; set; }

        [Required(ErrorMessage = "עיסוק הוא שדה חובה")]
        public string Occupation { get; set; }

        public double Risk { get; set; }
    }
}