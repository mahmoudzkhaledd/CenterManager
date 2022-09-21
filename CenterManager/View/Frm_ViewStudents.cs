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
    public partial class Frm_ViewStudents : View_ModelForm, ViewStudentsInterFace
    {
        ViewStudentsPresenter presenter;
        int id = 0;
        Action<int> action;
        public Frm_ViewStudents(int mode = 0, Action<int> action = null)
        {
            InitializeComponent();
            presenter = new ViewStudentsPresenter(this, mode);
            if (mode != 0)
            {
                dataGridView1.Columns["ST_Phone"].Visible = false;
                dataGridView1.Columns["Address"].Visible = false;
                dataGridView1.Columns["Parent_Number"].Visible = false;
                dataGridView1.Columns["Is_for_Contact"].Visible = false;
                Width -= 200;
                groupBox1.Visible = false;
                button7.Visible = true;
                groupBox2.Location = new Point(groupBox2.Location.X, 5);
                dataGridView1.Location = new Point(groupBox2.Location.X, groupBox2.Location.Y + groupBox2.Height + 20);
                Height = dataGridView1.Location.Y + dataGridView1.Height + 50;
            }
            else groupBox1.Visible = true;
            this.action = action;
        }

        public object StudentDataSource
        {
            get => dataGridView1.DataSource;
            set
            {
                dataGridView1.DataSource = value;
            }
        }
        public DataGridViewRow SelectedRow { get => dataGridView1.CurrentRow; set { } }

        public string Search { get => textBox1.Text; set => textBox1.Text = value; }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {


            if (dataGridView1.Rows.Count > 0)
            {
                try
                {
                    id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["STID"].Value);
                    txtName.Text = dataGridView1.CurrentRow.Cells["STName"].Value.ToString();

                    txtType.Text = dataGridView1.CurrentRow.Cells["Study_Level"].Value.ToString();

                    txtParentNumber.Text = dataGridView1.CurrentRow.Cells["Parent_Number"].Value.ToString();

                    txtDiscount.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["Discount"].Value);

                }
                catch { }
            }
            else {
                id = 0;
                txtName.Text = "";
                txtType.Text = "";
                txtParentNumber.Text = "";
                txtDiscount.Text = "";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Methods.ViewForm(new Frm_AddStudent(), () => { presenter.UpdateData(); });
            if(dataGridView1.Rows.Count > 0) { 
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Selected = true;
                dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.Rows.Count - 1; 
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0) {
                int i = dataGridView1.SelectedRows[0].Index;
                Methods.ViewForm(new Frm_AddStudent(id), () => { presenter.UpdateData(); });
                dataGridView1.Rows[i].Selected = true;
                dataGridView1.FirstDisplayedScrollingRowIndex = i;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            presenter.UpdateData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;

                DeleteMethods.DeleteStudent(id);
                presenter.UpdateData();
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
            presenter.DeleteAll();
            presenter.UpdateData();
            id = 0;
            txtName.Text = "";
            txtType.Text = "";
            txtParentNumber.Text = "";
            txtDiscount.Text = "";
        }
        private void button6_Click_1(object sender, EventArgs e)
        {
            presenter.Search();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0) {
                action.Invoke(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["STCode"].Value));
                DialogResult = DialogResult.OK;
            }
        }
    }
}
