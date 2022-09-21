namespace CenterManager.View
{
    partial class Frm_ProgramSettings
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
            this.txtProgramName = new System.Windows.Forms.TextBox();
            this.radioButtonList1 = new RadioButtonList();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Location = new System.Drawing.Point(313, 379);
            this.button1.Text = "حفظ";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.radioButtonList1);
            this.groupBox1.Controls.Add(this.txtProgramName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Size = new System.Drawing.Size(773, 349);
            this.groupBox1.Text = "الاعدادات";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(657, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "اسم البرنامج :";
            // 
            // txtProgramName
            // 
            this.txtProgramName.Location = new System.Drawing.Point(315, 40);
            this.txtProgramName.Name = "txtProgramName";
            this.txtProgramName.Size = new System.Drawing.Size(336, 38);
            this.txtProgramName.TabIndex = 1;
            this.txtProgramName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // radioButtonList1
            // 
            this.radioButtonList1.ColumnWidth = 150;
            this.radioButtonList1.FormattingEnabled = true;
            this.radioButtonList1.HorizontalExtent = 3;
            this.radioButtonList1.Items.AddRange(new object[] {
            "الرئيسيه",
            "الطلاب",
            "المجاميع",
            "الحضور",
            "المذكرات",
            "الامتحانات",
            "المصروفات",
            "الايرادات",
            "المستخدمين",
            "اعدادات"});
            this.radioButtonList1.Location = new System.Drawing.Point(435, 141);
            this.radioButtonList1.MultiColumn = true;
            this.radioButtonList1.Name = "radioButtonList1";
            this.radioButtonList1.Size = new System.Drawing.Size(326, 202);
            this.radioButtonList1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(668, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "صفحة البدء:";
            // 
            // Frm_ProgramSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "Frm_ProgramSettings";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtProgramName;
        private System.Windows.Forms.Label label1;
        private RadioButtonList radioButtonList1;
        private System.Windows.Forms.Label label2;
    }
}