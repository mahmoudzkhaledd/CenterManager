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
    public partial class Frm_TakeAttendance : View_ModelForm ,AttendanceInterFace
    {
        int GroupID = -1;
        string GroupName = "";
        int LectureID = -1;
        bool AttendanceTaken = false;
        List<int> attendance = new List<int>();
        AttendancePresenter presenter;
        public Frm_TakeAttendance() 
        {
            InitializeComponent();
            presenter = new AttendancePresenter(this);
        }

        public int StudentCode { 
            get {
                try {
                    return Convert.ToInt32(txtSTCode.Text);
                }
                catch { return 1000; }
            } 
            set {
                txtSTCode.Text = value.ToString();
            } 
        }
        public object StudentDataSource { get => dataGridView1.DataSource; set => dataGridView1.DataSource = value ; }
        int AttendanceInterFace.GroupID { get => GroupID; set { } }

        public int LecID { get => LectureID; set => LectureID = value; }
        

        public int StudentNumber { get => Convert.ToInt32(txtNumber.Text); set => txtNumber.Text = value.ToString(); }
        public string CurrentLec { get => txtLecID.Text; set => txtLecID.Text = value; }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dr = Methods.ViewForm(new Frm_ChooseGroup((g, n) => { GroupID = g; GroupName = n; }, GroupID));
            if (dr == DialogResult.OK)
            {
                button2.Text = "اخذ الحضور";
                txtGroupName.Text = GroupName;
                if (txtGroupName.Text != "" && GroupID != -1)
                {
                    presenter.ShowAllStudents();
                    presenter.MakeLec();
                    PushStudents();
                    presenter.ShowStudentsNumber();
                    attendance.Clear();
                    lblSelNumber.Text = attendance.Count.ToString();
                    AttendanceTaken = false;
                    dataGridView1.Enabled = !AttendanceTaken;
                }
            }
        }

        private void PushStudents()
        {
            if (txtGroupName.Text != "")
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++) {
                    presenter.Add(Convert.ToInt32(dataGridView1.Rows[i].Cells["STID"].Value), false);
                }
                presenter.ShowStudentsNumber();
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                txtSTCode.Text = Convert.ToString(dataGridView1.SelectedRows[0].Cells["STCode"].Value);
                txtSTName.Text = dataGridView1.SelectedRows[0].Cells["STName"].Value.ToString();
            }
            catch { }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(!AttendanceTaken)
            {
                if (txtLecID.Text != "")
                {
                    for (int i = 0; i < attendance.Count; i++)
                    {
                        presenter.Update(attendance[i], true);
                    }
                    presenter.ShowStudentsNumber();
                    AttendanceTaken = true;
                    button2.Text = "تعديل الحضور";
                    dataGridView1.Enabled = !AttendanceTaken;
                    MessageBox.Show("تم اخذ الحضور بنجاح");
                }
            }
            else {
                Methods.ViewForm(new Frm_ShowAttendance());
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == dataGridView1.Columns["CHK"].Index) {
                try {
                    bool x = !Convert.ToBoolean(dataGridView1.SelectedRows[0].Cells["CHK"].Value);
                    dataGridView1.SelectedRows[0].Cells["CHK"].Value = x;
                    if(x) attendance.Add(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["STID"].Value));
                    else attendance.Remove(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["STID"].Value));
                    lblSelNumber.Text = attendance.Count.ToString();
                }
                catch { }
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            
        }

        private void cmbLecs_SelectedIndexChanged(object sender, EventArgs e)
        {
            try {
                LectureID = Convert.ToInt32(txtLecID.Text);
                presenter.ShowStudentsNumber();
            } catch { }
        }
    }
}
