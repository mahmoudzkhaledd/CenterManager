using CenterManager.Control.DBControl;
using CenterManager.Control.Methods;
using CenterManager.View;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CenterManager
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ChangeProperties();
            if (Properties.Settings.Default.Demo && EndDemo()) Application.Run(new Frm_EndDemo());
            else Application.Run(new Frm_Start());
        }

        private static void ChangeProperties()
        {
            Properties.Settings.Default.SerialNumber = "P852u8xegYxdokc";
            Properties.Settings.Default.Demo = false;
            Properties.Settings.Default.StartDay = "1/9/2022";
            Properties.Settings.Default.DemoDays = 5;
            Properties.Settings.Default.Save();
        }
        private static bool EndDemo()
        {
            int[] a = new int[] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            for (int i = 1; i < a.Length; i++) a[i] += a[i - 1];
            string s = Properties.Settings.Default.StartDay;
            string ss = DateTime.Now.ToString("dd/MM/yyyy");
            if (s != "")
            {
                string[] t = s.Split('/');
                string[] tt = ss.Split('/');
                int x1 = Convert.ToInt32(t[0]) , y1 = Convert.ToInt32(t[1]), z1 = Convert.ToInt32(t[2]);
                int x2 = Convert.ToInt32(tt[0]), y2 = Convert.ToInt32(tt[1]), z2 = Convert.ToInt32(tt[2]);
                int sum1 = z1 * 365 + a[y1 - 1] + x1;
                int sum2 = z2 * 365 + a[y2 - 1] + x2;
                int diff = Math.Abs(sum2 - sum1);
                return diff >= Properties.Settings.Default.DemoDays;
            }
            return false;
        }
    }
}
