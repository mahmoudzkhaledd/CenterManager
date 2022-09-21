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
    public partial class Frm_viewGroups : View_ModelForm , ViewGroupsInterFace
    {
        ViewGroupsPresenter presenter;
        int id = 0;
        public Frm_viewGroups() {
            InitializeComponent();
            presenter = new ViewGroupsPresenter(this);
        }

        public object GroupsDataSours { get => dataGridView1.DataSource; set => dataGridView1.DataSource = value; }
        int ViewGroupsInterFace.id { get => id; set => id = value; }
        public string Search { get => txtSearch.Text; set => txtSearch.Text = value; }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e) {
           if(dataGridView1.Rows.Count > 0)
            {
                try
                {
                    txtName.Text = dataGridView1.SelectedRows[0].Cells["GroupName"].Value.ToString();
                    txtFrom.Text = dataGridView1.SelectedRows[0].Cells["FromHour"].Value.ToString();
                    txtTo.Text = dataGridView1.SelectedRows[0].Cells["ToHour"].Value.ToString();
                    txtClass.Text = dataGridView1.SelectedRows[0].Cells["ClassID"].Value.ToString();
                    txtPrice.Text = dataGridView1.SelectedRows[0].Cells["Price"].Value.ToString();
                    txtNote.Text = dataGridView1.SelectedRows[0].Cells["Note"].Value?.ToString();
                }
                catch { }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            presenter.LoadData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Methods.ViewForm(new Frm_AddGroup(0), () => { 
                presenter.LoadData();
                if(dataGridView1.Rows.Count > 0) {
                    dataGridView1.Rows[dataGridView1.Rows.Count - 1].Selected = true;
                    dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.Rows.Count - 1;
                }
            });
        }

        private void button1_Click(object sender, EventArgs e)
        {
           if(dataGridView1.Rows.Count > 0)
            {
                int i = dataGridView1.SelectedRows[0].Index;
                id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["GID"].Value);
                Methods.ViewForm(new Frm_AddGroup(id), () => {
                    presenter.LoadData();
                });
                dataGridView1.Rows[i].Selected = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["GID"].Value);
                DeleteMethods.DeleteGroup(id);
                presenter.LoadData();
                if (index - 1 > 0)
                {
                    dataGridView1.Rows[index - 1].Selected = true;
                    dataGridView1.FirstDisplayedScrollingRowIndex = index - 1;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(dataGridView1.Rows.Count > 0)
            {
                presenter.DeleteAll();
                presenter.LoadData();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            presenter.Search();
        }
    }
}
