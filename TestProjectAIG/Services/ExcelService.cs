using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProjectAIG.Models;
using Microsoft.Office.Interop;
using Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
using System.Drawing.Design;
using System.Windows.Forms;
using System.IO;
using System.ComponentModel.DataAnnotations;
using Application = Microsoft.Office.Interop.Excel.Application;

namespace TestProjectAIG.Controllers
{
    public class ExcelService
    {
        public List<LifeInsuranceDetails> ImportDataFromExcel(string filePath)
        {
            Application xlApp = new Application();
            Workbook xlWorkbook = null;
            Worksheet xlWorksheet = null;
            Range xlRange = null;

            List<LifeInsuranceDetails> lifeInsuranceDataList = new List<LifeInsuranceDetails>();

            try
            {
                xlWorkbook = xlApp.Workbooks.Open(filePath);
                xlWorksheet = xlWorkbook.Sheets[1];
                xlRange = xlWorksheet.UsedRange;

                for (int row = 2; row <= xlRange.Rows.Count; row++)
                {
                    LifeInsuranceDetails lifeInsuranceData = new LifeInsuranceDetails()
                    {
                        FirstName = Convert.ToString((xlRange.Cells[row, 1] as Range).Value2),
                        LastName = Convert.ToString((xlRange.Cells[row, 2] as Range).Value2),
                        Id = Convert.ToString((xlRange.Cells[row, 3] as Range).Value2),
                        Gender = Convert.ToString((xlRange.Cells[row, 4] as Range).Value2),
                        Occupation = Convert.ToString((xlRange.Cells[row, 5] as Range).Value2),
                    };
                    string hobbiesString = Convert.ToString((xlRange.Cells[row, 6] as Range).Value2);
                    if (!string.IsNullOrWhiteSpace(hobbiesString))
                    {
                        lifeInsuranceData.Hobbies = hobbiesString.Split(',').ToList();
                    }

                    lifeInsuranceDataList.Add(lifeInsuranceData);
                }
            }
            finally
            {
                if (xlRange != null)
                    Marshal.ReleaseComObject(xlRange);
                if (xlWorksheet != null)
                    Marshal.ReleaseComObject(xlWorksheet);
                if (xlWorkbook != null)
                {
                    xlWorkbook.Close(false, Type.Missing, Type.Missing);
                    Marshal.ReleaseComObject(xlWorkbook);
                }
                xlApp.Quit();
                Marshal.ReleaseComObject(xlApp);
            }

            return lifeInsuranceDataList;
        }

        public void CalculatePolicyPrices(string filesPath, List<LifeInsuranceDetails> lifeInsuranceDetailsList)
        {
            Application excelApp = new Application();
            Workbook workbook = null;
            Worksheet worksheet = null;
            Range range = null;

            try
            {
                workbook = excelApp.Workbooks.Open(filesPath);
                worksheet = workbook.Sheets[1];
                range = worksheet.UsedRange;

                for (int row = 2; row <= range.Rows.Count; row++)
                {
                    LifeInsuranceDetails lifeInsuranceDetails = lifeInsuranceDetailsList[row - 2];
                    PolicyService policyService = new PolicyService();
                    lifeInsuranceDetails.Risk = policyService.LifeInsuranceCalculateRisk(lifeInsuranceDetails.Occupation, lifeInsuranceDetails.Hobbies);
                    double price = policyService.CalculateLifeInsurancePolicy(lifeInsuranceDetails);

                    if (lifeInsuranceDetails.Risk >= 0.75 || price < 0)
                    {
                        (range.Cells[row, 7] as Range).Value2 = -1;
                    }
                    else if (price >= 0)
                    {
                        (range.Cells[row, 7] as Range).Value2 = price;
                    }
                }

                workbook.Save();
            }
            finally
            {
                if (range != null)
                    Marshal.ReleaseComObject(range);
                if (worksheet != null)
                    Marshal.ReleaseComObject(worksheet);
                if (workbook != null)
                {
                    workbook.Close(false, Type.Missing, Type.Missing);
                    Marshal.ReleaseComObject(workbook);
                }
                excelApp.Quit();
                Marshal.ReleaseComObject(excelApp);
            }
        }

        public bool ExcelFileValidation(string filesPath)
        {
            bool result = true;
            if (!File.Exists(filesPath))
            {
                MessageBox.Show("קובץ האקסל לא נמצא.");
                return false;
            }
            string fileExtension = Path.GetExtension(filesPath).ToLower();
            if (fileExtension != ".xls" && fileExtension != ".xlsx")
            {
                MessageBox.Show("פורמט הקובץ אינו נתמך. יש להשתמש בקובץ בפורמט .xls או .xlsx.");
                return false;
            }
            return result;
        }
    }
}