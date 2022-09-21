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
    public partial class Frm_CorrectExams : View_ModelForm
    {
        int ExamID = -1;
        Exam ExamModel = null;
        CenterManagerEntities db = Methods.db;
        public Frm_CorrectExams()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Methods.ViewForm(new Frm_ChooseGroup((i, s) => { ExamID = i; }, ExamID, 1));
            if (ExamID != -1) {
                ExamModel = db.Exams.SingleOrDefault(a => a.ID == ExamID);
            }
            LoadData();
            numMark.Focus();
        }

        private void InsertAllStudents()
        {
            
        }

        private void LoadData()
        {
            if (ExamModel != null) { 
                txtExamName.Text = ExamModel.Name;
                txtFinalMark.Text= ExamModel.FinalMark.ToString();
                var c = db.StudentsGroups.Where(a => a.GroupID == ExamModel.GroupID)
                    .Select(x=>new {
                        x.Student.ID,
                        x.Student.STCode,
                        x.Student.Name
                    }).ToList();
                foreach (var x in c) {
                    if (db.StudentExams.SingleOrDefault(a=>a.STID == x.ID && a.ExamID == ExamID) == null) {
                        StudentExam exam = new StudentExam();
                        exam.STID = x.ID;
                        exam.ExamID = ExamID;
                        exam.Mark = 0;
                        db.StudentExams.Add(exam);
                    }
                }
                db.SaveChanges();
                c.Clear();
            }
            LoadStudents();
        }

        private void LoadStudents()
        {
            dataGridView1.DataSource = db.StudentExams.Where(a => a.ExamID == ExamID)
                .Select(x => new {
                    x.Student.ID,
                    x.Student.STCode,
                    x.Student.Name,
                    STMark = x.Mark
                }).ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (chkSaveFirst.Checked) Done();
            Next();
        }

        private void Next()
        {
            if (dataGridView1.Rows.Count > 0) {
                if (dataGridView1.SelectedRows[0].Index + 1 < dataGridView1.Rows.Count){
                    dataGridView1.Rows[dataGridView1.SelectedRows[0].Index + 1].Selected = true;
                    dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.SelectedRows[0].Index;
                }
                numMark.Focus();
            }
        }
        private void Previous()
        {
            if (dataGridView1.Rows.Count > 0)
            {
                if (dataGridView1.SelectedRows[0].Index - 1 >= 0){
                    dataGridView1.Rows[dataGridView1.SelectedRows[0].Index - 1].Selected = true;
                    dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.SelectedRows[0].Index;
                }
                numMark.Select();
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (chkSaveFirst.Checked) Done();
            Previous();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0) {
                try
                {
                    txtName.Text = dataGridView1.SelectedRows[0].Cells["STName"].Value.ToString();
                    numMark.Value = Convert.ToDecimal(dataGridView1.SelectedRows[0].Cells["STMark"].Value);
                }
                catch { }
            }
        }
        void Done() {
            if (dataGridView1.Rows.Count > 0) {
                int i = dataGridView1.SelectedRows[0].Index;
                int STDID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);
                db.StudentExams.SingleOrDefault(a => a.STID == STDID && a.ExamID == ExamID).Mark = Convert.ToDouble(numMark.Value);
                db.SaveChanges();

                LoadStudents();
                dataGridView1.Rows[i].Selected = true;
                numMark.Select();
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Done();
        }
        
        private void numMark_ValueChanged(object sender, EventArgs e)
        {
            if (txtFinalMark.Text != "") {
                if (numMark.Value > Convert.ToDecimal(txtFinalMark.Text))
                {
                    numMark.Value = Convert.ToDecimal(txtFinalMark.Text);
                }
            }
        }

        private void numMark_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                e.Handled = true;
                Done();
            }
        }
    }
}
