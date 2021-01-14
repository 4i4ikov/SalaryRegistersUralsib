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
            if ( ValidateChildren() )
            {

            }
        }
    }
}
