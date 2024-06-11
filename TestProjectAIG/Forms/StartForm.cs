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
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (rbUI.Checked)
            {
                InsuranceOptions form2 = new InsuranceOptions();
                form2.Show();
                this.Hide();
            }
            else if (rbExcel.Checked)
            {
                /*OpenFileDialog openFileDialog = new OpenFileDialog();
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    ExcelController excelController = new ExcelController();
                    var data = excelController.ImportDataFromExcel(openFileDialog.FileName);
                    // Handle data
                }*/
            }
        }
    }
}