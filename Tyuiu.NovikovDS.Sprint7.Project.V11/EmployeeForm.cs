using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.NovikovDS.Sprint7.Project.V11.Lib;

namespace Tyuiu.NovikovDS.Sprint7.Project.V11
{
    public partial class EmployeeForm : Form
    {
        DataService ds = new DataService();

        string filePath = @"C:\Sprint5\Employee.csv";

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            ButtonLoadCsv_NDS_Click(sender, e); //загрузка файла
        }

        private void ButtonLoadCsv_NDS_Click(object sender, EventArgs e)
        {
            ImportCsvToDataGridView(filePath);
        }

        private void ImportCsvToDataGridView(string filePath)
        {
            DataTable dataTable = new DataTable();

            using (TextFieldParser parser = new TextFieldParser(filePath))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(";");

                // Чтение заголовков
                string[] headers = parser.ReadFields();
                foreach (string header in headers)
                {
                    dataTable.Columns.Add(header);
                }

                // Чтение строк
                while (!parser.EndOfData)
                {
                    string[] fields = parser.ReadFields();
                    dataTable.Rows.Add(fields);
                }
            }

            DataGridViewEmployee_NDS.DataSource = dataTable; // Установка источника данных для DataGridView
            DataGridViewEmployee_NDS.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        public EmployeeForm()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.FormClosing += new FormClosingEventHandler(EmployeeForm_FormClosing);
        }

        private void ButtonImportCsv_NDS_Click(object sender, EventArgs e)
        {
            // Open a file dialog to select the CSV file
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
            ImportCsvToDataGridView(filePath);
        }

        private void ButtonExportCsv_NDS_Click(object sender, EventArgs e)
        {
            // Create the CSV file
            using (StreamWriter sw = new StreamWriter(filePath, false, Encoding.UTF8))
            {
                // Write the header row
                for (int i = 0; i < DataGridViewEmployee_NDS.ColumnCount; i++)
                {
                    sw.Write(DataGridViewEmployee_NDS.Columns[i].HeaderText);
                    if (i < DataGridViewEmployee_NDS.ColumnCount - 1)
                    {
                        sw.Write(";");
                    }
                }
                sw.WriteLine();

                // Write the data rows
                foreach (DataGridViewRow row in DataGridViewEmployee_NDS.Rows)
                {
                    for (int i = 0; i < DataGridViewEmployee_NDS.ColumnCount; i++)
                    {
                        if (row.Cells[i].Value != null)
                        {
                            sw.Write(row.Cells[i].Value.ToString());
                        }
                        if (i < DataGridViewEmployee_NDS.ColumnCount - 1)
                        {
                            sw.Write(";");
                        }
                    }
                    sw.WriteLine();
                }
            }
        }

        private void ButtonDeleteRow_NDS_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in DataGridViewEmployee_NDS.SelectedRows)
            {
                DataGridViewEmployee_NDS.Rows.RemoveAt(row.Index);
            }
        }

        private void ButtonFind_NDS_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < DataGridViewEmployee_NDS.RowCount; i++)
            {
                DataGridViewEmployee_NDS.Rows[i].Selected = false;
                for (int j = 0; j < DataGridViewEmployee_NDS.ColumnCount; j++)
                    if (DataGridViewEmployee_NDS.Rows[i].Cells[j].Value != null)
                        if (DataGridViewEmployee_NDS.Rows[i].Cells[j].Value.ToString().Contains(TextBoxFind_NDS.Text))
                        {
                            DataGridViewEmployee_NDS.Rows[i].Selected = true;
                            break;
                        }
            }
        }

        public double[] GetRow(int row)
        {
            double[] array = new double[DataGridViewEmployee_NDS.Rows.Count];
            for (int i = 0; i < DataGridViewEmployee_NDS.Rows.Count; i++)
            {
                array[i] = DataGridViewEmployee_NDS.Rows[i].Cells[0].Value == null ? array[i - 1] : Convert.ToInt32(DataGridViewEmployee_NDS.Rows[i].Cells[row].Value);
                //второй, в конце Cells[1] - номер столбца
            }
            return array;
        }

        private void ButtonMiddleAge_NDS_Click(object sender, EventArgs e)
        {
            double[] matrix = GetRow(5);

            TextBoxResult_NDS.Text = ds.FindMiddleValue(matrix).ToString();
        }

        private void ButtonMaxAge_NDS_Click(object sender, EventArgs e)
        {
            double[] matrix = GetRow(5);

            TextBoxResult_NDS.Text = ds.FindMaxValue(matrix).ToString();
        }

        private void ButtonMiddleVozrast_NDS_Click(object sender, EventArgs e)
        {
            double[] matrix = GetRow(3);

            TextBoxResult_NDS.Text = ds.FindMiddleValue(matrix).ToString();
        }

        private void ButtonMinVozrast_NDS_Click(object sender, EventArgs e)
        {
            double[] matrix = GetRow(3);

            TextBoxResult_NDS.Text = ds.FindMinValue(matrix).ToString();
        }

        private void ButtonAddRow_NDS_Click(object sender, EventArgs e)
        {
            AddRowEmployee about = new();
            about.ShowDialog();

            DataTable dataTable = (DataTable)DataGridViewEmployee_NDS.DataSource;
            dataTable.Rows.Add(AddRowEmployee.Fam, AddRowEmployee.Imy, AddRowEmployee.Otc, AddRowEmployee.Age, AddRowEmployee.Dol, AddRowEmployee.Sta, AddRowEmployee.Edu);
        }

        private void ButtonGoBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm fmain = new MainForm();
            fmain.ShowDialog();
        }

        private void EmployeeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
