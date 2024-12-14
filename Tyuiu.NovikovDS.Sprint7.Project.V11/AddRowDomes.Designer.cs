namespace Tyuiu.NovikovDS.Sprint7.Project.V11
{
    partial class AddRowDomes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddRowDomes));
            ButtonAddRow_NDS = new Button();
            TextBoxFondG_NDS = new TextBox();
            TextBoxFondGVvod_NDS = new TextBox();
            TextBoxFondM_NDS = new TextBox();
            TextBoxFondMVvod_NDS = new TextBox();
            TextBoxKol_NDS = new TextBox();
            TextBoxKolVvod_NDS = new TextBox();
            TextBoxPod_NDS = new TextBox();
            TextBoxPodVvod_NDS = new TextBox();
            SuspendLayout();
            // 
            // ButtonAddRow_NDS
            // 
            ButtonAddRow_NDS.BackgroundImage = (Image)resources.GetObject("ButtonAddRow_NDS.BackgroundImage");
            ButtonAddRow_NDS.Font = new Font("Segoe UI", 11F);
            ButtonAddRow_NDS.Location = new Point(285, 53);
            ButtonAddRow_NDS.Name = "ButtonAddRow_NDS";
            ButtonAddRow_NDS.Size = new Size(110, 43);
            ButtonAddRow_NDS.TabIndex = 29;
            ButtonAddRow_NDS.Text = "Добавить";
            ButtonAddRow_NDS.UseVisualStyleBackColor = true;
            ButtonAddRow_NDS.Click += ButtonAddRow_NDS_Click_1;
            // 
            // TextBoxFondG_NDS
            // 
            TextBoxFondG_NDS.Font = new Font("Segoe UI", 10F);
            TextBoxFondG_NDS.Location = new Point(151, 81);
            TextBoxFondG_NDS.Name = "TextBoxFondG_NDS";
            TextBoxFondG_NDS.ReadOnly = true;
            TextBoxFondG_NDS.Size = new Size(128, 25);
            TextBoxFondG_NDS.TabIndex = 28;
            TextBoxFondG_NDS.Text = "Фонд в год";
            // 
            // TextBoxFondGVvod_NDS
            // 
            TextBoxFondGVvod_NDS.Location = new Point(151, 110);
            TextBoxFondGVvod_NDS.Name = "TextBoxFondGVvod_NDS";
            TextBoxFondGVvod_NDS.Size = new Size(128, 23);
            TextBoxFondGVvod_NDS.TabIndex = 27;
            // 
            // TextBoxFondM_NDS
            // 
            TextBoxFondM_NDS.Font = new Font("Segoe UI", 10F);
            TextBoxFondM_NDS.Location = new Point(12, 81);
            TextBoxFondM_NDS.Name = "TextBoxFondM_NDS";
            TextBoxFondM_NDS.ReadOnly = true;
            TextBoxFondM_NDS.Size = new Size(128, 25);
            TextBoxFondM_NDS.TabIndex = 26;
            TextBoxFondM_NDS.Text = "Фонд в месяц";
            // 
            // TextBoxFondMVvod_NDS
            // 
            TextBoxFondMVvod_NDS.Location = new Point(12, 110);
            TextBoxFondMVvod_NDS.Name = "TextBoxFondMVvod_NDS";
            TextBoxFondMVvod_NDS.Size = new Size(128, 23);
            TextBoxFondMVvod_NDS.TabIndex = 25;
            // 
            // TextBoxKol_NDS
            // 
            TextBoxKol_NDS.Font = new Font("Segoe UI", 10F);
            TextBoxKol_NDS.Location = new Point(151, 12);
            TextBoxKol_NDS.Name = "TextBoxKol_NDS";
            TextBoxKol_NDS.ReadOnly = true;
            TextBoxKol_NDS.Size = new Size(128, 25);
            TextBoxKol_NDS.TabIndex = 24;
            TextBoxKol_NDS.Text = "Кол-во работников";
            // 
            // TextBoxKolVvod_NDS
            // 
            TextBoxKolVvod_NDS.Location = new Point(151, 41);
            TextBoxKolVvod_NDS.Name = "TextBoxKolVvod_NDS";
            TextBoxKolVvod_NDS.Size = new Size(128, 23);
            TextBoxKolVvod_NDS.TabIndex = 23;
            // 
            // TextBoxPod_NDS
            // 
            TextBoxPod_NDS.Font = new Font("Segoe UI", 10F);
            TextBoxPod_NDS.Location = new Point(12, 12);
            TextBoxPod_NDS.Name = "TextBoxPod_NDS";
            TextBoxPod_NDS.ReadOnly = true;
            TextBoxPod_NDS.Size = new Size(128, 25);
            TextBoxPod_NDS.TabIndex = 22;
            TextBoxPod_NDS.Text = "Подразделение";
            // 
            // TextBoxPodVvod_NDS
            // 
            TextBoxPodVvod_NDS.Location = new Point(12, 41);
            TextBoxPodVvod_NDS.Name = "TextBoxPodVvod_NDS";
            TextBoxPodVvod_NDS.Size = new Size(128, 23);
            TextBoxPodVvod_NDS.TabIndex = 21;
            // 
            // AddRowDomes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(405, 145);
            Controls.Add(ButtonAddRow_NDS);
            Controls.Add(TextBoxFondG_NDS);
            Controls.Add(TextBoxFondGVvod_NDS);
            Controls.Add(TextBoxFondM_NDS);
            Controls.Add(TextBoxFondMVvod_NDS);
            Controls.Add(TextBoxKol_NDS);
            Controls.Add(TextBoxKolVvod_NDS);
            Controls.Add(TextBoxPod_NDS);
            Controls.Add(TextBoxPodVvod_NDS);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddRowDomes";
            Text = "Добавление предприятия";
            Load += AddRowDomes_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ButtonAddRow_NDS;
        private TextBox TextBoxFondG_NDS;
        private TextBox TextBoxFondGVvod_NDS;
        private TextBox TextBoxFondM_NDS;
        private TextBox TextBoxFondMVvod_NDS;
        private TextBox TextBoxKol_NDS;
        private TextBox TextBoxKolVvod_NDS;
        private TextBox TextBoxPod_NDS;
        private TextBox TextBoxPodVvod_NDS;
    }
}