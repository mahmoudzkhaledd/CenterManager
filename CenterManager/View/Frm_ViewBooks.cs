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
    public partial class Frm_ViewBooks : View_ModelForm , ViewBooksInterFace
    {
        ViewBooksPresenter presenter;
        public Frm_ViewBooks()
        {
            InitializeComponent();
            presenter = new ViewBooksPresenter(this);
        }
        int SelectedID = 0;
        public int id { get => SelectedID; set => SelectedID = value; }
        public object BooksDataSource { get => dataGridView1.DataSource; set => dataGridView1.DataSource = value; }
        public string Search { get => txtSearch.Text; set => txtSearch.Text = value; }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try { 
                if(dataGridView1.Rows.Count > 0)
                {
                    txtName.Text = dataGridView1.SelectedRows[0].Cells["BookName"].Value.ToString();
                    txtClass.Text = dataGridView1.SelectedRows[0].Cells["ClassID"].Value.ToString();
                    txtForST.Text = dataGridView1.SelectedRows[0].Cells["Price_for_St"].Value.ToString();
                    txtPrice.Text = dataGridView1.SelectedRows[0].Cells["Price"].Value.ToString();
                }
            } catch { }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            if(dataGridView1.Rows.Count > 0)
            {
                int i = dataGridView1.SelectedRows[0].Index;
                SelectedID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["BookID"].Value);
                Methods.ViewForm(new Frm_AddBook(SelectedID));
                presenter.UpdateBooks();
                dataGridView1.Rows[i].Selected = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                DeleteMethods.DeleteBook(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["BookID"].Value));
                presenter.UpdateBooks();
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

        private void button1_Click(object sender, EventArgs e)
        {
            presenter.DeleteAll(); 
            presenter.UpdateBooks();
            txtClass.Text = "";
            txtForST.Text = "";
            txtName.Text = "";
            txtPrice.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            presenter.Search();
        }
    }
}
