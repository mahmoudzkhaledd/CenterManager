using CenterManager.Control.DBControl;
using CenterManager.Control.Methods;
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
    public partial class Frm_ProgramSettings : Add_ModelForm
    {
        public Frm_ProgramSettings()
        {
            InitializeComponent();
            CenterManagerEntities db = Methods.db;
            txtProgramName.Text = db.Settings.SingleOrDefault(a => a.ID == 1).ProgramName;
            
            if (Properties.Settings.Default.StartupPage != null && Properties.Settings.Default.StartupPage != "") { 
                radioButtonList1.SelectedItem = Properties.Settings.Default.StartupPage;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveProgramName();
            SaveStartPage();
        }

        private void SaveStartPage()
        {
            Properties.Settings.Default.StartupPage = radioButtonList1.SelectedItem.ToString();
            Properties.Settings.Default.Save();
        }

        private void SaveProgramName()
        {
            if (txtProgramName.Text != "")
            {
                CenterManagerEntities db = Methods.db;
                db.Settings.SingleOrDefault(a => a.ID == 1).ProgramName = txtProgramName.Text;
                db.SaveChanges();
                MessageBox.Show("تم الحفظ بنجاح");
            }
        }
    }
}
