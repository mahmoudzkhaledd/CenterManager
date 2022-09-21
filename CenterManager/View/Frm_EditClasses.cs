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
    public partial class Frm_EditClasses : View_ModelForm , ClassesInterFace
    {
        int id = 0;
        EditStudentsPresenter presenter; 
        public Frm_EditClasses()
        {
            InitializeComponent();
            presenter = new EditStudentsPresenter(this);
        }

        public object ClassesDataSource { get =>dataGridView1.DataSource ; set =>dataGridView1.DataSource = value ; }
        int ClassesInterFace.id { get => id; set =>id = value ; }
        string ClassesInterFace.Class_Name { get =>txtName.Text ; set =>txtName.Text = value ; }
        public string Search { get => txtSearch.Text; set => txtSearch.Text = value; }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            LoadData();
        }
        void LoadData() {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                txtName.Text = Convert.ToString(dataGridView1.SelectedRows[0].Cells["Class_Name"].Value);
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            presenter.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            btnAdd.Visible = true;
            btnEdit.Visible = false;
            btnDelete.Visible = false;
            btnDeleteAll.Visible = false;
            txtName.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ClassID"].Value);
                int i = dataGridView1.SelectedRows[0].Index;
               
                presenter.EditClass();
                dataGridView1.Rows[i].Selected = true;
                dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.Rows.Count - 1;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           if(dataGridView1.Rows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ClassID"].Value);
                DeleteMethods.DeleteClass(id);
                presenter.Refresh();
                if (index - 1 > 0)
                {
                    dataGridView1.Rows[index - 1].Selected = true;
                    dataGridView1.FirstDisplayedScrollingRowIndex = index - 1;
                }
            }
            else
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if (groupBox1.Controls[i] is TextBox)
                    {
                        (groupBox1.Controls[i] as TextBox).Text = "";
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                DeleteMethods.DeleteAllClasses();
                presenter.Refresh();
            }
        }
        void Add()
        {
            if (txtName.Text != "")
            {
                presenter.AddClass();
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Selected = true;
                dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.Rows.Count - 1;
                txtName.Text = "";
            }
            else MessageBox.Show("من فضلك ادخل اسم الصف");
            txtName.Select();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            btnAdd.Visible = false;
            btnEdit.Visible = true;
            btnDelete.Visible = true;
            btnDeleteAll.Visible = true;
            LoadData();
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13 && btnAdd.Enabled) { e.Handled = true; Add(); }
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            presenter.Search();
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13 && btnAdd.Enabled) { e.Handled = true;
                presenter.Search();
            }
        }
    }
}
