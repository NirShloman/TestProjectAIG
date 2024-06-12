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
using System.ComponentModel.DataAnnotations;
using Microsoft.Office.Interop.Excel;

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
            if (!LifeInsuranceValidationInput())
            {
                return;
            }

            var selectedHobbies = clbHobbies.CheckedItems.Cast<string>().ToList();
            string occupation = cbOccupation.SelectedItem?.ToString();

            PolicyService policyService = new PolicyService();
            double risk = policyService.LifeInsuranceCalculateRisk(occupation, selectedHobbies);

            var lifeInsuranceDetails = new LifeInsuranceDetails
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Id = txtID.Text,
                Hobbies = selectedHobbies,
                Occupation = occupation,
                Risk = risk
            };

            double price = policyService.CalculateLifeInsurancePolicy(lifeInsuranceDetails);

            List<ValidationResult> results = new List<ValidationResult>();
            ValidationContext context = new ValidationContext(lifeInsuranceDetails);

            bool isValid = Validator.TryValidateObject(lifeInsuranceDetails, context, results, true);

            if (isValid)
            {
                MessageBox.Show("הנתונים תקינים ונשלחו בהצלחה.");
                FinishForm finishForm = new FinishForm();
                if (risk >= 0.75)
                {
                    finishForm.DisplayResults("לא ניתן לבטח.");
                }
                else
                {
                    finishForm.DisplayResults($"עלות ביטוח החיים הוא: {price}");
                }
                finishForm.Show();
                this.Hide();
            }
            else
            {
                string errors = string.Join(Environment.NewLine, results.Select(r => r.ErrorMessage));
                MessageBox.Show($":אנא תקן את השגיאות הבאות\n{errors}", "שגיאות ולידציה", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool LifeInsuranceValidationInput()
        {
            List<string> validationErrors = new List<string>();

            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                validationErrors.Add("שם פרטי הוא שדה חובה.");
            }

            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                validationErrors.Add("שם משפחה הוא שדה חובה.");
            }

            if (string.IsNullOrWhiteSpace(txtID.Text))
            {
                validationErrors.Add("תעודת זהות היא שדה חובה.");
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(txtID.Text, @"^\d{9}$"))
            {
                validationErrors.Add("תעודת זהות חייבת להיות מספר בן 9 ספרות.");
            }

            if (clbHobbies.CheckedItems.Cast<string>().ToList().Count == 0)
            {
                validationErrors.Add("יש לבחור לפחות תחביב אחד.");
            }

            if (string.IsNullOrWhiteSpace(cbOccupation.SelectedItem?.ToString()))
            {
                validationErrors.Add("עיסוק הוא שדה חובה.");
            }

            if (validationErrors.Count > 0)
            {
                MessageBox.Show(string.Join("\n", validationErrors), "שגיאות ולידציה", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}