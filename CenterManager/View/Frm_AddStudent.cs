using CenterManager.Control.DBControl;
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
    public partial class Frm_AddStudent : Add_ModelForm , AddStudentInterFace
    {
        // 0 for Add Mode and 1 for Edite Mode
        public Frm_AddStudent(int ID = 0 ,int m = 0)
        {
            InitializeComponent();
            presenter = new AddStudentPresenter(this,ID);
            if(m == 0)
            {
                if (ID == 0) button1.Text = "اضافة";
                else button1.Text = "تعديل";
            }
            else
            {
                button1.Visible = false;
                for(int i = 0; i < groupBox1.Controls.Count; i++)
                {
                    if (groupBox1.Controls[i] is Label) {}
                    else { groupBox1.Controls[i].Enabled = false; }
                }
                Height -= button1.Height;
            }
        }

        AddStudentPresenter presenter;
        Student s = new Student();
        public bool isMale
        {
            get => rdioMale.Checked;
            set
            {
                rdioMale.Checked = value;
                rdioFemale.Checked = !value;
            }
        }
        public int StClass
        {
            get => Convert.ToInt32(cmbClass.SelectedValue);
            set => cmbClass.SelectedValue = value;
        }
        public string PhoneNumber { get => txtPhoneNumber.Text; set => txtPhoneNumber.Text = value; }
        public string Address { get => txtAddress.Text; set => txtAddress.Text = value; }
        public string ParentNumber { get => txtParentNumber.Text; set => txtParentNumber.Text = value; }
        public bool IsForContact { get => chkContact.Checked; set => chkContact.Checked = value; }
        public string School { get => txtSchool.Text; set => txtSchool.Text = value; }
        public int Type
        {
            get
            {
                if (cmbType.Text == "عام") return 0;
                else if (cmbType.Text == "علمى رياضه") return 1;
                else if (cmbType.Text == "علمى علوم") return 2;
                else return 3;
            }
            set
            {
                cmbType.SelectedItem = cmbType.Items[value];
            }
        }

        public int SelectedClass
        {
            get => Convert.ToInt32(cmbClass.SelectedValue);
            set {
                try { cmbClass.SelectedItem = cmbClass.Items[value]; } catch { }
            }
        }

        public double discount { get => Convert.ToDouble(numDiscount.Value); set => numDiscount.Value = Convert.ToDecimal(value); }
        public object ClassDataSource
        {
            get => cmbClass.DataSource;
            set
            {
                try {  
                    cmbClass.DataSource = value;
                    cmbClass.DisplayMember = "Class_Name";
                    cmbClass.ValueMember = "ID";
                } catch { }
            }
        }

        public string STName { get => txtName.Text; set => txtName.Text = value; }
        public int STCode { get => Convert.ToInt32(txtCode.Text); set => txtCode.Text = value.ToString(); }

        bool Check()
        {
            bool x = true;
            for (int i = 0; i < groupBox1.Controls.Count; i++)
            {
                if (groupBox1.Controls[i] is TextBox)
                {
                    TextBox t = groupBox1.Controls[i] as TextBox;
                    if (t.Text == "") { x = false; break; }
                }
            }
            if (cmbClass.Items.Count == 0) x = false;
            return x;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Check()) presenter.Execute();
            else MessageBox.Show("من فضلك ادخل كل البيانات");
        }
    }
}
