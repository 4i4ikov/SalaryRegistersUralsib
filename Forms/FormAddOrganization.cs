using System;
using System.Windows.Forms;

namespace SalaryRegistersUralsib
{
    public partial class FormAddOrganization : Form
    {
        public FormAddOrganization()
        {
            InitializeComponent();

        }

        private void ToolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void FormAddOrganization_Load(object sender, EventArgs e)
        {
            foreach ( Control control in Controls )
            {
                CueTextBox textBox = control as CueTextBox;
                if ( textBox != null )
                {
                    textBox.Validating += new System.ComponentModel.CancelEventHandler(textBox.CheckString);

                }
            }
        }

        private void FormAddOrganization_FormClosing(object sender, FormClosingEventArgs e)
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
