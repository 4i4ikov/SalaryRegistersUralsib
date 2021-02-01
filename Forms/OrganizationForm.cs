
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
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

            myList.Add(new List<Int32> { 20, 20, 20, 20, 3, 14, 13, 10, 80, 7, 30, 2, 30, 45, 5, 3, 5, 6, 10, 100, 1, 11, 10, 10, 12, 22, 20, 4, 4, 3, 14, 13, 10, 34, 30, 2, 30, 45, 5, 3, 5, 6, 10, 10, 10, 50 });//Настройки для создания и загрузки из дос файла ОТКРЫТИЯ КАРТ

        }





        private void FormZP_Load(object sender, EventArgs e)
        {
            workersTableAdapter.Fill(dbDataSet.Workers);
            enrollmentsTableAdapter.Fill(dbDataSet.Enrollments);
            cardTableAdapter.Fill(dbDataSet.Card);
            organizationsTableAdapter1.Fill(dbDataSet.Organizations);
            tabControl1.SelectedIndex = 6;
            tabControl1.SelectedIndex = 0;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            //кнопка добавления сотрудника
            FormAddWorker f = new FormAddWorker();

            if ( f.ShowDialog() == DialogResult.OK )
            {
                workersTableAdapter.Insert(f.Surname.Text, f.Name_Worker.Text, f.Middlename.Text, f.Table_num.Text, Convert.ToDateTime(f.BithDate.Text), f.Bill_Num.Text, label5.Text, false);
                workersTableAdapter.Fill(dbDataSet.Workers);
            }
        }

        private void FireButton_Click(object sender, EventArgs e)
        {
            //Кнопка увольнения сотрудника
            Dictionary<string, string> c = workersDataGridView.GetCellsPls();
            if ( !Convert.ToBoolean(c [ "Fired" ]) )
            {
                DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите уволить сотрудника с именем "+c["WName"]+"?\nЭто действие невозможно отменить.", " Подтверждение увольнения", MessageBoxButtons.YesNo);
                if ( dialogResult == DialogResult.Yes )
                {
                    workersTableAdapter.UpdateFiredStatus(!Convert.ToBoolean(c [ "Fired" ]), Convert.ToInt32(c [ "WCode" ]));
                    DialogResult dg = MessageBox.Show("Добавить в таблицу на вкладке \"Увольнение\"?", "Добавление на вкладку", MessageBoxButtons.YesNo);
                    if ( dg == DialogResult.Yes )
                    {
                        enrollmentsTableAdapter.Insert(label5.Text, c [ "Table_num" ], c [ "WSurname" ], c [ "WName" ], c [ "WMiddlename" ], null, null, null, null, "uval");
                        enrollmentsTableAdapter.Fill(dbDataSet.Enrollments);
                    }
                    workersTableAdapter.ClearBeforeFill = false;
                    workersTableAdapter.Fill(dbDataSet.Workers);
                    workersTableAdapter.ClearBeforeFill = true;
                }
            }
            else MessageBox.Show(c [ "WName" ] + " уже уволен(а)!");
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
                if ( !dg.Rows [ i - 1 ].IsNewRow )
                {
                    for ( int j = 1; j < dg.ColumnCount + 1; j++ )
                    {
                        wsh.Rows [ i + 1 ].Columns [ j ] = dg.Rows [ i - 1 ].Cells [ j - 1 ].Value;
                    }
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
            //Кнопка экспортировать в эксель
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
                    SheetsInNewWorkbook = 6
                };
                Excel.Workbook workbook = excelapp.Workbooks.Add();
                //Excel.Workbook workbook2 = excelapp.Workbooks.Add(); 

                Excel.Worksheet wsh = workbook.Sheets[1];
                Excel.Worksheet wsh2 = workbook.Sheets[2];
                Excel.Worksheet wsh3 = workbook.Sheets[3];
                Excel.Worksheet wsh4 = workbook.Sheets[4];
                Excel.Worksheet wsh5 = workbook.Sheets[5];
                Excel.Worksheet wsh6 = workbook.Sheets[6];

                wsh.Name = "Сотрудники";
                wsh2.Name = "Карты";
                wsh3.Name = "Зачисления";
                wsh4.Name = "Зачисления по картам";
                wsh5.Name = "Реестр-распоряжение";
                wsh6.Name = "Увольнение";

                FillTheWorkSheet(workersDataGridView, wsh);
                FillTheWorkSheet(GridView1, wsh2);
                FillTheWorkSheet(GridView2, wsh3);
                FillTheWorkSheet(GridView3, wsh4);
                FillTheWorkSheet(GridView4, wsh5);
                FillTheWorkSheet(GridView5, wsh6);

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
                    f.Controls [ kvp.Key ].Text = kvp.Value.Split(' ') [ 0 ];//Если данные хранятся в формате дата+ВРЕМЯ(пробел между ними), а нам нужна только дата
                }
            }
            if ( f.ShowDialog() == DialogResult.OK )
            {
                try
                {
                    cardTableAdapter.Insert(f.WSurname.Text, f.WName.Text, f.WMiddlename.Text, f.Table_num.Text, f.Doc [ 0 ] ?? null, f.Doc [ 1 ] ?? null, f.Doc [ 2 ] ?? null, f.Doc [ 3 ] ?? null, f.Doc [ 4 ] ?? null, f.Doc [ 5 ] ?? null, f.Mass [ 0 ] ?? null, f.Mass [ 1 ] ?? null, f.Mass [ 2 ] ?? null, f.Mass [ 3 ] ?? null, f.Mass [ 4 ] ?? null, f.Mass [ 5 ] ?? null, f.Mass [ 6 ] ?? null, f.Mass [ 7 ] ?? null, f.WBirth.Text, f.Place_Of_Birth.Text, f.Sex.SelectedIndex.ToString(), f.SNILS.Text, f.Phone.Text, f.Phone.Text, f.INN_worker.Text, f.Full_Name_Card.Text, f.Code_Word.Text, f.Bank_Code.Text, f.Card_type.Text, f.Doc2 [ 0 ] ?? null, f.Doc2 [ 1 ] ?? null, f.Doc2 [ 2 ] ?? null, f.Doc2 [ 3 ] ?? null, f.Doc2 [ 4 ] ?? null, f.Mass2 [ 0 ] ?? null, f.Mass2 [ 1 ] ?? null, f.Mass2 [ 2 ] ?? null, f.Mass2 [ 3 ] ?? null, f.Mass2 [ 4 ] ?? null, f.Mass2 [ 5 ] ?? null, f.Mass2 [ 6 ] ?? null, f.Mass2 [ 7 ] ?? null, f.Action_param.Text, f.Employment_Date.Text, f.Salary.Text, f.Email.Text, f.Card_N.Text, f.Org_key.Text, int.Parse(f.WCode.Text));
                    cardTableAdapter.Fill(dbDataSet.Card);
                }
                catch { MessageBox.Show("Ошибка при добавлении карты. Попробуйте ещё раз."); }
            }
        }

        private void Button_DOS_Click(object sender, EventArgs e)//Кнопка создать дос на вкладке Откр.карт
        {
            SaveFileDialog sfd = new SaveFileDialog
            {
                FileName = CurOrgKey.Text+DateTime.Now.ToString("MM.dd")+".N01"
            };
            if ( sfd.ShowDialog() == DialogResult.OK )
            {
                DataGridView d = tabControl1.SelectedTab.Controls [ "GridView" + tabControl1.SelectedIndex ] as DataGridView;//текущая таблица
                string str = d.Rows.Count.ToString().PadLeft(5)+"\n";//количество строк в таблице
                foreach ( DataGridViewRow row in d.Rows )
                {
                    int n = 0;
                    foreach ( int i in myList [ tabControl1.SelectedIndex - 1 ] )
                    {
                        if ( row.Cells [ n ].OwningColumn.HeaderText != "Удалить" )
                            str += row.Cells [ n ].Value.ToString().PadRight(i);
                        n++;
                    }
                    str += "*\n";
                }
                File.WriteAllText(sfd.FileName, str.Remove(str.Length - 2), System.Text.Encoding.GetEncoding(866));
                Unix2Dos(sfd.FileName); //Перевод из Unix в DOS
            }
        }
        private void Unix2Dos(string fileName)//Взято из другого источника, готовый код
        {
            const byte CR = 0x0D;
            const byte LF = 0x0A;
            byte[] DOS_LINE_ENDING = new byte[] { CR, LF };
            byte[] data = File.ReadAllBytes(fileName);
            using ( FileStream fileStream = File.OpenWrite(fileName) )
            {
                BinaryWriter bw = new BinaryWriter(fileStream,System.Text.Encoding.GetEncoding(866));
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
            //сброс изменений простой перезагрузкой значений из бд
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
            // кнопка для удаления записи
            DataGridView dg = (DataGridView)sender;
            if ( !dg.CurrentRow.IsNewRow && dg.Columns [ e.ColumnIndex ].HeaderText == "Удалить" )
            {
                dg.Rows.Remove(dg.Rows [ e.RowIndex ]);
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            //кнопка назад
            MainProgram.Context.MainForm = new SalaryProjectForm();
            Close();
            MainProgram.Context.MainForm.Show();
        }

        private void Button_LoadFromDOS_Click(object sender, EventArgs e)
        {
            OpenFileDialog opn = new OpenFileDialog();//Открытие файла
            if ( opn.ShowDialog() == DialogResult.OK )
            {
                string filePath = opn.FileName;
                string text = File.ReadAllText(filePath, System.Text.Encoding.GetEncoding(866));//Чтение файла
                string[] st = text.Split(new string[]{ "\r\n" },StringSplitOptions.None);//Разбиваем строки на подстроки в виде массива
                try
                {
                    for ( int i = 1; i < int.Parse(st [ 0 ]) + 1; i++ )//перебор всех строк
                    {
                        int point = 0;
                        List<string> m = new List<string>();// массив строк для добавления в бд
                        foreach ( int j in myList [ tabControl1.SelectedIndex - 1 ] )// перебор массива с позициями каждой записи
                        {
                            string str = "";
                            for ( int n = 0; n < j; n++ )//посимвольное чтение строки
                            {
                                str += st [ i ] [ point ];
                                point++;
                            }
                            m.Add(str.Trim());//добавление полученной строки в массив
                        }
                        Random r = new Random();
                        m.Add(r.Next(100000000, 999999999).ToString());//рандомный номер карты
                        m.Add(label5.Text);//код организации
                        m.Add(r.Next(100).ToString());//рандомный код работника
                        dbDataSet.Card.Rows.Add(m.ToArray());//добавление строки в бд
                        cardTableAdapter.Update(dbDataSet.Card);//обновление таблицы
                        cardTableAdapter.Fill(dbDataSet.Card);//отображение таблицы
                    }
                }
                catch ( Exception ex )
                {
                    MessageBox.Show("Ошибка чтения файла.");
                    Debug.WriteLine(ex.Message);
                }
            }
        }

        private void CreateEnrollmentDos_Click(object sender, EventArgs e)//Кнопка создать DOS на вкладке Зачисления
        {
            SaveFileDialog sfd = new SaveFileDialog
            {
                FileName = CurOrgKey.Text+DateTime.Now.ToString("MMdd")+".l01"
            };

            if ( sfd.ShowDialog() == DialogResult.OK )
            {

                DataGridView d = tabControl1.SelectedTab.Controls [ "GridView" + tabControl1.SelectedIndex ] as DataGridView;//текущая таблица
                float sum = 0;

                foreach ( DataGridViewRow row in d.Rows )//перебор всех строк таблицы
                {
                    if ( !row.IsNewRow )//если это не новая строка
                    {
                        try
                        {
                            sum += (Single)row.Cells [ 6 ].Value;//вычисляем сумму
                        }
                        catch ( Exception ex )
                        {
                            Debug.WriteLine(ex.Message);//при ошибке пишем в консоль
                        }
                    }
                }

                string z = " ";// дескриптор

                if ( CurOrgDesc.Text == "+" ) z = "Z";

                string str = (d.Rows.Count-1).ToString().PadLeft(5)+//количество строк
                    CurOrgKey.Text.PadRight(8)+//код организации
                    String.Format("{0:0.00}", Convert.ToSingle(Math.Round(sum,2))).Replace(",", ".").PadLeft(14) +//сумма
                    z+"\n";//первая строка

                foreach ( DataGridViewRow row in d.Rows )//перебор всех строк таблицы
                {
                    if ( !row.IsNewRow )//если не новая строка
                    {
                        str += !Convert.IsDBNull(row.Cells [ 0 ].Value) ? row.Cells [ 0 ].Value.ToString().PadRight(20) : new string(' ', 20) ;//таб номер

                        str += String.Format("{0:0.00}",
                            Convert.ToSingle(Convert.IsDBNull(row.Cells [ 6 ].Value) ? "0,00" : row.Cells [ 6 ].Value)).Replace(",", ".").PadLeft(12);//сумма зачисл

                        str += (!Convert.IsDBNull(row.Cells [ 7 ].Value)) ? "0" + row.Cells [ 7 ].Value.ToString().PadLeft(1) : "  ";//вид вида выплаты

                        str += String.Format("{0:0.00}", Convert.ToSingle(Convert.IsDBNull(row.Cells [ 8 ].Value) ? "0,00" : row.Cells [ 8 ].Value)).Replace(",", ".").PadLeft(12);//сумма удерж
                        str += row.Cells [ 9 ].Value.ToString().PadLeft(1);//код вида дохода

                        str += "\n";//переход на новую строку
                    }
                }
                File.WriteAllText(sfd.FileName, str.Remove(str.Length - 1), System.Text.Encoding.GetEncoding(866));// сохранение файла
                Unix2Dos(sfd.FileName);//перевод в DOS
            }
        }

        private void LoadFromDosEnrollments_Click(object sender, EventArgs e)
        {
            //try
            //{
            OpenFileDialog opn = new OpenFileDialog();//открытие файла
            if ( opn.ShowDialog() == DialogResult.OK )
            {
                string filePath = opn.FileName;
                string[] text = File.ReadAllLines(filePath, System.Text.Encoding.GetEncoding(866));//чтение в нужной кодировке
                for ( int i = 1; i <= int.Parse(text [ 0 ].Substring(0, 5).Trim()); i++ )//перебор строк файла по количеству из него
                {
                    string tableNum = text[i].Substring(0,20).Trim();//табельный номер
                    
                    Single.TryParse(text [ i ].Substring(20, 12).Replace('.', ','), out float sum);
                    Single.TryParse(text [ i ].Substring(34, 12).Replace('.', ','), out float uderzh);//сумма удерж
                    string paytypecode = text [ i ].Substring(32, 2).Trim();//вид выплаты
                    string vid = text [ i ].Substring(46, 1).Trim();

                    string enrollment_type = tabControl1.SelectedTab.Controls [ "GridView" + tabControl1.SelectedIndex ].Tag.ToString();//тип зачисления для добавления в таблицу
                    dbDataSet.Enrollments.Rows.Add(new object [ ] { CurOrgKey.Text, null, tableNum, null, null, null, ( sum == 0 ) ? (Single?)null : sum, ( paytypecode == "" ) ? (int?)null : int.Parse(paytypecode), ( uderzh == 0 ) ? (Single?)null : uderzh, ( vid == "" ) ? (int?)null : int.Parse(vid), enrollment_type });//добавление данных в бд
                    enrollmentsTableAdapter.Update(dbDataSet.Enrollments);//обвновление таблицы
                    enrollmentsTableAdapter.Fill(dbDataSet.Enrollments);//заполнение таблицы
                }
            }
            //}
            //catch ( Exception ex )
            //{
            //    MessageBox.Show("Ошибка чтения файла.");
            //    Debug.WriteLine(ex.Message);
            //}
        }

        private void LoadWorkersList(object sender, EventArgs e)
        {
            foreach ( DataGridViewRow row in workersDataGridView.Rows )
            {
                if ( !(bool)row.Cells [ 7 ].Value )//не уволен ли сотрудник? 
                {
                    if ( tabControl1.SelectedTab.Controls [ "GridView" + tabControl1.SelectedIndex ].Tag.ToString() == "zach" )//Если это обычное зачисление
                        dbDataSet.Enrollments.Rows.Add(new object [ ] { label5.Text, null, row.Cells [ 3 ].Value, row.Cells [ 0 ].Value, row.Cells [ 1 ].Value, row.Cells [ 2 ].Value, null, null, null, null, tabControl1.SelectedTab.Controls [ "GridView" + tabControl1.SelectedIndex ].Tag.ToString() });
                    else // иначе это Зачисление по карте или реестр распоряжение, заполняем вместе с ФИО
                        dbDataSet.Enrollments.Rows.Add(new object [ ] { label5.Text, null, row.Cells [ 5 ].Value, row.Cells [ 0 ].Value, row.Cells [ 1 ].Value, row.Cells [ 2 ].Value, null, null, null, null, tabControl1.SelectedTab.Controls [ "GridView" + tabControl1.SelectedIndex ].Tag.ToString() });
                    enrollmentsTableAdapter.Update(dbDataSet.Enrollments);//обвновление таблицы
                    enrollmentsTableAdapter.Fill(dbDataSet.Enrollments);//заполнение таблицы
                }
            }
        }

        private void Zach2and3DosCreate(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog// сохранение файла
            {
                FileName = CurOrgKey.Text+DateTime.Now.ToString("MMdd")+".l01"
            };

            if ( sfd.ShowDialog() == DialogResult.OK )

            {

                DataGridView d = tabControl1.SelectedTab.Controls [ "GridView" + tabControl1.SelectedIndex ] as DataGridView;//Таблица текущей вкладки
                float sum = 0;

                foreach ( DataGridViewRow row in d.Rows )
                {
                    if ( !row.IsNewRow && !Convert.IsDBNull(row.Cells [ 6 ].Value) )
                    {
                        try
                        {
                            sum += (Single)row.Cells [ 6 ].Value;// считаем сумму всех зачислений
                        }
                        catch ( Exception ex )
                        {
                            Debug.WriteLine(ex.Message);
                        }
                    }
                }

                string z = ( CurOrgDesc.Text == "+" ) ? "Z":" ";

                string enrollment_type = tabControl1.SelectedTab.Controls [ "GridView" + tabControl1.SelectedIndex ].Tag.ToString();
                string str = "";
                switch ( enrollment_type )//первая строка разная в двух видах реестров
                {
                    case "cardzach":
                        str = ( d.Rows.Count - 1 ).ToString().PadLeft(5) +
                    CurOrgKey.Text.PadRight(10) +
                    String.Format("{0:0.00}", Convert.ToSingle(Math.Round(sum, 2))).Replace(",", ".").PadLeft(12) +
                    z + "\n";
                        break;

                    case "reestr":
                        str = ( d.Rows.Count - 1 ).ToString().PadLeft(5).Substring(0, 5) +// кол-во строк
                    CurOrgKey.Text.PadRight(10).Substring(0, 10) +//код орг
                    String.Format("{0:0.00}", Convert.ToSingle(Math.Round(sum, 2))).Replace(",", ".").PadLeft(12).Substring(0, 12) +//сумма
                    z +//дескриптор
                    DateTime.Now.ToString("dd.MM.yyyy") +//дата формирования реестра 01.01.2021
                    DateTime.Now.ToString("MM.yyyy") +//период зачисления(месяц) 01.2021
                    CurOrgName.Text.PadRight(150).Substring(0, 150) +//название организации 150
                    CurINN.Text.PadRight(12).Substring(0, 12) +//ИНН Организации длиной 12
                    CurOGRN.Text.PadRight(12).Substring(0, 12) +//ОГРН длиной 12
                    CurBill.Text.PadRight(12).Substring(0, 12) +//Счет длиной списания 12
                    CurBank.Text.PadRight(18).Substring(0, 18) +//Банк длиной 18
                    CurBankPodr.Text.PadRight(100).Substring(0, 100) +//Филиал банка длиной 100
                    CurBIK.Text.PadRight(9).Substring(0, 9) +//БИК длиной 9
                    "\n";

                        break;
                    default:
                        str = "\n";
                        break;
                }

                foreach ( DataGridViewRow row in d.Rows )
                {
                    if ( !row.IsNewRow )
                    {
                        str += row.Cells [ 3 ].Value.ToString().PadRight(20);//фамилия
                        str += row.Cells [ 4 ].Value.ToString().PadRight(20);//имя
                        str += row.Cells [ 5 ].Value.ToString().PadRight(20);//отчество

                        str += row.Cells [ 0 ].Value.ToString().PadRight(20);//табельный номер

                        str += String.Format("{0:0.00}", Convert.ToSingle(Convert.IsDBNull(row.Cells [ 6 ].Value) ? "0,00" : row.Cells [ 6 ].Value)).Replace(",", ".").PadLeft(12);//сумма
                        str += "0" + row.Cells [ 7 ].Value.ToString();//код вида выплаты

                        str += String.Format("{0:0.00}", Convert.ToSingle(Convert.IsDBNull(row.Cells [ 6 ].Value) ? "0,00" : row.Cells [ 8 ].Value)).Replace(",", ".").PadLeft(12);// сумма удерж
                        str += row.Cells [ 9 ].Value.ToString();//тип зачисления

                        str += "\n";
                    }

                }
                File.WriteAllText(sfd.FileName, str.Remove(str.Length - 1), System.Text.Encoding.GetEncoding(866));
                Unix2Dos(sfd.FileName);
            }
        }

        private void UvalCreateDosClick(object sender, EventArgs e)//Создать DOS Увольнения
        {
            SaveFileDialog sfd = new SaveFileDialog
            {
                FileName = CurOrgKey.Text+DateTime.Now.ToString("MMdd")+".Y01"
            };

            if ( sfd.ShowDialog() == DialogResult.OK )

            {

                DataGridView d = tabControl1.SelectedTab.Controls [ "GridView" + tabControl1.SelectedIndex ] as DataGridView;//текущая таблица

                string z = ( CurOrgDesc.Text == "+" ) ? "Z":" ";//дескриптор

                string str = (d.Rows.Count-1).ToString().PadLeft(5)+
                    CurOrgKey.Text.PadRight(8)+
                    z+"\n";//первая строка

                foreach ( DataGridViewRow row in d.Rows )
                {
                    if ( !row.IsNewRow )
                    {
                        str += row.Cells [ 0 ].Value.ToString().PadRight(20);//таб номер
                        str += row.Cells [ 3 ].Value.ToString().PadRight(30);//фамилия
                        str += row.Cells [ 4 ].Value.ToString().PadRight(20);//имя
                        str += row.Cells [ 5 ].Value.ToString().PadRight(20);//отчество
                        str += "\n";
                    }
                }
                File.WriteAllText(sfd.FileName, str.Remove(str.Length - 1), System.Text.Encoding.GetEncoding(866));//сохранение файла
                Unix2Dos(sfd.FileName);//перевести файл в DOS формат
            }
        }

        private void LoadFromDosEnrollments2and3(object sender, EventArgs e)
        {
            //try
            //{
            OpenFileDialog opn = new OpenFileDialog();
            if ( opn.ShowDialog() == DialogResult.OK )
            {
                string filePath = opn.FileName;
                string[] text = File.ReadAllLines(filePath, System.Text.Encoding.GetEncoding(866));
                for ( int i = 1; i <= int.Parse(text [ 0 ].Substring(0, 5).Trim()); i++ )
                {
                    string sur = text[i].Substring(0,20).Trim(); //фамилия
                    string nname = text[i].Substring(20,20).Trim();//имя
                    string mid = text[i].Substring(40,20).Trim();//отчество
                    string table_num = text[i].Substring(60,20).Trim();//табельный номер

                    Single.TryParse(text [ i ].Substring(20, 12).Replace('.', ','), out float sum);
                    Single.TryParse(text [ i ].Substring(34, 12).Replace('.', ','), out float uderzh);//сумма удерж
                    string paytypecode = text [ i ].Substring(32, 2).Trim();//вид выплаты
                    string vid = text [ i ].Substring(46, 1).Trim();

                    string enrollment_type = tabControl1.SelectedTab.Controls [ "GridView" +
                        tabControl1.SelectedIndex ].Tag.ToString();

                    dbDataSet.Enrollments.Rows.Add(new object [ ] { CurOrgKey.Text, null, table_num, sur, nname, mid, ( sum == 0 ) ? (Single?)null : sum, ( paytypecode == "" ) ? (int?)null : int.Parse(paytypecode), ( uderzh == 0 ) ? (Single?)null : uderzh, ( vid == "" ) ? (int?)null : int.Parse(vid), enrollment_type });
                    enrollmentsTableAdapter.Update(dbDataSet.Enrollments);
                    enrollmentsTableAdapter.Fill(dbDataSet.Enrollments);
                }
            }
            //}
            //catch ( Exception ex )
            //{
            //    MessageBox.Show("Ошибка чтения файла.");
            //    Debug.WriteLine(ex.Message);
            //}
        }
    }
}
