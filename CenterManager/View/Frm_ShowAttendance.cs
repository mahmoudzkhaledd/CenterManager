using CenterManager.Control.Methods;
using CenterManager.Control.Presenters;
using CenterManager.Models.View_Models;
using CenterManager.View.InterFaces;
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
    public partial class Frm_ShowAttendance : View_ModelForm, ViewAttendanceInterFace
    {
        ViewAttendancePresenter presenter;
        public Frm_ShowAttendance()
        {
            InitializeComponent();
            presenter = new ViewAttendancePresenter(this);
            button1.Visible = true;
            if(cmbLecs.Items.Count > 0)
                cmbLecs.SelectedIndex = cmbLecs.Items.Count - 1;
        }

        public object StudentsDataSource { get => dataGridView1.DataSource; set => dataGridView1.DataSource = value; }
        public object LecDataSource
        {
            get => cmbLecs.DataSource;
            set
            {
                cmbLecs.DataSource = value;
                cmbLecs.DisplayMember = "Data";
                cmbLecs.ValueMember = "LecID";
            }
        }
        public object GroupsDataSource
        {
            get => cmbGroups.DataSource;
            set
            {
                cmbGroups.DataSource = value;
                cmbGroups.DisplayMember = "Name";
                cmbGroups.ValueMember = "ID";
            }
        }

        public int GroupID { get => Convert.ToInt32(cmbGroups.SelectedValue); }
        public int LecID { get => Convert.ToInt32(cmbLecs.SelectedValue); set { } }

        public string Search { get => txtSearch.Text; set => txtSearch.Text = value; }

        private void button1_Click(object sender, EventArgs e)
        {

            if (cmbLecs.Text != "")
            {
                lblFilter.Text = "كل الطلبه";
                presenter.UpdateStudents();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void cmbGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (presenter != null)
            {
                presenter.UpdateLecs();
                if (cmbLecs.Items.Count == 0) cmbLecs.Text = "";
            }
        }

        private void cmbLecs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLecs.Text != "")
            {
                string x = cmbLecs.Text;
                txtDate.Text = x;
                x = x.Replace("{ Data = ", string.Empty);
                x = x.Split(',')[0];
                txtLec.Text = x.Split(':')[0];
                x = x.Replace(x.Split(':')[0] ,string.Empty);
                x = x.Remove(0,1);
                txtDate.Text = x;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0 && txtLec.Text != "" && cmbGroups.Text != "" && cmbLecs.Text != "")
            {
                int s = dataGridView1.SelectedRows[0].Index;
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);
                presenter.MakeAttend(id, true);
                try
                {
                    dataGridView1.Rows[s].Selected = true;
                }
                catch { }
            }
        }
        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0 && txtLec.Text != "" && cmbGroups.Text != "" && cmbLecs.Text != "")
            {
                int s = dataGridView1.SelectedRows[0].Index;
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);
                presenter.MakeAttend(id, false);
                try
                {
                    dataGridView1.Rows[s].Selected = true;
                }
                catch { }
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            presenter.Search();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (cmbLecs.Text != "")
            {
                lblFilter.Text = "كل الطلبه";
                presenter.UpdateStudents();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (cmbLecs.Text != "")
            {
                lblFilter.Text = "كل الغياب";
                presenter.FilterStudentAttendance(false);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (cmbLecs.Text != "")
            {
                lblFilter.Text = "كل الحاضرين";
                presenter.FilterStudentAttendance(true);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DeleteMethods.DeleteLecture(LecID);
            presenter.UpdateLecs();
            presenter.UpdateStudents();
            if (cmbLecs.Items.Count > 0)
                cmbLecs.SelectedIndex = cmbLecs.Items.Count - 1;
            else cmbLecs.Text = "";
        }
    }
}
