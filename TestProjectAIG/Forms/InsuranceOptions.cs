using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestProjectAIG.Views
{
    public partial class InsuranceOptions : Form
    {
        public InsuranceOptions()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (rbHomeInsurance.Checked)
            {
                HomeInsuranceForm homeInsuranceForm = new HomeInsuranceForm();
                homeInsuranceForm.Show();
                this.Hide();
            }
            else if (rbLifeInsurance.Checked)
            {
                LifeInsuranceForm lifeInsuranceForm = new LifeInsuranceForm();
                lifeInsuranceForm.Show();
                this.Hide();
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            StartForm form1 = new StartForm();
            form1.Show();
            this.Hide();
        }
    }
}