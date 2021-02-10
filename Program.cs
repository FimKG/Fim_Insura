using Fim_Insura.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fim_Insura
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
            //Application.Run(new splash());
            //Application.Run(new register());
            //Application.Run(new policyTypeReg());
            //Application.Run(new myPolicy());
            //Application.Run(new manage_Client());
            //Application.Run(new login());
            //Application.Run(new landing());
            //Application.Run(new client_Main());
            //Application.Run(new client_login());
            Application.Run(new admin_Main());
            //Application.Run(new InsureProduct());
        }
    }
}
