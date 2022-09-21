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
    public partial class Frm_ShowStudentBooks : View_ModelForm
    {
        CenterManagerEntities db = Methods.db;
        int stdid = -1;
        public Frm_ShowStudentBooks(int stdid, int stcode, string stname)
        {
            InitializeComponent();
            this.stdid = stdid;
            txtName.Text = stname;
            txtSTCode.Text = stcode.ToString();
            GetData();
        }

        private void GetData()
        {
            dataGridView1.DataSource = db.StudentBooks
                .Where(a => a.STID == stdid)
                .Select(a => new
                {
                    a.BookID,
                    a.ID,
                    a.Book.Name,
                    a.Number,
                    a.Paid,
                    a.Date
                }).ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0) {
                DialogResult d = MessageBox.Show("هل انت متاكد من الارجاع ؟", "", MessageBoxButtons.YesNo);
                if (d == DialogResult.Yes)
                {
                    int ID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);
                    int bID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["BookID"].Value);
                    Delete(ID, bID, (int)numericUpDown1.Value);
                    GetData();
                }
            }
        }
       public void Delete(int ID,int bID ,int value) {
            CenterManagerEntities db = Methods.db;
            try {
                db.Books.SingleOrDefault(a => a.ID == bID).Quantity += value;
            }
            catch { }
            db.StudentBooks.Remove(db.StudentBooks.SingleOrDefault(a => a.ID == ID));
            db.SaveChanges();
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown1.Value > Convert.ToInt32(txtNumber.Text)) {
                numericUpDown1.Value = Convert.ToInt32(txtNumber.Text);
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {

                txtNumber.Text = dataGridView1.SelectedRows[0].Cells["BooksNumber"].Value.ToString();
            }
            catch { }
        }
    }
}
