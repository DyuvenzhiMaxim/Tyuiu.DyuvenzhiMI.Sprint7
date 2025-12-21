
using System.Diagnostics;
using System.Windows.Forms;
using Tyuiu.DyuvenzhiMI.Sprint7.Project.V11.Lib;

namespace Tyuiu.DyuvenzhiMI.Sprint7.Project.V11
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonAvtorInfo_DMI_Click(object sender, EventArgs e)
        {
            FormAvtorInfo formAboutMe = new FormAvtorInfo();
            formAboutMe.ShowDialog();
        }

        private void buttonProgramInfo_DMI_Click(object sender, EventArgs e)
        {
            FormProgramInfo formAboutProgram = new FormProgramInfo();
            formAboutProgram.ShowDialog();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelTel_DMI_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(labelTel_DMI.Text);
            MessageBox.Show("Текст скопирован в буфер обмена!", "Ура!");
        }

        private void pictureBoxInfoShtatEd_DMI_MouseEnter(object sender, EventArgs e)
        {
            toolTip_DMI.SetToolTip(pictureBoxInfoShtatEd_DMI, "Обще число должностей в штатном расписании");
        }

        private void pictureBoxPayMonth_DMI_MouseEnter(object sender, EventArgs e)
        {
            toolTip_DMI.SetToolTip(pictureBoxPayMonth_DMI, "Общая сумма всех выплат сотрудникам за календарный месяц");
        }

        private void pictureBoxPayYear_DMI_MouseEnter(object sender, EventArgs e)
        {
            toolTip_DMI.SetToolTip(pictureBoxPayYear_DMI, "Среднемесячная зарплата × Среднесписочная численность × 12 месяцев");
        }

        private void buttonProgramInfo_DMI_MouseEnter(object sender, EventArgs e)
        {
            toolTip_DMI.SetToolTip(buttonProgramInfo_DMI, "О программе");
        }

        private void buttonAvtorInfo_DMI_MouseEnter(object sender, EventArgs e)
        {
            toolTip_DMI.SetToolTip(buttonAvtorInfo_DMI, "Об авторе");
        }

        private void buttonStaff_DMI_MouseEnter(object sender, EventArgs e)
        {
            toolTip_DMI.SetToolTip(buttonStaff_DMI, "Перейти к сотрудникам");
        }

        private void labelTel_DMI_MouseEnter(object sender, EventArgs e)
        {
            toolTip_DMI.SetToolTip(labelTel_DMI, "Скопировать");
        }

        private void linkLabelVk_DMI_LinkClicked(object sender, EventArgs e)
        {
            try
            {
                var psi = new ProcessStartInfo
                {
                    FileName = "https://vk.com/durov",
                    UseShellExecute = true
                };
                Process.Start(psi);
                linkLabelVk_DMI.LinkVisited = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Не удалось открыть ссылку: {ex.Message}");
            }
        }

        private void linkLabelTg_DMI_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)//LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                var psi = new ProcessStartInfo
                {
                    FileName = "https://t.me/durov_russia",
                    UseShellExecute = true
                };
                Process.Start(psi);
                linkLabelTg_DMI.LinkVisited = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Не удалось открыть ссылку: {ex.Message}");
            }
        }

        private void linkLabelGitHub_DMI_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                var psi = new ProcessStartInfo
                {
                    FileName = "https://github.com/DyuvenzhiMaxim",
                    UseShellExecute = true
                };
                Process.Start(psi);
                linkLabelGitHub_DMI.LinkVisited = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Не удалось открыть ссылку: {ex.Message}");
            }
        }

        private void buttonData_DMI_MouseEnter(object sender, EventArgs e)
        {
            toolTip_DMI.SetToolTip(buttonChart_DMI, "Берёт данные из полей и строит из них график");
        }

        private void buttonData_DMI_Click(object sender, EventArgs e)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\AAA.csv";
            File.WriteAllText(path, "");


        }
    }
}
