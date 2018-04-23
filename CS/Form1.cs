using System;
using System.Windows.Forms;

using System.Diagnostics;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports.UI;
// ...

namespace ExportToRtfCS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // A path to export a report.
            string reportPath = "c:\\Test.rtf";

            // Create a report instance.
            XtraReport1 report = new XtraReport1();

            // Export the report to RTF.
            report.ExportToRtf(reportPath);

            // Show the result.
            StartProcess(reportPath);
        }

        // Use this method if you want to automaically open
        // the created RTF file in the default program.
        public void StartProcess(string path)
        {
            Process process = new Process();
            try
            {
                process.StartInfo.FileName = path;
                process.Start();
                process.WaitForInputIdle();
            }
            catch { }
        }
    }
}