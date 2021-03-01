using SalaryRegistersUralsib.bd.DbDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SalaryRegistersUralsib
{
    public partial class SalaryProjectForm : Form
    {
        public SalaryProjectForm()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.Icon1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                organizationsTableAdapter1.Fill(dbDataSet.Organizations);
            }
            catch ( Exception )
            {
                MessageBox.Show("Не удалось открыть базу данных.");
                Close();
            }
            
        }

        private void AddOrg_Click(object sender, EventArgs e)
        {
            //Добавление Организации

            FormAddOrganization f = new FormAddOrganization(); // создать форму

            if ( f.ShowDialog() == DialogResult.OK ) // отобразить форму
            {
                // если OK, то добавить
                
                string Org, Org_key, Mngr, Mngr_d, Desc, Booker;
                Org = f.textBox1.Text;
                Org_key = f.textBox2.Text;
                Mngr = f.textBox4.Text;
                Mngr_d = f.textBox5.Text;
                Booker = f.textBox6.Text;
                Desc = f.checkBox1.Checked ? "+" : "-";

                try
                {
                    organizationsTableAdapter1.Insert(Org, Org_key, Desc, Mngr, Mngr_d, Booker, null, null, null, null, null, null);
                    organizationsTableAdapter1.Fill(dbDataSet.Organizations); // отображение
                }
                catch ( Exception exc )
                {
                    MessageBox.Show("Ошибка при изменении базы данных:\n" + exc.Message);
                }
            }
        }

        private void SelectOrg_Click(object sender, EventArgs e)
        {
            //Выбор организации
            Dictionary<string, string> s = dataGridView2.GetCellsPls();
            string str = s["Organization"].ToString();
            string orgKey = s["Org_key"].ToString();

            //Отображение формы Зарплатного проекта с выбраной организацией
            Organizations f = new Organizations();

            f.label1.Text = str; //Текущая организация = label1
            f.label5.Text = orgKey;
            f.Text = str + " - " + orgKey; //Название окна = Текущая организация + Код организации

            //Фильтр таблиц по текущей организации
            f.workersBindingSource.Filter = "Org_key = '" + orgKey + "'";
            f.cardBindingSource.Filter = "Org_key = '" + orgKey + "'";
            f.OrgBindingSource.Filter = "org_key = '" + orgKey + "'";

            f.enrollmentsBindingSource.Filter += " AND (Org_key = '" + orgKey + "')";
            f.CardEnrollmentsBindingSource.Filter += " AND (Org_key = '" + orgKey + "')";
            f.ReestrBindingSource.Filter += " AND (Org_key = '" + orgKey + "')";
            f.UvalBindingSource.Filter += " AND (Org_key = '" + orgKey + "')";



            MainProgram.Context.MainForm = f;//смена главной формы
            
            MainProgram.Context.MainForm.Show();//открытие главной формы
            Close();//закрытие текущей формы
        }



        private void DataGridView1_KeyPress(object sender, KeyEventArgs e)
        {
            if ( e.KeyCode == Keys.Enter )
            {
                e.Handled = true;
                SelectOrg_Click(sender, e);
            }
        }

        private void РедактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // редактирование организации
            FormEditOrg f = new FormEditOrg();
            // заполнить массив с текущими значениями
            Dictionary<string, string> OrgMas = dataGridView2.GetCellsPls();

            // ввести текущие значения в текстбоксы
            f.textBox1.Text = OrgMas [ "Organization" ];
            //* Код организации больше не меняется, значение не редактируемое
            f.textBox2.Text = OrgMas [ "Org_key" ];
            f.checkBox1.Checked = ( OrgMas [ "Descriptor" ] == "+" );
            f.textBox4.Text = OrgMas [ "Manager" ];
            f.textBox5.Text = OrgMas [ "Manager_d" ];
            f.textBox6.Text = OrgMas [ "Booker" ];

            if ( f.ShowDialog() == DialogResult.OK ) // отобразить форму
            {
                // если OK, то редактировать

                string Org, Org_key, Mngr, Mngr_d, Desc, Booker;
                Org = f.textBox1.Text;

                Org_key = f.textBox2.Text;
                Mngr = f.textBox4.Text;
                Mngr_d = f.textBox5.Text;
                Booker = f.textBox6.Text;
                if ( f.checkBox1.Checked ) // дескриптор
                {
                    Desc = "+";
                }
                else
                {
                    Desc = "-";
                }

                organizationsTableAdapter1.Update(Org, Desc, Mngr, Mngr_d, Booker, null, null, null, null, null, null, Org_key);
                organizationsTableAdapter1.ClearBeforeFill = false;//что бы таблица не очищалась перед отображением
                organizationsTableAdapter1.Fill(dbDataSet.Organizations); // отображение
                organizationsTableAdapter1.ClearBeforeFill = true;
            }
        }

        private void УдалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDelOrg f = new FormDelOrg();
            if ( dataGridView2.RowCount <= 1 ) return;//удаление организации, если она последняя, то не удалить
            // получить позицию выделенной строки в dataGridView1

            Dictionary<string, string> OrgMas = dataGridView2.GetCellsPls();
            f.label2.Text = "Наименование удаляемой организации: " + "\n" +
                            OrgMas [ "Organization" ] + "\n" +
                            "Вы действительно хотите удалить её?"
                            ;
            if ( f.ShowDialog() == DialogResult.OK )
            {
                organizationsTableAdapter1.Delete(OrgMas [ "Org_key" ]);
                organizationsTableAdapter1.Fill(dbDataSet.Organizations); // отображениечя
            }
        }

        private void HelpClick(object sender, EventArgs e)
        {

        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dd = sender as DataGridView;


                if ( dd.SelectedRows.Count > 0 )
                {
                    string org_Key = dd.SelectedRows[0].Cells["orgkeyDataGridViewTextBoxColumn"].Value.ToString() ?? String.Empty;
                    string org = dd.SelectedRows[0].Cells["organizationDataGridViewTextBoxColumn"].Value.ToString() ?? String.Empty;
                    int? arg1 = new WorkersTableAdapter().GetWorkersCount(org_Key);
                    int? arg2 = new CardTableAdapter().GetCardsCount(org_Key);
                    toolStripStatusLabel1.Text = string.Format("{0}, {1} сотр., {2} карт.", org, arg1, arg2);
                }
            
                

            
            
        }
    }
}
