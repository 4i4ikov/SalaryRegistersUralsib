
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq.Expressions;
using System.Windows.Forms;

using Excel = Microsoft.Office.Interop.Excel;
namespace SalaryRegistersUralsib
{
    public partial class Organizations : Form
    {
        List<List<Int32>> myList = new List<List<Int32>>();
        public Organizations()
        {

            InitializeComponent();
            this.Icon = Properties.Resources.Icon1;

            myList.Add(new List<Int32> { 20, 20, 20, 20, 3, 14, 13, 10, 80, 7, 30, 2, 30, 45, 5, 3, 5, 6, 10, 100, 1, 11, 10, 10, 12, 22, 20, 4, 4, 3, 14, 13, 10, 34, 30, 2, 30, 45, 5, 3, 5, 6, 10, 10, 10, 50 });
            myList.Add(new List<Int32> { });
            myList.Add(new List<Int32> { });
            myList.Add(new List<Int32> { });
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
            organizationsTableAdapter1.Fill(dbDataSet.Organizations);
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
            workersTableAdapter.ClearBeforeFill = false;
            workersTableAdapter.Fill(dbDataSet.Workers);
            workersTableAdapter.ClearBeforeFill = true;
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
                FillTheWorkSheet(GridView1, wsh2);
                FillTheWorkSheet(GridView2, wsh3);
                FillTheWorkSheet(GridView3, wsh4);

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
                //Debug.WriteLine(f.Doc);
                //Debug.WriteLine(" ");
                //Debug.WriteLine(f.Doc2);

                
                cardTableAdapter.Insert(f.WSurname.Text, f.WName.Text, f.WMiddlename.Text, f.Table_num.Text, f.Doc [ 0 ] ?? null, f.Doc [ 1 ] ?? null, f.Doc [ 2 ] ?? null, f.Doc [ 3 ] ?? null, f.Doc [ 4 ] ?? null, f.Doc [ 5 ] ?? null, f.Mass [ 0 ] ?? null, f.Mass [ 1 ] ?? null, f.Mass [ 2 ] ?? null, f.Mass [ 3 ] ?? null, f.Mass [ 4 ] ?? null, f.Mass [ 5 ] ?? null, f.Mass [ 6 ] ?? null, f.Mass [ 7 ] ?? null, f.WBirth.Text, f.Place_Of_Birth.Text, f.Sex.SelectedIndex.ToString(), f.SNILS.Text, f.Phone.Text, f.Phone.Text, f.INN_worker.Text, f.Full_Name_Card.Text, f.Code_Word.Text, f.Bank_Code.Text, f.Card_type.Text, f.Doc2 [ 0 ] ?? null, f.Doc2 [ 1 ] ?? null, f.Doc2 [ 2 ] ?? null, f.Doc2 [ 3 ] ?? null, f.Doc2 [ 4 ] ?? null, f.Mass2 [ 0 ] ?? null, f.Mass2 [ 1 ] ?? null, f.Mass2 [ 2 ] ?? null, f.Mass2 [ 3 ] ?? null, f.Mass2 [ 4 ] ?? null, f.Mass2 [ 5 ] ?? null, f.Mass2 [ 6 ] ?? null, f.Mass2 [ 7 ] ?? null, f.Action_param.Text, f.Employment_Date.Text, f.Salary.Text, f.Email.Text, int.Parse(f.Card_N.Text), f.Org_key.Text, int.Parse(f.WCode.Text));

                cardTableAdapter.Fill(dbDataSet.Card);
            }
        }

        private void Button_DOS_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog
            {
                
                FileName = DateTime.Now.ToString("MM.dd")+".N01"
            
            };
            if ( sfd.ShowDialog() == DialogResult.OK )

