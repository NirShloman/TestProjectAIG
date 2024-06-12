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
using TestProjectAIG.Extensions;
using TestProjectAIG.Models.Mapping;

namespace TestProjectAIG.Views
{
    public partial class LifeInsuranceForm : Form
    {
        public LifeInsuranceForm()
        {
            InitializeComponent();
            this.clbHobbies.LoadItemsToCheckedListBox(LifeInsuranceRiskItemsMapping.Hobbies.Keys.ToList());
            this.cbOccupation.LoadItemsToComboBox(LifeInsuranceRiskItemsMapping.Occupations.Keys.ToList());
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            InsuranceOptions insuranceOptions = new InsuranceOptions();
            insuranceOptions.Show();
            this.Hide();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            PolicyService policyService = new PolicyService();

            var selectedHobbies = clbHobbies.CheckedItems.Cast<string>().ToList();
            var occupation = cbOccupation.SelectedItem.ToString();
            double risk = policyService.LifeInsuranceCalculateRisk(occupation, selectedHobbies);

            var lifeInsuranceDetails = new LifeInsuranceDetails
            {
                Hobbies = selectedHobbies,
                Occupation = occupation,
                Risk = risk
            };

            double price = policyService.CalculateLifeInsurancePolicy(lifeInsuranceDetails);

            FinishForm finishForm = new FinishForm();
            if (risk >= 0.75)
            {
                finishForm.DisplayResults("לא ניתן לבטח.");
            }
            else
            {
                finishForm.DisplayResults($"עלות הביטוח החיים הוא: {price}");
            }
            finishForm.Show();
            this.Hide();
        }
    }
}