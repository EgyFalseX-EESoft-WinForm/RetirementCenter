﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using System.IO;
using FXFW;

namespace RetirementCenter
{
    public partial class LoginFrm : DevExpress.XtraEditors.XtraForm
    {
        public bool Logged = false;
        private string LoginInfoFileName = Application.StartupPath + "\\loginInfo";
        public LoginFrm()
        {
            InitializeComponent();

            if (File.Exists(LoginInfoFileName))
            {
                
                FileStream fs = File.Open(LoginInfoFileName, FileMode.Open, FileAccess.Read);
                byte[] buff = new byte[fs.Length];
                fs.Read(buff, 0, Convert.ToInt32(fs.Length));
                fs.Close(); fs.Dispose();
                string username = Encoding.Default.GetString(buff, 0, buff.Length);
                TxtUserName.Text = username;
                TxtPassword.Focus();
            }
        }
        private void text_EditValueChanged(object sender, EventArgs e)
        {
            if (TxtUserName.Text.Trim().Length > 0 && TxtPassword.Text.Trim().Length > 0)
                BtnEnter.Enabled = true;
            else
                BtnEnter.Enabled = false;
        }
        private void BtnEnter_Click(object sender, EventArgs e)
        {
            //FXFW.SqlDB.UserInfo = new FXFW.SqlDB.UserInfoStruct { UserID = "1", UserName = "Admin" };
            //Close();
            //return;
            ///////////////////////////////////////////////////////////////////////////////
            if (CheckEmptyPass(TxtUserName.Text.Trim()))
            {
                RetirementCenter.Forms.Main.PasswordChangerFrm changepass =
                    new RetirementCenter.Forms.Main.PasswordChangerFrm(TxtUserName.Text.Trim());
                changepass.ShowDialog();
            }
            if (LoadUserInfo(TxtUserName.Text.Trim(), TxtPassword.Text.Trim()))
            {
                SetAdminInfo();
                SaveLoginTime();
                Logged = true;
                //Program.ShowMsg("تم الدخول..  مرحبا " + TxtUserName.Text.Trim(), false, this);
                SaveLoginInfoToFile();
                Close();
            }
            else
                MessageBox.Show("خطاء في اسم المستخدم او كلمة المرور", "خطـــــــاء", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void BtnEnd_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }
        private void SaveLoginTime()
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);
            try
            {
                //GETDATE()
                con.Open();
                cmd.CommandText = @"UPDATE Users SET LastActivityDate = GETDATE() WHERE UserID = " + FXFW.SqlDB.UserInfo.UserID;
                cmd.ExecuteNonQuery();
                //Program.Logger.LogThis("تم حفظ بيانات الدخول", Text, FXFW.Logger.OpType.success, null, null, this);
            }
            catch (SqlException ex)
            {
                msgDlg.Show(FXFW.SqlDB.CheckExp(ex));
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, null, ex, this);
            }
            con.Close();
        }
        private void SetAdminInfo()
        {
            Program.UserInfo.UserId = Convert.ToInt32(FXFW.SqlDB.UserInfo.UserID);
            Program.UserInfo.UserName = FXFW.SqlDB.UserInfo.UserName;
            Program.UserInfo.RealName = new DataSources.dsRetirementCenterTableAdapters.UsersTableAdapter().ScalarQueryRealName(Program.UserInfo.UserId);

            Program.UserInfo.UserRoles = new List<int>();
            DataSources.dsRetirementCenterTableAdapters.UserRolesTableAdapter adp = new DataSources.dsRetirementCenterTableAdapters.UserRolesTableAdapter();
            
            foreach (DataSources.dsRetirementCenter.UserRolesRow item in adp.GetDataByUserId(Program.UserInfo.UserId).Rows)
            {
                Program.UserInfo.UserRoles.Add(item.RoleId);
                if (item.RoleId == 1)
                {
                    if (System.Diagnostics.Debugger.IsAttached) 
                    {
                        Program.UserInfo.IsAdmin = true;
                    } else if (new RetirementCenter.Forms.Main.AntiAdminLogincs().ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        Program.UserInfo.IsAdmin = true;
                    }
                    else
                    {
                        Application.Exit();
                    }
                    
                }
            }
            Program.UserInfo.Syndicates = new List<int>();
            DataSources.dsRetirementCenterTableAdapters.RoleSyndicateTableAdapter adpRoleSyn = new DataSources.dsRetirementCenterTableAdapters.RoleSyndicateTableAdapter();
            foreach (DataSources.dsRetirementCenter.RoleSyndicateRow item in adpRoleSyn.GetDataByUserId(Program.UserInfo.UserId))
            {
                Program.UserInfo.Syndicates.Add(item.SyndicateId);
            }

        }
        private void SaveLoginInfoToFile()
        {
            FileStream fs;
            fs = File.Open(LoginInfoFileName, FileMode.Create, FileAccess.Write);

            byte[] buff = Encoding.Default.GetBytes(TxtUserName.Text);

            fs.Write(buff, 0, buff.Length);

            fs.Flush(); fs.Close(); fs.Dispose();

        }

        public bool LoadUserInfo(string username, string password)
        {
            DataTable TblUser = SqlDB.LoadDataTable(String.Format(@"SELECT UserID, UserName, UserPass, IsActive FROM Users
                                                              WHERE (UserName = N'{0}') AND (UserPass = HASHBYTES('SHA2_512', N'{1}')) AND (IsActive = 1)", username, password));
            foreach (DataRow row in TblUser.Rows)
            {
                SqlDB.UserInfo = new SqlDB.UserInfoStruct { UserID = row["UserID"].ToString(), UserName = row["UserName"].ToString() };
                return true;
            }
            return false;
        }

        public bool CheckEmptyPass(string username)
        {
            DataTable TblUser = SqlDB.LoadDataTable(String.Format(@"SELECT UserID, UserName, UserPass, IsActive FROM Users
                                                              WHERE (UserName = N'{0}') AND (UserPass IS NULL) AND (IsActive = 1)", username));
            foreach (DataRow row in TblUser.Rows)
            {
                return true;
            }
            return false;
        }
    }
}