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
        public static readonly double lifeInsuranceBasePrice;
        public static readonly double homeInsuranceBasePrice;

        static PolicyService()
        {
            lifeInsuranceBasePrice = Double.Parse(System.Configuration.ConfigurationSettings.AppSettings["lifeInsuranceBasePrice"]);
            homeInsuranceBasePrice = Double.Parse(System.Configuration.ConfigurationSettings.AppSettings["homeInsuranceBasePrice"]);
        }

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

        public double CalculateLifeInsurancePolicy(LifeInsuranceDetails lifeDetails)
        {
            double riskFactor = lifeDetails.Risk;
            return lifeInsuranceBasePrice * (1 + riskFactor);
        }

        public double CalculateHomeInsurancePolicy(HomeInsuranceDetails homeDetails)
        {
            double ageFactor = homeDetails.Age * 0.01;
            double sizeFactor = homeDetails.HomeSize * 0.05;
            return homeInsuranceBasePrice + (homeInsuranceBasePrice * ageFactor) + (homeInsuranceBasePrice * sizeFactor);
        }
    }
}