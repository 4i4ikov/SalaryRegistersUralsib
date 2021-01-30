using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
namespace SalaryRegistersUralsib
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
            foreach ( Control control in this.Controls )
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
            if ( f.ShowDialog() == DialogResult.OK ) // отобразить форму
            {
                ( sender as CueTextBox ).Text = "";
                Mass = f.GetData();
                Mass.Reverse();
                foreach ( var s in Mass )
                {
                    if ( s.Length > 0 )
                    {
                        ( sender as CueTextBox ).Text += s.ToString() + " ";
                    }
                }
            }
        }

        private void FormAddWorker_FormClosing(object sender, FormClosingEventArgs e)
        {
            if ( DialogResult != DialogResult.OK ) return;
            Tag = " ";
            foreach ( Control control in this.Controls )
            {
                if ( control is CueTextBox textBox )
                {
                    string ch = textBox.Check(textBox, false);
                    if ( !( Tag.ToString().IndexOf(ch) > -1 ) )
                        Tag += ch + ",";
                }
                if ( control is ComboBox c && c.SelectedIndex == -1 )
                {
                    
                    if ( !( Tag.ToString().IndexOf(c.Tag.ToString()) > -1 ) )
                        Tag += c.Tag.ToString() + ",";
                }
                else
                {

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
