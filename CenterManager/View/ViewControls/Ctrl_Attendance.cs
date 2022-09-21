using CenterManager.Control.DBControl;
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
    public partial class Ctrl_Attendance : UserControl
    {
        public Ctrl_Attendance()
        {
            InitializeComponent();
            if (Methods.TitleColor != "") { 
                lblTitle.ForeColor = System.Drawing.ColorTranslator.FromHtml(Methods.TitleColor);
            }
            UsersPermission p = Methods.MyPermissions;
            button1.Visible = p.TakeAttendance;
            button2.Visible = p.ViewAttendance;
            
        }
        override public Color ForeColor
        {
            set
            {
                lblTitle.ForeColor = value;
            }
            get => lblTitle.ForeColor;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Methods.ViewForm(new Frm_TakeAttendance());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Methods.ViewForm(new Frm_ShowAttendance());
        }
    }
}
