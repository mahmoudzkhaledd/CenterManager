namespace CenterManager.View
{
    partial class Frm_AddExam
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
            this.cmbGroups = new System.Windows.Forms.ComboBox();
            this.ExamDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSubjectName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.QNumber = new System.Windows.Forms.NumericUpDown();
            this.FinalMark = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFromHour = new System.Windows.Forms.TextBox();
            this.txtToHour = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FinalMark)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Location = new System.Drawing.Point(409, 358);
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.txtToHour);
            this.groupBox1.Controls.Add(this.txtFromHour);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.FinalMark);
            this.groupBox1.Controls.Add(this.QNumber);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtSubjectName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.ExamDate);
            this.groupBox1.Controls.Add(this.cmbGroups);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Size = new System.Drawing.Size(976, 340);
            this.groupBox1.Text = "الامتحان";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(854, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "المجموعه :";
            // 
            // cmbGroups
            // 
            this.cmbGroups.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbGroups.FormattingEnabled = true;
            this.cmbGroups.Location = new System.Drawing.Point(513, 124);
            this.cmbGroups.Name = "cmbGroups";
            this.cmbGroups.Size = new System.Drawing.Size(335, 39);
            this.cmbGroups.TabIndex = 2;
            this.cmbGroups.SelectedIndexChanged += new System.EventHandler(this.cmbGroups_SelectedIndexChanged);
            // 
            // ExamDate
            // 
            this.ExamDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExamDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ExamDate.Location = new System.Drawing.Point(33, 196);
            this.ExamDate.Name = "ExamDate";
            this.ExamDate.Size = new System.Drawing.Size(312, 38);
            this.ExamDate.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(351, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 31);
            this.label3.TabIndex = 6;
            this.label3.Text = "تاريخ الامتحان :";
            // 
            // txtSubjectName
            // 
            this.txtSubjectName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSubjectName.Location = new System.Drawing.Point(513, 201);
            this.txtSubjectName.Name = "txtSubjectName";
            this.txtSubjectName.ReadOnly = true;
            this.txtSubjectName.Size = new System.Drawing.Size(335, 38);
            this.txtSubjectName.TabIndex = 7;
            this.txtSubjectName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(854, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 31);
            this.label4.TabIndex = 8;
            this.label4.Text = "الماده :";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(351, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 31);
            this.label5.TabIndex = 10;
            this.label5.Text = "عدد الاسئله :";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(33, 47);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 39);
            this.button2.TabIndex = 11;
            this.button2.Text = "اضافة اسئله";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(351, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 31);
            this.label6.TabIndex = 13;
            this.label6.Text = "الدرجه النهائيه :";
            // 
            // QNumber
            // 
            this.QNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.QNumber.Location = new System.Drawing.Point(160, 49);
            this.QNumber.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.QNumber.Name = "QNumber";
            this.QNumber.Size = new System.Drawing.Size(185, 38);
            this.QNumber.TabIndex = 14;
            this.QNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FinalMark
            // 
            this.FinalMark.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FinalMark.DecimalPlaces = 2;
            this.FinalMark.Location = new System.Drawing.Point(33, 125);
            this.FinalMark.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.FinalMark.Name = "FinalMark";
            this.FinalMark.Size = new System.Drawing.Size(312, 38);
            this.FinalMark.TabIndex = 15;
            this.FinalMark.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(854, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 31);
            this.label2.TabIndex = 17;
            this.label2.Text = "من الساعه :";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(351, 268);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 31);
            this.label7.TabIndex = 19;
            this.label7.Text = "الى الساعه :";
            // 
            // txtFromHour
            // 
            this.txtFromHour.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFromHour.Location = new System.Drawing.Point(513, 275);
            this.txtFromHour.Name = "txtFromHour";
            this.txtFromHour.ReadOnly = true;
            this.txtFromHour.Size = new System.Drawing.Size(335, 38);
            this.txtFromHour.TabIndex = 20;
            this.txtFromHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtToHour
            // 
            this.txtToHour.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtToHour.Location = new System.Drawing.Point(33, 265);
            this.txtToHour.Name = "txtToHour";
            this.txtToHour.ReadOnly = true;
            this.txtToHour.Size = new System.Drawing.Size(312, 38);
            this.txtToHour.TabIndex = 21;
            this.txtToHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(854, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 31);
            this.label8.TabIndex = 23;
            this.label8.Text = "اسم الامتحان :";
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Location = new System.Drawing.Point(513, 48);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(335, 38);
            this.txtName.TabIndex = 22;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Frm_AddExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 429);
            this.Name = "Frm_AddExam";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_AddExam_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FinalMark)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbGroups;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown FinalMark;
        private System.Windows.Forms.NumericUpDown QNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSubjectName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker ExamDate;
        private System.Windows.Forms.TextBox txtToHour;
        private System.Windows.Forms.TextBox txtFromHour;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtName;
    }
}