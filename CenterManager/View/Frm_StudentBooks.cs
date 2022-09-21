using CenterManager.Control.DBControl;
using CenterManager.Control.Methods;
using CenterManager.Models.View_Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CenterManager.View
{
    public partial class Frm_StudentBooks : Frm_Master
    {

        CenterManagerEntities db = Methods.db;
        Student StudentModel = null;
        Book BookModel = null;
        bool Student = false;
        bool BookChosen = false;
        int NeddedBooksNumber { get => Convert.ToInt32(BooksNumber.Value); set => BooksNumber.Value = value; }
        float BookPrice { get => float.Parse(txtPrice.Text); set => txtPrice.Text = value.ToString(); }
        float Discount { get => (float)numDiscount.Value; set => numDiscount.Value = Convert.ToDecimal(value); }
        float TotalBeforeDiscount { get => float.Parse(txtTotalBefore.Text); set => txtTotalBefore.Text = value.ToString(); }
        float TotalAfterDiscount { get => float.Parse(txtTotalAfter.Text); set => txtTotalAfter.Text = value.ToString(); }
        float Paid { get => (float)numPaid.Value; set => numPaid.Value = Convert.ToDecimal(value); }
        float Remainder { get => float.Parse(txtRemainder.Text); set => txtRemainder.Text = value.ToString(); }
        public Frm_StudentBooks()
        {
            InitializeComponent();
            LoadBooks();
        }
        void LoadBooks()
        {
            cmbBook.DataSource = db.Books.Select(x => new { BoookID = x.ID, BoookName = x.Name }).ToList();
            cmbBook.DisplayMember = "BoookName";
            cmbBook.ValueMember = "BoookID";
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
                    txtDiscount.Text = StudentModel.Discount.ToString();
                    txtStCode.BackColor = Color.LawnGreen;
                    Student = true;
                    Calculate();
                }
                else
                {
                    txtStCode.BackColor = Color.Red;
                    Student = false;
                    txtStName.Text = "";
                    txtDiscount.Text = "";
                    StudentModel = null;
                }
            }
            else
            {
                txtStCode.BackColor = Color.Red;
                Student = false;
                txtStName.Text = "";
                txtDiscount.Text = "";
                StudentModel = null;
            }
        }
        StudentBook GetInterFaceData()
        {
            if (StudentModel != null && BookModel != null)
            {
                StudentBook s = new StudentBook();
                s.BookID = BookModel.ID;
                s.STID = StudentModel.ID;
                s.Number = NeddedBooksNumber;
                s.Discount = Discount;
                s.BeforeDiscount = TotalBeforeDiscount;
                s.AfterDiscount = TotalAfterDiscount;
                s.Paid = Paid;
                s.Remainder = Remainder;
                s.Date = DateTime.Now.ToString();
                return s;
            }
            return null;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            try {
                Payment();
            }
            catch {
            }
        }
        private void Payment()
        {
            if (Student && BookChosen)
            {
                StudentBook s = GetInterFaceData();
                if(s == null)
                {
                    MessageBox.Show("من فضلك اختر الطالب");
                    return;
                }
                if (NeddedBooksNumber <= BookModel.Quantity)
                {
                    if (db.StudentBooks.SingleOrDefault(a => a.STID == s.STID && a.BookID == s.BookID) == null)
                    {
                        db.StudentBooks.Add(s);
                        BookModel.Quantity -= NeddedBooksNumber;
                        db.SaveChanges();
                        LoadBooksData();
                        MessageBox.Show("تمت العمليه بنجاح");
                    }
                    else
                        MessageBox.Show("الطالب اخد المذكره بالفعل");
                }
                else {
                    MessageBox.Show("العدد المطلوب اكبر من الكميه المتوفره");
                }
            }
            else MessageBox.Show("فشلت العمليه");
        }

       

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtStCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbBook_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBook.Text != "")
            {
                LoadBooksData();
                Calculate();
            }
        }

        private void LoadBooksData()
        {
            if (cmbBook.Items.Count > 0)
            {
                int id = -1;
                try {
                    id = Convert.ToInt32(cmbBook.SelectedValue.ToString().Split('=')[1].Split(',')[0]);
                }
                catch {
                    try {
                        id = (int) cmbBook.SelectedValue;
                    }
                    catch {
                        id = -1;
                        BookModel = null;
                        return;
                    }
                }
                BookModel = db.Books.SingleOrDefault(x => x.ID == id);
                if (BookModel != null)
                {
                    txtBookName.Text = BookModel.Name;
                    txtRemindBooks.Text = BookModel.Quantity.ToString();
                    txtClass.Text = BookModel.Class1.Class_Name;
                    txtSubject.Text = BookModel.Subject.Name;
                    txtNote.Text = BookModel.Note;
                    txtPrice.Text = BookModel.Price_for_St.ToString();
                    BookChosen = true;
                }
                else
                {
                    BookChosen = false;
                    BookModel = null;
                }
            }
            else BookModel = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadStudentData();
        }

        private void BooksNumber_ValueChanged(object sender, EventArgs e)
        {
            Calculate();
            if (BookModel != null) {
                if (BooksNumber.Value > BookModel.Quantity)
                {
                    BooksNumber.Value = BookModel.Quantity;
                }
            }
        }

        private void Calculate()
        {
            if (BookModel != null)
            {
                try
                {
                    TotalBeforeDiscount = NeddedBooksNumber * BookPrice;
                    if (rdioDiscountAll.Checked)
                    {
                        TotalAfterDiscount = TotalBeforeDiscount - Discount;
                    }
                    else
                    {
                        TotalAfterDiscount = NeddedBooksNumber * (BookPrice - Discount);
                    }
                    Remainder = Paid - TotalAfterDiscount;
                }
                catch { }
            }
        }

        private void numDiscount_ValueChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void rdioDiscountBook_CheckedChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void rdioDiscountAll_CheckedChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void numPaid_ValueChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Methods.ViewForm(new Frm_ViewStudents(1, (i) => { txtStCode.Text = i.ToString();LoadStudentData(); }));
            Calculate();
        }

        private void txtStCode_Leave(object sender, EventArgs e)
        {
            LoadStudentData();
        }
        private void txtStCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoadStudentData();
                e.Handled = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (StudentModel != null) {
                Methods.ViewForm(new Frm_ShowStudentBooks(StudentModel.ID,StudentModel.STCode,StudentModel.Name));
                LoadBooksData();
            }
        }
    }
}
