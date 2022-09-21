namespace CenterManager.View
{
    partial class Frm_AddGroup
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.StartYear = new System.Windows.Forms.DateTimePicker();
            this.EndYear = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbClass = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.StartTime = new System.Windows.Forms.DateTimePicker();
            this.EndTime = new System.Windows.Forms.DateTimePicker();
            this.Days = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.label7 = new System.Windows.Forms.Label();
            this.numPrice = new System.Windows.Forms.NumericUpDown();
            this.chkIsActive = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.cmbSubject = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Days)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Location = new System.Drawing.Point(353, 477);
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbSubject);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtNote);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.chkIsActive);
            this.groupBox1.Controls.Add(this.numPrice);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.Days);
            this.groupBox1.Controls.Add(this.EndTime);
            this.groupBox1.Controls.Add(this.StartTime);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmbClass);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.EndYear);
            this.groupBox1.Controls.Add(this.StartYear);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Size = new System.Drawing.Size(858, 451);
            this.groupBox1.Text = "المجموعه";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(712, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "اسم المجموعه :";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(436, 31);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(245, 38);
            this.txtName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(689, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "بداية العام الدراسي :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(687, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 31);
            this.label3.TabIndex = 4;
            this.label3.Text = "نهاية العام الدرسى :";
            // 
            // StartYear
            // 
            this.StartYear.CustomFormat = "d/MM/yyyy";
            this.StartYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.StartYear.Location = new System.Drawing.Point(436, 162);
            this.StartYear.Name = "StartYear";
            this.StartYear.Size = new System.Drawing.Size(245, 38);
            this.StartYear.TabIndex = 5;
            // 
            // EndYear
            // 
            this.EndYear.CustomFormat = "d/MM/yyyy";
            this.EndYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.EndYear.Location = new System.Drawing.Point(436, 222);
            this.EndYear.Name = "EndYear";
            this.EndYear.Size = new System.Drawing.Size(245, 38);
            this.EndYear.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(300, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 31);
            this.label4.TabIndex = 7;
            this.label4.Text = "الصف :";
            // 
            // cmbClass
            // 
            this.cmbClass.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmbClass.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbClass.FormattingEnabled = true;
            this.cmbClass.Location = new System.Drawing.Point(29, 31);
            this.cmbClass.Name = "cmbClass";
            this.cmbClass.Size = new System.Drawing.Size(265, 39);
            this.cmbClass.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(320, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 31);
            this.label5.TabIndex = 9;
            this.label5.Text = "من :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(315, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 31);
            this.label6.TabIndex = 10;
            this.label6.Text = "الى :";
            // 
            // StartTime
            // 
            this.StartTime.CustomFormat = "hh:mm";
            this.StartTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.StartTime.Location = new System.Drawing.Point(29, 96);
            this.StartTime.Name = "StartTime";
            this.StartTime.ShowUpDown = true;
            this.StartTime.Size = new System.Drawing.Size(265, 38);
            this.StartTime.TabIndex = 11;
            // 
            // EndTime
            // 
            this.EndTime.CustomFormat = "";
            this.EndTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.EndTime.Location = new System.Drawing.Point(29, 162);
            this.EndTime.Name = "EndTime";
            this.EndTime.ShowUpDown = true;
            this.EndTime.Size = new System.Drawing.Size(265, 38);
            this.EndTime.TabIndex = 12;
            // 
            // Days
            // 
            this.Days.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Days.Appearance.Options.UseFont = true;
            this.Days.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.Days.CheckOnClick = true;
            this.Days.Items.AddRange(new DevExpress.XtraEditors.Controls.CheckedListBoxItem[] {
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("السبت"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("الاحد"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("الاثنين"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("الثلاثاء"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("الاربع"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("الخميس"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("الجمعه")});
            this.Days.Location = new System.Drawing.Point(422, 349);
            this.Days.MultiColumn = true;
            this.Days.Name = "Days";
            this.Days.Size = new System.Drawing.Size(348, 83);
            this.Days.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(712, 298);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 31);
            this.label7.TabIndex = 14;
            this.label7.Text = "سعر المجموعه :";
            // 
            // numPrice
            // 
            this.numPrice.DecimalPlaces = 2;
            this.numPrice.Location = new System.Drawing.Point(436, 296);
            this.numPrice.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numPrice.Name = "numPrice";
            this.numPrice.Size = new System.Drawing.Size(245, 38);
            this.numPrice.TabIndex = 15;
            this.numPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // chkIsActive
            // 
            this.chkIsActive.AutoSize = true;
            this.chkIsActive.Checked = true;
            this.chkIsActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIsActive.Location = new System.Drawing.Point(223, 227);
            this.chkIsActive.Name = "chkIsActive";
            this.chkIsActive.Size = new System.Drawing.Size(136, 35);
            this.chkIsActive.TabIndex = 16;
            this.chkIsActive.Text = "مجموعه نشطه";
            this.chkIsActive.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(776, 357);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 31);
            this.label8.TabIndex = 17;
            this.label8.Text = "الايام :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(288, 298);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 31);
            this.label9.TabIndex = 18;
            this.label9.Text = "ملاحظه :";
            // 
            // txtNote
            // 
            this.txtNote.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNote.Location = new System.Drawing.Point(29, 298);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(253, 134);
            this.txtNote.TabIndex = 19;
            // 
            // cmbSubject
            // 
            this.cmbSubject.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmbSubject.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbSubject.FormattingEnabled = true;
            this.cmbSubject.Location = new System.Drawing.Point(436, 99);
            this.cmbSubject.Name = "cmbSubject";
            this.cmbSubject.Size = new System.Drawing.Size(245, 39);
            this.cmbSubject.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(763, 102);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 31);
            this.label10.TabIndex = 20;
            this.label10.Text = "الماده :";
            // 
            // Frm_AddGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 548);
            this.Name = "Frm_AddGroup";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Days)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker EndTime;
        private System.Windows.Forms.DateTimePicker StartTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbClass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker EndYear;
        private System.Windows.Forms.DateTimePicker StartYear;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox chkIsActive;
        private System.Windows.Forms.NumericUpDown numPrice;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.CheckedListBoxControl Days;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbSubject;
        private System.Windows.Forms.Label label10;
    }
}