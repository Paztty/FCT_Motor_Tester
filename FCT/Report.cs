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

namespace FCT
{
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
            comboBoxModel.Items.Clear();
            ReportList.Clear();
            DateTime startFilterTime = DateTime.Now;
            DateTime endFilterTime = DateTime.Now;
            while (DateTime.Compare(endFilterTime, startFilterTime) >= 0)
            {
                string folderReport = @"C:\DaeyoungVN\FCT\History\" + startFilterTime.ToString("yyyy") + "\\" + startFilterTime.ToString("MMMM") + "\\" + startFilterTime.ToString("dd") + "\\";
                if (Directory.Exists(folderReport))
                {
                    string[] fileReport = Directory.GetFiles(folderReport, "*.txt");
                    for (int i = 0; i < fileReport.Length; i++)
                    {
                        ReportList.Add(fileReport[i]);
                        string fileName = Path.GetFileNameWithoutExtension(fileReport[i]);
                        comboBoxModel.Items.Add(fileName);
                    }
                }
                startFilterTime = startFilterTime.AddDays(1);
            }
            if (comboBoxModel.Items.Count > 0)
            {
                comboBoxModel.SelectedIndex = 0;
            }
            
        }

        public DateTime startTime;
        public DateTime endTime;
        List<string> ReportList = new List<string>();

        private void dateTimePickerEnd_ValueChanged(object sender, EventArgs e)
        {
            ReportList.Clear();
            comboBoxModel.Items.Clear();
            DateTime startFilterTime = dateTimePickerStart.Value;
            DateTime endFilterTime = dateTimePickerEnd.Value;
            while (DateTime.Compare(endFilterTime, startFilterTime) >= 0)
            {
                string folderReport = @"C:\DaeyoungVN\FCT\History\" + startFilterTime.ToString("yyyy") + "\\" + startFilterTime.ToString("MMMM") + "\\" + startFilterTime.ToString("dd") + "\\";
                if (Directory.Exists(folderReport))
                {
                    string[] fileReport = Directory.GetFiles(folderReport, "*.txt");
                    for (int i = 0; i < fileReport.Length; i++)
                    {
                        ReportList.Add(fileReport[i]);
                        string fileName = Path.GetFileNameWithoutExtension(fileReport[i]);
                        comboBoxModel.Items.Add(fileName);

                    }
                }
                startFilterTime = startFilterTime.AddDays(1);
            }
        }

        private void Report_Load(object sender, EventArgs e)
        {

        }

        private void btApply_Click(object sender, EventArgs e)
        {
            List<reportColumn> reportColumns = new List<reportColumn>();
            List<string[]> contentReport = new List<string[]>();

            for (int i = 0; i < ReportList.Count; i++)
            {
                string fileName = Path.GetFileNameWithoutExtension(ReportList[i]);
                if (fileName == comboBoxModel.Text)
                {
                    contentReport.Add(File.ReadAllLines(ReportList[i]));
                }
            }

            for (int fileCount = 0; fileCount < contentReport.Count; fileCount++)
            {
                string[] columns = contentReport[fileCount][0].Split('/');
                for (int i = 0; i < columns.Length; i++)
                {
                    Console.Write(columns[i] + " ");
                    if (i >= reportColumns.Count)
                    {
                        reportColumns.Add(new reportColumn(columns[i]));
                        for (int valueCount = 1; valueCount < contentReport[fileCount].Length; valueCount++)
                        {
                            reportColumns[i].ColumnValues.Add(contentReport[fileCount][valueCount].Split('/')[i]);
                        }
                    }
                    else
                    {
                        bool exitted = false;
                        for (int position = i; position < reportColumns.Count; position++)
                        {
                            if (columns[i] == reportColumns[position].ColumnHeader)
                            {
                                for (int valueCount = 1; valueCount < contentReport[fileCount].Length; valueCount++)
                                {
                                    reportColumns[position].ColumnValues.Add(contentReport[fileCount][valueCount].Split('/')[i]);
                                }
                                exitted = true;
                                break;
                            }
                            else
                            {

                            }
                        }
                        if (!exitted)
                        {
                            reportColumns.Insert(i, new reportColumn(columns[i]));
                            if (i > 0)
                            {
                                int indexStart = reportColumns[0].ColumnValues.Count - contentReport[fileCount].Length + 1;
                                for (int valueCount = 1; valueCount <= indexStart; valueCount++)
                                {
                                    reportColumns[i].ColumnValues.Add(" ");
                                }

                                for (int valueCount = 1; valueCount < contentReport[fileCount].Length; valueCount++)
                                {
                                    reportColumns[i].ColumnValues.Add(contentReport[fileCount][valueCount].Split('/')[i]);
                                    //reportColumns[i + 1].ColumnValues.Add(" ");
                                }
                            }
                        }
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            for (int i = 0; i < reportColumns.Count; i++)
            {
                Console.Write(reportColumns[i].ColumnHeader + " ");
            }
            Console.WriteLine();

            for (int j = 0; j < reportColumns[0].ColumnValues.Count; j++)
            {
                for (int i = 0; i < reportColumns.Count; i++)
                {
                    try
                    {
                        Console.Write(reportColumns[i].ColumnValues[j] + " ");
                    }
                    catch (Exception)
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();


            dataGridViewReport.Rows.Clear();
            dataGridViewReport.Columns.Clear();
            for (int i = 0; i < reportColumns.Count; i++)
            {
                dataGridViewReport.Columns.Add(reportColumns[i].ColumnHeader, reportColumns[i].ColumnHeader);
                for (int j = 0; j < reportColumns[i].ColumnValues.Count ; j++)
                {
                    if (i == 0)
                    {
                        dataGridViewReport.Rows.Add();
                    }
                    else
                    {
                        try
                        {
                            dataGridViewReport[i, j].Value = reportColumns[i].ColumnValues[j];
                        }
                        catch (Exception)
                        {
                            Console.WriteLine(reportColumns[i].ColumnValues[j]);
                            Console.WriteLine("data grid view [{0},{1}], report columns[{2},{3}]", i, j, i, j);
                           // throw;
                        }
                        
                    }
                }
            }
            for (int i = 0; i < dataGridViewReport.RowCount; i++)
            {
                dataGridViewReport[0, i].Value = i + 1;
            }
            dataGridViewReport.Refresh();
        }

        private void dateTimePickerStart_ValueChanged(object sender, EventArgs e)
        {
            ReportList.Clear();
            comboBoxModel.Items.Clear();
            DateTime startFilterTime = dateTimePickerStart.Value;
            DateTime endFilterTime = dateTimePickerEnd.Value;
            while (DateTime.Compare(endFilterTime, startFilterTime) >= 0)
            {
                string folderReport = @"C:\DaeyoungVN\FCT\History\" + startFilterTime.ToString("yyyy") + "\\" + startFilterTime.ToString("MMMM") + "\\" + startFilterTime.ToString("dd") + "\\";
                if (Directory.Exists(folderReport))
                {
                    string[] fileReport = Directory.GetFiles(folderReport, "*.txt");
                    for (int i = 0; i < fileReport.Length; i++)
                    {
                        ReportList.Add(fileReport[i]);
                        string fileName = Path.GetFileNameWithoutExtension(fileReport[i]);
                        comboBoxModel.Items.Add(fileName);

                    }
                }
                startFilterTime = startFilterTime.AddDays(1);
            }
        }
    }

    public class reportColumn
    {
        public string ColumnHeader = "";
        public List<string> ColumnValues = new List<string>();
        public reportColumn(string ColumnHeader)
        {
            this.ColumnHeader = ColumnHeader;
        }

    }

}
