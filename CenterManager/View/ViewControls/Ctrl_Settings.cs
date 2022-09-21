using CenterManager.Control.Methods;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CenterManager.View.ViewControls
{
    public partial class Ctrl_Settings : UserControl
    {
        Action action;
        public Ctrl_Settings(Action action)
        {
            InitializeComponent();
            this.action = action;
            if (Methods.TitleColor != "")
            {
                lblTitle.ForeColor = System.Drawing.ColorTranslator.FromHtml(Methods.TitleColor);
            }
           
        }
        override public Color ForeColor
        {
            set
            {
                lblTitle.ForeColor = value;
            }
            get => lblTitle.ForeColor;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Methods.ViewForm(new Frm_ConnectionSettings());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Methods.ViewForm(new Frm_ProgramSettings());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Methods.ViewForm(new Frm_Themes(Parent.BackColor));
            lblTitle.ForeColor = System.Drawing.ColorTranslator.FromHtml(Methods.TitleColor);
            action.Invoke();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("سيتم حذف جميع الاعدادات هل انت متاكد من ذلك","",MessageBoxButtons.YesNo) == DialogResult.Yes) 
            {
                Properties.Settings.Default.ProgramName = "برنامج ادارة السنتر";
                Properties.Settings.Default.ServerName = "Server Name Here";
                Properties.Settings.Default.DBName = "DataBase Name Here";
                Properties.Settings.Default.DBUserName = "";
                Properties.Settings.Default.DBPassword = "";
                Properties.Settings.Default.UserName = "";
                Properties.Settings.Default.Password = "";
                Properties.Settings.Default.Save();
                Application.Exit();
            }
        }
    }
}
