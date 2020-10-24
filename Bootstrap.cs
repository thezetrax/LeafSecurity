using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SecuGen.FDxSDKPro.Windows;
using System.Windows.Forms;

namespace LeafSecurity
{
    class Bootstrap
    {
        public static bool Check(DashBoardForm dashboard)
        {
            // Creating directory objects for application folder
            DirectoryOps.DefaultApplicationDirectory defaultDir = 
                new DirectoryOps.DefaultApplicationDirectory(Program.defaultApplicationDirName);
            DirectoryOps.DefaultApplicationDirectory defaultDatabaseDir = 
                new DirectoryOps.DefaultApplicationDirectory(Program.defaultApplicationDatabaseDirName);
            DirectoryOps.DefaultApplicationDirectory defaultMatlabDir = 
                new DirectoryOps.DefaultApplicationDirectory(Program.defaultMatlabFunctionDirName);
            DirectoryOps.DefaultApplicationDirectory defaultTempDir =
                new DirectoryOps.DefaultApplicationDirectory(Program.defaultApplicationTempDir);

            // Opening Operation Objects for each folder.
            DirectoryOps.DirectoryOperation dirOperations = 
                new DirectoryOps.DirectoryOperation(defaultDir);
            DirectoryOps.DirectoryOperation dbDirOperations = 
                new DirectoryOps.DirectoryOperation(defaultDatabaseDir);
            DirectoryOps.DirectoryOperation matlabDirOperations =
                new DirectoryOps.DirectoryOperation(defaultMatlabDir);
            DirectoryOps.DirectoryOperation tempDirOperations =
                new DirectoryOps.DirectoryOperation(defaultTempDir);
            
            // If application Folder and application database folder
            // do not exist create them.
            if(!dirOperations.Exists())
                dirOperations.Create();
            if(!dbDirOperations.Exists())
                dbDirOperations.Create();
            if (!matlabDirOperations.Exists())
                matlabDirOperations.Create();
            if (!tempDirOperations.Exists())
                tempDirOperations.Create();

            // Checking if Fingerprint Machine is Connected
            SGFingerPrintManager m_FPM = new SGFingerPrintManager();
            SGFPMDeviceName device_name = SGFPMDeviceName.DEV_FDU03;

            //...Initializing Port Address
            Int32 port_addr = (Int32) SGFPMPortAddr.USB_AUTO_DETECT;
            m_FPM.Init(device_name);
            Int32 iError = m_FPM.OpenDevice(port_addr);
            if(iError != (Int32) SGFPMError.ERROR_NONE)
            {
                DialogResult res = MessageBox.Show(dashboard, "Are you sure you want to continue with out a fingerprint sensor?",
                    "Fingerprint Sensor not Connected", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                Console.WriteLine("Openning Device Error : " + iError);
                if (res == DialogResult.No)
                {
                    dashboard.Close();
                    return false;
                }
                dashboard.fp_device_connected(false); // Tell dashboard sensor is not connected
            }
            dashboard.fp_device_connected(true); // Tell dashboard sensor is connected
            return true;
        }
    }
}
