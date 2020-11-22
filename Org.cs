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

        private void Button3_Click(object sender, EventArgs e)
        {
            workersTableAdapter.Fill(dbDataSet.Workers);
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

        private void ContextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void FireButton_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> c = cardDataGridView.GetCellsPls();
            workersTableAdapter.UpdateFiredStatus(!Convert.ToBoolean(c["Fired"]), Convert.ToInt32(c["WCode"]));
            workersTableAdapter.Fill(dbDataSet.Workers);
        }
        private void FillTheWorkSheet(DataGridView dg, Excel.Worksheet wsh)
        {
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
                    SheetsInNewWorkbook = 2
                };
                Excel.Workbook workbook = excelapp.Workbooks.Add();
                //Excel.Workbook workbook2 = excelapp.Workbooks.Add(); // Новый файл для экспорта, мб понадобится при разростании проекта в нечто огромное

                Excel.Worksheet worksheet = workbook.Sheets[1];
                Excel.Worksheet worksheet2 = workbook.Sheets[2];
                worksheet.Name = "Сотрудники";
                worksheet2.Name = "Карты";

                FillTheWorkSheet(cardDataGridView, worksheet);
                FillTheWorkSheet(dataGridView1, worksheet2);


                excelapp.AlertBeforeOverwriting = false;
                workbook.SaveAs(sfd.FileName);
                excelapp.Visible = true;
            }
        }

        private void AddCardButton_Click(object sender, EventArgs e)
        {

            FormAddCard f = new FormAddCard();
            Dictionary<string, string> c = cardDataGridView.GetCellsPls()
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
                //TODO добавить функцию в форму, которая возвращает список не правильно заполненных полей, если такие есть, то спросить оставить все как есть или откатить изменения (отрыть заного диалог с формой ShowDialog)
                //
                cardTableAdapter.Insert( f.WSurname.Text, f.WName.Text, f.WMiddlename.Text, f.Table_num.Text, f.Docum.Text, int.Parse(f.Docum_Serial.Text), int.Parse(f.Docum_Num.Text), Convert.ToDateTime(f.DateTime2.Text), f.Docum_Place.Text, f.Docum_Cod.Text, f.Mass[0], int.Parse(f.Mass[1]), f.Mass[2], f.Mass[3], f.Mass[4], f.Mass[5], f.Mass[6], int.Parse(f.Mass[7]), Convert.ToDateTime(f.WBirth.Text), f.PlaceOfBirth.Text, f.Sex.Text, f.SNILS.Text, f.Home_Phone.Text, f.INN_worker.Text, f.Full_Name_Card.Text, f.Code_Word.Text, f.Bank_Code.Text, f.Card_Type.Text, Convert.ToDateTime(f.EmpDate.Text), f.Salary.Text, f.Email.Text, f.Org_key.Text, int.Parse(f.WCode.Text));
                
                
                cardTableAdapter.Fill(dbDataSet.Card);
            }
        }

        private void Button_DOS_Click(object sender, EventArgs e)
        {
            FormDOS f = new FormDOS(this);
            f.Show();
        }
    }
}
