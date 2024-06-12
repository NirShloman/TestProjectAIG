using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProjectAIG.Models.Common;

namespace TestProjectAIG.Models
{
    public class HomeInsuranceDetails : AddressDetails
    {
        [Required(ErrorMessage = "סוג הדירה הוא שדה חובה")]
        public string ApartmentType { get; set; }

        [Required(ErrorMessage = "סוג המבנה הוא שדה חובה")]
        public string StructureType { get; set; }

        [Required(ErrorMessage = "גודל הדירה הוא שדה חובה")]
        [Range(10, 1000, ErrorMessage = "גודל הדירה חייב להיות בין 10 ל-1000 מ\"ר")]
        public float HomeSize { get; set; }
    }
}