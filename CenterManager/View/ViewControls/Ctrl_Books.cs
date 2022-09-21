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
    public partial class Ctrl_Books : UserControl
    {
        public Ctrl_Books()
        {
            InitializeComponent(); 
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
        private void button1_Click(object sender, EventArgs e)
        {
            Methods.ViewForm(new Frm_AddBook(0));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Methods.ViewForm(new Frm_ViewBooks());
        }

        private void button3_Click(object sender, EventArgs e) {
            Methods.ViewForm(new Frm_StudentBooks());
        }

        private void button4_Click(object sender, EventArgs e) {
            Methods.ViewForm(new Frm_ReturnBook());
        }
    }
}
