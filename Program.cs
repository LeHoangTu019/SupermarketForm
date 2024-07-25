using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.CustomerFolder;
using WindowsFormsApp1.Entity;
using WindowsFormsApp1.ProductFolder;

namespace WindowsFormsApp1
{
    internal static class Program
    {
            
        public static SuperMarketManagement superMarketManagement = new SuperMarketManagement();
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}
