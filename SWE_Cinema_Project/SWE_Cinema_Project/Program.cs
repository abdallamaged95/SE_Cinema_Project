using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SWE_Cinema_Project
{
    
    internal static class Program
    {
        private readonly static string ordb = "Data Source=orcl;User Id=hr;Password=hr;";
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main_Menu_Form());
        }

        public static string getORDB()
        {
            return ordb;
        }
    }

    
}