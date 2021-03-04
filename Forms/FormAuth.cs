
using SalaryRegistersUralsib.DbDataSetTableAdapters;
using SalaryRegistersUralsib.Forms;

using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace SalaryRegistersUralsib
{

    public partial class AuthForm : Form
    {
        public AuthForm()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.Icon1;
        }

        public static string GeneratePassword(int passLength)
        {
            var chars = "abcdefghijklmnopqrstuvwxyz@#$&ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
            var result = new string(
            Enumerable.Repeat(chars, passLength)
                      .Select(s => s[random.Next(s.Length)])
                      .ToArray());
            return result;
        }

        private void AuthButton_Click(object sender, EventArgs e)
        {
            
            int UserID = new UsersTableAdapter().GetPasswordReset(LoginInput.Text) ?? 0;
            if ( UserID != 0 )
            {
                string newPass =  GeneratePassword(12);

                MessageBox.Show("Выполнен сброс пароля, пожалуйста, сохраните его!");

                new UsersTableAdapter().UpdatePasswordByID(EncodeS(newPass), UserID);
                PasswordInput.Text = newPass;
                PasswordInput.PasswordChar = '\0';
                return;
            }
            DbDataSet.UsersDataTable dt = new  DbDataSet.UsersDataTable ();
            new UsersTableAdapter().GetUserByLoginAndPassword(dt, LoginInput.Text, EncodeS(PasswordInput.Text));

            if ( dt.Rows.Count > 0 )
            {
                DataRow dr = dt.Rows [ 0 ];
                if ( dr.Field<String>("Permissions").Contains("admin") )
                {
                    MessageBox.Show("У вас есть доступ к админке, переходим на неё");
                    MainProgram.Context.MainForm = new FormAdmin();
                    Close();
                    MainProgram.Context.MainForm.Show();
                }
                else
                {
                    MainProgram.Context.MainForm = new SalaryProjectForm();
                    Close();
                    MainProgram.Context.MainForm.Show();
                }
            }
            else MessageBox.Show("Проверьте правильность вводимых данных");

        }
        // СТАРАЯ КНОПКА СМЕНЫ ПАРОЛЯ
        //private void TestingButton_Click(object sender, EventArgs e)
        //{
        //    if ( EncodeS(LoginInput.Text) == Properties.Settings.Default.Login )
        //    {
        //        ChangeLoginPassword f = new ChangeLoginPassword();
        //        bool b = false;
        //        Hide();
        //        while ( !b  )
        //        {
        //            if ( f.ShowDialog() == DialogResult.OK )
        //            {
        //                if ( EncodeS(f.OldPasswordInput.Text) == Properties.Settings.Default.Password )
        //                {
        //                    Properties.Settings.Default.Password = EncodeS(f.NewPasswordInput.Text);
        //                    Properties.Settings.Default.Save();
        //                    b = true;
        //                    MessageBox.Show("Пароль успешно изменён!");
        //                }
        //                else MessageBox.Show("Вы ввели не верный старый пароль, повторите попытку.");

        //            }
        //            else b = true;
        //        }
        //        Show();
                
        //    }
        //    else MessageBox.Show("Введите верный логин!");
                
        //}
        private string EncodeS(string PasswordInput)
        {
            byte[] Bytes = System.Text.Encoding.UTF8.GetBytes(PasswordInput); //Из строки в массив байтов
            for ( int i = 0; i < 1024; i++ )
            {
                Bytes = System.Security.Cryptography.MD5.Create().ComputeHash(
                        System.Security.Cryptography.SHA512.Create().ComputeHash(Bytes));
            }
            System.Text.StringBuilder OutputStringBuilder = new System.Text.StringBuilder(128);
            foreach ( byte b in Bytes )
            {
                OutputStringBuilder.Append(b.ToString("X2"));
            }

            return OutputStringBuilder.ToString();
        }
    }
}
