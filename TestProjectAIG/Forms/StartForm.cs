using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestProjectAIG.Controllers;
using TestProjectAIG.Models;

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
                ExcelService excelService = new ExcelService();
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Excel Files|*.xls;*.xlsx";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    if (!excelService.ExcelFileValidation(filePath))
                    {
                        return;
                    }
                    else
                    {
                        var data = excelService.ImportDataFromExcel(filePath);
                        excelService.CalculatePolicyPrices(filePath, data);
                    }
                }
            }
        }
    }
}