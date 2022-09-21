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
    public partial class Ctrl_Exam : UserControl
    {
        override public  Color ForeColor { set { 
                lblTitle.ForeColor = value;
            } get=> lblTitle.ForeColor; }
        public Ctrl_Exam()
        {
            InitializeComponent();
            if (Methods.TitleColor != "")
            {
                lblTitle.ForeColor = System.Drawing.ColorTranslator.FromHtml(Methods.TitleColor);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Methods.ViewForm(new Frm_AddExam());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Methods.ViewForm(new Frm_ShowExams());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Methods.ViewForm(new Frm_CorrectExams());
        }
    }
}
