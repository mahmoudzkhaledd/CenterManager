using CenterManager.Control.DBControl;
using CenterManager.Control.Methods;
using CenterManager.Models.View_Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CenterManager.View
{
    public partial class Frm_ConnectionSettings : Form
    {
        bool mode = false;
        CenterManagerEntities db = Methods.db;
        public Frm_ConnectionSettings(bool Mode = false)
        {
            InitializeComponent();
            this.mode = Mode;
            txtServerName.Text= Properties.Settings.Default.ServerName ;
            txtDBName.Text = Properties.Settings.Default.DBName ;
            txtUserName.Text = Properties.Settings.Default.DBUserName ;
            txtPassword.Text = Properties.Settings.Default.DBPassword  ;
            checkBox1.Checked = Properties.Settings.Default.WindowsAuth  ;
            lblState.Text = "";
        }

        void Execute(Action a) {
            
        }


        private async void button1_Click(object sender, EventArgs e) {
            button2.Enabled = false; 
            button1.Enabled = false;
            panel1.Enabled = false;
            timer1.Start();
            await Task.Run(Save);
            timer1.Stop();
            button2.Enabled = true;
            button1.Enabled = true;
            panel1.Enabled = true;
            lblState.Text = "";
        }
        void Save() {
            if (Methods.TestConnection(txtServerName.Text, txtDBName.Text, txtUserName.Text, txtPassword.Text, checkBox1.Checked))
            {
                Properties.Settings.Default.ServerName = txtServerName.Text;
                Properties.Settings.Default.DBName = txtDBName.Text;
                Properties.Settings.Default.DBUserName = txtUserName.Text;
                Properties.Settings.Default.DBPassword = txtPassword.Text;
                Properties.Settings.Default.WindowsAuth = checkBox1.Checked;
                Properties.Settings.Default.Save();
                Methods.LoadConnectionString();

                if (mode)
                {
                    Thread th = new Thread(() => Application.Run(new Frm_Login()));
                    th.SetApartmentState(ApartmentState.STA);
                    th.Start();
                }
                Invoke((MethodInvoker)delegate { Close(); });
            }
            else MessageBox.Show("الرجاء التحقق من اعدادات الاتصال");
        }
        private async void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            button1.Enabled = false;
            panel1.Enabled = false;
            timer1.Start();
            await Task.Run(TestConnection);
            timer1.Stop();
            button2.Enabled = true;
            button1.Enabled = true; 
            panel1.Enabled = true;
            lblState.Text = "";
        }

        private void TestConnection()
        {
           
            if (Methods.TestConnection(txtServerName.Text, txtDBName.Text, txtUserName.Text, txtPassword.Text, checkBox1.Checked))
            {
                MessageBox.Show("Connection Successful", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Connection Failed", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtUserName.Enabled = !checkBox1.Checked;
            txtPassword.Enabled = !checkBox1.Checked;
        }

       
        List<string> loading = new List<string>() { "جارى التحميل", "جارى التحميل .", "جارى التحميل ..", "جارى التحميل ..." };
        int c = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (c > 3) c = 0;
            lblState.Text = loading[c];
            lblState.Location = new Point((Width - lblState.Width) / 2, lblState.Location.Y);
            c++;
        }
    }
}
