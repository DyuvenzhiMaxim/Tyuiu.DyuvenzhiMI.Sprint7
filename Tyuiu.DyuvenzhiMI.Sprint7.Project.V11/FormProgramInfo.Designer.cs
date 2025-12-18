namespace Tyuiu.DyuvenzhiMI.Sprint7.Project.V11
{
    partial class FormProgramInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProgramInfo));
            groupBoxMain_DMI = new GroupBox();
            buttonOK_DMI = new Button();
            textBoxInfo_DMI = new TextBox();
            groupBoxMain_DMI.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxMain_DMI
            // 
            groupBoxMain_DMI.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxMain_DMI.BackColor = SystemColors.Info;
            groupBoxMain_DMI.Controls.Add(buttonOK_DMI);
            groupBoxMain_DMI.Controls.Add(textBoxInfo_DMI);
            groupBoxMain_DMI.Location = new Point(0, 0);
            groupBoxMain_DMI.Name = "groupBoxMain_DMI";
            groupBoxMain_DMI.Size = new Size(869, 522);
            groupBoxMain_DMI.TabIndex = 0;
            groupBoxMain_DMI.TabStop = false;
            groupBoxMain_DMI.Text = "Дювенжи М. И. | Спринт 7 | Вариант 11";
            // 
            // buttonOK_DMI
            // 
            buttonOK_DMI.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonOK_DMI.BackColor = Color.PeachPuff;
            buttonOK_DMI.Font = new Font("Segoe UI", 16F);
            buttonOK_DMI.Location = new Point(790, 451);
            buttonOK_DMI.Name = "buttonOK_DMI";
            buttonOK_DMI.Size = new Size(67, 59);
            buttonOK_DMI.TabIndex = 2;
            buttonOK_DMI.Text = "ОК";
            buttonOK_DMI.UseVisualStyleBackColor = false;
            buttonOK_DMI.Click += button1_Click;
            // 
            // textBoxInfo_DMI
            // 
            textBoxInfo_DMI.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxInfo_DMI.BackColor = SystemColors.Info;
            textBoxInfo_DMI.Enabled = false;
            textBoxInfo_DMI.Font = new Font("Segoe UI", 14F);
            textBoxInfo_DMI.Location = new Point(3, 23);
            textBoxInfo_DMI.Multiline = true;
            textBoxInfo_DMI.Name = "textBoxInfo_DMI";
            textBoxInfo_DMI.ReadOnly = true;
            textBoxInfo_DMI.Size = new Size(863, 496);
            textBoxInfo_DMI.TabIndex = 1;
            textBoxInfo_DMI.Text = resources.GetString("textBoxInfo_DMI.Text");
            // 
            // FormProgramInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(869, 522);
            Controls.Add(groupBoxMain_DMI);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormProgramInfo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "О программе";
            groupBoxMain_DMI.ResumeLayout(false);
            groupBoxMain_DMI.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxMain_DMI;
        private TextBox textBoxInfo_DMI;
        private Button buttonOK_DMI;
    }
}