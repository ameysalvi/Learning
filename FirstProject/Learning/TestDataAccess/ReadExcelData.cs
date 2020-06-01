using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using excel = Microsoft.Office.Interop.Excel;

namespace Learning.TestDataAccess
{
    public class ReadExcelData
    {
        public string Key { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Sex { get; set; }
        public string Exp { get; set; }
        public string Date { get; set; }
        public string Profession { get; set; }
        public string Photo { get; set; }
        public string Tools { get; set; }
        public string Continents { get; set; }
        public string Commonds { get; set; }

        //[Test]

        //public void ExcelData()
        //{
        //    excel.Application xlApp = new excel.Application();
        //    excel.Workbook xlWorkbook = xlApp.Workbooks.Open(@"C:\Automation\Learning\Learning\Learning\TestData.xlsx");
        //    excel.Worksheet xlWorksheet = xlWorkbook.Sheets[1];
        //    excel.Range xlRange = xlWorksheet.UsedRange;

        //    int rowCount = xlRange.Rows.Count;
        //    int colCount = xlRange.Columns.Count;
        //    Console.WriteLine(rowCount);
        //    Console.WriteLine(colCount);
        //}
        
    }
}
        


