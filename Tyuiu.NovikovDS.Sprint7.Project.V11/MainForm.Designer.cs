namespace Tyuiu.NovikovDS.Sprint7.Project.V11
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            ButtonAboutMe_NDS = new Button();
            ButtonDomes_NDS = new Button();
            ButtonEmployee_NDS = new Button();
            SuspendLayout();
            // 
            // ButtonAboutMe_NDS
            // 
            ButtonAboutMe_NDS.BackColor = Color.MistyRose;
            ButtonAboutMe_NDS.Image = (Image)resources.GetObject("ButtonAboutMe_NDS.Image");
            ButtonAboutMe_NDS.Location = new Point(331, 427);
            ButtonAboutMe_NDS.Name = "ButtonAboutMe_NDS";
            ButtonAboutMe_NDS.Size = new Size(80, 79);
            ButtonAboutMe_NDS.TabIndex = 0;
            ButtonAboutMe_NDS.UseVisualStyleBackColor = false;
            ButtonAboutMe_NDS.Click += ButtonAboutMe_NDS_Click;
            // 
            // ButtonDomes_NDS
            // 
            ButtonDomes_NDS.Font = new Font("Segoe UI", 11F);
            ButtonDomes_NDS.ForeColor = SystemColors.MenuText;
            ButtonDomes_NDS.Image = (Image)resources.GetObject("ButtonDomes_NDS.Image");
            ButtonDomes_NDS.Location = new Point(140, 156);
            ButtonDomes_NDS.Name = "ButtonDomes_NDS";
            ButtonDomes_NDS.Size = new Size(150, 50);
            ButtonDomes_NDS.TabIndex = 1;
            ButtonDomes_NDS.Text = "Предприятия";
            ButtonDomes_NDS.UseVisualStyleBackColor = true;
            ButtonDomes_NDS.Click += ButtonDomes_NDS_Click;
            // 
            // ButtonEmployee_NDS
            // 
            ButtonEmployee_NDS.Font = new Font("Segoe UI", 11F);
            ButtonEmployee_NDS.ForeColor = SystemColors.MenuText;
            ButtonEmployee_NDS.Image = (Image)resources.GetObject("ButtonEmployee_NDS.Image");
            ButtonEmployee_NDS.Location = new Point(140, 233);
            ButtonEmployee_NDS.Name = "ButtonEmployee_NDS";
            ButtonEmployee_NDS.Size = new Size(150, 50);
            ButtonEmployee_NDS.TabIndex = 2;
            ButtonEmployee_NDS.Text = "Работники";
            ButtonEmployee_NDS.UseVisualStyleBackColor = true;
            ButtonEmployee_NDS.Click += ButtonEmployee_NDS_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(423, 518);
            Controls.Add(ButtonEmployee_NDS);
            Controls.Add(ButtonDomes_NDS);
            Controls.Add(ButtonAboutMe_NDS);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "Спринт 7 | Проект | РППб-24-1 | Новиков Д. С.";
            Load += MainForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button ButtonAboutMe_NDS;
        private Button ButtonDomes_NDS;
        private Button ButtonEmployee_NDS;
    }
}
