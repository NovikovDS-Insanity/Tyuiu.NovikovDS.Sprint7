
namespace Tyuiu.NovikovDS.Sprint7.Project.V11
{
    partial class EmployeeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeForm));
            ButtonLoadCsv_NDS = new Button();
            DataGridViewEmployee_NDS = new DataGridView();
            ButtonGoBack_NDS = new Button();
            ButtonExportCsv_NDS = new Button();
            ButtonDeleteRow_NDS = new Button();
            TextBoxFind_NDS = new TextBox();
            ButtonFind_NDS = new Button();
            TextBoxResult_NDS = new TextBox();
            ButtonMiddleAge_NDS = new Button();
            ButtonMiddleVozrast_NDS = new Button();
            ButtonMaxAge_NDS = new Button();
            ButtonMinVozrast_NDS = new Button();
            ButtonAddRow_NDS = new Button();
            ((System.ComponentModel.ISupportInitialize)DataGridViewEmployee_NDS).BeginInit();
            SuspendLayout();
            // 
            // ButtonLoadCsv_NDS
            // 
            ButtonLoadCsv_NDS.Image = (Image)resources.GetObject("ButtonLoadCsv_NDS.Image");
            ButtonLoadCsv_NDS.Location = new Point(585, 387);
            ButtonLoadCsv_NDS.Name = "ButtonLoadCsv_NDS";
            ButtonLoadCsv_NDS.Size = new Size(10, 10);
            ButtonLoadCsv_NDS.TabIndex = 0;
            ButtonLoadCsv_NDS.UseVisualStyleBackColor = true;
            ButtonLoadCsv_NDS.Click += ButtonLoadCsv_NDS_Click;
            // 
            // DataGridViewEmployee_NDS
            // 
            DataGridViewEmployee_NDS.AllowUserToAddRows = false;
            DataGridViewEmployee_NDS.AllowUserToDeleteRows = false;
            DataGridViewEmployee_NDS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewEmployee_NDS.Location = new Point(12, 12);
            DataGridViewEmployee_NDS.Name = "DataGridViewEmployee_NDS";
            DataGridViewEmployee_NDS.ReadOnly = true;
            DataGridViewEmployee_NDS.Size = new Size(692, 257);
            DataGridViewEmployee_NDS.TabIndex = 1;
            // 
            // ButtonGoBack_NDS
            // 
            ButtonGoBack_NDS.BackColor = SystemColors.Control;
            ButtonGoBack_NDS.Image = (Image)resources.GetObject("ButtonGoBack_NDS.Image");
            ButtonGoBack_NDS.Location = new Point(336, 275);
            ButtonGoBack_NDS.Name = "ButtonGoBack_NDS";
            ButtonGoBack_NDS.Size = new Size(50, 49);
            ButtonGoBack_NDS.TabIndex = 2;
            ButtonGoBack_NDS.UseVisualStyleBackColor = false;
            ButtonGoBack_NDS.Click += ButtonGoBack_NDS_Click;
            // 
            // ButtonExportCsv_NDS
            // 
            ButtonExportCsv_NDS.Image = (Image)resources.GetObject("ButtonExportCsv_NDS.Image");
            ButtonExportCsv_NDS.Location = new Point(487, 275);
            ButtonExportCsv_NDS.Name = "ButtonExportCsv_NDS";
            ButtonExportCsv_NDS.Size = new Size(108, 49);
            ButtonExportCsv_NDS.TabIndex = 3;
            ButtonExportCsv_NDS.Text = "Сохранить таблицу";
            ButtonExportCsv_NDS.UseVisualStyleBackColor = true;
            ButtonExportCsv_NDS.Click += ButtonExportCsv_NDS_Click;
            // 
            // ButtonDeleteRow_NDS
            // 
            ButtonDeleteRow_NDS.Image = (Image)resources.GetObject("ButtonDeleteRow_NDS.Image");
            ButtonDeleteRow_NDS.Location = new Point(601, 275);
            ButtonDeleteRow_NDS.Name = "ButtonDeleteRow_NDS";
            ButtonDeleteRow_NDS.Size = new Size(103, 49);
            ButtonDeleteRow_NDS.TabIndex = 4;
            ButtonDeleteRow_NDS.Text = "Удалить строку";
            ButtonDeleteRow_NDS.UseVisualStyleBackColor = true;
            ButtonDeleteRow_NDS.Click += ButtonDeleteRow_NDS_Click;
            // 
            // TextBoxFind_NDS
            // 
            TextBoxFind_NDS.Location = new Point(601, 387);
            TextBoxFind_NDS.Name = "TextBoxFind_NDS";
            TextBoxFind_NDS.Size = new Size(103, 23);
            TextBoxFind_NDS.TabIndex = 5;
            // 
            // ButtonFind_NDS
            // 
            ButtonFind_NDS.Image = (Image)resources.GetObject("ButtonFind_NDS.Image");
            ButtonFind_NDS.Location = new Point(601, 332);
            ButtonFind_NDS.Name = "ButtonFind_NDS";
            ButtonFind_NDS.Size = new Size(103, 49);
            ButtonFind_NDS.TabIndex = 6;
            ButtonFind_NDS.Text = "Найти";
            ButtonFind_NDS.UseVisualStyleBackColor = true;
            ButtonFind_NDS.Click += ButtonFind_NDS_Click;
            // 
            // TextBoxResult_NDS
            // 
            TextBoxResult_NDS.Location = new Point(12, 387);
            TextBoxResult_NDS.Name = "TextBoxResult_NDS";
            TextBoxResult_NDS.ReadOnly = true;
            TextBoxResult_NDS.Size = new Size(100, 23);
            TextBoxResult_NDS.TabIndex = 7;
            // 
            // ButtonMiddleAge_NDS
            // 
            ButtonMiddleAge_NDS.Image = (Image)resources.GetObject("ButtonMiddleAge_NDS.Image");
            ButtonMiddleAge_NDS.Location = new Point(12, 329);
            ButtonMiddleAge_NDS.Name = "ButtonMiddleAge_NDS";
            ButtonMiddleAge_NDS.Size = new Size(108, 48);
            ButtonMiddleAge_NDS.TabIndex = 8;
            ButtonMiddleAge_NDS.Text = "Средний стаж";
            ButtonMiddleAge_NDS.UseVisualStyleBackColor = true;
            ButtonMiddleAge_NDS.Click += ButtonMiddleAge_NDS_Click;
            // 
            // ButtonMiddleVozrast_NDS
            // 
            ButtonMiddleVozrast_NDS.Image = (Image)resources.GetObject("ButtonMiddleVozrast_NDS.Image");
            ButtonMiddleVozrast_NDS.Location = new Point(126, 329);
            ButtonMiddleVozrast_NDS.Name = "ButtonMiddleVozrast_NDS";
            ButtonMiddleVozrast_NDS.Size = new Size(108, 48);
            ButtonMiddleVozrast_NDS.TabIndex = 9;
            ButtonMiddleVozrast_NDS.Text = "Средний возраст";
            ButtonMiddleVozrast_NDS.UseVisualStyleBackColor = true;
            ButtonMiddleVozrast_NDS.Click += ButtonMiddleVozrast_NDS_Click;
            // 
            // ButtonMaxAge_NDS
            // 
            ButtonMaxAge_NDS.Image = (Image)resources.GetObject("ButtonMaxAge_NDS.Image");
            ButtonMaxAge_NDS.Location = new Point(12, 275);
            ButtonMaxAge_NDS.Name = "ButtonMaxAge_NDS";
            ButtonMaxAge_NDS.Size = new Size(108, 48);
            ButtonMaxAge_NDS.TabIndex = 10;
            ButtonMaxAge_NDS.Text = "Максимальный стаж";
            ButtonMaxAge_NDS.UseVisualStyleBackColor = true;
            ButtonMaxAge_NDS.Click += ButtonMaxAge_NDS_Click;
            // 
            // ButtonMinVozrast_NDS
            // 
            ButtonMinVozrast_NDS.Image = (Image)resources.GetObject("ButtonMinVozrast_NDS.Image");
            ButtonMinVozrast_NDS.Location = new Point(126, 275);
            ButtonMinVozrast_NDS.Name = "ButtonMinVozrast_NDS";
            ButtonMinVozrast_NDS.Size = new Size(108, 49);
            ButtonMinVozrast_NDS.TabIndex = 11;
            ButtonMinVozrast_NDS.Text = "Минимальный возраст";
            ButtonMinVozrast_NDS.UseVisualStyleBackColor = true;
            ButtonMinVozrast_NDS.Click += ButtonMinVozrast_NDS_Click;
            // 
            // ButtonAddRow_NDS
            // 
            ButtonAddRow_NDS.Image = (Image)resources.GetObject("ButtonAddRow_NDS.Image");
            ButtonAddRow_NDS.Location = new Point(487, 332);
            ButtonAddRow_NDS.Name = "ButtonAddRow_NDS";
            ButtonAddRow_NDS.Size = new Size(108, 49);
            ButtonAddRow_NDS.TabIndex = 12;
            ButtonAddRow_NDS.Text = "Добавить строку";
            ButtonAddRow_NDS.UseVisualStyleBackColor = true;
            ButtonAddRow_NDS.Click += ButtonAddRow_NDS_Click;
            // 
            // EmployeeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(717, 418);
            Controls.Add(ButtonAddRow_NDS);
            Controls.Add(ButtonMinVozrast_NDS);
            Controls.Add(ButtonMaxAge_NDS);
            Controls.Add(ButtonMiddleVozrast_NDS);
            Controls.Add(ButtonMiddleAge_NDS);
            Controls.Add(TextBoxResult_NDS);
            Controls.Add(ButtonFind_NDS);
            Controls.Add(TextBoxFind_NDS);
            Controls.Add(ButtonDeleteRow_NDS);
            Controls.Add(ButtonExportCsv_NDS);
            Controls.Add(ButtonGoBack_NDS);
            Controls.Add(DataGridViewEmployee_NDS);
            Controls.Add(ButtonLoadCsv_NDS);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "EmployeeForm";
            Text = "Сотрудники";
            Load += EmployeeForm_Load;
            ((System.ComponentModel.ISupportInitialize)DataGridViewEmployee_NDS).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void ButtonGoBack_NDS_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm fmain = new MainForm();
            fmain.ShowDialog();
        }

        #endregion

        private Button ButtonLoadCsv_NDS;
        private DataGridView DataGridViewEmployee_NDS;
        private Button ButtonGoBack_NDS;
        private Button ButtonExportCsv_NDS;
        private Button ButtonDeleteRow_NDS;
        private TextBox TextBoxFind_NDS;
        private Button ButtonFind_NDS;
        private TextBox TextBoxResult_NDS;
        private Button ButtonMiddleAge_NDS;
        private Button ButtonMiddleVozrast_NDS;
        private Button ButtonMaxAge_NDS;
        private Button ButtonMinVozrast_NDS;
        private Button ButtonAddRow_NDS;
    }
}