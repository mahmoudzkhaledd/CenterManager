using CenterManager.Control.DBControl;
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

using System.Xml;
namespace CenterManager.View
{
    public partial class Frm_Login : Frm_Master
    {

        public Frm_Login()
        {
            InitializeComponent();
            lblProgramName.Text = Properties.Settings.Default.ProgramName;
            lblProgramName.Location = new Point((Width - lblProgramName.Width)/2,lblProgramName.Location.Y);
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr one, int two, int three, int four);
        private void button1_Click(object sender, EventArgs e)
        {
            if (Methods.TestConnection())
            {
                if (!Methods.Login(txtUserName.Text, txtPassword.Text))
                    MessageBox.Show("الرجاء التحقق من اسم المستخدم وكلمة المرور");
                else
                {
                    if (checkBox1.Checked)
                    {
                        Properties.Settings.Default.RememberPassword = true;
                        Properties.Settings.Default.UserName = txtUserName.Text;
                        Properties.Settings.Default.Password = txtPassword.Text;
                        Properties.Settings.Default.Save();
                    }
                    
                    Thread th = new Thread(() => Application.Run(new Frm_Main()));
                    th.SetApartmentState(ApartmentState.STA);
                    th.Start();
                    Close();
                }
            }
            else
            {
                MessageBox.Show("الرجاء التحقق من اعدادات الاتصال");
                Methods.ViewForm(new Frm_ConnectionSettings());
            }
        }
        
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Frm_Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Methods.ViewForm(new Frm_ConnectionSettings());
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) button1_Click(null,null); 
        }

        private void txtUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void label3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }
    }
}
