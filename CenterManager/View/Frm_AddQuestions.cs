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
    public partial class Frm_AddQuestions : View_ModelForm
    {
        CenterManagerEntities db = Methods.db;
        int ExamID = -1;
        Action<DataGridViewRowCollection ,double> action = null;
        int Mode;
        double TotalMarks { get => Convert.ToDouble(txtTotalMarks.Text); set => txtTotalMarks.Text = value.ToString(); }
        public Frm_AddQuestions(int e , Action<DataGridViewRowCollection, double> a ,int Mode = 0)
        {
            InitializeComponent();
            ExamID = e;
            action = a;
            this.Mode = Mode;
            if (Mode != 0) {
                GetData();
                Calculate();
            }
        }
        void GetData() {
            dataGridView1.DataSource = db.ExamDetails.Where(m => m.ExamID == ExamID)
                    .Select(x => new {
                        ID = x.ID,
                        Text = x.Name,
                        Value = x.Mark
                    }).ToList();
        }
        
        void Calculate() {
            TotalMarks = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++) {
                TotalMarks += Convert.ToDouble(dataGridView1.Rows[i].Cells["QMark"].Value);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && QuestionMark.Value != 0)
            {
                if (Mode == 0) {
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells["QName"].Value = txtName.Text;
                    dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells["QMark"].Value = QuestionMark.Value;
                }
                else {
                    ExamDetail d = new ExamDetail();
                    d.Name = txtName.Text;
                    d.Mark = Convert.ToDouble(QuestionMark.Value);
                    d.ExamID = ExamID;
                    db.ExamDetails.Add(d);
                    db.SaveChanges();
                    GetData();
                }
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Selected = true;
                dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.Rows.Count - 1;
                Calculate();
                Clear();
            }
        }

        private void Clear()
        {
            txtName.Text = "";
            QuestionMark.Value = 1;
            txtName.Select();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                int index = 0;
                try { index = dataGridView1.SelectedRows[0].Index; } catch { }
                if (Mode == 0)
                {
                    dataGridView1.Rows.Remove(dataGridView1.SelectedRows[0]);
                }
                else
                {
                    int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);
                    db.ExamDetails.Remove(db.ExamDetails.SingleOrDefault(a => a.ID == id));
                    db.SaveChanges();
                    GetData();
                }

                if (index - 1 > 0)
                {
                    dataGridView1.Rows[index - 1].Selected = true;
                    dataGridView1.FirstDisplayedScrollingRowIndex = index - 1;
                }
                else if (dataGridView1.Rows.Count > 0)
                {
                    dataGridView1.Rows[0].Selected = true;
                    dataGridView1.FirstDisplayedScrollingRowIndex = 0;
                }
                Calculate();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Mode == 0)
            {
                action.Invoke(dataGridView1.Rows , TotalMarks);
                Hide();
            }
            else {
                Exam exam = db.Exams.SingleOrDefault(a => a.ID == ExamID);
                exam.FinalMark = TotalMarks;
                exam.NumberOfQuestions = dataGridView1.Rows.Count;
                db.SaveChanges(); 
                DialogResult = DialogResult.OK;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0) {
                int i = dataGridView1.SelectedRows[0].Index;
                if (Mode == 0) {
                    dataGridView1.SelectedRows[0].Cells["QName"].Value = txtName.Text;
                    dataGridView1.SelectedRows[0].Cells["QMark"].Value = QuestionMark.Value;
                }
                else
                {
                    int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);
                    ExamDetail exam = db.ExamDetails.SingleOrDefault(a => a.ID == id);
                    exam.Name = txtName.Text;
                    exam.Mark = Convert.ToDouble(QuestionMark.Value);
                    db.SaveChanges();
                    GetData();
                }
                dataGridView1.Rows[i].Selected = true;
                dataGridView1.FirstDisplayedScrollingRowIndex = i;
                Calculate();
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0) {
                try
                {
                    if (Mode == 0) {
                        if (dataGridView1.SelectedRows[0].Cells[1].Value != null && dataGridView1.SelectedRows[0].Cells[2].Value != null) {
                            txtName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                            QuestionMark.Value = Convert.ToDecimal(dataGridView1.SelectedRows[0].Cells[2].Value);
                        }
                    } else {
                        txtName.Text = dataGridView1.SelectedRows[0].Cells["QName"].Value.ToString();
                        QuestionMark.Value = Convert.ToDecimal(dataGridView1.SelectedRows[0].Cells["QMark"].Value);
                    }
                }
                catch { }

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            btnAdd.Visible = false;
            btnEdit.Visible = true;
            btnDelete.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            btnAdd.Visible = true;
            btnEdit.Visible = false;
            btnDelete.Visible = false;
            Clear();
        }
    }
}
