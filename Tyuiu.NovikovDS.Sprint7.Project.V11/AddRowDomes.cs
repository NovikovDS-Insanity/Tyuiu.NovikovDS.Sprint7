using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Tyuiu.NovikovDS.Sprint7.Project.V11
{
    public partial class AddRowDomes : Form
    {
        public static string Pod, Kol, FondM, FondG;

        public AddRowDomes()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void ButtonAddRow_NDS_Click(object sender, EventArgs e)
        {
            Pod = TextBoxPodVvod_NDS.Text;
            Kol = TextBoxKolVvod_NDS.Text;
            FondM = TextBoxFondMVvod_NDS.Text;
            FondG = TextBoxFondGVvod_NDS.Text;

            this.Close();
        }

        private void AddRowDomes_Load(object sender, EventArgs e)
        {

        }

        private void ButtonAddRow_NDS_Click_1(object sender, EventArgs e)
        {
            Pod = TextBoxPodVvod_NDS.Text;
            Kol = TextBoxKolVvod_NDS.Text;
            FondM = TextBoxFondMVvod_NDS.Text;
            FondG = TextBoxFondGVvod_NDS.Text;

            this.Close();
        }
    }
}
