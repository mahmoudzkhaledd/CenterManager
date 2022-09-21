namespace CenterManager.View
{
    partial class Frm_AddUser
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("الرئيسيه");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("اضافة طالب");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("المواد");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("تعديل الصفوف");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("تصفح الطلاب");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("الطلاب", new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("اضافة مجموعه");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("تسجيل الطلاب فى المجموعات");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("عرض كل المجموعات");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("المجاميع", new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8,
            treeNode9});
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("اخذ الحضور");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("عرض سجل الحضور");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("الحضور", new System.Windows.Forms.TreeNode[] {
            treeNode11,
            treeNode12});
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("اضافة مذكره");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("عرض المذكرات");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("مذكره للطالب");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("المذكرات", new System.Windows.Forms.TreeNode[] {
            treeNode14,
            treeNode15,
            treeNode16});
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("اضافة امتحان");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("عرض الامتحانات");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("تصحيح امتحان");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("الامتحانات", new System.Windows.Forms.TreeNode[] {
            treeNode18,
            treeNode19,
            treeNode20});
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("المصروفات");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("الايرادات");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("اضافة مستخدم");
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("تعديل المستخدمين");
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("المستخدمين", new System.Windows.Forms.TreeNode[] {
            treeNode24,
            treeNode25});
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("الاعدادات");
            this.label1 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCardNumber = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Location = new System.Drawing.Point(400, 681);
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.treeView1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtCardNumber);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtUserName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtLastName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtFirstName);
            this.groupBox1.Size = new System.Drawing.Size(972, 663);
            this.groupBox1.Text = "";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(830, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "الاسم الاول :";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFirstName.Location = new System.Drawing.Point(505, 37);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(319, 38);
            this.txtFirstName.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(333, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 31);
            this.label2.TabIndex = 6;
            this.label2.Text = "الاسم الاخير :";
            // 
            // txtLastName
            // 
            this.txtLastName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLastName.Location = new System.Drawing.Point(28, 37);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(299, 38);
            this.txtLastName.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(830, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 31);
            this.label3.TabIndex = 8;
            this.label3.Text = "اسم المستخدم :";
            // 
            // txtUserName
            // 
            this.txtUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUserName.Location = new System.Drawing.Point(505, 206);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(319, 38);
            this.txtUserName.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(333, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 31);
            this.label4.TabIndex = 10;
            this.label4.Text = "كلمة المرور :";
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.Location = new System.Drawing.Point(28, 206);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(299, 38);
            this.txtPassword.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(830, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 31);
            this.label5.TabIndex = 12;
            this.label5.Text = "العنوان :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAddress
            // 
            this.txtAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddress.Location = new System.Drawing.Point(505, 121);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(319, 38);
            this.txtAddress.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(333, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 31);
            this.label6.TabIndex = 14;
            this.label6.Text = "رقم البطاقه :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCardNumber
            // 
            this.txtCardNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCardNumber.Location = new System.Drawing.Point(28, 121);
            this.txtCardNumber.Name = "txtCardNumber";
            this.txtCardNumber.Size = new System.Drawing.Size(299, 38);
            this.txtCardNumber.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(830, 291);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 31);
            this.label7.TabIndex = 16;
            this.label7.Text = "الصلاحيات :";
            // 
            // treeView1
            // 
            this.treeView1.CheckBoxes = true;
            this.treeView1.HideSelection = false;
            this.treeView1.Location = new System.Drawing.Point(505, 291);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "MainPage";
            treeNode1.Text = "الرئيسيه";
            treeNode2.Name = "AddStudent";
            treeNode2.Text = "اضافة طالب";
            treeNode3.Name = "Subjects";
            treeNode3.Text = "المواد";
            treeNode4.Name = "EditClasses";
            treeNode4.Text = "تعديل الصفوف";
            treeNode5.Name = "ShowStudents";
            treeNode5.Text = "تصفح الطلاب";
            treeNode6.Name = "Students";
            treeNode6.Text = "الطلاب";
            treeNode7.Name = "AddGroup";
            treeNode7.Text = "اضافة مجموعه";
            treeNode8.Name = "StudentGroups";
            treeNode8.Text = "تسجيل الطلاب فى المجموعات";
            treeNode9.Name = "ViewAllGroups";
            treeNode9.Text = "عرض كل المجموعات";
            treeNode10.Name = "Groups";
            treeNode10.Text = "المجاميع";
            treeNode11.Name = "TakeAttendance";
            treeNode11.Text = "اخذ الحضور";
            treeNode12.Name = "ViewAttendance";
            treeNode12.Text = "عرض سجل الحضور";
            treeNode13.Name = "Attendance";
            treeNode13.Text = "الحضور";
            treeNode14.Name = "AddBook";
            treeNode14.Text = "اضافة مذكره";
            treeNode15.Name = "ViewBooks";
            treeNode15.Text = "عرض المذكرات";
            treeNode16.Name = "StudentBooks";
            treeNode16.Text = "مذكره للطالب";
            treeNode17.Name = "Books";
            treeNode17.Text = "المذكرات";
            treeNode18.Name = "AddExam";
            treeNode18.Text = "اضافة امتحان";
            treeNode19.Name = "ViewExams";
            treeNode19.Text = "عرض الامتحانات";
            treeNode20.Name = "CorrentExams";
            treeNode20.Text = "تصحيح امتحان";
            treeNode21.Name = "Exams";
            treeNode21.Text = "الامتحانات";
            treeNode22.Name = "Node7";
            treeNode22.Text = "المصروفات";
            treeNode23.Name = "Node8";
            treeNode23.Text = "الايرادات";
            treeNode24.Name = "AddUser";
            treeNode24.Text = "اضافة مستخدم";
            treeNode25.Name = "EditUsers";
            treeNode25.Text = "تعديل المستخدمين";
            treeNode26.Name = "Users";
            treeNode26.Text = "المستخدمين";
            treeNode27.Name = "Node10";
            treeNode27.Text = "الاعدادات";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode6,
            treeNode10,
            treeNode13,
            treeNode17,
            treeNode21,
            treeNode22,
            treeNode23,
            treeNode26,
            treeNode27});
            this.treeView1.RightToLeftLayout = true;
            this.treeView1.ShowNodeToolTips = true;
            this.treeView1.Size = new System.Drawing.Size(319, 351);
            this.treeView1.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(333, 291);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 31);
            this.label8.TabIndex = 18;
            this.label8.Text = "الصوره الشخصيه :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(28, 291);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(299, 302);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(111, 599);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(164, 43);
            this.button2.TabIndex = 20;
            this.button2.Text = "حذف";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Frm_AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 756);
            this.Name = "Frm_AddUser";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCardNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button2;
    }
}