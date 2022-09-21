using CenterManager.Control.DBControl;
using CenterManager.Control.Methods;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CenterManager.View.ViewControls
{
    public partial class Ctrl_MainPage : UserControl
    {
        
        public void UpdateData() {
            CenterManagerEntities db = Methods.db;
            try
            {
                lblGroupsNumber.Text = db.Groups.Count().ToString();
                lblSubjectsNumber.Text = db.Subjects.Count().ToString();
                lblClassesNumber.Text = db.Classes.Count().ToString();
                lblStudentsNumber.Text = db.Students.Count().ToString();
                lblBooksNumber.Text = db.Books.Count().ToString();
                lblExamsNumber.Text = db.Exams.Count().ToString();
                lblLecsNumber.Text = db.Lectures.Count().ToString();
                UpdateProgramName(db);
            }
            catch { }
        }
        override public Color ForeColor
        {
            set
            {
                lblProgramName.ForeColor = value;
                flowLayoutPanel1.ForeColor = Color.Black;
            }
            get => lblProgramName.ForeColor;
        }
        private void UpdateProgramName(CenterManagerEntities db = null)
        {
            if(db != null) lblProgramName.Text = db.Settings.SingleOrDefault(a=>a.ID == 1).ProgramName;
            lblProgramName.Location = new Point((Width - lblProgramName.Width)/2 ,lblProgramName.Location.Y);
        }

        public Ctrl_MainPage()
        {
            InitializeComponent();
            flowLayoutPanel1.Location = new Point(Width / 2 - flowLayoutPanel1.Width/2 ,(Height + lblProgramName.Height) / 2 - flowLayoutPanel1.Height /2);
            StartUpdating();
            if (Methods.TitleColor != "")
            {
                lblProgramName.ForeColor = System.Drawing.ColorTranslator.FromHtml(Methods.TitleColor);
            }
            UsersPermission p = Methods.MyPermissions;
            panel2.Visible =p.ViewAllGroups ;
            panel3.Visible = p.Subjects;
            panel4.Visible = p.EditClasses;
            panel5.Visible = p.ShowStudents;
            panel8.Visible = p.ViewAttendance;
            panel9.Visible = p.ViewBooks;
            panel10.Visible = p.ViewExams; 
            
        }
        public void StartUpdating() {
            UpdateData();
        }
        private void panel1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("");
        }

        private void flowLayoutPanel1_Resize(object sender, EventArgs e)
        {
            
        }

        private void Ctrl_MainPage_Resize(object sender, EventArgs e)
        {
            UpdateProgramName();
        }
    }
}
