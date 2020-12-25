using pressF.Forms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
namespace pressF
{
    public partial class Organizations : Form
    {
        public Organizations()
        {
            InitializeComponent();
        }

        private void FormZP_Load(object sender, EventArgs e)
        {
            enrollmentsTableAdapter.Fill(dbDataSet.Enrollments);
            cardTableAdapter.Fill(dbDataSet.Card);
            workersTableAdapter.Fill(dbDataSet.Workers);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //Старая версия добавления карточки
            FormAddCard f = new FormAddCard();
            if (f.ShowDialog() == DialogResult.OK) // отобразить форму
            {
                MessageBox.Show(f.Mass[0]);
                //Проверка заполненности всех текстбоксов разом
                /* bool filled = f.Controls.OfType<CueTextBox>().All(check =>
                 {
                     if (check.Text == check.CueText) return false;
                     return String.IsNullOrEmpty(check.Text);
                 });
                 //Если не Всё заполнено 
                 MessageBox.Show(filled.ToString());
                 if (!filled) MessageBox.Show("Не все значения были заполнены!");*/
                /*                else //Всё ок*/
                {
                    /*MessageBox.Show(FormSelectPlace);*/
                    //Получение значений из формы добавления
                    /*
                    DateTime Birth = Convert.ToDateTime(f.DateTime1.Text);

                    String Bill_num = f.Bill_Num.Text;
                    String Table_num = f.Table_num.Text;
                    String orgKey = label5.Text;
                    DateTime date = ConvertToDateDime(f.DateTime2
                    workersTableAdapter.Insert(f.Surname.Text, f.Name_Worker.Text,f.Middlename.Text,f.Table_num.Text, f.Docum.SelectedIndex,f.Docum_Serial.Text,f.Docum_Num.Text,Convert.ToDateTime(f.DateTime2.Text),f.Docum_Place.Text,f.Docum_Cod.Text,City,Region_cod,District,Street,House,Block,Apartment,Index,Birth,Place_Of_Birth,Sex,SNILS,Home_phone,INN_worker,Full_Name_Card,Code_Word,Bank_Code,Card_type,Employment_Date,Salary,Email,Org_key); // добавление
                    workersTableAdapter.Fill(dbDataSet.Workers); // отображение
*/
                }
            }

        }




        private void AddButton_Click(object sender, EventArgs e)
        {
            FormAddWorker f = new FormAddWorker();

            if (f.ShowDialog() == DialogResult.OK)
            {
                workersTableAdapter.Insert(f.Surname.Text, f.Name_Worker.Text, f.Middlename.Text, f.Table_num.Text, Convert.ToDateTime(f.BithDate.Text), f.Bill_Num.Text, label5.Text, false);
                workersTableAdapter.Fill(dbDataSet.Workers);
            }
        }


        private void FireButton_Click(object sender, EventArgs e)
        {
            //Кнопка увольнения сотрудника, просто меняет "переключатель" в бд на противоположное значение
            Dictionary<string, string> c = workersDataGridView.GetCellsPls();
            workersTableAdapter.UpdateFiredStatus(!Convert.ToBoolean(c["Fired"]), Convert.ToInt32(c["WCode"]));
            workersTableAdapter.Fill(dbDataSet.Workers);
        }
        private void FillTheWorkSheet(DataGridView dg, Excel.Worksheet wsh)
        {
            //Заполняет лист экселя на базе DataGrid'а

            //Заголовки колонок
            for (int i = 1; i < dg.Columns.Count + 1; i++)
            {
                wsh.Cells[1, i] = dg.Columns[i - 1].HeaderText;
            }
            //данные колонок
            for (int i = 1; i < dg.RowCount + 1; i++)
            {
                for (int j = 1; j < dg.ColumnCount + 1; j++)
                {
                    wsh.Rows[i + 1].Columns[j] = dg.Rows[i - 1].Cells[j - 1].Value;
                }
            }
            //наводим красоту в таблице при помощи стандартных методов экселя
            wsh.Range["A1", wsh.Rows[dg.RowCount + 1].Columns[dg.ColumnCount]].AutoFormat(Format:
   Excel.XlRangeAutoFormat.xlRangeAutoFormatClassic2);
            wsh.Columns.AutoFit();
        }
        private void ExportButton_Click(object sender, EventArgs e)
        {

            SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "Excel Documents (*.xlsx)|*.xlsx",
                FileName = label1.Text + DateTime.Now.ToString(" MM.dd")
            + ".xlsx"
            };
            if (sfd.ShowDialog() == DialogResult.OK)

