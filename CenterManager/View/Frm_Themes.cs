using CenterManager.Control.DBControl;
using CenterManager.Control.Methods;
using CenterManager.Models.View_Models;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CenterManager.View
{
    public partial class Frm_Themes : Frm_Master
    {
        Button SelectedButton;
        string SelectedColor = "";
        string TitleColor = "";
        public Frm_Themes(Color c)
        {
            InitializeComponent();
            ArrangeButtons(Properties.Settings.Default.Indexes);
            BackgroundPanel.BackColor = c;
            CenterManagerEntities db = Methods.db;
            lblProgramName.Text = db.Settings.SingleOrDefault(a => a.ID == 1).ProgramName;
            lblProgramName.Location = new Point((lblProgramName.Parent.Width - lblProgramName.Width) / 2
                , lblProgramName.Location.Y);
            string s = db.Settings.SingleOrDefault(a => a.ID == 1).TitleColor;
            if (s != null)
            {
                lblProgramName.ForeColor = System.Drawing.ColorTranslator.FromHtml(s);
            }
        }

        public Frm_Themes()
        {
        }

        void ArrangeButtons(StringCollection s)
        {
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
                    if (button != null)
                        flowLayoutPanel1.Controls.SetChildIndex(button, i);
                }
            }
        }
        private void btnSettings_Click(object sender, EventArgs e)
        {
            ChangeColor(sender as Button);
            SelectedButton = sender as Button;
        }

        private void ChangeColor(Button b)
        {
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

        private void button3_Click(object sender, EventArgs e)
        {
            if (SelectedButton != null)
            {
                int cIndex = flowLayoutPanel1.Controls.GetChildIndex(SelectedButton);
                if (cIndex > 0)
                    flowLayoutPanel1.Controls.SetChildIndex(SelectedButton, cIndex - 1);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (SelectedButton != null)
            {
                int index = flowLayoutPanel1.Controls.GetChildIndex(SelectedButton);
                if (index < flowLayoutPanel1.Controls.Count)
                    flowLayoutPanel1.Controls.SetChildIndex(SelectedButton, index + 1);
            }
        }
        void SaveArrange()
        {
            Properties.Settings.Default.Indexes = new StringCollection();
            StringCollection s = Properties.Settings.Default.Indexes;
            if (s != null) s.Clear();
            for (int i = 0; i < flowLayoutPanel1.Controls.Count; i++) {
                s.Add((flowLayoutPanel1.Controls[i] as Button).Text);
            }
            Properties.Settings.Default.Save();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            SaveArrange();
            SaveColor();
            MessageBox.Show("تم الحفظ");
        }

        private void SaveColor()
        {
            CenterManagerEntities db = Methods.db;
            Setting setting = db.Settings.SingleOrDefault(a => a.ID == 1);
            if (SelectedColor != "")
                setting.BackColor = SelectedColor;
            else
                setting.BackColor = System.Drawing.ColorTranslator.ToHtml(BackgroundPanel.BackColor);
            if (TitleColor != "")
                setting.TitleColor = TitleColor;
            else
                setting.TitleColor = System.Drawing.ColorTranslator.ToHtml(lblProgramName.ForeColor);
            Methods.TitleColor = setting.TitleColor;
            Methods.BackColor = setting.BackColor;
            db.SaveChanges();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (ColorDialog d = new ColorDialog())
            {
                if (d.ShowDialog() == DialogResult.OK) {
                    SelectedColor = System.Drawing.ColorTranslator.ToHtml(d.Color);
                    BackgroundPanel.BackColor = d.Color;
                }
            }
        }
        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (ColorDialog d = new ColorDialog())
            {
                if (d.ShowDialog() == DialogResult.OK)
                {
                    TitleColor = System.Drawing.ColorTranslator.ToHtml(d.Color);
                    lblProgramName.ForeColor = d.Color;
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            StringCollection c = new StringCollection() { 
                "الرئيسيه",
                "الطلاب",
                "المجاميع",
                "الحضور",
                "المذكرات",
                "الامتحانات",
                "المصروفات",
                "الايرادات",
                "المستخدمين",
                "اعدادات"};
            BackgroundPanel.BackColor = Color.White;
            lblProgramName.ForeColor = Color.Gray;
            SelectedColor = System.Drawing.ColorTranslator.ToHtml(Color.White);
            TitleColor = System.Drawing.ColorTranslator.ToHtml(Color.Gray);
            ArrangeButtons(c);
        }
    }
}
