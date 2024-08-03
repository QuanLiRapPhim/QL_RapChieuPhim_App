using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema
{
    internal static class Program
    {
        public static Form1 frm_mainForm = null;
        public static DangNhap frmForm = null;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmForm =new DangNhap();
            Application.Run(frmForm);
        }
    }
}
