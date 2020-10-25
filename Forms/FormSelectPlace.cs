using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace pressF
{
    public partial class FormSelectPlace : Form
    {
        public FormSelectPlace()
        {
            InitializeComponent();
        }
        List<string> mass = new List<string>();
        public List<string> GetData()
        {

            foreach (Control control in Controls)
            {
                CueTextBox textBox = control as CueTextBox;
                if (textBox != null)
                {
                    mass.Add(textBox.Text);
                }
            }
            return mass;
        }

        private void FormSelectPlace_Load(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                CueTextBox textBox = control as CueTextBox;
                if (textBox != null)
                {
                    textBox.Validating += new System.ComponentModel.CancelEventHandler(textBox.CheckString);

                }
            }
        }

        private void FormSelectPlace_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (DialogResult != DialogResult.OK) return;
            foreach (Control control in this.Controls)
            {
                CueTextBox textBox = control as CueTextBox;
                if (textBox != null)
                {
                    string ch = textBox._check(textBox, true);
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
