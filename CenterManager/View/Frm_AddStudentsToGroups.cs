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
    public partial class Frm_AddStudentsToGroups : View_ModelForm , AddStudentGroupInterFace
    {
        int id = 0;
        int SelectedClassID = 0;
        AddStudentGroupPresenter presenter;
        public Frm_AddStudentsToGroups()
        {
            InitializeComponent();
            presenter = new AddStudentGroupPresenter(this);
            
            dataGridView1.Columns["CHK"].DisplayIndex = dataGridView1.Columns.Count -1;
        }

        public int GroupID { get => Convert.ToInt32(cmbGroup.SelectedValue); set => cmbGroup.SelectedValue = value; }
        public object StudentDataSource { get => dataGridView1.DataSource; 
            set { 
                dataGridView1.DataSource = value; 
            }
        }

        public object GroupsDataSource { get => cmbGroup.DataSource; set { 
                cmbGroup.DataSource = value;
                cmbGroup.DisplayMember = "GroupName";
                cmbGroup.ValueMember = "ID";
            } }

        public int STID { get =>id ; set { } }

        public int StudentNumber { get { try { return Convert.ToInt32(txtNumber.Text); } catch { return 0; } } set => txtNumber.Text = value.ToString(); }

        public string Search { get => txtSearch.Text; set => txtSearch.Text = value; }
        public string ClassName { get => txtClass.Text; set => txtClass.Text = value; }
        int AddStudentGroupInterFace.ClassID { get => SelectedClassID; set => SelectedClassID = value; }

        private void button3_Click(object sender, EventArgs e)
        {
            if(cmbGroup.Items.Count > 0)
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if (Convert.ToBoolean(dataGridView1.Rows[i].Cells["CHK"].Value))
                    {
                        id = Convert.ToInt32(dataGridView1.Rows[i].Cells["STDID"].Value);
                        presenter.Add();
                    }
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            if (dataGridView1.Rows.Count > 0)
            {
                id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["STDID"].Value);
                Methods.ViewForm(new Frm_AddStudent(id , -1));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cmbGroup.Items.Count > 0) {
                Methods.ViewForm(new Frm_AddGroup(Convert.ToInt32(cmbGroup.SelectedValue),-1));
            }
        }

        private void cmbGroup_SelectedValueChanged(object sender, EventArgs e) {
            if (presenter != null)
            {
                presenter.ShowStudentNumber();
                presenter.GetClass();
                
                if (!panel1.Visible) ShowStudentInGroup(); 
                else presenter.ShowAllStudents();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count > 0) {
                if (e.ColumnIndex == dataGridView1.Columns["CHK"].Index)
                {
                    dataGridView1.Rows[e.RowIndex].Cells["CHK"].Value = !Convert.ToBoolean(dataGridView1.Rows[e.RowIndex].Cells["CHK"].Value);
                }
            }
        }
        void ShowStudentInGroup() {
            panel1.Visible = false;
            panel2.Visible = true;
            presenter.ShowStudentsInGroups();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Cells["CHK"].Value = true;
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            ShowStudentInGroup();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
            presenter.ShowAllStudents(); 
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Cells["CHK"].Value = false;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!Convert.ToBoolean(row.Cells["CHK"].Value)) {
                    id = Convert.ToInt32(row.Cells["OPID"].Value);
                    DeleteMethods.DeleteStudentGroup(id);
                }
            }
            ShowStudentInGroup();
            presenter.ShowStudentNumber();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            presenter.Search();
        }

    }
}
