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
    public partial class Frm_AddGroup : Add_ModelForm, AddGroupInterFace
    {
        AddGroupPresenter presenter;
        public Frm_AddGroup(int id, int m = 0)
        {
            InitializeComponent();
            presenter = new AddGroupPresenter(this, id);
            if (m == 0)
            {
                if (id == 0) button1.Text = "اضافة";
                else button1.Text = "تعديل";
                EndTime.Value.AddHours(2);
                
            }
            else
            {
                button1.Visible = false;
                groupBox1.Enabled = false;
                Height -= button1.Height;
            }
        }
        public string GroupName { get =>txtName.Text ; set =>txtName.Text = value ; }
        public DateTime YearStart { get => StartYear.Value; set =>StartYear.Value = value ; }
        public DateTime YearEnd { get => EndYear.Value; set =>EndYear.Value = value ; }
        
        public string FromTime { get => StartTime.Text; set => StartTime.Value = DateTime.Parse(value); }
        public string ToTime { get => EndTime.Text; set =>EndTime.Value = DateTime.Parse(value); }
       
        public int Class { get => Convert.ToInt32(cmbClass.SelectedValue); set => cmbClass.SelectedValue = value; }
        public bool IsActive { get =>chkIsActive.Checked ; set =>chkIsActive.Checked = value ; }
        public float Price { get =>float.Parse(numPrice.Value.ToString()) ; set => numPrice.Value = Convert.ToDecimal(value); }
        public string Note { get => txtNote.Text; set => txtNote.Text = value; }
        public bool Sat 
        { get => Days.Items["السبت"].CheckState == CheckState.Checked ; 
            set => Days.Items["السبت"].CheckState = value ? CheckState.Checked:CheckState.Unchecked; }
        public bool Sun
        {
            get => Days.Items["الاحد"].CheckState == CheckState.Checked;
            set => Days.Items["الاحد"].CheckState = value ? CheckState.Checked : CheckState.Unchecked;
        }
        public bool Mon
        {
            get => Days.Items["الاثنين"].CheckState == CheckState.Checked;
            set => Days.Items["الاثنين"].CheckState = value ? CheckState.Checked : CheckState.Unchecked;
        }
        public bool Tues
        {
            get => Days.Items["الثلاثاء"].CheckState == CheckState.Checked;
            set => Days.Items["الثلاثاء"].CheckState = value ? CheckState.Checked : CheckState.Unchecked;
        }
        public bool Wed
        {
            get => Days.Items["الاربع"].CheckState == CheckState.Checked;
            set => Days.Items["الاربع"].CheckState = value ? CheckState.Checked : CheckState.Unchecked;
        }
        public bool Thurs
        {
            get => Days.Items["الخميس"].CheckState == CheckState.Checked;
            set => Days.Items["الخميس"].CheckState = value ? CheckState.Checked : CheckState.Unchecked;
        }
        public bool Fri {
            get => Days.Items["الجمعه"].CheckState == CheckState.Checked;
            set => Days.Items["الجمعه"].CheckState = value ? CheckState.Checked : CheckState.Unchecked;
        }
        public object ClassDataSource
        {
            get => cmbClass.DataSource;
            set
            {
                try
                {
                    cmbClass.DataSource = value;
                    cmbClass.DisplayMember = "Class_Name";
                    cmbClass.ValueMember = "ID";
                }
                catch { }
            }
        }
        public int SelectedClass
        {
            get => Convert.ToInt32(cmbClass.SelectedValue);
            set
            {
                try {cmbClass.SelectedIndex = value;  } catch { }
            }
        }

        public int Subject { get => Convert.ToInt32(cmbSubject.SelectedValue); set => cmbSubject.SelectedValue = value; }
        public object SubjectDataSource { get => cmbSubject.DataSource; set
            { 
                cmbSubject.DataSource = value;
                cmbSubject.DisplayMember = "Name";
                cmbSubject.ValueMember = "ID";
            } }

        bool Check()
        {
            bool x = true;
            if (txtName.Text == "") x = false;
            if (cmbClass.Items.Count == 0) x = false;
            if (Days.CheckedItems.Count == 0) x = false;
            return x;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(StartTime.Text.ToString());
            if (StartTime.Value >= EndTime.Value)
            {
                MessageBox.Show("يجب ان يكون وقت بدء المجموعه بعد وقت انتهائها");
                return;
            }
            if (StartYear.Value.Year > EndYear.Value.Year || StartYear.Value.Month > EndYear.Value.Month || StartYear.Value.Day > EndYear.Value.Day || 
                    (StartYear.Value.Year == EndYear.Value.Year && StartYear.Value.Month == EndYear.Value.Month && StartYear.Value.Day == EndYear.Value.Day))
            {
                MessageBox.Show("يجب ان يكون وقت بدء السنه الدراسيه بعد وقت انتهائها");
                return;
            }
            if (Check()) presenter.Execute();
            else { MessageBox.Show("من فضلك ادخل كل البيانات"); }
        }
    }
}
