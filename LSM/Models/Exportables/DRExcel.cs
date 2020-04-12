using OfficeOpenXml;
using Spire.Xls;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LSM.Models.Exportables
{
    class DRExcel
    {
        public String CustomerName { get; set; }
        public String CustomerAddress { get; set; }
        public String DRDate { get; set; }
        
        public DRExcel()
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
        }

        public void PrintUsingExcel() {

            Workbook workbook = new Workbook();
            var exPath = System.AppDomain.CurrentDomain.BaseDirectory + "DRTemplate.xlsx";
            Console.WriteLine(exPath);
            workbook.LoadFromFile(exPath);

            Worksheet sheet = workbook.Worksheets["DR"];
            sheet.Range["C1"].Text = CustomerName;
            sheet.Range["H1"].Text = DRDate;
            sheet.Range["C2"].Text = CustomerAddress;

            PrintDialog dialog = new PrintDialog();

            dialog.AllowPrintToFile = true;
            dialog.AllowCurrentPage = true;
            dialog.AllowSomePages = true;
            dialog.AllowSelection = true;
            dialog.UseEXDialog = true;

            dialog.PrinterSettings = workbook.PrintDocument.PrinterSettings;

            workbook.PrintDialog = dialog;
            PrintDocument pd = workbook.PrintDocument;


            if (dialog.ShowDialog() == DialogResult.OK)
            {
                pd.Print();
            }
        }

    }
}
