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
    public partial class Frm_AddExam : Add_ModelForm
    {
        CenterManagerEntities db = Methods.db;
        Group GroupModel = null;
        Exam ExamModel = null;
        int ExamID = 1;
        int ID = 1;
        Frm_AddQuestions frm = null;
        DataGridViewRowCollection Questions = null;
        public Frm_AddExam(int id = 0)
        {
            ID = id;
            InitializeComponent();
            cmbGroups.DataSource = db.Groups.Select((x) => new { GroupName = x.Name, ID = x.ID }).ToList();
            cmbGroups.DisplayMember = "GroupName";
            cmbGroups.ValueMember = "ID";
            UpdateExamID(); 
            cmbGroups_SelectedIndexChanged(null, null);
            if (ID != 0) {
                button2.Visible = false;
                QNumber.Width = 312;
                QNumber.Location = new Point(FinalMark.Location.X, QNumber.Location.Y);
                button1.Text = "تعديل";
                ExamModel = db.Exams.SingleOrDefault(a => a.ID == ID);
                GroupModel = (Group)(ExamModel.Group);
                LoadDataToScreen();
            }
            
        }
        void LoadDataToScreen()
        {
            txtName.Text = ExamModel.Name;
            cmbGroups.SelectedValue = GroupModel.ID;
            QNumber.Value = ExamModel.NumberOfQuestions;
            FinalMark.Value =Convert.ToDecimal(ExamModel.FinalMark);
            ExamDate.Value = ExamModel.Date;
            cmbGroups_SelectedIndexChanged(null, null);
        }
        void UpdateExamID()
        {
            try {
                ExamID = db.Exams.Max(x => x.ID) + 1;
            }
            catch { ExamID = 1; }
        }
        void GetExam()
        {
            try
            {
                if (ID == 0) {
                    ExamModel = new Exam();
                    ExamModel.ID = ExamID;
                }
                ExamModel.Name = txtName.Text;
                ExamModel.GroupID = Convert.ToInt32(cmbGroups.SelectedValue);
                ExamModel.Date = ExamDate.Value;
                ExamModel.NumberOfQuestions = (int)QNumber.Value;
                ExamModel.FinalMark = (double)FinalMark.Value;
            }
            catch { }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (ID == 0) {
                if (GroupModel != null && txtName.Text != "")
                {
                    GetExam();
                    if (ExamModel != null) {
                        db.Exams.Add(ExamModel);
                        AddQuestions();
                        db.SaveChanges();
                        MessageBox.Show("تم الاضافه بنجاح");
                        UpdateExamID();
                        Clear();
                    }
                    else { MessageBox.Show("من فضلك ادخل بيانات صحيحه"); }
                }
                else MessageBox.Show("من فضلك ادخل كل البيانات");
                txtName.Select();
            }
            else {
                GetExam();
                db.SaveChanges();
                MessageBox.Show("تم التعديل بنجاح");
            }
        }

        private void AddQuestions()
        {
            if (Questions != null) {
                for (int i = 0; i < Questions.Count; i++) {
                    ExamDetail exam = new ExamDetail();
                    exam.Name = Questions[i].Cells[1].Value.ToString();
                    exam.Mark = Convert.ToDouble(Questions[i].Cells[2].Value);
                    exam.ExamID = ExamID;
                    db.ExamDetails.Add(exam);
                }
            }
        }

        private void Clear()
        {
            txtName.Text = "";
            QNumber.Value = 0;
            FinalMark.Value = 0;
            ExamDate.Value = DateTime.Now;

        }

        private void cmbGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbGroups.Text != "" && cmbGroups.Items.Count > 0) {
                int selID = -2;
                try {
                    selID = Convert.ToInt32(cmbGroups.SelectedValue);
                    GroupModel = db.Groups.SingleOrDefault(a=>a.ID == selID);
                    if (GroupModel != null) {
                        txtSubjectName.Text = GroupModel.Subject.Name;
                        txtFromHour.Text = GroupModel.FromHour;
                        txtToHour.Text = GroupModel.ToHour;
                    }
                }
                catch { 
                    GroupModel = null;
                    selID = -2; 
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(frm == null) 
                frm = new Frm_AddQuestions(ExamID, (i ,m) => { 
                    Questions = i;
                    QNumber.Value = Questions.Count;
                    FinalMark.Value = Convert.ToDecimal(m);
                }, 0);

            frm.ShowDialog();
        }

        private void Frm_AddExam_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(frm != null) frm.Dispose();
        }
    }
}
