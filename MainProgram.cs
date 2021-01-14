using System;
using System.Windows.Forms;

namespace SalaryRegistersUralsib
{
    static class MainProgram
    {
        public static ApplicationContext Context { get; set; }
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Context = new ApplicationContext(new AuthForm());
            Application.Run(Context);


        }
    }
}
