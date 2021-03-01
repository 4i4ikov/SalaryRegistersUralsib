using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalaryRegistersUralsib.Forms
{
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
            Icon = Properties.Resources.Icon1;
            usersTableAdapter1.Fill(dbDataSet1.Users);
        }

        private void FormAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Validate();
            usersBindingSource.EndEdit();
            tableAdapterManager1.UpdateAll(dbDataSet1);
            usersTableAdapter1.Fill(dbDataSet1.Users);
            MainProgram.Context.MainForm = new AuthForm();
            MainProgram.Context.MainForm.Show();
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
           
        }
    }
}
