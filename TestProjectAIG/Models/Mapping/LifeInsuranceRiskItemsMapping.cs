using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectAIG.Models.Mapping
{
    public class LifeInsuranceRiskItemsMapping
    {
        public static readonly Dictionary<string, double> Hobbies;
        public static readonly Dictionary<string, double> Occupations;

        static LifeInsuranceRiskItemsMapping()
        {
            Hobbies = new Dictionary<string, double>
            {
                { "צלילה", 0.10 },
                { "רכיבת אופנועים", 0.20 },
                { "צניחה", 0.50 },
                { "קפיצת בנג'י", 0.30 },
                { "טיפוס הרים", 0.40 },
                { "ריצה", 0.25 },
                { "סקי", 0.15 },
                { "סנובורד", 0.18 },
                { "גלישה", 0.12 },
                { "רכיבת אופנים", 0.14 }
            };

            Occupations = new Dictionary<string, double>
            {
                { "חייל", 0.30 },
                { "מורה", 0.00 },
                { "צנחן", 0.50 },
                { "עובד משרד", 0.05 }
            };
        }
    }
}