using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectAIG.Controllers
{
    public class ExcelController
    {
        /*public List<PersonalData> ImportDataFromExcel(string filePath)
        {
            List<PersonalData> personalDataList = new List<PersonalData>();
            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(filePath);
            Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Excel.Range xlRange = xlWorksheet.UsedRange;

            int rowCount = xlRange.Rows.Count;
            int colCount = xlRange.Columns.Count;

            for (int i = 1; i <= rowCount; i++)
            {
                PersonalData data = new PersonalData
                {
                    FirstName = xlRange.Cells[i, 1].Value2.ToString(),
                    LastName = xlRange.Cells[i, 2].Value2.ToString(),
                    ID = xlRange.Cells[i, 3].Value2.ToString(),
                    Gender = xlRange.Cells[i, 4].Value2.ToString()
                };
                personalDataList.Add(data);
            }

            xlWorkbook.Close();
            xlApp.Quit();
            return personalDataList;
        }*/
    }
}