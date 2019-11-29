using System;
using System.Windows.Forms;

namespace WebHook_Tool_Telegram___By_aliilapro__
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Frm.Main());
        }
    }
}
