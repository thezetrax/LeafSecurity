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
            dashFrm = new DashBoardForm();
            loginFrm = new LoginForm(dashFrm);

            Application.Run(loginFrm);
        }
    }
}
