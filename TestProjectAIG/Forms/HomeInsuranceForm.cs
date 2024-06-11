using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestProjectAIG.Services;

namespace TestProjectAIG.Views
{
    public partial class HomeInsuranceForm : Form
    {
        private GooglePlacesService googlePlacesService;

        public HomeInsuranceForm()
        {
            InitializeComponent();
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
            // Continue to the next form or process the address
            string street = txtStreet.Text;
            string city = txtCity.Text;
            // Handle the address
            FinishForm form5 = new FinishForm();
            form5.Show();
            this.Hide();
        }
    }
}