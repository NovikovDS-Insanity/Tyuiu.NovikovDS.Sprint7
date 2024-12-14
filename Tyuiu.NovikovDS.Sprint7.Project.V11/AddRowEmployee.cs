using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.NovikovDS.Sprint7.Project.V11
{
    public partial class AddRowEmployee : Form
    {
        public static string Fam, Imy, Otc, Age, Dol, Sta, Edu;

        public AddRowEmployee()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void AddRowEmployee_Load(object sender, EventArgs e)
        {

        }

        private void ButtonAddRow_NDS_Click(object sender, EventArgs e)
        {
            Fam = TextBoxFamVvod_NDS.Text;
            Imy = TextBoxImyaVvod_NDS.Text;
            Otc = TextBoxOtchestvoVvod_NDS.Text;
            Age = TextBoxAgeVvod_NDS.Text;
            Dol = TextBoxDolgVvod_NDS.Text;
            Sta = TextBoxStazVvod_NDS.Text;
            Edu = TextBoxEducVvod_NDS.Text;

            this.Close();
        }

        private void AddRowEmployee_Load_1(object sender, EventArgs e)
        {

        }
    }
}
