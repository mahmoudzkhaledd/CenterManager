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
    public partial class Frm_AddBook : Add_ModelForm , AddBookInterFace
    {
        AddBookPresenter presenter;

        public string BookName { get => txtBookName.Text; set => txtBookName.Text = value; }
        public float PriceForST { get =>float.Parse(numPriceForSt.Value.ToString()) ; set => numPriceForSt.Value = decimal.Parse(value.ToString()); }
        public float Price { get => float.Parse(numPrice.Value.ToString()); set => numPrice.Value = decimal.Parse(value.ToString()); }
        public float Earnings { get => float.Parse(txtTotal.Text); set => txtTotal.Text = value.ToString(); }
        public int ClassID { get => Convert.ToInt32(cmbClass.SelectedValue); set => cmbClass.SelectedValue = value; }
        public int SubjectID { get => Convert.ToInt32(cmbSubjects.SelectedValue); set => cmbSubjects.SelectedValue =value; }
        public string Note { get => txtNote.Text; set => txtNote.Text = value; }
        public object ClassDataSource { get => cmbClass.DataSource; 
            set {
                cmbClass.DataSource = value;
                cmbClass.DisplayMember = "Class_Name";
                cmbClass.ValueMember = "ID";
            }
        }
        public object SubjectDataSource
        {
            get => cmbSubjects.DataSource;
            set
            {
                cmbSubjects.DataSource = value;
                cmbSubjects.DisplayMember = "Name";
                cmbSubjects.ValueMember = "ID";
            }
        }

        public int SelectedClassID { get => cmbClass.SelectedIndex; set => cmbClass.SelectedIndex = value; }
        public int Quantity { get => (int)numQuantity.Value; set => numQuantity.Value = value; }

        int id;
        public Frm_AddBook(int id)
        {
            this.id = id;   
            InitializeComponent();
            presenter = new AddBookPresenter(this ,id);
            if (id != 0) { button1.Text = "تعديل"; }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            txtTotal.Text = (-numPrice.Value + numPriceForSt.Value).ToString();
            if (numPrice.Value > numPriceForSt.Value) {
                numPrice.Value = numPriceForSt.Value;
            }

        }
        bool Check() {
            bool x = true;
            if (txtBookName.Text == "") {
                x = false;
                MessageBox.Show("من فضلك ادخل اسم المذكره");
            }
            return x;
        }
        void Execute() {

            if (Check())
                presenter.Execute();
            txtBookName.Select();
            if (id == 0) cmbSubjects.SelectedIndex = 0;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Execute();
        }

        private void txtBookName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                e.Handled = true;
                Execute();
            }
        }
    }
}
