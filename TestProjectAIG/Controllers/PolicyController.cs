using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProjectAIG.Models;

namespace TestProjectAIG.Controllers
{
    public class PolicyController
    {
        public double CalculateLifeInsurancePolicy(LifeInsuranceDetails lifeDetails)
        {
            double basePrice = 1000;
            double riskFactor = lifeDetails.Risk;
            return basePrice * (1 + riskFactor);
        }

        public double CalculateHomeInsurancePolicy(HomeInsuranceDetails homeDetails)
        {
            double basePrice = 500;
            double ageFactor = homeDetails.HomeAge * 0.01;
            double sizeFactor = homeDetails.HomeSize * 0.05;
            return basePrice + (basePrice * ageFactor) + (basePrice * sizeFactor);
        }
    }
}