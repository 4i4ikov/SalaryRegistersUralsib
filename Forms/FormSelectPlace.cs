using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SalaryRegistersUralsib
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

            foreach ( Control control in Controls )
            {
                if ( control is CueTextBox textBox )
                {
                    mass.Add(textBox.Text);
                }
            }
            return mass;
        }

        private void FormSelectPlace_Load(object sender, EventArgs e)
        {
            foreach ( Control control in this.Controls )
            {
                if ( control is CueTextBox textBox )
                {
                    textBox.Validating += new System.ComponentModel.CancelEventHandler(textBox.CheckString);

                }
            }
        }

        private void FormSelectPlace_FormClosing(object sender, FormClosingEventArgs e)
        {

            if ( DialogResult != DialogResult.OK ) return;
            foreach ( Control control in this.Controls )
            {
                if ( control is CueTextBox textBox )
                {
                    string ch = textBox._check(textBox, true);
                    if ( !( Tag.ToString().IndexOf(ch) > -1 ) )
                        Tag += ch + ",";
                }
            }
            if ( !( string.IsNullOrWhiteSpace(Tag.ToString()) ) )
            {
                e.Cancel = true;
                MessageBox.Show("Не верно заполненные значения \n" + Tag.ToString());
            }


        }
    }
}
