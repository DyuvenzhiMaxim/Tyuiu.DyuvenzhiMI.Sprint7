
using OfficeOpenXml; // Для работы с Exel
using OfficeOpenXml.FormulaParsing.Excel.Functions.DateTime;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Text;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.IO.Packaging;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

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
            //Создание Exel таблицы с ФЗП по месяцам
            string path = $@"{Directory.GetCurrentDirectory()}\PayByMonths.csv";
            File.WriteAllText(path, "");
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(path);
            }

            using (var packageMonths = new ExcelPackage())
            {
                var worksheet = packageMonths.Workbook.Worksheets.Add("ФЗП за месяц");
                //Сохраняем
                var file = new FileInfo(path);
                packageMonths.SaveAs(file);
            }

            //Создание Exel таблицы с сотрудниками
            string path2 = $@"{Directory.GetCurrentDirectory()}\Employees.csv";
            File.WriteAllText(path2, "");

            FileInfo fileInfo2 = new FileInfo(path2);
            bool fileExists2 = fileInfo2.Exists;
            if (fileExists2)
            {
                File.Delete(path2);
            }

            using (var packageEmployees = new ExcelPackage())
            {
                var worksheetEmployees = packageEmployees.Workbook.Worksheets.Add("Сотрудники");
                //Сохраняем
                var file = new FileInfo(path2);
                packageEmployees.SaveAs(file);
            }
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

        //Флаги сохранения
        private bool isFileSaved = false;
        private bool isFileSaved2 = false;
        private void buttonData_DMI_Click(object sender, EventArgs e)
        {

            //Активируем и блокируем кнопку построить график
            if (comboBoxMonth_DMI.Text != "")
            {
                buttonChart_DMI.Enabled = true;
            }
            if (chartPay_DMI.Series.Count > 0 && chartPay_DMI.Series[0].Points.Count > 0)
            {
                buttonChart_DMI.Enabled = false;
            }
            //Открытие Exel таблицы с ФЗП по месяцам
            string path = $@"{Directory.GetCurrentDirectory()}\PayByMonths.csv";


            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            if (fileExists != true)
            {
                MessageBox.Show($"Зачем удалил файл? Перезапускай теперь", "Ой");
            }
            else
            {
                //Запись в Exel
                using (ExcelPackage packageMonths = new ExcelPackage(new FileInfo(path)))
                {
                    //открыли первый лист
                    var worksheet = packageMonths.Workbook.Worksheets[0];
                    //Заголоок
                    worksheet.Cells["A1"].Value = "Сотрудник/Месяц";

                    //Заопнялю B1-M1 названиями месяцев
                    var Months = new[] { "Январь", "Февраль", "Март", "Апрель", "Май" };
                    worksheet.Cells[1, 2, 1, 6].LoadFromArrays(new object[][] { Months });
                    //Заполняю A2-A5
                    worksheet.Cells["A2"].Value = "Дювенжи Максим Иванович";
                    worksheet.Cells["A3"].Value = "Рив Илон Маск";
                    worksheet.Cells["A4"].Value = "Эллиот Марк Цукерберг";
                    worksheet.Cells["A5"].Value = "Дениз Меган Фокс";
                    worksheet.Cells["A6"].Value = "Мавроди Вячеслав Пантелеевич";
                    //Заполняю A2-D2
                    var PayToMe = new object[] { 347000, 512000, 429000, 583000 };
                    worksheet.Cells[2, 2, 2, 5].LoadFromArrays(new object[][] { PayToMe });
                    //Заполняю A3-D3
                    var PayToMask = new object[] { 142000, 217000, 189000, 134000 };
                    worksheet.Cells[3, 2, 3, 6].LoadFromArrays(new object[][] { PayToMask });
                    //Заполняю A4-D4
                    var PayToMark = new object[] { 78000, 112000, 56000, 93000 };
                    worksheet.Cells[4, 2, 4, 6].LoadFromArrays(new object[][] { PayToMark });
                    //Заполняю A5-D5
                    var PayToMegan = new object[] { 43000, 28000, 57000, 35000 };
                    worksheet.Cells[5, 2, 5, 6].LoadFromArrays(new object[][] { PayToMegan });
                    //Заполняю A6-D6
                    var PayToMavrody = new object[] { 17000, 24000, 13000, 29000 };
                    worksheet.Cells[6, 2, 6, 6].LoadFromArrays(new object[][] { PayToMavrody });

                    //Находим среднее значение у каждого рабочего
                    worksheet.Cells["G1"].Value = "ср. зарплата сотрудника";
                    worksheet.Cells["G2"].Formula = "AVERAGE(B2:E2)";
                    worksheet.Cells["G3"].Formula = "AVERAGE(B3:E3)";
                    worksheet.Cells["G4"].Formula = "AVERAGE(B4:E4)";
                    worksheet.Cells["G5"].Formula = "AVERAGE(B5:E5)";
                    worksheet.Cells["G6"].Formula = "AVERAGE(B6:E6)";
                    //Находим среднее згачение у каджого месяца
                    worksheet.Cells["H1"].Value = "ФЗП";
                    worksheet.Cells["H2"].Formula = "SUM(B2:B6)";
                    worksheet.Cells["H3"].Formula = "SUM(C2:C6)";
                    worksheet.Cells["H4"].Formula = "SUM(D2:D6)";
                    worksheet.Cells["H5"].Formula = "SUM(E2:E7)";

                    //Авто ширина столбцов
                    worksheet.Cells[worksheet.Dimension.Address].AutoFitColumns();

                    //Проверяем выбор месяца и возращаем значение закреплённое под ним
                    int comboBoxIndex = comboBoxMonth_DMI.SelectedIndex;
                    if (comboBoxIndex >= 0)
                    {
                        worksheet.Calculate();
                        var value = worksheet.Cells[2 + comboBoxIndex, 8].Value?.ToString();
                        textBoxPayMonth_DMI.Text = value;
                    }
                    else
                    {
                        textBoxPayMonth_DMI.Text = "Выберите месяц";
                    }

                    //Флаг в тру
                    if (isFileSaved)
                    {
                        return;
                    }
                    isFileSaved = true;

                    //Сохраняем
                    var file = new FileInfo(path);
                    packageMonths.SaveAs(file);
                }
            }



            //Создание Exel таблицы с сотрудниками
            string path2 = $@"{Directory.GetCurrentDirectory()}\Employees.csv";

            FileInfo fileInfo2 = new FileInfo(path2);
            bool fileExists2 = fileInfo.Exists;
            if (fileExists2 != true)
            {
                MessageBox.Show($"Зачем удалил файл? Перезапускай теперь", "Ой");
            }
            else
            {
                //Записываем в Exel
                using (ExcelPackage packageEmployees = new ExcelPackage(new FileInfo(path2)))
                {
                    var worksheetEmployees = packageEmployees.Workbook.Worksheets[0];

                    //Заголовки
                    var Employees = new[] { "ФИО", "домашний адрес", "телефон", "Дата рождения",
                    "должность", "стаж работы", "образование", "Ср. зарплата за месяц" };
                    worksheetEmployees.Cells[1, 1, 1, 8].LoadFromArrays(new object[][] { Employees });


                    //Открываем файл с зарплатами сотрудников
                    string pathToEcelMonths = $@"{Directory.GetCurrentDirectory()}\PayByMonths.csv";
                    using (ExcelPackage package = new ExcelPackage(new FileInfo(pathToEcelMonths)))
                    {
                        //открыли первый лист
                        var worksheet = package.Workbook.Worksheets[0];

                        //Сотрудник 0
                        var PayToMe = worksheet.Cells["G2"].Value;
                        worksheetEmployees.Cells["H2"].Value = PayToMe;
                        var Employee0 = new object[] { "Дювенжи Максим Иванович", "ТИУ", "8 800 555 35 35",
                    "22 августа 2007 год", "Директор", "19 лет", "Доктор наук" };
                        worksheetEmployees.Cells[2, 1, 2, 7].LoadFromArrays(new object[][] { Employee0 });

                        //Сотрудник 1
                        var PayToMask = worksheet.Cells["G3"].Value;
                        worksheetEmployees.Cells["H3"].Value = PayToMe;
                        var Employee1 = new[] { "Рив Илон Маск", "США, Техас, Старбейс", "310-363-6000", "28 июня 1971 года",
                    "управленец, Главный инженер", "30 лет", "двойное бакалаврское" };
                        worksheetEmployees.Cells[3, 1, 3, 7].LoadFromArrays(new object[][] { Employee1 });
                        //Сотрудник 2
                        var PayToMark = worksheet.Cells["G4"].Value;
                        worksheetEmployees.Cells["H4"].Value = PayToMark;
                        var Employee2 = new[] { "Эллиот Марк Цукерберг", "США, Менло-Парк, Калифорния", "650-543-4800",
                    "14 мая 1984 года", "Рабочий", "21 год", "Бакалавр неполное" };
                        worksheetEmployees.Cells[4, 1, 4, 7].LoadFromArrays(new object[][] { Employee2 });
                        //Сотрудник 3
                        var PayToMegan = worksheet.Cells["G5"].Value;
                        worksheetEmployees.Cells["H5"].Value = PayToMegan;
                        var Employee3 = new[] { "Дениз Меган Фокс", "Комната облуживающего персонала", "1-747-214-8022",
                    "16 мая 1986 года.", "Облуживающий персонал", "24 года", "11 классов" };
                        worksheetEmployees.Cells[5, 1, 5, 7].LoadFromArrays(new object[][] { Employee3 });
                        //Сотрудник 4
                        var PayToMavrody = worksheet.Cells["G6"].Value;
                        worksheetEmployees.Cells["H6"].Value = PayToMavrody;
                        var Employee4 = new[] { "Мавроди Вячеслав Пантелеевич", "Отсутствует", "8 800 300-30-00",
                    "11 августа 1955 года", "Бухгалтер", "32 года", "Бакалавр неполное" };
                        worksheetEmployees.Cells[6, 1, 6, 7].LoadFromArrays(new object[][] { Employee4 });

                        //Авто ширина столбцов
                        worksheetEmployees.Cells[worksheetEmployees.Dimension.Address].AutoFitColumns();
                    }
                    //chartPay_DMI.Refresh();
                    //Флаг2 в тру
                    if (isFileSaved2)
                    {
                        return;
                    }
                    isFileSaved2 = true;

                    //Сохраняем
                    var fileEmployee = new FileInfo(path2);
                    packageEmployees.SaveAs(fileEmployee);

                }
            }
        }

        private void buttonChart_DMI_Click(object sender, EventArgs e)
        {
            string pathToEcelMonths = $@"{Directory.GetCurrentDirectory()}\PayByMonths.csv";
            using (ExcelPackage package = new ExcelPackage(new FileInfo(pathToEcelMonths)))
            {
                var worksheet = package.Workbook.Worksheets[0];
                var NewEmploee = Convert.ToString(worksheet.Cells["A7"].Value);

                //управляем масштабом
                chartPay_DMI.ChartAreas[0].AxisX.Minimum = 1;
                chartPay_DMI.ChartAreas[0].AxisX.Maximum = 4;

                //Данные из Excel
                var AddXy1 = worksheet.Cells["H2"].Value;
                var AddXy2 = worksheet.Cells["H3"].Value;
                var AddXy3 = worksheet.Cells["H4"].Value;
                var AddXy4 = worksheet.Cells["H5"].Value;

                this.chartPay_DMI.ChartAreas[0].AxisX.Title = "Месяц";
                this.chartPay_DMI.ChartAreas[0].AxisY.Title = "Заработок";

                // Данные для графика
                chartPay_DMI.Series[0].Points.AddXY(1, AddXy1);
                chartPay_DMI.Series[0].Points.AddXY(2, AddXy2);
                chartPay_DMI.Series[0].Points.AddXY(3, AddXy3);
                chartPay_DMI.Series[0].Points.AddXY(4, AddXy4);

                chartPay_DMI.Series[0].Points[0].AxisLabel = "Январь";
                chartPay_DMI.Series[0].Points[1].AxisLabel = "Февраль";
                chartPay_DMI.Series[0].Points[2].AxisLabel = "Март";
                chartPay_DMI.Series[0].Points[3].AxisLabel = "Апрель";

                chartPay_DMI.ChartAreas[0].AxisX.LabelStyle.Interval = 1;
                chartPay_DMI.Refresh();
                //Блокируем кнопку постройки графика
                if (chartPay_DMI.Series.Count > 0 && chartPay_DMI.Series[0].Points.Count > 0)
                {
                    buttonChart_DMI.Enabled = false;
                }
            }
        }

        private void linkLabelEmployees_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string pathToEmployees = $@"{Directory.GetCurrentDirectory()}\Employees.csv";
            Process.Start(new ProcessStartInfo(pathToEmployees)
            {
                UseShellExecute = true
            });
            linkLabelEmployees.LinkVisited = true;
        }

        private void linkLabelMonths_DMI_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string pathToMonths = $@"{Directory.GetCurrentDirectory()}\PayByMonths.csv";
            Process.Start(new ProcessStartInfo(pathToMonths)
            {
                UseShellExecute = true
            });
            linkLabelMonths_DMI.LinkVisited = true;
        }

        private void buttonStaff_DMI_Click(object sender, EventArgs e)
        {
            panelChoise_DMI.Visible = true;
        }

        private void buttonAddEmploee_DMI_Click(object sender, EventArgs e)
        {
            FormAddEmploee formAddEmploee = new FormAddEmploee();
            formAddEmploee.ShowDialog();

            string pathToEcelMonths = $@"{Directory.GetCurrentDirectory()}\PayByMonths.csv";
            using (ExcelPackage package = new ExcelPackage(new FileInfo(pathToEcelMonths)))
            {
                var worksheet = package.Workbook.Worksheets[0];
                var NewEmploee = Convert.ToString(worksheet.Cells["A7"].Value);
                if (NewEmploee != "")
                {
                    buttonAddEmploee_DMI.Enabled = false;
                    textBoxShtatEd_DMI.BackColor = Color.GreenYellow;
                    if (comboBoxMonth_DMI.SelectedIndex! < 0)
                    {
                        comboBoxMonth_DMI.SelectedIndex = 0;
                    }

                    buttonData_DMI.PerformClick();
                }
            }
            linkLabelSave_DMI_LinkClicked(linkLabelSave_DMI, new LinkLabelLinkClickedEventArgs(linkLabelSave_DMI.Links[0]));
        }

        private void comboBoxMonth_DMI_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonData_DMI.Visible = true;
        }

        private void linkLabelSave_DMI_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {


            string pathToEcelMonths = $@"{Directory.GetCurrentDirectory()}\PayByMonths.csv";
            using (ExcelPackage package = new ExcelPackage(new FileInfo(pathToEcelMonths)))
            {
                var worksheet = package.Workbook.Worksheets[0];
                int ComboIndex = comboBoxMonth_DMI.SelectedIndex;
                comboBoxMonth_DMI.SelectedIndex = 3;
                buttonData_DMI.PerformClick();
                int value2 = Convert.ToInt32(textBoxPayMonth_DMI.Text);
                //MessageBox.Show($"H5: '{value2}'");
                chartPay_DMI.Series[0].Points[3].SetValueXY(4, value2);
                chartPay_DMI.Refresh();
                comboBoxMonth_DMI.SelectedIndex = ComboIndex;
                buttonData_DMI.PerformClick();
            }
        }
    }
}
