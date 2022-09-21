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
    public partial class Frm_ChooseGroup : Add_ModelForm
    {
        CenterManagerEntities db = Methods.db;
        Action<int, string> action;
        int Mode = 0;
        public Frm_ChooseGroup(Action<int ,string> a ,int GID ,int Mode = 0)
        {
            this.Mode = Mode;
            InitializeComponent();
            if (Mode == 0) {
                cmbGroup.DataSource = db.Groups.Select((x) => new { GroupName = x.Name, ID = x.ID }).ToList();
                cmbGroup.DisplayMember = "GroupName";
                cmbGroup.ValueMember = "ID";
                if (GID != -1) cmbGroup.SelectedValue = GID;
            }
            else {
                groupBox1.Text = "اختيار الامتحان";
                label1.Text = "الامتحان :";
                cmbGroup.DataSource = db.Exams.Select(x=>new {x.Name ,x.ID }).ToList();
                cmbGroup.DisplayMember = "Name";
                cmbGroup.ValueMember = "ID";
                button3.Visible = false;
            }
            action = a;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(cmbGroup.Items.Count > 0 && cmbGroup.Text != "") {
                action.Invoke(Convert.ToInt32(cmbGroup.SelectedValue) , Convert.ToString(cmbGroup.Text));
                DialogResult = DialogResult.OK;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (cmbGroup.Items.Count > 0) {
                Methods.ViewForm(new Frm_AddGroup(Convert.ToInt32(cmbGroup.SelectedValue), -1));
            }
        }

        private void cmbGroup_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
