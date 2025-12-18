namespace Tyuiu.DyuvenzhiMI.Sprint7.Project.V11
{
    partial class FormAvtorInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAvtorInfo));
            groupBoxMain_DMI = new GroupBox();
            buttonOK_DMI = new Button();
            labelAutorInfo_DMI = new Label();
            pictureBoxMe_DMI = new PictureBox();
            groupBoxMain_DMI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMe_DMI).BeginInit();
            SuspendLayout();
            // 
            // groupBoxMain_DMI
            // 
            groupBoxMain_DMI.BackColor = SystemColors.Info;
            groupBoxMain_DMI.Controls.Add(buttonOK_DMI);
            groupBoxMain_DMI.Controls.Add(labelAutorInfo_DMI);
            groupBoxMain_DMI.Controls.Add(pictureBoxMe_DMI);
            groupBoxMain_DMI.Dock = DockStyle.Fill;
            groupBoxMain_DMI.Location = new Point(0, 0);
            groupBoxMain_DMI.Name = "groupBoxMain_DMI";
            groupBoxMain_DMI.Size = new Size(800, 450);
            groupBoxMain_DMI.TabIndex = 0;
            groupBoxMain_DMI.TabStop = false;
            // 
            // buttonOK_DMI
            // 
            buttonOK_DMI.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonOK_DMI.BackColor = Color.Bisque;
            buttonOK_DMI.Font = new Font("Segoe UI", 10F);
            buttonOK_DMI.Location = new Point(500, 222);
            buttonOK_DMI.Name = "buttonOK_DMI";
            buttonOK_DMI.Size = new Size(288, 216);
            buttonOK_DMI.TabIndex = 2;
            buttonOK_DMI.Text = "ОК";
            buttonOK_DMI.UseVisualStyleBackColor = false;
            buttonOK_DMI.Click += button1_Click;
            // 
            // labelAutorInfo_DMI
            // 
            labelAutorInfo_DMI.AutoSize = true;
            labelAutorInfo_DMI.Font = new Font("Segoe UI", 14F);
            labelAutorInfo_DMI.Location = new Point(294, 36);
            labelAutorInfo_DMI.Name = "labelAutorInfo_DMI";
            labelAutorInfo_DMI.Size = new Size(481, 128);
            labelAutorInfo_DMI.TabIndex = 1;
            labelAutorInfo_DMI.Text = "Жёсткий программист нового поколения!\r\n(Дювенжи М. И. ТИУ ПИНб-25-1)\r\nГотов к покорению мира и уже на пути\r\nстановления мировой звездой!";
            // 
            // pictureBoxMe_DMI
            // 
            pictureBoxMe_DMI.Image = (Image)resources.GetObject("pictureBoxMe_DMI.Image");
            pictureBoxMe_DMI.Location = new Point(6, 23);
            pictureBoxMe_DMI.Name = "pictureBoxMe_DMI";
            pictureBoxMe_DMI.Size = new Size(270, 336);
            pictureBoxMe_DMI.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxMe_DMI.TabIndex = 0;
            pictureBoxMe_DMI.TabStop = false;
            // 
            // FormAvtorInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBoxMain_DMI);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAvtorInfo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "О программисте";
            groupBoxMain_DMI.ResumeLayout(false);
            groupBoxMain_DMI.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMe_DMI).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxMain_DMI;
        private Label labelAutorInfo_DMI;
        private PictureBox pictureBoxMe_DMI;
        private Button buttonOK_DMI;
    }
}