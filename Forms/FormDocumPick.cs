using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pressF.Forms
{
    public partial class FormDocumPick : Form
    {
        public FormDocumPick()
        {
            InitializeComponent();
        }

        private void Docum_DropDown(object sender, EventArgs e)
        {
            FormSelectDocument f = new FormSelectDocument();
            if (f.ShowDialog() == DialogResult.OK) // отобразить форму
            {
                foreach (RadioButton radio in f.groupBox1.Controls)
                {
                    if (radio.Checked)
                    {
                        Docum.SelectedIndex = radio.TabIndex - 1;
                    }
                }
            }
        }
    }
}
