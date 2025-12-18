
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
    }
}
