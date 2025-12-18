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
            groupBoxTitle_DMI = new GroupBox();
            buttonHelp_DMI = new Button();
            buttonAvtorInfo_DMI = new Button();
            groupBoxBody_DMI = new GroupBox();
            labelTitleName_DMI = new Label();
            groupBoxInfo_DMI.SuspendLayout();
            groupBoxTitle_DMI.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxInfo_DMI
            // 
            groupBoxInfo_DMI.Controls.Add(buttonAvtorInfo_DMI);
            groupBoxInfo_DMI.Controls.Add(buttonHelp_DMI);
            groupBoxInfo_DMI.Dock = DockStyle.Bottom;
            groupBoxInfo_DMI.Location = new Point(0, 527);
            groupBoxInfo_DMI.Name = "groupBoxInfo_DMI";
            groupBoxInfo_DMI.Size = new Size(1155, 71);
            groupBoxInfo_DMI.TabIndex = 0;
            groupBoxInfo_DMI.TabStop = false;
            groupBoxInfo_DMI.Text = "Дополнительная информация";
            // 
            // groupBoxTitle_DMI
            // 
            groupBoxTitle_DMI.Controls.Add(labelTitleName_DMI);
            groupBoxTitle_DMI.Dock = DockStyle.Top;
            groupBoxTitle_DMI.Location = new Point(0, 0);
            groupBoxTitle_DMI.Name = "groupBoxTitle_DMI";
            groupBoxTitle_DMI.Size = new Size(1155, 125);
            groupBoxTitle_DMI.TabIndex = 1;
            groupBoxTitle_DMI.TabStop = false;
            groupBoxTitle_DMI.Text = "Главная страница";
            // 
            // buttonHelp_DMI
            // 
            buttonHelp_DMI.Image = (Image)resources.GetObject("buttonHelp_DMI.Image");
            buttonHelp_DMI.Location = new Point(1117, 32);
            buttonHelp_DMI.Name = "buttonHelp_DMI";
            buttonHelp_DMI.Size = new Size(38, 39);
            buttonHelp_DMI.TabIndex = 1;
            buttonHelp_DMI.UseVisualStyleBackColor = true;
            // 
            // buttonAvtorInfo_DMI
            // 
            buttonAvtorInfo_DMI.Image = (Image)resources.GetObject("buttonAvtorInfo_DMI.Image");
            buttonAvtorInfo_DMI.Location = new Point(1072, 32);
            buttonAvtorInfo_DMI.Name = "buttonAvtorInfo_DMI";
            buttonAvtorInfo_DMI.Size = new Size(39, 39);
            buttonAvtorInfo_DMI.TabIndex = 0;
            buttonAvtorInfo_DMI.UseVisualStyleBackColor = true;
            // 
            // groupBoxBody_DMI
            // 
            groupBoxBody_DMI.Dock = DockStyle.Fill;
            groupBoxBody_DMI.Location = new Point(0, 125);
            groupBoxBody_DMI.Name = "groupBoxBody_DMI";
            groupBoxBody_DMI.Size = new Size(1155, 402);
            groupBoxBody_DMI.TabIndex = 2;
            groupBoxBody_DMI.TabStop = false;
            groupBoxBody_DMI.Text = "Основная информация (невидно)";
            groupBoxBody_DMI.Visible = false;
            // 
            // labelTitleName_DMI
            // 
            labelTitleName_DMI.AccessibleRole = AccessibleRole.Window;
            labelTitleName_DMI.AutoSize = true;
            labelTitleName_DMI.Font = new Font("Segoe UI", 16F);
            labelTitleName_DMI.Location = new Point(477, 23);
            labelTitleName_DMI.Name = "labelTitleName_DMI";
            labelTitleName_DMI.Size = new Size(186, 37);
            labelTitleName_DMI.TabIndex = 0;
            labelTitleName_DMI.Text = "Отдел кадров\r\n";
            labelTitleName_DMI.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1155, 598);
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
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxInfo_DMI;
        private GroupBox groupBoxTitle_DMI;
        private GroupBox groupBoxBody_DMI;
        private Button buttonAvtorInfo_DMI;
        private Button buttonHelp_DMI;
        private Label labelTitleName_DMI;
    }
}
