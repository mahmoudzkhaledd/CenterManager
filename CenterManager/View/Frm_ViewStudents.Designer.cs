namespace CenterManager.View
{
    partial class Frm_ViewStudents
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.STID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ST_Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Parent_Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Is_for_Contact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsMale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Study_Level = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.School = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtParentNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtType = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDiscount);
            this.groupBox1.Controls.Add(this.txtType);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtParentNumber);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Size = new System.Drawing.Size(1390, 151);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button7);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Location = new System.Drawing.Point(12, 169);
            this.groupBox2.Size = new System.Drawing.Size(1390, 103);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Droid Arabic Kufi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STID,
            this.STCode,
            this.STName,
            this.ST_Phone,
            this.Address,
            this.Parent_Number,
            this.Is_for_Contact,
            this.IsMale,
            this.ClassID,
            this.Study_Level,
            this.School,
            this.Discount});
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(12, 284);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1390, 400);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // STID
            // 
            this.STID.DataPropertyName = "ID";
            this.STID.HeaderText = "ID";
            this.STID.Name = "STID";
            this.STID.ReadOnly = true;
            this.STID.Visible = false;
            // 
            // STCode
            // 
            this.STCode.DataPropertyName = "STCode";
            this.STCode.HeaderText = "كود الطالب";
            this.STCode.Name = "STCode";
            this.STCode.ReadOnly = true;
            // 
            // STName
            // 
            this.STName.DataPropertyName = "Name";
            this.STName.FillWeight = 98.01569F;
            this.STName.HeaderText = "اسم الطالب";
            this.STName.Name = "STName";
            this.STName.ReadOnly = true;
            // 
            // ST_Phone
            // 
            this.ST_Phone.DataPropertyName = "ST_Phone";
            this.ST_Phone.FillWeight = 98.01569F;
            this.ST_Phone.HeaderText = "رقم التليفون";
            this.ST_Phone.Name = "ST_Phone";
            this.ST_Phone.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.FillWeight = 98.01569F;
            this.Address.HeaderText = "العنوان";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // Parent_Number
            // 
            this.Parent_Number.DataPropertyName = "Parent_Number";
            this.Parent_Number.FillWeight = 98.01569F;
            this.Parent_Number.HeaderText = "رقم ولى الامر";
            this.Parent_Number.Name = "Parent_Number";
            this.Parent_Number.ReadOnly = true;
            // 
            // Is_for_Contact
            // 
            this.Is_for_Contact.DataPropertyName = "Is_for_Contact";
            this.Is_for_Contact.FillWeight = 98.01569F;
            this.Is_for_Contact.HeaderText = "للتواصل ام لا";
            this.Is_for_Contact.Name = "Is_for_Contact";
            this.Is_for_Contact.ReadOnly = true;
            // 
            // IsMale
            // 
            this.IsMale.DataPropertyName = "IsMale";
            this.IsMale.FillWeight = 98.01569F;
            this.IsMale.HeaderText = "النوع";
            this.IsMale.Name = "IsMale";
            this.IsMale.ReadOnly = true;
            // 
            // ClassID
            // 
            this.ClassID.DataPropertyName = "ClassID";
            this.ClassID.FillWeight = 98.01569F;
            this.ClassID.HeaderText = "الصف";
            this.ClassID.Name = "ClassID";
            this.ClassID.ReadOnly = true;
            // 
            // Study_Level
            // 
            this.Study_Level.DataPropertyName = "Study_Level";
            this.Study_Level.FillWeight = 98.01569F;
            this.Study_Level.HeaderText = "القسم";
            this.Study_Level.Name = "Study_Level";
            this.Study_Level.ReadOnly = true;
            // 
            // School
            // 
            this.School.DataPropertyName = "School";
            this.School.FillWeight = 98.01569F;
            this.School.HeaderText = "المدرسه";
            this.School.Name = "School";
            this.School.ReadOnly = true;
            // 
            // Discount
            // 
            this.Discount.DataPropertyName = "Discount";
            this.Discount.FillWeight = 98.01569F;
            this.Discount.HeaderText = "الخصم";
            this.Discount.Name = "Discount";
            this.Discount.ReadOnly = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(886, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 31);
            this.label8.TabIndex = 30;
            this.label8.Text = "الشعبه :";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(1016, 31);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(242, 38);
            this.txtName.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1318, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 31);
            this.label1.TabIndex = 21;
            this.label1.Text = "الاسم :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(886, 93);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 31);
            this.label9.TabIndex = 39;
            this.label9.Text = "خصم للطالب :";
            // 
            // txtParentNumber
            // 
            this.txtParentNumber.Location = new System.Drawing.Point(1016, 90);
            this.txtParentNumber.Name = "txtParentNumber";
            this.txtParentNumber.ReadOnly = true;
            this.txtParentNumber.Size = new System.Drawing.Size(242, 38);
            this.txtParentNumber.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1264, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 31);
            this.label5.TabIndex = 32;
            this.label5.Text = "رقم ولى الامر :";
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(562, 31);
            this.txtType.Name = "txtType";
            this.txtType.ReadOnly = true;
            this.txtType.Size = new System.Drawing.Size(318, 38);
            this.txtType.TabIndex = 41;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(238, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 45);
            this.button1.TabIndex = 42;
            this.button1.Text = "تعديل";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Crimson;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(136, 63);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 45);
            this.button2.TabIndex = 43;
            this.button2.Text = "حذف";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DodgerBlue;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(371, 63);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(171, 45);
            this.button3.TabIndex = 44;
            this.button3.Text = "اضافة طالب جديد";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Crimson;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(3, 63);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(127, 45);
            this.button4.TabIndex = 45;
            this.button4.Text = "حذف الكل";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Image = global::CenterManager.Properties.Resources.icons8_search_40;
            this.button6.Location = new System.Drawing.Point(1332, 37);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(52, 48);
            this.button6.TabIndex = 0;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(924, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(402, 38);
            this.textBox1.TabIndex = 47;
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(562, 90);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.ReadOnly = true;
            this.txtDiscount.Size = new System.Drawing.Size(318, 38);
            this.txtDiscount.TabIndex = 47;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Location = new System.Drawing.Point(6, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(550, 118);
            this.panel1.TabIndex = 48;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Olive;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(371, 10);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(171, 38);
            this.button5.TabIndex = 46;
            this.button5.Text = "تحديث البيانات";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button7
            // 
            this.button7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button7.BackColor = System.Drawing.Color.DodgerBlue;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(747, 40);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(171, 45);
            this.button7.TabIndex = 47;
            this.button7.Text = "تحديد";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Visible = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Frm_ViewStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1414, 693);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(13, 17, 13, 17);
            this.Name = "Frm_ViewStudents";
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtParentNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn STID;
        private System.Windows.Forms.DataGridViewTextBoxColumn STCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn STName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ST_Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Parent_Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Is_for_Contact;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsMale;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Study_Level;
        private System.Windows.Forms.DataGridViewTextBoxColumn School;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button7;
    }
}