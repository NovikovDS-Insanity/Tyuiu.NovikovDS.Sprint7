namespace Tyuiu.NovikovDS.Sprint7.Project.V11
{
    partial class AboutIt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutIt));
            pictureBox1 = new PictureBox();
            StrokaDva_NDS = new TextBox();
            StrokaTri_NDS = new TextBox();
            StrokaChetire_NDS = new TextBox();
            StrokaPyat_NDS = new TextBox();
            StrokaOdin_NDS = new TextBox();
            StrokaShest_NDS = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 200);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // StrokaDva_NDS
            // 
            StrokaDva_NDS.BorderStyle = BorderStyle.None;
            StrokaDva_NDS.Font = new Font("Segoe UI", 11F);
            StrokaDva_NDS.Location = new Point(168, 38);
            StrokaDva_NDS.Name = "StrokaDva_NDS";
            StrokaDva_NDS.ReadOnly = true;
            StrokaDva_NDS.Size = new Size(308, 20);
            StrokaDva_NDS.TabIndex = 2;
            StrokaDva_NDS.TabStop = false;
            StrokaDva_NDS.Text = "Разработчик: Новиков Д. С.";
            // 
            // StrokaTri_NDS
            // 
            StrokaTri_NDS.BorderStyle = BorderStyle.None;
            StrokaTri_NDS.Font = new Font("Segoe UI", 11F);
            StrokaTri_NDS.Location = new Point(168, 64);
            StrokaTri_NDS.Name = "StrokaTri_NDS";
            StrokaTri_NDS.ReadOnly = true;
            StrokaTri_NDS.Size = new Size(308, 20);
            StrokaTri_NDS.TabIndex = 3;
            StrokaTri_NDS.TabStop = false;
            StrokaTri_NDS.Text = "группа РППб-24-1";
            // 
            // StrokaChetire_NDS
            // 
            StrokaChetire_NDS.BorderStyle = BorderStyle.None;
            StrokaChetire_NDS.Font = new Font("Segoe UI", 11F);
            StrokaChetire_NDS.Location = new Point(168, 114);
            StrokaChetire_NDS.Name = "StrokaChetire_NDS";
            StrokaChetire_NDS.ReadOnly = true;
            StrokaChetire_NDS.Size = new Size(308, 20);
            StrokaChetire_NDS.TabIndex = 4;
            StrokaChetire_NDS.TabStop = false;
            StrokaChetire_NDS.Text = "Тюменский индустриальный университет ";
            // 
            // StrokaPyat_NDS
            // 
            StrokaPyat_NDS.BorderStyle = BorderStyle.None;
            StrokaPyat_NDS.Font = new Font("Segoe UI", 11F);
            StrokaPyat_NDS.Location = new Point(168, 140);
            StrokaPyat_NDS.Name = "StrokaPyat_NDS";
            StrokaPyat_NDS.ReadOnly = true;
            StrokaPyat_NDS.Size = new Size(308, 20);
            StrokaPyat_NDS.TabIndex = 5;
            StrokaPyat_NDS.TabStop = false;
            StrokaPyat_NDS.Text = "Высшая школа цифровых технологий";
            // 
            // StrokaOdin_NDS
            // 
            StrokaOdin_NDS.BorderStyle = BorderStyle.None;
            StrokaOdin_NDS.Font = new Font("Segoe UI", 11F);
            StrokaOdin_NDS.Location = new Point(168, 12);
            StrokaOdin_NDS.Name = "StrokaOdin_NDS";
            StrokaOdin_NDS.ReadOnly = true;
            StrokaOdin_NDS.Size = new Size(308, 20);
            StrokaOdin_NDS.TabIndex = 6;
            StrokaOdin_NDS.TabStop = false;
            StrokaOdin_NDS.Text = "Программа создана на коленке";
            // 
            // StrokaShest_NDS
            // 
            StrokaShest_NDS.BorderStyle = BorderStyle.None;
            StrokaShest_NDS.Font = new Font("Segoe UI", 11F);
            StrokaShest_NDS.Location = new Point(168, 178);
            StrokaShest_NDS.Name = "StrokaShest_NDS";
            StrokaShest_NDS.ReadOnly = true;
            StrokaShest_NDS.Size = new Size(308, 20);
            StrokaShest_NDS.TabIndex = 7;
            StrokaShest_NDS.TabStop = false;
            StrokaShest_NDS.Text = "Внутреннее имя: Project.V11";
            // 
            // AboutIt
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            CausesValidation = false;
            ClientSize = new Size(503, 228);
            Controls.Add(StrokaShest_NDS);
            Controls.Add(StrokaOdin_NDS);
            Controls.Add(StrokaPyat_NDS);
            Controls.Add(StrokaChetire_NDS);
            Controls.Add(StrokaTri_NDS);
            Controls.Add(StrokaDva_NDS);
            Controls.Add(pictureBox1);
            Font = new Font("Segoe UI", 9F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AboutIt";
            Text = "О программе";
            Load += AboutIt_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox StrokaDva_NDS;
        private TextBox StrokaTri_NDS;
        private TextBox StrokaChetire_NDS;
        private TextBox StrokaPyat_NDS;
        private TextBox StrokaOdin_NDS;
        private TextBox StrokaShest_NDS;
    }
}