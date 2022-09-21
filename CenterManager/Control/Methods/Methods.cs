using CenterManager.Control.DBControl;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
using System.Drawing;

namespace CenterManager.Control.Methods
{
    public static class Methods
    {
        public static string TitleColor  = "";
        public static string BackColor  = "";
        public static User MyUser = null;
        public static UsersPermission MyPermissions = null;
        public static bool Demo = false;
        public static int DemoDays = 0;
        public static DateTime StartDay;

        public static CenterManagerEntities db = new CenterManagerEntities();
        public static bool Login(string UserName, string Password)
        {
            CenterManagerEntities db = Methods.db;
            User user = db.Users.SingleOrDefault(a => a.UserName == UserName);
            if (user != null && user.Password == Password)
            {
                Methods.MyUser = user;
                Methods.MyPermissions = user.UsersPermission;
                return true;
            }
            return false;
        }
        // To View Any Form you want and dispose it once it closed

        public static  string GetConnectionString(string ServerName, string DBName, string userName, string Password, bool WindowsAuth) {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = ServerName;
            builder.InitialCatalog = DBName;
            if (!WindowsAuth)
            {
                builder.UserID = userName;
                builder.Password = Password;
                builder.IntegratedSecurity = false;
            }
            else
            {
                builder.IntegratedSecurity = true;
            }
            return builder.ConnectionString;
        }

        internal static void LoadConnectionString()
        {
            db.Database.Connection.ConnectionString = GetConnectionString(Properties.Settings.Default.ServerName, Properties.Settings.Default.DBName, Properties.Settings.Default.DBUserName, Properties.Settings.Default.DBPassword, Properties.Settings.Default.WindowsAuth);
        }

        public static bool TestConnection(string ServerName  = "",string DBName = "", string userName = "", string Password= "", bool WindowsAuth = true)
        {
            if(ServerName == "")
            {
                ServerName = Properties.Settings.Default.ServerName;
                DBName = Properties.Settings.Default.DBName;
                userName = Properties.Settings.Default.DBUserName;
                Password = Properties.Settings.Default.DBPassword;
                WindowsAuth = Properties.Settings.Default.WindowsAuth;
            }
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = GetConnectionString(ServerName, DBName, userName, Password, WindowsAuth);
                try
                {
                    con.Open();
                    con.Close();
                    return true;
                }
                catch(Exception ex)
                {
                    con.Close();
                    return false;
                }

            }
        }
        public static DialogResult ViewForm(Form frm, Action a = null) {
            DialogResult dr;
            using (frm) {
                dr = frm.ShowDialog();
                a?.Invoke();
            }
            GC.Collect();
            GC.WaitForPendingFinalizers();
            frm = null;
            GC.Collect();
            GC.WaitForPendingFinalizers();
            return dr;
        }
    }
}
