using SalaryRegistersUralsib.Forms;

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

using Excel = Microsoft.Office.Interop.Excel;
namespace SalaryRegistersUralsib
{
    public partial class Organizations : Form
    {
        public Organizations()
        {
            
            InitializeComponent();
            this.Icon = Properties.Resources.Icon1;
        }
        /*
         * сделать:
         * ОДИН обработчик событий для всех трех datagridview только с разными "фильтрами" для EnrollmentType
         * 
         * допилить:
         * добавление карточек(вообще не работает на данный момент)
         * проверку вводимых данных при добавлении и редактировании списка организаций(заменить все textbox на кастомный с настройками)
         * 
         * ВАЖНО:
         * Не забыть про функцию генерации файлов DOS
         * Не забыть про генерацию печатных форм
         * 
         */




        private void FormZP_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbDataSet.Workers". При необходимости она может быть перемещена или удалена.
            this.workersTableAdapter.Fill(this.dbDataSet.Workers);
            enrollmentsTableAdapter.Fill(dbDataSet.Enrollments);
            cardTableAdapter.Fill(dbDataSet.Card);
            workersTableAdapter.Fill(dbDataSet.Workers);
            
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            FormAddWorker f = new FormAddWorker();

            if ( f.ShowDialog() == DialogResult.OK )
            {
                workersTableAdapter.Insert(f.Surname.Text, f.Name_Worker.Text, f.Middlename.Text, f.Table_num.Text, Convert.ToDateTime(f.BithDate.Text), f.Bill_Num.Text, label5.Text, false);
                workersTableAdapter.Fill(dbDataSet.Workers);
            }
        }


        private void FireButton_Click(object sender, EventArgs e)
        {
            //Кнопка увольнения сотрудника, просто меняет "переключатель" в бд на противоположное значение
            Dictionary<string, string> c = workersDataGridView.GetCellsPls();
            workersTableAdapter.UpdateFiredStatus(!Convert.ToBoolean(c [ "Fired" ]), Convert.ToInt32(c [ "WCode" ]));
            workersTableAdapter.Fill(dbDataSet.Workers);
        }

        private void FillTheWorkSheet(DataGridView dg, Excel.Worksheet wsh)
        {
            //Заполняет лист экселя на базе DataGrid'а

            //Заголовки колонок
            for ( int i = 1; i < dg.Columns.Count + 1; i++ )
            {
                wsh.Cells [ 1, i ] = dg.Columns [ i - 1 ].HeaderText;
            }
            //данные колонок
            for ( int i = 1; i < dg.RowCount + 1; i++ )
            {
                for ( int j = 1; j < dg.ColumnCount + 1; j++ )
                {
                    wsh.Rows [ i + 1 ].Columns [ j ] = dg.Rows [ i - 1 ].Cells [ j - 1 ].Value;
                }
            }
            //наводим красоту в таблице при помощи стандартных методов экселя
            try
            {
                wsh.Range [ "A1", wsh.Rows [ dg.RowCount + 1 ].Columns [ dg.ColumnCount ] ].AutoFormat(Format:
   Excel.XlRangeAutoFormat.xlRangeAutoFormatClassic2);
                wsh.Columns.AutoFit();
            }
            catch ( Exception )
            {
                Debug.WriteLine("Ошибка из-за версии экселя меньше 2016");
            }
            
        }
        private void ExportButton_Click(object sender, EventArgs e)
        {

            SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "Excel Documents (*.xlsx)|*.xlsx",
                FileName = label1.Text + DateTime.Now.ToString(" MM.dd")
            + ".xlsx"
            };
            if ( sfd.ShowDialog() == DialogResult.OK )

