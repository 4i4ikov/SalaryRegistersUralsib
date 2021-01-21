using Microsoft.Office.Interop.Excel;

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace SalaryRegistersUralsib.Forms
{
    public partial class FormDocumPick : Form
    {
        private Control.ControlCollection c;
        private bool DocumMode;
        

        public List<String> GetData()
        {
            List<string> Mass = new List<string>();
            foreach ( Control control in Controls )
            {
                if ( control is ComboBox comboBox )
                {
                    Mass.Add(comboBox.Text);
                }
                if ( control is CueTextBox textBox )
                {
                    string tx = !(String.IsNullOrWhiteSpace(textBox.Text)) ? textBox.Text : "";
                    Mass.Add(tx ?? "");
                }
            }
            
            return Mass;
        }
        public FormDocumPick(bool docummode)
        {
            InitializeComponent();
            this.DocumMode = docummode;
            foreach ( Control control in this.Controls )
            {
                if ( control is CueTextBox textBox )
                {
                    textBox.Validating += new System.ComponentModel.CancelEventHandler(textBox.CheckString);

                }
            }
        }

        private void Docum_DropDown(object sender, EventArgs e)
        {
            
            FormSelectDocument f = new FormSelectDocument();
            
            f.groupBox1.Visible = DocumMode;
            f.groupBox2.Visible = !DocumMode;
            if ( f.ShowDialog() == DialogResult.OK ) // отобразить форму
            {

                c = f.groupBox1.Controls;
                Docum.SelectedIndex = 14;
                if ( !DocumMode )
                {
                    c = f.groupBox2.Controls;
                    Docum.SelectedIndex = 0;
                }
                foreach ( Control r in c )
                {
                    if ( r is RadioButton radio && radio.Checked )
                    {
                        Debug.WriteLine(radio.TabIndex);
                        Docum.SelectedIndex += radio.TabIndex - 1;
                    }
                }
            }
        }

        private void FormDocumPick_FormClosing(object sender, FormClosingEventArgs e)
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
                if (control is ComboBox c && c.SelectedIndex == -1)
                {
                    Debug.WriteLine(c.SelectedIndex);
                    if ( !( Tag.ToString().IndexOf(c.Tag.ToString()) > -1 ) )
                        Tag += c.Tag.ToString() + ",";
                } else
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
