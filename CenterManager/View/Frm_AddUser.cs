using CenterManager.Control.DBControl;
using CenterManager.Control.Methods;
using CenterManager.Models.View_Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CenterManager.View
{
    public partial class Frm_AddUser : Add_ModelForm
    {
        CenterManagerEntities db = Methods.db;
        Image SelectedImage = null;
        public Frm_AddUser() {
            InitializeComponent();
            treeView1.AfterCheck += new TreeViewEventHandler((s,e)=> treeView1_AfterCheck(s,e));
            pictureBox1.Image = null;
        }

        private void treeView1_AfterCheck(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Nodes.Count == 0 && e.Node.Parent != null) {
                int x = 0;
                foreach (TreeNode node in e.Node.Parent.Nodes)
                {
                    if (node != e.Node)
                    {
                        if (node.Checked) x++;
                    }
                }
                if (x == 0)
                {
                    e.Node.Parent.Checked = e.Node.Checked;
                }
                else
                {
                    e.Node.Parent.Checked = true;
                }
            }
        }
        public string GetMemberName<T>(Expression<Func<T>> memberExpression)
        {
            MemberExpression expressionBody = (MemberExpression)memberExpression.Body;
            return expressionBody.Member.Name;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < groupBox1.Controls.Count; i++)
                {
                    TextBox t = groupBox1.Controls[i] as TextBox;
                    if (t != null)
                    {
                        if (t.Text == "")
                        {
                            MessageBox.Show("من فضلك ادخل كل المعلومات");
                            return;
                        }
                    }
                }
                if (db.Users.SingleOrDefault(a => a.UserName == txtUserName.Text) != null) {
                    MessageBox.Show("اسم المستخدم موجود بالفعل");
                    txtUserName.Select();
                    return;
                }
                int c = 0;
                foreach (TreeNode n in treeView1.Nodes)
                {
                    foreach (TreeNode node in n.Nodes)
                    {
                        if (node.Checked) c++;
                    }
                }
                if (c == 0)
                {
                    MessageBox.Show("من فضلك اعطى صلاحيات للمستخدم");
                    return;
                }
                
                User u = new User();
                u.FirstName = txtFirstName.Text;
                u.LastName = txtLastName.Text;
                u.Address = txtAddress.Text;
                u.CardNumber = txtCardNumber.Text;
                u.UserName = txtUserName.Text;
                u.Password = txtPassword.Text;
                using (MemoryStream ms = new MemoryStream()) {
                    if (pictureBox1.Image != null) {
                        pictureBox1.Image.Save(ms, ImageFormat.Png);
                        u.Image = ms.ToArray();
                    }
                }
                UsersPermission p = new UsersPermission();
                for (int i = 0; i < p.GetType().GetProperties().Count(); i++)
                {
                    string n = p.GetType().GetProperties()[i].Name;
                    foreach (TreeNode t in treeView1.Nodes)
                    {
                        if (t.Name != n)
                        {
                            foreach (TreeNode a in t.Nodes)
                            {
                                if (a.Name == n)
                                {
                                    p.GetType().GetProperties()[i].SetValue(p, a.Checked);
                                    break;
                                }
                            }
                        }
                        else
                        {
                            p.GetType().GetProperties()[i].SetValue(p, t.Checked);
                            break;
                        }
                    }
                }

                db.UsersPermissions.Add(p);
                u.PermissionsID = p.ID;
                db.Users.Add(u);
                db.SaveChanges();
                MessageBox.Show("تم الاضافه");
                Clear();
            }
            catch { MessageBox.Show("فشلت العمليه"); }
        }

        private void Clear()
        {
            ClearImage();
            for (int i = 0; i < groupBox1.Controls.Count; i++)
            {
                TextBox t = groupBox1.Controls[i] as TextBox;
                if (t != null)
                    t.Text = "";
            }
            foreach (TreeNode t in treeView1.Nodes) {

                foreach (TreeNode s in t.Nodes)
                {
                    s.Checked = false;
                }
                t.Checked = false;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog d = new OpenFileDialog()) {
                d.Filter = "Image Files(*.PNG;*.JPG;*.JPEG)|*.PNG;*.JPG;*.JPEG|All files (*.*)|*.*";
                if (d.ShowDialog() == DialogResult.OK) {
                    long length = new System.IO.FileInfo(d.FileName).Length;
                    if (length * 0.000001 < 1)
                        pictureBox1.ImageLocation = d.FileName;
                    else MessageBox.Show("حجم الملف اكبر من 1 ميجا");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClearImage();
        }

        private void ClearImage()
        {
            if (pictureBox1.Image != null)
                pictureBox1.Image.Dispose();
            pictureBox1.ImageLocation = "";
            pictureBox1.Image = null;
            GC.Collect();
            pictureBox1.Update();
        }
    }
}
