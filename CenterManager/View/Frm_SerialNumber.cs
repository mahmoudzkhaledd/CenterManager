using CenterManager.Models.View_Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CenterManager.View
{
    public partial class Frm_SerialNumber : Frm_Master
    {
        public Frm_SerialNumber()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CheckNumber();
        }
        void CheckNumber() {
            if (txtSerial.Text == Properties.Settings.Default.SerialNumber)
            {
                Properties.Settings.Default.Demo = false;
                Properties.Settings.Default.Save();
                Application.Restart();
            }
            else MessageBox.Show("الرقم خاطئ الرجاء اعادة المحاوله");
        }
    }
}
