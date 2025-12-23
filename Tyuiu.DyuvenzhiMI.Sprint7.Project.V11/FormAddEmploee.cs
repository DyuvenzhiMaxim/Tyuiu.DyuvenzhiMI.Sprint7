using OfficeOpenXml; // Для работы с Exel
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Tyuiu.DyuvenzhiMI.Sprint7.Project.V11.Lib;

namespace Tyuiu.DyuvenzhiMI.Sprint7.Project.V11
{
    public partial class FormAddEmploee : Form
    {
        public FormAddEmploee()
        {
            InitializeComponent();
        }
        private void buttonSave_DMI_Click(object sender, EventArgs e)
        {
            //Получаем значения с textBox
            var FIO = textBoxFIO_DMI.Text;
            var Addres = textBoxAddres_DMI.Text;
            var Tel = textBoxTel_DMI.Text;
            var Birth = textBoxBirth_DMI.Text;
            var Job = textBoxJob_DMI.Text;
            var Exp = textBoxExp_DMI.Text;
            var Educ = textBoxEduc_DMI.Text;
            var Pay = textBoxPay_DMI.Text;

            DataService ds = new DataService();
            bool res = ds.BoolValid(FIO, Addres, Tel, Birth, Job, Exp, Educ, Pay);
            //Проверка что поля где должны быть числа - с числами
            if (res == false)
            {
                // Строка не является целым числом
                MessageBox.Show($"Где-то где должно быть число, введено не число или оно дробное ;|", "Ой");
            }
            else
            {
                //Записываем в файл с зарплатами по месяцам
                string path = $@"{Directory.GetCurrentDirectory()}\PayByMonths.csv";
                //Запись в Exel
                using (ExcelPackage packageMonths = new ExcelPackage(new FileInfo(path)))
                {
                    //открыли первый лист
                    var worksheet = packageMonths.Workbook.Worksheets[0];

                    worksheet.Cells["A7"].Value = FIO;
                    worksheet.Cells["E7"].Value = Convert.ToInt32(Pay);

                    //Сохраняем
                    var file = new FileInfo(path);
                    packageMonths.SaveAs(file);
                }

                string path2 = $@"{Directory.GetCurrentDirectory()}\Employees.csv";
                using (ExcelPackage packageEmloyees = new ExcelPackage(new FileInfo(path2)))
                {
                    var worksheet2 = packageEmloyees.Workbook.Worksheets[0];

                    worksheet2.Cells["A7"].Value = FIO;
                    worksheet2.Cells["B7"].Value = Addres;
                    worksheet2.Cells["C7"].Value = Convert.ToInt32(Tel);
                    worksheet2.Cells["D7"].Value = Birth;
                    worksheet2.Cells["E7"].Value = Job;
                    worksheet2.Cells["F7"].Value = Convert.ToInt32(Exp);
                    worksheet2.Cells["G7"].Value = Educ;
                    worksheet2.Cells["H7"].Value = Convert.ToInt32(Pay);

                    //Сохраняем
                    var file = new FileInfo(path2);
                    packageEmloyees.SaveAs(file);
                }
                this.Close();
            }
        }
    }
}
