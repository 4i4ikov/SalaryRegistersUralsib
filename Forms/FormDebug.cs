using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace pressF.Forms
{

    public partial class FormDebug : Form
    {
        private readonly int[] arr = { 20, 20, 20, 20, 3, 14, 13, 10, 80, 7, 30, 2, 30, 45, 5, 3, 5, 6, 10, 100, 1, 11, 10, 10, 12, 22, 20, 4, 4, 3, 14, 13, 10, 34, 30, 2, 30, 45, 5, 3, 5, 6, 10, 10, 10, 50 };

        public FormDebug() => InitializeComponent();

        private void button1_Click(object sender, EventArgs e)
        {
            if ( openFileDialog1.ShowDialog() == DialogResult.OK )
            {
                //Get the path of specified file
                string filePath = openFileDialog1.FileName;
                string text = File.ReadAllText(filePath, Encoding.GetEncoding(866));
                textBox1.Text = text;
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            int point = 0;
            var n = 1;
            foreach ( int item in arr )
            {
                string str = "";
                for ( int i = 0; i < item; i++ )
                {
                    str += textBox1.Text [ point ];
                    point++;
                }
                Controls [ "cueTextBox" + Convert.ToString(n) ].Text = str.Trim();
                n++;
            }
        }

        private void DTB_TextChanged(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {
            var n = 1;
            foreach ( int item in arr )
            {
                DTB.Text += Controls [ "cueTextBox" + Convert.ToString(n) ].Text.PadRight(item);
                n++;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var n = 1;
            foreach ( int item in arr )
            {
                DTB.Text = Controls [ "cueTextBox" + Convert.ToString(n) ].Text = String.Empty;
                n++;

            }
        }
    }
}
