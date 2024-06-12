using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectAIG.Models.Mapping
{
    public class HomeInsuranceRiskItemsMapping
    {
        public static readonly Dictionary<string, double> StructureType;
        public static readonly Dictionary<string, double> ApartmentType;

        static HomeInsuranceRiskItemsMapping()
        {
            StructureType = new Dictionary<string, double>
            {
                { "בית פרטי", 0.10 },
                { "בניין מגורים", 0.20 },
                { "מגדל מגורים", 0.50 },
                { "מבנה מסחרי ", 0.30 },
            };

            ApartmentType = new Dictionary<string, double>
            {
                { "דירת חדר", 0.30 },
                { "דירת שני חדרים", 0.50 },
                { "דירת שלושה חדרים", 0.05 },
                { "דירת גן", 0.05 }
            };
        }
    }
}