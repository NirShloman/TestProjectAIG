using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestProjectAIG.Models.Mapping;
using TestProjectAIG.Services;
using TestProjectAIG.Extensions;
using TestProjectAIG.Controllers;
using TestProjectAIG.Models;
using System.ComponentModel.DataAnnotations;
using Microsoft.Office.Interop.Excel;
using System.IO;

namespace TestProjectAIG.Views
{
    public partial class HomeInsuranceForm : Form
    {
        private GooglePlacesService googlePlacesService;

        [Obsolete]
        public HomeInsuranceForm()
        {
            InitializeComponent();
            this.cbStructureType.LoadItemsToComboBox(HomeInsuranceRiskItemsMapping.StructureType.Keys.ToList());
            this.cbApartmentType.LoadItemsToComboBox(HomeInsuranceRiskItemsMapping.ApartmentType.Keys.ToList());
            googlePlacesService = new GooglePlacesService();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            using (var insuranceOptionss = new InsuranceOptions())
            {
            }
            InsuranceOptions insuranceOptions = new InsuranceOptions();
            insuranceOptions.Show();
            this.Hide();
        }

        private async void txtStreet_TextChanged(object sender, EventArgs e)
        {
            string input = txtStreet.Text;
            if (input.Length > 2)
            {
                var suggestions = await googlePlacesService.GetPlaceAutoComplete(input);
                lbStreetSuggestions.Items.Clear();
                if (suggestions != null)
                {
                    lbStreetSuggestions.Items.AddRange(suggestions.ToArray());
                    lbStreetSuggestions.Visible = true;
                }
                else
                {
                    lbStreetSuggestions.Visible = false;
                }
            }
        }

        private void lbStreetSuggestions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbStreetSuggestions.SelectedItem != null)
            {
                txtStreet.Text = lbStreetSuggestions.SelectedItem.ToString();
                lbStreetSuggestions.Visible = false;
            }
        }

        private async void txtCity_TextChanged(object sender, EventArgs e)
        {
            string input = txtCity.Text;
            if (input.Length > 2)
            {
                var suggestions = await googlePlacesService.GetPlaceAutoComplete(input);
                lbCitySuggestions.Items.Clear();
                if (suggestions != null)
                {
                    lbCitySuggestions.Items.AddRange(suggestions.ToArray());
                    lbCitySuggestions.Visible = true;
                }
                else
                {
                    lbCitySuggestions.Visible = false;
                }
            }
        }

        private void lbCitySuggestions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbCitySuggestions.SelectedItem != null)
            {
                txtCity.Text = lbCitySuggestions.SelectedItem.ToString();
                lbCitySuggestions.Visible = false;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (!HomeInsuranceValidationInput())
            {
                return;
            }
            var homeInsuranceDetails = new HomeInsuranceDetails
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Id = txtId.Text,
                Street = txtStreet.Text,
                City = txtCity.Text,
                ApartmentType = cbApartmentType.SelectedItem.ToString(),
                StructureType = cbStructureType.SelectedItem.ToString(),
                Age = float.Parse(txtAge.Text),
                HomeSize = float.Parse(txtHomeSize.Text),
            };
            PolicyService policyService = new PolicyService();
            double price = policyService.CalculateHomeInsurancePolicy(homeInsuranceDetails);

            List<ValidationResult> results = new List<ValidationResult>();
            ValidationContext context = new ValidationContext(homeInsuranceDetails);

            bool isValid = Validator.TryValidateObject(homeInsuranceDetails, context, results, true);

            if (isValid)
            {
                MessageBox.Show("הנתונים תקינים ונשלחו בהצלחה.");
                FinishForm finishForm = new FinishForm();

                finishForm.DisplayResults($"עלות ביטוח הדירה הוא: {price}");

                finishForm.Show();
                this.Hide();
            }
            else
            {
                string errors = string.Join(Environment.NewLine, results.Select(r => r.ErrorMessage));
                MessageBox.Show($":אנא תקן את השגיאות הבאות\n{errors}", "שגיאות ולידציה", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool HomeInsuranceValidationInput()
        {
            List<string> validationErrors = new List<string>();

            if (string.IsNullOrWhiteSpace(txtStreet.Text))
            {
                validationErrors.Add("רחוב הוא שדה חובה.");
            }

            if (string.IsNullOrWhiteSpace(txtCity.Text))
            {
                validationErrors.Add("עיר היא שדה חובה.");
            }

            if (cbApartmentType.SelectedItem == null)
            {
                validationErrors.Add("סוג הדירה הוא שדה חובה.");
            }

            if (cbStructureType.SelectedItem == null)
            {
                validationErrors.Add("סוג המבנה הוא שדה חובה.");
            }

            if (validationErrors.Count > 0)
            {
                MessageBox.Show(string.Join("\n", validationErrors), "שגיאות ולידציה", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!float.TryParse(txtAge.Text, out float age))
            {
                MessageBox.Show("גיל חייב להיות מספר חוקי.", "שגיאות ולידציה", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!float.TryParse(txtHomeSize.Text, out float homeSize))
            {
                MessageBox.Show("גודל הדירה חייב להיות מספר חוקי.", "שגיאות ולידציה", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}