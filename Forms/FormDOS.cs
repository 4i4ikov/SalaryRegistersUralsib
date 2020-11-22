using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
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
            if (org != null)
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
