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
            textBox1 = new TextBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            pictureBox3 = new PictureBox();
            textBox3 = new TextBox();
            pictureBox4 = new PictureBox();
            label4 = new Label();
            label5 = new Label();
            groupBoxInfo_DMI.SuspendLayout();
            groupBoxTitle_DMI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBoxBody_DMI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // groupBoxInfo_DMI
            // 
            groupBoxInfo_DMI.BackColor = Color.PeachPuff;
            groupBoxInfo_DMI.Controls.Add(label5);
            groupBoxInfo_DMI.Controls.Add(label4);
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
            buttonProgramInfo_DMI.Location = new Point(1145, 0);
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
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(124, 39);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(39, 45);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // labelTitleName_DMI
            // 
            labelTitleName_DMI.AccessibleRole = AccessibleRole.Window;
            labelTitleName_DMI.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelTitleName_DMI.AutoSize = true;
            labelTitleName_DMI.Font = new Font("Segoe UI", 20F);
            labelTitleName_DMI.Location = new Point(156, 38);
            labelTitleName_DMI.Name = "labelTitleName_DMI";
            labelTitleName_DMI.Size = new Size(868, 46);
            labelTitleName_DMI.TabIndex = 0;
            labelTitleName_DMI.Text = "Отдел кадров Великого Завода имени Дювенжи М. И.";
            labelTitleName_DMI.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBoxBody_DMI
            // 
            groupBoxBody_DMI.BackColor = Color.Bisque;
            groupBoxBody_DMI.Controls.Add(label3);
            groupBoxBody_DMI.Controls.Add(label2);
            groupBoxBody_DMI.Controls.Add(pictureBox4);
            groupBoxBody_DMI.Controls.Add(pictureBox3);
            groupBoxBody_DMI.Controls.Add(pictureBox2);
            groupBoxBody_DMI.Controls.Add(label1);
            groupBoxBody_DMI.Controls.Add(textBox3);
            groupBoxBody_DMI.Controls.Add(textBox2);
            groupBoxBody_DMI.Controls.Add(textBox1);
            groupBoxBody_DMI.Dock = DockStyle.Fill;
            groupBoxBody_DMI.Location = new Point(0, 125);
            groupBoxBody_DMI.Name = "groupBoxBody_DMI";
            groupBoxBody_DMI.Size = new Size(1193, 359);
            groupBoxBody_DMI.TabIndex = 2;
            groupBoxBody_DMI.TabStop = false;
            groupBoxBody_DMI.Text = "Штатное расписание";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(403, 45);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(109, 27);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(12, 40);
            label1.Name = "label1";
            label1.Size = new Size(333, 32);
            label1.TabIndex = 1;
            label1.Text = "Количество штатных единиц";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(518, 26);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(21, 23);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(12, 139);
            label2.Name = "label2";
            label2.Size = new Size(385, 32);
            label2.TabIndex = 3;
            label2.Text = "Фонд заработной платы за месяц";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(12, 222);
            label3.Name = "label3";
            label3.Size = new Size(354, 32);
            label3.TabIndex = 3;
            label3.Text = "Фонд заработной платы за год";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(403, 144);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(109, 27);
            textBox2.TabIndex = 0;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(518, 125);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(21, 23);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(403, 228);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(109, 27);
            textBox3.TabIndex = 0;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(518, 209);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(21, 23);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 2;
            pictureBox4.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 33);
            label4.Name = "label4";
            label4.Size = new Size(119, 20);
            label4.TabIndex = 1;
            label4.Text = "Обратная связь";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(35, 53);
            label5.Name = "label5";
            label5.Size = new Size(113, 20);
            label5.TabIndex = 2;
            label5.Text = "8 800 555 35 35";
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
            groupBoxInfo_DMI.PerformLayout();
            groupBoxTitle_DMI.ResumeLayout(false);
            groupBoxTitle_DMI.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBoxBody_DMI.ResumeLayout(false);
            groupBoxBody_DMI.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
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
        private Label label1;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label label5;
        private Label label4;
    }
}
