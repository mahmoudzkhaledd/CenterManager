namespace CenterManager.View
{
    partial class Frm_StudentBooks
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
            this.cmbBook = new System.Windows.Forms.ComboBox();
            this.txtStCode = new System.Windows.Forms.TextBox();
            this.BooksNumber = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numPaid = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtRemainder = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.button2 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtStName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtRemindBooks = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtClass = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtTotalBefore = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.numDiscount = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.txtTotalAfter = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.rdioDiscountBook = new System.Windows.Forms.RadioButton();
            this.rdioDiscountAll = new System.Windows.Forms.RadioButton();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BooksNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPaid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDiscount)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "المذكره : ";
            // 
            // cmbBook
            // 
            this.cmbBook.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmbBook.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbBook.FormattingEnabled = true;
            this.cmbBook.Location = new System.Drawing.Point(139, 25);
            this.cmbBook.Name = "cmbBook";
            this.cmbBook.Size = new System.Drawing.Size(375, 39);
            this.cmbBook.TabIndex = 1;
            this.cmbBook.SelectedIndexChanged += new System.EventHandler(this.cmbBook_SelectedIndexChanged);
            // 
            // txtStCode
            // 
            this.txtStCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtStCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtStCode.Location = new System.Drawing.Point(140, 91);
            this.txtStCode.Name = "txtStCode";
            this.txtStCode.Size = new System.Drawing.Size(227, 38);
            this.txtStCode.TabIndex = 2;
            this.txtStCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtStCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtStCode_KeyDown);
            this.txtStCode.Leave += new System.EventHandler(this.txtStCode_Leave);
            // 
            // BooksNumber
            // 
            this.BooksNumber.Location = new System.Drawing.Point(402, 163);
            this.BooksNumber.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.BooksNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.BooksNumber.Name = "BooksNumber";
            this.BooksNumber.Size = new System.Drawing.Size(113, 38);
            this.BooksNumber.TabIndex = 3;
            this.BooksNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BooksNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.BooksNumber.ValueChanged += new System.EventHandler(this.BooksNumber_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "كود الطالب :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(275, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 31);
            this.label3.TabIndex = 5;
            this.label3.Text = "عدد المذكرات : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 411);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 31);
            this.label4.TabIndex = 7;
            this.label4.Text = "المدفوع :";
            // 
            // numPaid
            // 
            this.numPaid.DecimalPlaces = 2;
            this.numPaid.Location = new System.Drawing.Point(139, 409);
            this.numPaid.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numPaid.Name = "numPaid";
            this.numPaid.Size = new System.Drawing.Size(375, 38);
            this.numPaid.TabIndex = 8;
            this.numPaid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numPaid.ValueChanged += new System.EventHandler(this.numPaid_ValueChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Droid Arabic Kufi", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(174, 531);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(262, 110);
            this.button1.TabIndex = 10;
            this.button1.Text = "دفع";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(58, 477);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 31);
            this.label9.TabIndex = 14;
            this.label9.Text = "الباقى :";
            // 
            // txtRemainder
            // 
            this.txtRemainder.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtRemainder.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtRemainder.Location = new System.Drawing.Point(140, 474);
            this.txtRemainder.Name = "txtRemainder";
            this.txtRemainder.ReadOnly = true;
            this.txtRemainder.Size = new System.Drawing.Size(375, 38);
            this.txtRemainder.TabIndex = 13;
            this.txtRemainder.Text = "0.00";
            this.txtRemainder.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Location = new System.Drawing.Point(579, 12);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.button4);
            this.splitContainer1.Panel1.Controls.Add(this.button2);
            this.splitContainer1.Panel1.Controls.Add(this.label11);
            this.splitContainer1.Panel1.Controls.Add(this.txtDiscount);
            this.splitContainer1.Panel1.Controls.Add(this.label10);
            this.splitContainer1.Panel1.Controls.Add(this.txtStName);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label12);
            this.splitContainer1.Panel2.Controls.Add(this.txtRemindBooks);
            this.splitContainer1.Panel2.Controls.Add(this.label8);
            this.splitContainer1.Panel2.Controls.Add(this.txtNote);
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Panel2.Controls.Add(this.txtSubject);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.txtClass);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.txtBookName);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer1.Size = new System.Drawing.Size(536, 629);
            this.splitContainer1.SplitterDistance = 233;
            this.splitContainer1.TabIndex = 21;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(121, 25);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(191, 45);
            this.button2.TabIndex = 33;
            this.button2.Text = "بحث عن الطالب";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(405, 138);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 31);
            this.label11.TabIndex = 32;
            this.label11.Text = "الخصم :";
            // 
            // txtDiscount
            // 
            this.txtDiscount.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtDiscount.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtDiscount.Location = new System.Drawing.Point(31, 135);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.ReadOnly = true;
            this.txtDiscount.Size = new System.Drawing.Size(357, 38);
            this.txtDiscount.TabIndex = 31;
            this.txtDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(405, 79);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 31);
            this.label10.TabIndex = 30;
            this.label10.Text = "اسم الطالب :";
            // 
            // txtStName
            // 
            this.txtStName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtStName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtStName.Location = new System.Drawing.Point(31, 76);
            this.txtStName.Name = "txtStName";
            this.txtStName.ReadOnly = true;
            this.txtStName.Size = new System.Drawing.Size(357, 38);
            this.txtStName.TabIndex = 29;
            this.txtStName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(405, 91);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(123, 31);
            this.label12.TabIndex = 30;
            this.label12.Text = "العدد المتبقى :";
            // 
            // txtRemindBooks
            // 
            this.txtRemindBooks.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtRemindBooks.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtRemindBooks.Location = new System.Drawing.Point(31, 88);
            this.txtRemindBooks.Name = "txtRemindBooks";
            this.txtRemindBooks.ReadOnly = true;
            this.txtRemindBooks.Size = new System.Drawing.Size(357, 38);
            this.txtRemindBooks.TabIndex = 29;
            this.txtRemindBooks.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(405, 286);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 31);
            this.label8.TabIndex = 28;
            this.label8.Text = "ملاحظه :";
            // 
            // txtNote
            // 
            this.txtNote.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtNote.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtNote.Location = new System.Drawing.Point(31, 283);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.ReadOnly = true;
            this.txtNote.Size = new System.Drawing.Size(357, 87);
            this.txtNote.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(405, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 31);
            this.label7.TabIndex = 26;
            this.label7.Text = "الماده :";
            // 
            // txtSubject
            // 
            this.txtSubject.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtSubject.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtSubject.Location = new System.Drawing.Point(31, 225);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.ReadOnly = true;
            this.txtSubject.Size = new System.Drawing.Size(357, 38);
            this.txtSubject.TabIndex = 25;
            this.txtSubject.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(405, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 31);
            this.label6.TabIndex = 24;
            this.label6.Text = "الصف :";
            // 
            // txtClass
            // 
            this.txtClass.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtClass.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtClass.Location = new System.Drawing.Point(31, 157);
            this.txtClass.Name = "txtClass";
            this.txtClass.ReadOnly = true;
            this.txtClass.Size = new System.Drawing.Size(357, 38);
            this.txtClass.TabIndex = 23;
            this.txtClass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(405, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 31);
            this.label5.TabIndex = 22;
            this.label5.Text = "اسم المذكره :";
            // 
            // txtBookName
            // 
            this.txtBookName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtBookName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtBookName.Location = new System.Drawing.Point(31, 17);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.ReadOnly = true;
            this.txtBookName.Size = new System.Drawing.Size(357, 38);
            this.txtBookName.TabIndex = 21;
            this.txtBookName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 166);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(114, 31);
            this.label13.TabIndex = 35;
            this.label13.Text = "سعر المذكره :";
            // 
            // txtPrice
            // 
            this.txtPrice.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtPrice.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtPrice.Location = new System.Drawing.Point(140, 163);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(129, 38);
            this.txtPrice.TabIndex = 34;
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(5, 295);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(163, 31);
            this.label14.TabIndex = 36;
            this.label14.Text = "الاجمالى قبل الخصم :";
            // 
            // txtTotalBefore
            // 
            this.txtTotalBefore.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtTotalBefore.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtTotalBefore.Location = new System.Drawing.Point(174, 292);
            this.txtTotalBefore.Name = "txtTotalBefore";
            this.txtTotalBefore.ReadOnly = true;
            this.txtTotalBefore.Size = new System.Drawing.Size(341, 38);
            this.txtTotalBefore.TabIndex = 37;
            this.txtTotalBefore.Text = "0.00";
            this.txtTotalBefore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(373, 87);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(142, 45);
            this.button3.TabIndex = 34;
            this.button3.Text = "التحقق";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // numDiscount
            // 
            this.numDiscount.DecimalPlaces = 2;
            this.numDiscount.Location = new System.Drawing.Point(140, 230);
            this.numDiscount.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numDiscount.Name = "numDiscount";
            this.numDiscount.Size = new System.Drawing.Size(179, 38);
            this.numDiscount.TabIndex = 39;
            this.numDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numDiscount.ValueChanged += new System.EventHandler(this.numDiscount_ValueChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(53, 232);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(68, 31);
            this.label15.TabIndex = 38;
            this.label15.Text = "الخصم :";
            // 
            // txtTotalAfter
            // 
            this.txtTotalAfter.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtTotalAfter.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtTotalAfter.Location = new System.Drawing.Point(174, 351);
            this.txtTotalAfter.Name = "txtTotalAfter";
            this.txtTotalAfter.ReadOnly = true;
            this.txtTotalAfter.Size = new System.Drawing.Size(341, 38);
            this.txtTotalAfter.TabIndex = 41;
            this.txtTotalAfter.Text = "0.00";
            this.txtTotalAfter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(5, 354);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(162, 31);
            this.label16.TabIndex = 40;
            this.label16.Text = "الاجمالى بعد الخصم :";
            // 
            // rdioDiscountBook
            // 
            this.rdioDiscountBook.AutoSize = true;
            this.rdioDiscountBook.Location = new System.Drawing.Point(325, 230);
            this.rdioDiscountBook.Name = "rdioDiscountBook";
            this.rdioDiscountBook.Size = new System.Drawing.Size(86, 35);
            this.rdioDiscountBook.TabIndex = 42;
            this.rdioDiscountBook.Text = "للمذكره";
            this.rdioDiscountBook.UseVisualStyleBackColor = true;
            this.rdioDiscountBook.CheckedChanged += new System.EventHandler(this.rdioDiscountBook_CheckedChanged);
            // 
            // rdioDiscountAll
            // 
            this.rdioDiscountAll.AutoSize = true;
            this.rdioDiscountAll.Checked = true;
            this.rdioDiscountAll.Location = new System.Drawing.Point(417, 230);
            this.rdioDiscountAll.Name = "rdioDiscountAll";
            this.rdioDiscountAll.Size = new System.Drawing.Size(99, 35);
            this.rdioDiscountAll.TabIndex = 43;
            this.rdioDiscountAll.TabStop = true;
            this.rdioDiscountAll.Text = "خصم كلى";
            this.rdioDiscountAll.UseVisualStyleBackColor = true;
            this.rdioDiscountAll.CheckedChanged += new System.EventHandler(this.rdioDiscountAll_CheckedChanged);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(31, 179);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(357, 45);
            this.button4.TabIndex = 34;
            this.button4.Text = "المذكرات التى اخذها الطالب";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Frm_StudentBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1123, 653);
            this.Controls.Add(this.rdioDiscountAll);
            this.Controls.Add(this.rdioDiscountBook);
            this.Controls.Add(this.txtTotalAfter);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.numDiscount);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtTotalBefore);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtRemainder);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numPaid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BooksNumber);
            this.Controls.Add(this.txtStCode);
            this.Controls.Add(this.cmbBook);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Droid Arabic Kufi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_StudentBooks";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.BooksNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPaid)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numDiscount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbBook;
        private System.Windows.Forms.TextBox txtStCode;
        private System.Windows.Forms.NumericUpDown BooksNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numPaid;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtRemainder;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtStName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtClass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtRemindBooks;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtTotalBefore;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.NumericUpDown numDiscount;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtTotalAfter;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.RadioButton rdioDiscountBook;
        private System.Windows.Forms.RadioButton rdioDiscountAll;
        private System.Windows.Forms.Button button4;
    }
}