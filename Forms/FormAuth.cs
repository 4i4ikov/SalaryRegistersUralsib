﻿using System;
using System.Windows.Forms;

namespace pressF
{

    public partial class AuthForm : Form
    {
        public AuthForm()
        {
            InitializeComponent();
        }

        private void AuthForm_Load(object sender, EventArgs e)
        {

        }

        private void AuthButton_Click(object sender, EventArgs e)
        {
            if ((EncodeS(LoginInput.Text) == Properties.Settings.Default.Login) && (EncodeS(PasswordInput.Text) == Properties.Settings.Default.Password))
            {
                Program.Context.MainForm = new ZP();
                Close();
                Program.Context.MainForm.Show();

            }
            else
            {
                MessageBox.Show("Введенные данные не верны!\nПроверьте их, пожалуйста!");
            }

        }
        private void TestingButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Login = EncodeS(LoginInput.Text);
            Properties.Settings.Default.Password = EncodeS(PasswordInput.Text);
            Properties.Settings.Default.Save();
            }
        private string EncodeS(string PasswordInput)
        {
            byte[] Bytes = System.Text.Encoding.UTF8.GetBytes(PasswordInput); //Из строки в массив байтов
            for (int i = 0; i < 1024; i++)
            {
                Bytes = System.Security.Cryptography.MD5.Create().ComputeHash(
                        System.Security.Cryptography.SHA512.Create().ComputeHash(Bytes));
            }
            System.Text.StringBuilder OutputStringBuilder = new System.Text.StringBuilder(128);
            foreach (byte b in Bytes)
            {
                OutputStringBuilder.Append(b.ToString("X2"));
            }

            return OutputStringBuilder.ToString();
        }
    }
}
