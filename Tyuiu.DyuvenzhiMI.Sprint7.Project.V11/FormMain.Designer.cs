namespace Tyuiu.DyuvenzhiMI.Sprint7.Project.V11
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            groupBoxInfo_DMI = new GroupBox();
            buttonAvtorInfo_DMI = new Button();
            buttonProgramInfo_DMI = new Button();
            groupBoxTitle_DMI = new GroupBox();
            pictureBox1 = new PictureBox();
            labelTitleName_DMI = new Label();
            groupBoxBody_DMI = new GroupBox();
            groupBoxInfo_DMI.SuspendLayout();
            groupBoxTitle_DMI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBoxInfo_DMI
            // 
            groupBoxInfo_DMI.BackColor = Color.PeachPuff;
            groupBoxInfo_DMI.Controls.Add(buttonAvtorInfo_DMI);
            groupBoxInfo_DMI.Dock = DockStyle.Bottom;
            groupBoxInfo_DMI.Location = new Point(0, 484);
            groupBoxInfo_DMI.Name = "groupBoxInfo_DMI";
            groupBoxInfo_DMI.Size = new Size(1193, 125);
            groupBoxInfo_DMI.TabIndex = 0;
            groupBoxInfo_DMI.TabStop = false;
            groupBoxInfo_DMI.Text = "Дополнительная информация";
            // 
            // buttonAvtorInfo_DMI
            // 
            buttonAvtorInfo_DMI.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonAvtorInfo_DMI.BackColor = Color.PeachPuff;
            buttonAvtorInfo_DMI.ForeColor = Color.LightSalmon;
            buttonAvtorInfo_DMI.Image = (Image)resources.GetObject("buttonAvtorInfo_DMI.Image");
            buttonAvtorInfo_DMI.Location = new Point(1135, 69);
            buttonAvtorInfo_DMI.Name = "buttonAvtorInfo_DMI";
            buttonAvtorInfo_DMI.Size = new Size(52, 50);
            buttonAvtorInfo_DMI.TabIndex = 0;
            buttonAvtorInfo_DMI.UseVisualStyleBackColor = false;
            buttonAvtorInfo_DMI.Click += buttonAvtorInfo_DMI_Click;
            // 
            // buttonProgramInfo_DMI
            // 
            buttonProgramInfo_DMI.Anchor = AnchorStyles.Right;
            buttonProgramInfo_DMI.BackColor = Color.PeachPuff;
            buttonProgramInfo_DMI.ForeColor = SystemColors.MenuText;
            buttonProgramInfo_DMI.Image = (Image)resources.GetObject("buttonProgramInfo_DMI.Image");
            buttonProgramInfo_DMI.Location = new Point(1142, 12);
            buttonProgramInfo_DMI.Name = "buttonProgramInfo_DMI";
            buttonProgramInfo_DMI.Size = new Size(48, 48);
            buttonProgramInfo_DMI.TabIndex = 1;
            buttonProgramInfo_DMI.UseVisualStyleBackColor = false;
            buttonProgramInfo_DMI.Click += buttonProgramInfo_DMI_Click;
            // 
            // groupBoxTitle_DMI
            // 
            groupBoxTitle_DMI.BackColor = Color.PeachPuff;
            groupBoxTitle_DMI.Controls.Add(pictureBox1);
            groupBoxTitle_DMI.Controls.Add(buttonProgramInfo_DMI);
            groupBoxTitle_DMI.Controls.Add(labelTitleName_DMI);
            groupBoxTitle_DMI.Dock = DockStyle.Top;
            groupBoxTitle_DMI.Location = new Point(0, 0);
            groupBoxTitle_DMI.Name = "groupBoxTitle_DMI";
            groupBoxTitle_DMI.Size = new Size(1193, 125);
            groupBoxTitle_DMI.TabIndex = 1;
            groupBoxTitle_DMI.TabStop = false;
            groupBoxTitle_DMI.Text = "Главная страница";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // labelTitleName_DMI
            // 
            labelTitleName_DMI.AccessibleRole = AccessibleRole.Window;
            labelTitleName_DMI.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelTitleName_DMI.AutoSize = true;
            labelTitleName_DMI.Font = new Font("Segoe UI", 16F);
            labelTitleName_DMI.Location = new Point(44, 23);
            labelTitleName_DMI.Name = "labelTitleName_DMI";
            labelTitleName_DMI.Size = new Size(186, 37);
            labelTitleName_DMI.TabIndex = 0;
            labelTitleName_DMI.Text = "Отдел кадров\r\n";
            labelTitleName_DMI.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBoxBody_DMI
            // 
            groupBoxBody_DMI.BackColor = Color.Bisque;
            groupBoxBody_DMI.Dock = DockStyle.Fill;
            groupBoxBody_DMI.Location = new Point(0, 125);
            groupBoxBody_DMI.Name = "groupBoxBody_DMI";
            groupBoxBody_DMI.Size = new Size(1193, 359);
            groupBoxBody_DMI.TabIndex = 2;
            groupBoxBody_DMI.TabStop = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1193, 609);
            Controls.Add(groupBoxBody_DMI);
            Controls.Add(groupBoxTitle_DMI);
            Controls.Add(groupBoxInfo_DMI);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Отдел кадров";
            Load += Form1_Load;
            groupBoxInfo_DMI.ResumeLayout(false);
            groupBoxTitle_DMI.ResumeLayout(false);
            groupBoxTitle_DMI.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxInfo_DMI;
        private GroupBox groupBoxTitle_DMI;
        private GroupBox groupBoxBody_DMI;
        private Button buttonAvtorInfo_DMI;
        private Button buttonProgramInfo_DMI;
        private Label labelTitleName_DMI;
        private PictureBox pictureBox1;
    }
}