            {
                Excel.Application excelapp = new Excel.Application
                {
                    SheetsInNewWorkbook = 4
                };
                Excel.Workbook workbook = excelapp.Workbooks.Add();
                //Excel.Workbook workbook2 = excelapp.Workbooks.Add(); // Новый файл для экспорта, мб понадобится при разростании проекта в нечто огромное

                Excel.Worksheet wsh = workbook.Sheets[1];
                Excel.Worksheet wsh2 = workbook.Sheets[2];
                Excel.Worksheet wsh3 = workbook.Sheets[3];
                Excel.Worksheet wsh4 = workbook.Sheets[4];


                wsh.Name = "Сотрудники";
                wsh2.Name = "Карты";
                wsh3.Name = "Зачисления";
                wsh4.Name = "Зачисления по картам";

                FillTheWorkSheet(workersDataGridView, wsh);
                FillTheWorkSheet(cardsGridView, wsh2);
                FillTheWorkSheet(dataGridView3, wsh3);
                FillTheWorkSheet(dataGridView2, wsh4);

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
            foreach ( KeyValuePair<string, string> kvp in c )
            {
                if ( kvp.Key != "WBirth" )
                {
                    f.Controls [ kvp.Key ].Text = kvp.Value;
                }
                else
                {
                    f.Controls [ kvp.Key ].Text = kvp.Value.Split(' ') [ 0 ];
                }
            }
            if ( f.ShowDialog() == DialogResult.OK )
            {
                //cardTableAdapter.Insert(f.WSurname, f.WName, f.WMiddlename, f.Table_num.Text, Docum, Docum_serial, Docum_num, Docum_date, Docum_place, Docum_cod, City, Region_cod, District, Street, House, Block, Apartment, [ Index ], Birth, Place_Of_Birth, Sex, SNILS,
                 //        Home_phone, Mobile_phone, INN_worker, Full_Name_Card, Code_Word, Bank_Code, Card_type, Docum2, Docum2_serial, Docum2_num, Docum2_date, Docum2_place, City2, Region_cod2, District2, Street2, House2, Block2,
                 //        Apartment2, Index2, Action_param, Employment_Date, Salary, Email, Org_key, Code);
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
            enrollmentsTableAdapter.Update(dbDataSet.Enrollments);
            enrollmentsTableAdapter.Fill(dbDataSet.Enrollments);
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            //сброс изменений простой перезагрузкой значений из бд в адаптер таблицы
            enrollmentsTableAdapter.Fill(dbDataSet.Enrollments);
        }



        private void enrollmentsDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //автоматическое заполнение колонки "Код организации", ибо она не меняется
            DataGridView dg = (DataGridView)sender;
            dg.CurrentRow.Cells [ 1 ].Value = label5.Text;
            dg.CurrentRow.Cells [ 2 ].Value = dg.Tag.ToString();
        }

        private void enrollmentsDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // при ошибке ввода помечаем ячейку и сбрасываем изменения
            return;
            DataGridView view = (DataGridView)sender;
            view.Rows [ e.RowIndex ].Cells [ e.ColumnIndex ].ErrorText = "ошибка ввода";
            e.Cancel = false;
            e.ThrowException = false;

        }

        private void enrollmentsDataGridView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            // убираем метку ошибки при изменении ячейки
            DataGridView view = (DataGridView)sender;
            view.Rows [ e.RowIndex ].Cells [ e.ColumnIndex ].ErrorText = String.Empty;
        }

        private void Organizations_FormClosed(object sender, FormClosedEventArgs e)
        {
            // сохранение таблицы с зачислениями при закрытии
            
            enrollmentsTableAdapter.Update(dbDataSet.Enrollments);
            tableAdapterManager.UpdateAll(dbDataSet);
            dbDataSet.AcceptChanges();
        }

        private void enrollmentsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dg = (DataGridView)sender;
            Debug.WriteLine(dg.Columns [ e.ColumnIndex ].HeaderCell.Value);
            if ( !dg.CurrentRow.IsNewRow && dg.Columns[e.ColumnIndex].HeaderText == "Удалить" ) //make sure button index here
            {
                dg.Rows.Remove(dg.Rows [ e.RowIndex ]);
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
            
        }

        private void button23_Click(object sender, EventArgs e)
        {

            MainProgram.Context.MainForm = new SalaryProjectForm();
            Close();
            MainProgram.Context.MainForm.Show();
        }
    }
}
