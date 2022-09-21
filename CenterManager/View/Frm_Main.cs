using CenterManager.Control.DBControl;
using CenterManager.Control.Methods;
using CenterManager.Models.View_Models;
using CenterManager.View.ViewControls;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CenterManager.View
{
    enum State { StudentsPage, MainPage, Groups, Books, Attendance, Exam, Users, Settings, None }
    public partial class Frm_Main : Frm_Master
    {
        Ctrl_Students students;
        Ctrl_MainPage mainPage;
        Ctrl_Groups groups;
        Ctrl_Attendance att;
        Ctrl_Books books;
        State CurrentState = State.None;
        Ctrl_Exam Exam;
        Ctrl_Settings Settings;
        Ctrl_Users Users;
        public Frm_Main()
        {
            InitializeComponent();
            LoadColors();
            LoadSettings();
            LoadMyUser();
            Settings = new Ctrl_Settings(LoadSettings);
            students = new Ctrl_Students();
            mainPage = new Ctrl_MainPage();
            groups = new Ctrl_Groups();
            att = new Ctrl_Attendance();
            books = new Ctrl_Books();
            Exam = new Ctrl_Exam();
            Users = new Ctrl_Users();
            students.Dock = DockStyle.Fill;
            string s = Properties.Settings.Default.StartupPage;
            switch (s)
            {
                case "الرئيسيه":
                    AddPage(mainPage, State.MainPage, button9);
                    break;
                case "الطلاب":
                    AddPage(students, State.StudentsPage, button1);
                    break;
                case "المجاميع":
                    AddPage(groups, State.Groups, button2);
                    break;
                case "الحضور":
                    AddPage(att, State.Attendance, button3);
                    break;
                case "المذكرات":
                    AddPage(books, State.Books, button4);
                    break;
                case "الامتحانات":
                    AddPage(Exam, State.Exam, button5);
                    break;
                case "المصروفات":

                    break;
                case "الايرادات":
                    break;
                case "المستخدمين":
                    AddPage(Users, State.Users, button10);
                    break;
                case "اعدادات":
                    AddPage(Settings, State.Settings, button8);
                    break;
                default:
                    break;
            }
        }

        private void LoadMyUser()
        {
            if (Methods.MyUser != null) {
                lblUserName.Text = Methods.MyUser.UserName;
                lblUserName.Location = new Point((lblUserName.Parent.Width - lblUserName.Width)/2 , lblUserName.Location.Y);
                if (Methods.MyUser.Image != null) {
                    using (MemoryStream ms = new MemoryStream(Methods.MyUser.Image))
                    {
                        pictureBox1.Image = Image.FromStream(ms);
                        
                    }
                }
            }
            LoadPermissions();
        }

        private void LoadPermissions()
        {
            UsersPermission p = Methods.MyPermissions;
            button1.Visible = p.Subjects || p.EditClasses || p.AddStudent || p.ShowStudents;
            button2.Visible = p.AddGroup || p.StudentGroups || p.StudentGroups;
            button3.Visible = p.TakeAttendance || p.ViewAttendance;
            button4.Visible = p.AddBook || p.StudentBooks || p.ViewBooks;
            button5.Visible = p.AddExam || p.CorrentExams || p.ViewExams;
            button10.Visible = p.AddUser || p.EditUsers;
        }

        private void LoadColors()
        {
            CenterManagerEntities db = Methods.db;
            Setting setting = db.Settings.SingleOrDefault(a => a.ID == 1);
            Methods.TitleColor = setting.TitleColor;
            Methods.BackColor = setting.BackColor;
        }

        public void LoadSettings()
        {
            StringCollection s = Properties.Settings.Default.Indexes;
            if (s != null && s.Count > 0)
            {
                for (int i = 0; i < s.Count; i++)
                {
                    string x = s[i];
                    Button button = null;
                    foreach (Button b in flowLayoutPanel1.Controls)
                    {
                        if (b.Text == x)
                        {
                            button = b;
                            break;
                        }
                    }
                    if (button != null) flowLayoutPanel1.Controls.SetChildIndex(button, i);
                }
            }
            if (Methods.BackColor != "")
            {
                BackColor = System.Drawing.ColorTranslator.FromHtml(Methods.BackColor);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (ToolPanel.Width == 270)
            {
                Panel_Account.Visible = false;
                Top_Panel.Height = 60;
                ToolPanel.Width = 60;
            }
            else
            {
                Panel_Account.Visible = true;
                Top_Panel.Height = 274;
                ToolPanel.Width = 270;
            }
        }
        void AddPage(UserControl c, State state, Button b)
        {

            c.BackColor = Color.Transparent;
            if (Methods.TitleColor != "") c.ForeColor = System.Drawing.ColorTranslator.FromHtml(Methods.TitleColor);
            if (CurrentState != state)
            {
                if (state == State.MainPage)
                {
                    mainPage.StartUpdating();
                }
                Main_Panel.Controls.Clear();
                Main_Panel.Controls.Add(c);
                c.Dock = DockStyle.Fill;
                CurrentState = state;
                for (int i = 0; i < flowLayoutPanel1.Controls.Count; i++)
                {
                    if (flowLayoutPanel1.Controls[i] is Button)
                    {
                        Button b2 = (Button)flowLayoutPanel1.Controls[i];
                        if (b2 == b) b2.BackColor = Color.DimGray;
                        else b2.BackColor = Color.FromArgb(255, 64, 64, 64);
                    }
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            AddPage(students, State.StudentsPage, button1);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            AddPage(mainPage, State.MainPage, button9);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddPage(groups, State.Groups, button2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddPage(att, State.Attendance, button3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddPage(books, State.Books, button4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AddPage(Exam, State.Exam, button5);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AddPage(Settings, State.Settings, button8);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            AddPage(Users, State.Users, button10);
        }

        private void Frm_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult d = MessageBox.Show("هل انت متاكد من تسجيل الخروج","" ,MessageBoxButtons.YesNo);
            if (d == DialogResult.Yes) {
                Properties.Settings.Default.RememberPassword = false;
                Properties.Settings.Default.UserName = "";
                Properties.Settings.Default.Password = "";
                Properties.Settings.Default.Save();
                
                Thread th = new Thread(() => Application.Run(new Frm_Login()));
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
                Close();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog d = new OpenFileDialog())
            {
                d.Filter = "Image Files(*.PNG;*.JPG;*.JPEG)|*.PNG;*.JPG;*.JPEG|All files (*.*)|*.*";
                if (d.ShowDialog() == DialogResult.OK)
                {
                    long length = new System.IO.FileInfo(d.FileName).Length;
                    if (length * 0.000001 < 1)
                    {
                        pictureBox1.ImageLocation = d.FileName;
                        using (MemoryStream ms = new MemoryStream()) {
                            byte[] b = File.ReadAllBytes(d.FileName);
                            Methods.db.Users.SingleOrDefault(a => a.ID == Methods.MyUser.ID).Image = b;
                            
                            Methods.db.SaveChanges();
                            MessageBox.Show("تم تغيير الصوره");
                        }
                    }
                    else MessageBox.Show("حجم الملف اكبر من 1 ميجا");
                }
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
        }
    }
}
