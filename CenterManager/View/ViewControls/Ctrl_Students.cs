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
    public partial class Ctrl_Students : UserControl
    {
        public Ctrl_Students() {
            InitializeComponent();
            if (Methods.TitleColor != "")
            {
                lblTitle.ForeColor = System.Drawing.ColorTranslator.FromHtml(Methods.TitleColor);
            }
            UsersPermission p = Methods.MyPermissions;
            button1.Visible = p.AddStudent;
            button2.Visible = p.ShowStudents;
            button3.Visible = p.Subjects;
            button4.Visible =p.EditClasses ; 
           
        }
        override public Color ForeColor
        {
            set
            {
                lblTitle.ForeColor = value;
            }
            get => lblTitle.ForeColor;
        }
        private void button1_Click(object sender, EventArgs e) {
            Methods.ViewForm(new Frm_AddStudent());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Methods.ViewForm(new Frm_ViewStudents());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Methods.ViewForm(new Frm_EditClasses());
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Methods.ViewForm(new Frm_EditSubjects());
        }
    }
}
