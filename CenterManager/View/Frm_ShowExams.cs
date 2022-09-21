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
    public partial class Frm_ShowExams : View_ModelForm
    {
        CenterManagerEntities db = Methods.db;
        public Frm_ShowExams()
        {
            InitializeComponent();
            UpdateData();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                try
                {
                    txtName.Text = dataGridView1.SelectedRows[0].Cells["ExamName"].Value.ToString();
                    txtFinalMark.Text = dataGridView1.SelectedRows[0].Cells["FinalMark"].Value.ToString();
                    txtQNumber.Text = dataGridView1.SelectedRows[0].Cells["NumberOfQuestions"].Value.ToString();
                }
                catch { }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Methods.ViewForm(new Frm_AddExam());
            UpdateData();
        }

        private void UpdateData()
        {
            dataGridView1.DataSource = db.Exams.Select(a => new {
                a.ID,
                a.Name,
                a.NumberOfQuestions,
                a.FinalMark,
                GroupID = a.Group.Name,
                Subject = a.Group.Subject.Name,
                a.Date,
            }).ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0) {
                int i = dataGridView1.SelectedRows[0].Index;
                Methods.ViewForm(new Frm_AddExam(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value)));
                UpdateData();
                dataGridView1.Rows[i].Selected = true;
                dataGridView1.FirstDisplayedScrollingRowIndex = i;
            }    
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);
                DeleteMethods.DeleteExam(id);
                UpdateData();
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
            DeleteMethods.DeleteAllExams();
            UpdateData();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (groupBox1.Controls[i] is TextBox)
                {
                    (groupBox1.Controls[i] as TextBox).Text = "";
                }
            }
        }

        private void button5_Click(object sender, EventArgs e) {
            if (dataGridView1.Rows.Count > 0) {
                int i = dataGridView1.SelectedRows[0].Index;
                Methods.ViewForm(new Frm_AddQuestions(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value), null, 1));
                UpdateData();
                dataGridView1.Rows[i].Selected = true;
                dataGridView1.FirstDisplayedScrollingRowIndex = i;
            }
        }
    }
}
