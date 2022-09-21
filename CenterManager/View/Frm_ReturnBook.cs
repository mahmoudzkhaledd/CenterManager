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
    public partial class Frm_ReturnBook : Frm_Master
    {
        CenterManagerEntities db = Methods.db;
        Student StudentModel = null;
        Book BookModel = null;
        bool Student = false;
        int AvailableBooksNumber = 0;
        decimal TotalReturn { get => Convert.ToDecimal(txtTotal.Text); set => txtTotal.Text = value.ToString(); }
        
        float Total = 0;
        public Frm_ReturnBook()
        {
            InitializeComponent();
        }

        void LoadStudentData()
        {
            if (txtStCode.Text != "")
            {
                int stid = -1;
                try
                {
                    stid = Convert.ToInt32(txtStCode.Text);
                }
                catch
                {
                    StudentModel = null;
                    return;
                }
                StudentModel = db.Students.SingleOrDefault(a => a.STCode == stid);
                if (StudentModel != null)
                {
                    txtStName.Text = StudentModel.Name;
                    txtStCode.BackColor = Color.LawnGreen;
                    Student = true;
                    Calculate();
                    dataGridView1.DataSource = db.StudentBooks.Where(a => a.STID == StudentModel.ID)
                        .Select(x =>
                        new {
                            x.ID,
                            BookID =  x.Book.ID,
                            x.Book.Name,
                            x.Number,
                            x.AfterDiscount,
                            x.Date
                        }).ToList();
                    // dataGridView2.Rows.Clear();
                }
                else
                {
                    txtStCode.BackColor = Color.Red;
                    Student = false;
                    txtStName.Text = "";
                    StudentModel = null;
                }
            }
            else
            {
                txtStCode.BackColor = Color.Red;
                Student = false;
                txtStName.Text = "";
                StudentModel = null;
            }
        }
        int ReturnNumber { get => (int)numReturn.Value; set=>numReturn.Value = value;  }
        private void Calculate()
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadStudentData();
        }

        private void txtStCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                e.Handled = true;
                LoadStudentData();
            }
        }

        private void txtStCode_Leave(object sender, EventArgs e)
        {
            LoadStudentData();
        }

        private void txtStCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
               
                Total = float.Parse(dataGridView1.SelectedRows[0].Cells["TotalPaid"].Value.ToString());
                AvailableBooksNumber = (int)dataGridView1.SelectedRows[0].Cells["BooksNumber"].Value;
                ReturnNumber = (int)dataGridView1.SelectedRows[0].Cells["BooksNumber"].Value;
            }
            else {
                BookModel = null;
            } 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0) {
                if ((int)dataGridView1.SelectedRows[0].Cells["BooksNumber"].Value > 0) {
                    DataGridViewRow row = new DataGridViewRow();
                    row = (DataGridViewRow)dataGridView1.SelectedRows[0].Clone();
                    row.Cells.RemoveAt(5);
                    row.Cells[0].Value = dataGridView1.SelectedRows[0].Cells["ID"].Value;
                    row.Cells[1].Value = dataGridView1.SelectedRows[0].Cells["BookID"].Value;
                    row.Cells[2].Value = dataGridView1.SelectedRows[0].Cells["BookName"].Value;
                    row.Cells[3].Value = ReturnNumber;
                    row.Cells[4].Value = dataGridView1.SelectedRows[0].Cells["TotalPaid"].Value;
                    TotalReturn += Convert.ToDecimal(dataGridView1.SelectedRows[0].Cells["TotalPaid"].Value);
                    dataGridView2.Rows.Add(row);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView2.Rows.Count > 0) {
                TotalReturn -= Convert.ToDecimal(dataGridView2.SelectedRows[0].Cells["SelectedPaid"].Value);
                dataGridView2.Rows.Remove(dataGridView2.SelectedRows[0]);
            }
        }

        private void numReturn_ValueChanged(object sender, EventArgs e)
        {
            if (numReturn.Value > AvailableBooksNumber) {
                numReturn.Value = AvailableBooksNumber;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*if (StudentModel != null)
            {
                for (int i = 0; i < dataGridView2.Rows.Count; i++)
                {
                    Return.BOOKID = (int)dataGridView2.Rows[i].Cells["StudentBookID"].Value;
                    Return.STID = StudentModel.ID;
                    Return.RETURNNUMBER = (int)dataGridView2.Rows[i].Cells["SelectedBookNumber"].Value;
                    db.ReturnBooks.Add(Return);
                    int aaa = (int)dataGridView2.Rows[i].Cells["OperationID"].Value;
                    db.StudentBooks.SingleOrDefault(a => a.ID == aaa).Number -= (int)dataGridView2.Rows[i].Cells["SelectedBookNumber"].Value;
                    db.SaveChanges();
                }
                LoadStudentData();
                dataGridView2.Rows.Clear();
            }
            else
                MessageBox.Show("من فضلك ادخل كود الطالب");*/
        }
    }
}
