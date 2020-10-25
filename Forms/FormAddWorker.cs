using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
namespace pressF
{
    public partial class FormAddWorker : Form
    {
        public List<string> Mass { get; set; }

        public FormAddWorker()
        {

            InitializeComponent();
        }
        public void FormAddWorker_Load(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if ((control as CueTextBox) != null)
                {
                    (control as CueTextBox).Validating += new System.ComponentModel.CancelEventHandler((control as CueTextBox).CheckString);
                }
            }
        }



        private void Place_Enter(object sender, EventArgs e)
        {
            FormSelectPlace f = new FormSelectPlace();
            if (f.ShowDialog() == DialogResult.OK) // отобразить форму
            {
                (sender as CueTextBox).Text = "";
                Mass = f.GetData();
                Mass.Reverse();
                foreach (var s in Mass)
                {
                    if (s.Length > 0)
                    {
                        (sender as CueTextBox).Text += s.ToString() + " ";
                    }
                }
            }
        }

        //ПРОВЕРКА СНИЛС
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
            if (!SNILSValidate(lol.Text))
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
        }


        private void FormAddWorker_FormClosing(object sender, FormClosingEventArgs e)
        {
            /*if (DialogResult != DialogResult.OK) return;
            List<string> reasons = new List<string> { };
            foreach (Control control in this.Controls)
            {
                CueTextBox textBox = control as CueTextBox;
                if (textBox != null)
                {
                    if (textBox.Required)
                    {
                        if (!(new Regex(@textBox.Tag.ToString()).IsMatch(textBox.Parent.FindForm().Tag.ToString())))
                        {
                            e.Cancel = true;
                            reasons.Add(textBox.Tag.ToString());
                        }
                    }
                }
            }
            if (e.Cancel || Tag.ToString() != ":")
            {
                e.Cancel = true;
                MessageBox.Show("Требуется правильно заполнить" + Tag + string.Join(",", reasons.ToArray()));
                MessageBox.Show(DateTime1.Text);
            }*/

#pragma warning disable CS0162 // Обнаружен недостижимый код
            if (DialogResult != DialogResult.OK) return;
#pragma warning restore CS0162 // Обнаружен недостижимый код
            foreach (Control control in this.Controls)
            {
                if (control as CueTextBox != null)
                {
                    string ch = (control as CueTextBox)._check(control as CueTextBox, true);
                    if (!(Tag.ToString().IndexOf(ch) > -1))
                        Tag += ch + ",";
                }
            }
            if (!(string.IsNullOrWhiteSpace(Tag.ToString())))
            {
                e.Cancel = true;
                MessageBox.Show("Не верно заполненные значения \n" + Tag.ToString());
            }

        }

    }

}