            {
                Excel.Application excelapp = new Excel.Application
                {
                    SheetsInNewWorkbook = 4
                };
                Excel.Workbook workbook = excelapp.Workbooks.Add();
                //Excel.Workbook workbook2 = excelapp.Workbooks.Add(); // Новый файл для экспорта, мб понадобится при разростании проекта в нечто огромное

                Excel.Worksheet worksheet = workbook.Sheets[1];
                Excel.Worksheet worksheet2 = workbook.Sheets[2];
                Excel.Worksheet worksheet3 = workbook.Sheets[3];
                Excel.Worksheet worksheet4 = workbook.Sheets[4];


                worksheet.Name = "Сотрудники";
                worksheet2.Name = "Карты";
                worksheet3.Name = "Зачисления";
                worksheet4.Name = "Зачисления по картам";

                FillTheWorkSheet(workersDataGridView, worksheet);
                FillTheWorkSheet(cardsGridView, worksheet2);
                FillTheWorkSheet(enrollmentsDataGridView, worksheet3);
                FillTheWorkSheet(dataGridView2, worksheet4);

                excelapp.AlertBeforeOverwriting = false;
                workbook.SaveAs(sfd.FileName);
                excelapp.Visible = true;
            }
        }

        private void AddCardButton_Click(object sender, EventArgs e)
        {

            FormAddCard f = new FormAddCard();
            Dictionary<string, string> c = workersDataGridView.GetCellsPls()
            ;
            foreach (KeyValuePair<string, string> kvp in c)
            {
                if (kvp.Key != "WBirth")
                {
                    f.Controls[kvp.Key].Text = kvp.Value;
                }
                else
                {
                    f.Controls[kvp.Key].Text = kvp.Value.Split(' ')[0];
                }
            }
            if (f.ShowDialog() == DialogResult.OK)
            {
                
                //cardTableAdapter.Insert( f.WSurname.Text, f.WName.Text, f.WMiddlename.Text, f.Table_num.Text, f.Docum.Text, int.Parse(f.Docum_Serial.Text), int.Parse(f.Docum_Num.Text), Convert.ToDateTime(f.DateTime2.Text), f.Docum_Place.Text, f.Docum_Cod.Text, f.Mass[0], int.Parse(f.Mass[1]), f.Mass[2], f.Mass[3], f.Mass[4], f.Mass[5], f.Mass[6], int.Parse(f.Mass[7]), Convert.ToDateTime(f.WBirth.Text), f.PlaceOfBirth.Text, f.Sex.Text, f.SNILS.Text, f.Home_Phone.Text, f.INN_worker.Text, f.Full_Name_Card.Text, f.Code_Word.Text, f.Bank_Code.Text, f.Card_Type.Text, Convert.ToDateTime(f.EmpDate.Text), f.Salary.Text, f.Email.Text, f.Org_key.Text, int.Parse(f.WCode.Text));
                //cardTableAdapter.Fill(dbDataSet.Card);
            }
        }

        private void Button_DOS_Click(object sender, EventArgs e)
        {

            //ДОПОЛНИТЕЛЬНАЯ ФОРМА БУДЕТ УБРАНА, НЕ ОБРАЩАТЬ НА НЕЁ ВНИМАНИЕ


            FormDOS f = new FormDOS(this);
            f.Show();


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Сохранение данных в бд простым способом
            enrollmentsTableAdapter.Update(dbDataSet);
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            //сброс изменений простой перезагрузкой значений из бд в адаптер таблицы
            enrollmentsTableAdapter.Fill(dbDataSet.Enrollments);
        }



        private void enrollmentsDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //автоматическое заполнение колонки "Код организации", ибо она не меняется
            enrollmentsDataGridView.CurrentRow.Cells[0].Value = label5.Text;
        }

        private void enrollmentsDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            // скрытие колонки "Код организации", она не меняется, заполняется автоматически
            enrollmentsDataGridView.Columns[0].Visible = false;
        }

        private void enrollmentsDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // при ошибке ввода помечаем ячейку и сбрасываем изменения
            DataGridView view = (DataGridView)sender;
            view.Rows[e.RowIndex].Cells[e.ColumnIndex].ErrorText = "ошибка ввода";
            e.Cancel = false;
            e.ThrowException = false;

        }

        private void enrollmentsDataGridView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            // убираем метку ошибки при изменении ячейки
            DataGridView view = (DataGridView)sender;
            view.Rows[e.RowIndex].Cells[e.ColumnIndex].ErrorText = String.Empty;
        }

        private void Organizations_FormClosed(object sender, FormClosedEventArgs e)
        {
            // сохранение таблицы с зачислениями при закрытии
            enrollmentsTableAdapter.Update(dbDataSet);
        }
    }
}
