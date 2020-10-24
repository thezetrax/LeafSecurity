using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeafSecurity
{
    static class Program
    {
        private static LoginForm loginFrm;
        private static DashBoardForm dashFrm;
        public static readonly string defaultApplicationDirName = @"LeafSecurity";
        public static readonly string defaultApplicationDatabaseDirName = @"LeafSecurity\data";
        public static readonly string defaultMatlabFunctionDirName = @"LeafSecurity\funs";
        public static readonly string defaultMatlabGeneratedDirName = @"LeafSecurity\funs\generated";
        public static readonly string defaultApplicationTempDir = @"LeafSecurity\temp";

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Bootstrapping Forms
            dashFrm = new DashBoardForm(); // Main Form
            loginFrm = new LoginForm(dashFrm); // Loging Form

            if (!Bootstrap.Check(dashFrm)) // Check Everything is going fine
            {
                Application.Exit();
                return;
            }

            dashFrm.Hide();
            loginFrm.ShowDialog(dashFrm);

            Application.Run(dashFrm);
        }
    }
}
