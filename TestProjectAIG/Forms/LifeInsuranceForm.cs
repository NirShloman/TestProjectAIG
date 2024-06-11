using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestProjectAIG.Controllers;
using TestProjectAIG.Models;

namespace TestProjectAIG.Views
{
    public partial class LifeInsuranceForm : Form
    {
        public LifeInsuranceForm()
        {
            InitializeComponent();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            InsuranceOptions insuranceOptions = new InsuranceOptions();
            insuranceOptions.Show();
            this.Hide();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            var personalData = new BasePersonalDetails
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Id = txtID.Text,
                Gender = cbGender.SelectedItem.ToString()
            };

            var selectedHobbies = clbHobbies.CheckedItems.Cast<string>().ToList();
            var occupation = cbOccupation.SelectedItem.ToString();
            double risk = CalculateRisk(occupation, selectedHobbies);

            var lifeInsuranceDetails = new LifeInsuranceDetails
            {
                Hobbies = selectedHobbies,
                Occupation = occupation,
                Risk = risk
            };

            PolicyController policyController = new PolicyController();
            double price = policyController.CalculateLifeInsurancePolicy(lifeInsuranceDetails);

            FinishForm finishForm = new FinishForm();
            if (risk >= 0.75)
            {
                finishForm.DisplayResults("Cannot insure due to high risk.");
            }
            else
            {
                finishForm.DisplayResults($"Insurance Price: {price}");
            }
            finishForm.Show();
            this.Hide();
        }

        private double CalculateRisk(string occupation, List<string> hobbies)
        {
            double risk = 0;

            switch (occupation)
            {
                case "Soldier":
                    risk += 0.30;
                    break;

                case "Teacher":
                    risk += 0;
                    break;

                case "Skydiver":
                    risk += 0.50;
                    break;
            }

            foreach (var hobby in hobbies)
            {
                switch (hobby)
                {
                    case "Diving":
                        risk += 0.10;
                        break;

                    case "Motorcycles":
                        risk += 0.20;
                        break;
                }
            }

            return risk;
        }
    }
}