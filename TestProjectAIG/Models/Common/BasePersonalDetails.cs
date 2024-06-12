using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TestProjectAIG.Models
{
    public class BasePersonalDetails
    {
        [Required(ErrorMessage = "שם פרטי הוא שדה חובה")]
        [StringLength(50, ErrorMessage = "שם פרטי לא יכול להיות יותר ארוך מ-50 תווים")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "שם משפחה הוא שדה חובה")]
        [StringLength(50, ErrorMessage = "שם משפחה לא יכול להיות יותר ארוך מ-50 תווים")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "תעודת זהות היא שדה חובה")]
        [RegularExpression(@"^\d{9}$", ErrorMessage = "תעודת זהות חייבת להיות מספר בן 9 ספרות")]
        public string Id { get; set; }

        [Required(ErrorMessage = "גיל הוא שדה חובה")]
        public float Age { get; set; }

        public string Gender { get; set; }
    }
}