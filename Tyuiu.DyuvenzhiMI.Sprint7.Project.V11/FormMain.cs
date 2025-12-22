
using OfficeOpenXml; // Для работы с Exel файлами
using OfficeOpenXml.FormulaParsing.Excel.Functions.DateTime;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Text;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
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
            toolTip_DMI.SetToolTip(pictureBoxInfoShtatEd_DMI, "Общее число должностей в штатном расписании");
        }

        private void pictureBoxPayMonth_DMI_MouseEnter(object sender, EventArgs e)
        {
            toolTip_DMI.SetToolTip(pictureBoxPayMonth_DMI, "Общая сумма всех выплат сотрудникам за календарный месяц");
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
            //Создание Exel таблицы с ФЗП по месяцам
            string path = $@"{Directory.GetCurrentDirectory()}\PayByMonths.csv";
            File.WriteAllText(path, "");

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(path);
            }

            //Запись в Exel
            using (var packageMonths = new ExcelPackage())
            {
                var worksheet = packageMonths.Workbook.Worksheets.Add("ФЗП за месяц"); // Создал лист
                //Заопнялю B1-M1 названиями месяцев
                var Months = new[] { "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь",
                                "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь"};
                worksheet.Cells[1, 2, 1, 13].LoadFromArrays(new object[][] { Months });
                //Заполняю A2-A5
                worksheet.Cells["A2"].Value = "Дювенжи Максим Иванович";
                worksheet.Cells["A3"].Value = "Рив Илон Маск";
                worksheet.Cells["A4"].Value = "Эллиот Марк Цукерберг";
                worksheet.Cells["A5"].Value = "Дениз Меган Фокс";
                worksheet.Cells["A6"].Value = "Мавроди Вячеслав Пантелеевич";
                //Заполняю A2-D2
                var PayToMe = new[] { "347000", "512000", "429000",
                                    "583000"};
                Convert.ToInt32(PayToMe);
                worksheet.Cells[2, 2, 2, 6].LoadFromArrays(new object[][] { PayToMe });
                //Заполняю A3-D3
                var PayToMask = new[] { "142000", "217000", "189000",
                                    "134000"};
                worksheet.Cells[3, 2, 3, 6].LoadFromArrays(new object[][] { PayToMask });
                //Заполняю A4-D4
                var PayToMark = new[] { "78 000", "112 000", "56 000",
                                    "93 000"};
                worksheet.Cells[4, 2, 4, 6].LoadFromArrays(new object[][] { PayToMark });
                //Заполняю A5-D5
                var PayToMegan = new[] { "43 000", "28 000", "57 000",
                                    "35 000"};
                worksheet.Cells[5, 2, 5, 6].LoadFromArrays(new object[][] { PayToMegan });
                //Заполняю A6-D6
                var PayToMavrody = new[] { "17 000", "24 000", "13 000",
                                    "29 000"};
                worksheet.Cells[6, 2, 6, 6].LoadFromArrays(new object[][] { PayToMavrody });

                //Находим среднее значение у каждого рабочего
                //worksheet.Cells["N6"].Formula = "AVERAGE(A1:A5)";

                //Авто ширина столбцов
                worksheet.Cells[worksheet.Dimension.Address].AutoFitColumns();

                //Проверяем выбор месяца и возращаем значение закреплённое под ним
                int comboBoxIndex = comboBoxMonth_DMI.SelectedIndex;
                if (comboBoxIndex >= 0)
                {
                    var value = worksheet.Cells[1, comboBoxIndex + 1].Value?.ToString();
                    textBoxPayMonth_DMI.Text = value;
                }
                else
                {
                    textBoxPayMonth_DMI.Text = "Выберите месяц";
                }

                //Сохраняем
                var file = new FileInfo(path);
                packageMonths.SaveAs(file);
            }



            /*
            //Создание Exel таблицы с сотрудниками
            string path2 = $@"{Directory.GetCurrentDirectory()}\Employees.csv";
            File.WriteAllText(path2, "");

            FileInfo fileInfo2 = new FileInfo(path2);
            bool fileExists2 = fileInfo2.Exists;
            if (fileExists2)
            {
                File.Delete(path2);
            }

            //Записываем в Exel
            using (var packageEmployees = new ExcelPackage())
            {
                var worksheetEmployees = packageEmployees.Workbook.Worksheets.Add("Сотрудники");

                //Заголовки
                var Employees = new[] { "ФИО", "домашний адрес", "телефон", "Дата рождения",
                    "должность", "стаж работы", "образование", "зарплата" };
                worksheetEmployees.Cells[1, 1, 1, 8].LoadFromArrays(new object[][] { Employees });

                //Сотрудник 0
                var Employee0 = new[] { "Дювенжи Максим Иванович", "ТИУ", "8 800 555 35 35",
                    "22 августа 2007 год", "Директор", "19 лет", "Доктор наук", "300 000-500 000₽" };
                worksheetEmployees.Cells[2, 1, 2, 8].LoadFromArrays(new object[][] { Employee0 });
                //Сотрудник 1
                var Employee1 = new[] { "Рив Илон Маск", "США, Техас, Старбейс", "310-363-6000", "28 июня 1971 года",
                    "управленец, Главный инженер", "30 лет", "двойное бакалаврское", "150 000₽" };
                worksheetEmployees.Cells[3, 1, 3, 8].LoadFromArrays(new object[][] { Employee1 });
                //Сотрудник 2
                var Employee2 = new[] { "Эллиот Марк Цукерберг", "США, Менло-Парк, Калифорния", "650-543-4800",
                    "14 мая 1984 года", "Рабочий", "21 год", "Бакалавр неполное", "50 000₽" };
                worksheetEmployees.Cells[4, 1, 4, 8].LoadFromArrays(new object[][] { Employee2 });
                //Сотрудник 3
                var Employee3 = new[] { "Дениз Меган Фокс", "Комната облуживающего персонала", "1-747-214-8022",
                    "16 мая 1986 года.", "Облуживающий персонал", "24 года", "11 классов", "30 000₽" };
                worksheetEmployees.Cells[5, 1, 5, 8].LoadFromArrays(new object[][] { Employee3 });
                //Сотрудник 4
                var Employee4 = new[] { "Мавроди Вячеслав Пантелеевич", "Отсутствует", "8 800 300-30-00",
                    "11 августа 1955 года", "Бухгалтер", "32 года", "Бакалавр неполное", "15 000₽" };
                worksheetEmployees.Cells[6, 1, 6, 8].LoadFromArrays(new object[][] { Employee4 });

                //Авто ширина столбцов
                worksheetEmployees.Cells[worksheetEmployees.Dimension.Address].AutoFitColumns();
                //Сохраняем
                var fileEmployee = new FileInfo(path2);
                packageEmployees.SaveAs(fileEmployee);

            }*/





        }
    }
}
