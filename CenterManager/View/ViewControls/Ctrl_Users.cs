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
    public partial class Ctrl_Users : UserControl
    {
        public Ctrl_Users()
        {
            InitializeComponent();
            UsersPermission p = Methods.MyPermissions;
            button4.Visible = p.AddUser; 
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Methods.ViewForm(new Frm_AddUser()) ;
        }
    }
}
