﻿using System;
using System.Windows.Forms;

namespace pressF
{
    public partial class MainForm : Form
    {

        public MainForm()
        {

            InitializeComponent();

        }


        private void ЗарплатныйПроектToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Дочерняя форма зарплатного проекта
            ZP form1 = new ZP();
            ZP newMDIChild = form1;
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void ВыходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void ЗакрытьВсёToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Закрыть все дочерние формы
            foreach (Form item in MdiChildren)
            {
                item.Close();
            }
        }

        private void MenuStrip1_MenuActivate(object sender, EventArgs e)
        {
            label1.Visible = false;
        }

        private void debugToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.FormDOS form1 = new Forms.FormDOS();
           
            form1.Show();
        }
    }
}
