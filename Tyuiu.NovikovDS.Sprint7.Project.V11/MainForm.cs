namespace Tyuiu.NovikovDS.Sprint7.Project.V11
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void ButtonAboutMe_NDS_Click(object sender, EventArgs e)
        {
            AboutIt about = new();
            about.ShowDialog();
        }

        private void ButtonDomes_NDS_Click(object sender, EventArgs e)
        {
            this.Hide();
            DomesForm dom = new();
            dom.ShowDialog();
        }

        private void ButtonEmployee_NDS_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeeForm emp = new();
            emp.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        
    }
}
