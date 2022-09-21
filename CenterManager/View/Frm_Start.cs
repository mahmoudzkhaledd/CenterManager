using CenterManager.Control.Methods;
using CenterManager.Models.View_Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CenterManager.View
{
    public partial class Frm_Start : Form
    {
        Task t;
        public Frm_Start()
        {
            InitializeComponent();
            lblName.Text = Properties.Settings.Default.ProgramName;
            lblName.Location = new Point((Width - lblName.Width) / 2, lblName.Location.Y);
            label1.Location = new Point((Width - label1.Width) / 2, label1.Location.Y);
            t = new Task(Start);
            t.Start();
        }

        private void Start()
        {
            Methods.Demo = Properties.Settings.Default.Demo;
            Methods.DemoDays = Properties.Settings.Default.DemoDays;
            Form f = null;
            if (Methods.TestConnection())
            {
                Methods.LoadConnectionString();
                if (Properties.Settings.Default.RememberPassword)
                {
                    if (Methods.Login(Properties.Settings.Default.UserName, Properties.Settings.Default.Password))
                        f = new Frm_Main();
                    else
                        f = new Frm_Login();
                }
                else
                    f = new Frm_Login();
            }
            else
            {
                MessageBox.Show("الرجاء التحقق من اعدادات الاتصال.");
                f = new Frm_ConnectionSettings(true);
            }


            Thread th = new Thread(() => Application.Run(f));
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            Invoke((MethodInvoker)delegate { Close(); });



        }

        private bool EndDemo()
        {
            return true;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr one, int two, int three, int four);



        private void Frm_Start_MouseDown(object sender, MouseEventArgs e)
        {

            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
