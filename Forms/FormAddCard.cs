using SalaryRegistersUralsib.Forms;

using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;
namespace SalaryRegistersUralsib
{
    public partial class FormAddCard : Form
    {
        public List<string> Mass { get; set; }
        public List<string> Mass2 { get; set; }

        public FormAddCard()
        {

            InitializeComponent();
        }
        public void FormAddWorker_Load(object sender, EventArgs e)
        {
            foreach ( Control control in Controls )
            {
                if ( control is CueTextBox textBox )
                {
                    textBox.Validating += new System.ComponentModel.CancelEventHandler(textBox.CheckString);

                }
            }
            
        }



        private void Place_Enter(object sender, EventArgs e)
        {
            FormSelectPlace f = new FormSelectPlace();
            if ( f.ShowDialog() == DialogResult.OK && sender is Button b ) // отобразить форму
            {


                if ( Boolean.Parse(b.Tag.ToString()) )
                {
                    Mass = f.GetData();
                    Mass.Reverse();
                    MessageBox.Show(String.Join(", ", Mass.ToArray()));
                }
                else
                {
                    Mass2 = f.GetData();
                    Mass2.Reverse();
                    MessageBox.Show(String.Join(", ", Mass2.ToArray()));
                }



            }
        }

        //TODO удостовериться что проверку снилс можно удалить из кода формы

        /*//ПРОВЕРКА СНИЛС
        public bool SNILSValidate(string snils)
        {
            string workSnils = OnlyDigits(snils);
            bool result = false;

            if (workSnils.Length == 9)
            {
                result = false;
            }
            else if (workSnils.Length == 11)
            {
                int controlSum = SNILSContolCalc(workSnils);
                int strControlSum = int.Parse(workSnils.Substring(9, 2));
                if (controlSum == strControlSum)
                {
                    result = true;
                }
            }
            else
            {
                result = false;
            }

            return result;
        }
        public static int SNILSContolCalc(string snils)
        {
            string workSnils = OnlyDigits(snils);

            if (workSnils.Length != 9 && workSnils.Length != 11)
            {
                throw new Exception(string.Format("Incorrect SNILS number. {0} digits! (it can only be 9 or 11 digits!)", workSnils.Length));
            }

            if (workSnils.Length == 11)
            {
                workSnils = workSnils.Substring(0, 9);
            }

            int totalSum = 0;
            for (int i = workSnils.Length - 1, j = 0; i >= 0; i--, j++)
            {
                int digit = int.Parse(workSnils[i].ToString());
                totalSum += digit * (j + 1);
            }

            return SNILSCheckControlSum(totalSum);
        }
        private static int SNILSCheckControlSum(int _controlSum)
        {
            int result;
            if (_controlSum < 100)
            {
                result = _controlSum;
            }
            else if (_controlSum <= 101)
            {
                result = 0;
            }
            else
            {
                int balance = _controlSum % 101;
                result = SNILSCheckControlSum(balance);
            }
            return result;
        }

        private void SNILS_TextChanged(object sender, EventArgs e)
        {
            CueTextBox lol = sender as CueTextBox;
            //if (!SNILSValidate(lol.Text))
            if (false)
            {
                lol.ForeColor = Color.Red;
                if (lol.Tag != null)
                {
                    if (!(new Regex(@lol.Tag.ToString()).IsMatch(lol.Parent.FindForm().Tag.ToString())))
                    {
                        lol.Parent.FindForm().Tag += " " + lol.Tag.ToString();

                    }
                }
            }
            else
            {
                lol.ForeColor = Color.Black;
                lol.Parent.FindForm().Tag = Regex.Replace(lol.Parent.FindForm().Tag.ToString(), " " + @lol.Tag.ToString(), string.Empty);
            }
        }
        // !ПРОВЕРКА СНИЛС
        public static string OnlyDigits(string source)
        {
            string result = string.Empty;

            foreach (char ch in source)
            {
                if (char.IsDigit(ch))
                {
                    result += ch;
                }
            }

            return result;
        }*/


        private void FormAddWorker_FormClosing(object sender, FormClosingEventArgs e)
        {

            if ( DialogResult != DialogResult.OK )
            {
                return;
            }

            //Проверка всех TextBox на соответствие требованиям(валидация)
            List<string> reasons = new List<string> { };
            ValidateChildren();
            foreach ( Control control in Controls )
            {
                if ( control is CueTextBox textBox )
                {

                    if ( ( new Regex(@textBox.Tag.ToString()).IsMatch(textBox.Parent.FindForm().Tag.ToString()) ) )
                    {
                        //e.Cancel = true;
                        reasons.Add(textBox.Tag.ToString());
                    }

                }
            }
            if ( e.Cancel )
            {
                MessageBox.Show("Требуется правильно заполнить: " + string.Join(", ", reasons.ToArray()));
            }
            //TODO проверить можно ли удалить старую валидацию формы добавления карт
            //if (DialogResult != DialogResult.OK)
            //{
            //    return;
            //}
            //foreach (Control control in Controls)
            //{
            //    if (control is CueTextBox textBox)
            //    {
            //        string ch = textBox._check(textBox, true);
            //        if (!(Tag.ToString().IndexOf(ch) > -1))
            //        {
            //            Tag += ch + ",";
            //        }
            //    }
            //}
            //if (!(string.IsNullOrWhiteSpace(Tag.ToString())))
            //{
            //    //e.Cancel = true;
            //    MessageBox.Show("Не верно заполненные значения \n" + Tag.ToString());
            //}

        }



        private void Card_Type_Enter(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ведется доработка, значения не будут добавлены в БД");
        }



        private void Sex_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void button6_Click(object sender, EventArgs e)
        {
            FormDocumPick f = new FormDocumPick();
            if ( f.ShowDialog() == DialogResult.OK )
            {
                MessageBox.Show("ведется доработка.");
            }
        }
    }

}
