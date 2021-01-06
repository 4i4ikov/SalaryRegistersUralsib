using System;
using System.Windows.Forms;

namespace pressF.Forms
{
    public partial class FormDOS : Form
    {
        private Organizations org;
        private BindingSource bns;
        public FormDOS(Organizations org = null)
        {
            InitializeComponent();
            if ( org != null )
            {
                this.org = org;
                this.bns = org.cardBindingSource;
                dataGridView1.DataSource = this.bns;
            }

        }

        private void AddButton_Click(object sender, EventArgs e)
        {

        }
    }
}
