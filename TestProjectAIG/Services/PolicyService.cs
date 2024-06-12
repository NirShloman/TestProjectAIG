using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProjectAIG.Models;
using TestProjectAIG.Models.Mapping;

namespace TestProjectAIG.Controllers
{
    public class PolicyService
    {
        public double LifeInsuranceCalculateRisk(string itemSelect, List<string> hobbies)
        {
            double risk = 0;

            risk += LifeInsuranceRiskItemsMapping.Occupations[itemSelect];

            foreach (var hobby in hobbies)
            {
                risk += LifeInsuranceRiskItemsMapping.Hobbies[hobby];
            }

            return risk;
        }

        [Obsolete]
        public double CalculateLifeInsurancePolicy(LifeInsuranceDetails lifeDetails)
        {
            double basePrice = Double.Parse(System.Configuration.ConfigurationSettings.AppSettings["lifeInsuranceBasePrice"]);
            double riskFactor = lifeDetails.Risk;
            return basePrice * (1 + riskFactor);
        }

        [Obsolete]
        public double CalculateHomeInsurancePolicy(HomeInsuranceDetails homeDetails)
        {
            double basePrice = Double.Parse(System.Configuration.ConfigurationSettings.AppSettings["homeInsuranceBasePrice"]);
            double ageFactor = homeDetails.Age * 0.01;
            double sizeFactor = homeDetails.HomeSize * 0.05;
            return basePrice + (basePrice * ageFactor) + (basePrice * sizeFactor);
        }
    }
}