            {
                string s = "";
                foreach ( int i in myList [ tabControl1.SelectedIndex - 1 ] )
                {
                    s += i + " ";
                }
                Debug.WriteLine(s);
                //DataGridView d = tabControl1.SelectedTab.Controls [ "GridView" + tabControl1.SelectedIndex ] as DataGridView;
                //s = "";
                //foreach ( DataGridViewRow row in d.Rows )
                //{
                //    foreach ( DataGridViewCell cell in row.Cells )
                //    {
                //        Debug.WriteLine(cell.Value.ToString());
                //    }
                //}
                DataGridView d = tabControl1.SelectedTab.Controls [ "GridView" + tabControl1.SelectedIndex ] as DataGridView;

                string str = d.Rows.Count.ToString().PadLeft(5)+"\n";
                foreach ( DataGridViewRow row in d.Rows )
                {
                    int n = 0;
                    foreach ( int i in myList [ tabControl1.SelectedIndex - 1 ] )
                    {
                        str += row.Cells [ n ].Value.ToString().PadRight(i);

                        n++;
                    }
                    str += "*\n";
                }
                File.WriteAllText(sfd.FileName, str.Remove(str.Length - 2), System.Text.Encoding.GetEncoding(866));
                Unix2Dos(sfd.FileName);
            }
        }
        private void Unix2Dos(string fileName)
        {
            const byte CR = 0x0D;
            const byte LF = 0x0A;
            byte[] DOS_LINE_ENDING = new byte[] { CR, LF };
            byte[] data = File.ReadAllBytes(fileName);
            using ( FileStream fileStream = File.OpenWrite(fileName) )
            {
                BinaryWriter bw = new BinaryWriter(fileStream);
                int position = 0;
                int index = 0;
                do
                {
                    index = Array.IndexOf<byte>(data, LF, position);
                    if ( index >= 0 )
                    {
                        if ( ( index > 0 ) && ( data [ index - 1 ] == CR ) )
                        {
                            // already dos ending
                            bw.Write(data, position, index - position + 1);
                        }
                        else
                        {
                            bw.Write(data, position, index - position);
                            bw.Write(DOS_LINE_ENDING);
                        }
                        position = index + 1;
                    }
                }
                while ( index >= 0 );
                bw.Write(data, position, data.Length - position);
                fileStream.SetLength(fileStream.Position);
            }
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
            OrgBindingSource.EndEdit();
            enrollmentsBindingSource.EndEdit();

            enrollmentsTableAdapter.Update(dbDataSet.Enrollments);
            organizationsTableAdapter1.Update(dbDataSet.Organizations);
            tableAdapterManager.UpdateAll(dbDataSet);
            dbDataSet.AcceptChanges();
        }

        private void enrollmentsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dg = (DataGridView)sender;
            Debug.WriteLine(dg.Columns [ e.ColumnIndex ].HeaderCell.Value);
            if ( !dg.CurrentRow.IsNewRow && dg.Columns [ e.ColumnIndex ].HeaderText == "Удалить" ) //make sure button index here
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

        private void button21_Click_1(object sender, EventArgs e)
        {
        }

        private void Button_LoadFromDOS_Click(object sender, EventArgs e)
        {
            OpenFileDialog opn = new OpenFileDialog();
            if ( opn.ShowDialog() == DialogResult.OK )
            {
                //Get the path of specified file
                string filePath = opn.FileName;
                string text = File.ReadAllText(filePath, System.Text.Encoding.GetEncoding(866));
                string[] sep = {"\r\n" };
                string[] st = text.Split(sep,StringSplitOptions.None);
                for ( int i = 1; i < int.Parse(st[0])+1; i++ )
                {
                    int point = 0;
                    List<string> m = new List<string>();
                    foreach ( int j in myList [ tabControl1.SelectedIndex - 1 ] )
                    {
                        string str = "";
                        for ( int n = 0; n < j; n++ )
                        {
                            str += st [ i ] [ point ];
                            point++;
                        }
                        m.Add(str.Trim());
                    }
                    Random r = new Random();
                    m.Add(r.Next(100000000, 999999999).ToString());
                    m.Add(label5.Text);
                    m.Add(r.Next(100).ToString());
                    dbDataSet.Card.Rows.Add(m.ToArray());
                    cardTableAdapter.Update(dbDataSet.Card);
                    cardTableAdapter.Fill(dbDataSet.Card);
                        //Debug.WriteLine(st [ i ]);
                }
                //foreach (string s in st )
                //{
                    
                //}
            }
        }
    }
}
