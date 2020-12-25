using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace pressF
{
    public partial class ZP : Form
    {
        public ZP()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            organizationsTableAdapter1.Fill(dbDataSet.Organizations);
            // if (Properties.Settings.Default.option1 == "debug")
            //  {
            button3.Enabled = true;
            // }
           /*         try
                     {
                       */

            organizationsTableAdapter1.Fill(dbDataSet.Organizations);
            /*
                        }

                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);

                            this.BeginInvoke(new MethodInvoker(this.Close));

                        }*/

        }

        private void ВыходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            //Добавление Организации

            FormAddOrganization f = new FormAddOrganization(); // создать форму

            if (f.ShowDialog() == DialogResult.OK) // отобразить форму
            {
                // если OK, то добавить

                string Org, Org_key, Mngr, Mngr_d, Desc, Booker;
                Org = f.textBox1.Text;
                Org_key = f.textBox2.Text;
                Mngr = f.textBox4.Text;
                Mngr_d = f.textBox5.Text;
                Booker = f.textBox6.Text;
                if (f.checkBox1.Checked) // дескриптор
                {
                    Desc = "+";
                }
                else
                {
                    Desc = "-";
                }

                try
                {
                    organizationsTableAdapter1.Insert(Org, Org_key, Desc, Mngr, Mngr_d, Booker); // добавление
                    organizationsTableAdapter1.Fill(dbDataSet.Organizations); // отображение
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Ошибка при обновлении базы данных" + exc);
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //Выбор организации
            Dictionary<string, string> s = dataGridView1.GetCellsPls();
            string str = s["Organization"].ToString();
            string orgKey = s["Org_key"].ToString();

            //Отображение формы Зарплатного проекта с выбраной организацией
            Organizations f = new Organizations();

            f.label1.Text = str; //Текущая организация = label1
            f.label5.Text = orgKey;
            f.Text = str + " - " + orgKey; //Название окна = Текущая организация + Код организации

            //Фильтр таблицы сотрудников по текущей организации
            f.workersBindingSource.Filter = "Org_key = '" + orgKey + "'";
            f.cardBindingSource.Filter = "Org_key = '" + orgKey + "'";
            f.enrollmentsBindingSource.Filter = "Org_key = '" + orgKey + "'";
            Program.Context.MainForm = f;
            Close();
            Program.Context.MainForm.Show();
            
        }



        private void DataGridView1_KeyPress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                Button1_Click(sender, e);
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            button3.ContextMenuStrip.Show(Cursor.Position);
        }

        private void РедактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // редактирование организации
            FormEditOrg f = new FormEditOrg();
            // заполнить массив с текущими значениями
            Dictionary<string, string> OrgMas = dataGridView1.GetCellsPls();

            // ввести текущие значения в текстбоксы
            f.textBox1.Text = OrgMas["Organization"];
            //* Код организации больше не меняется, значение не редактируемое
            f.textBox2.Text = OrgMas["Org_key"];
            f.checkBox1.Checked = (OrgMas["Descriptor"] == "+");
            f.textBox4.Text = OrgMas["Manager"];
            f.textBox5.Text = OrgMas["Manager_d"];
            f.textBox6.Text = OrgMas["Booker"];

            if (f.ShowDialog() == DialogResult.OK) // отобразить форму
            {
                // если OK, то редактировать

                string Org, Org_key, Mngr, Mngr_d, Desc, Booker;
                Org = f.textBox1.Text;

                Org_key = f.textBox2.Text;
                Mngr = f.textBox4.Text;
                Mngr_d = f.textBox5.Text;
                Booker = f.textBox6.Text;
                if (f.checkBox1.Checked) // дескриптор
                {
                    Desc = "+";
                }
                else
                {
                    Desc = "-";
                }

                /*this.organizationsTableAdapter1.Update(Org, OrgMas["Org_key"], Desc, Mngr, Mngr_d, Booker); // добавление */
                /*                this.organizationsTableAdapter1.Update(Org, Org_key, Desc, Mngr, Mngr_d, Booker);*/
                organizationsTableAdapter1.Update(Org, Desc, Mngr, Mngr_d, Booker, OrgMas["Organization"], OrgMas["Org_key"], OrgMas["Descriptor"], OrgMas["Manager"], OrgMas["Manager_d"], OrgMas["Booker"]);
                organizationsTableAdapter1.Fill(dbDataSet.Organizations); // отображение
            }
            /*MessageBox.Show(Org+OrgKey+Mngr+Mngr_d+Booker+Desc);*/
            /*Org, Org_key, Mngr, Mngr_d, Booker, Desc*/
        }

        private void УдалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDelOrg f = new FormDelOrg();
            if (dataGridView1.RowCount <= 1)
            {
                return;
            }

            // получить позицию выделенной строки в dataGridView1
            int index = dataGridView1.CurrentRow.Index;

            Dictionary<string, string> OrgMas = dataGridView1.GetCellsPls();
            f.label2.Text = "Наименование удаляемой организации: " + "\n" +
                            OrgMas["Organization"] + "\n" +
                            "Вы действительно хотите удалить её?"
                            ;
            if (f.ShowDialog() == DialogResult.OK)
            {
                organizationsTableAdapter1.Delete(OrgMas["Org_key"]);
                organizationsTableAdapter1.Fill(dbDataSet.Organizations); // отображениечя
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
