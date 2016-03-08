using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using DevExpress.UserSkins;
using DevExpress.XtraEditors;
using DevExpress.XtraBars.Helpers;
using DevExpress.XtraBars;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using RetirementCenter.Forms.Data;
using DevExpress.XtraSplashScreen;

namespace RetirementCenter
{
    
    public partial class MainFrm : XtraForm
    {

        #region -   Variables   -
        DataTable RoleDetialsTbl = new DataTable("FalseX2012");
        #endregion
        #region -   Functions   -
        public MainFrm()
        {
            InitializeComponent();
            //Load Skins and layout
            InitSkinGallery();
            DevExpress.XtraBars.Helpers.SkinHelper.InitSkinGallery(mbRetCenterSkins, true, true);
            mbRetCenterSkins.GalleryItemClick += rgbiSkins_GalleryItemClick;
            if (System.IO.File.Exists(FXFW.SqlDB.StyleSettingsPath))
                UserLookAndFeel.Default.SetSkinStyle(LoadSettings(FXFW.SqlDB.StyleSettingsPath).SkinName);
            
            IsMdiContainer = true;
        }
        private static FXFW.UserSkinSettings LoadSettings(string fileName)
        {
            FXFW.UserSkinSettings us = null;
            BinaryFormatter binFormat = new BinaryFormatter();
            System.IO.Stream fStream = new System.IO.FileStream(fileName, System.IO.FileMode.Open);
            try { us = binFormat.Deserialize(fStream) as FXFW.UserSkinSettings; }
            finally { fStream.Close(); }
            return us;
        }
        private static void SaveSettings(FXFW.UserSkinSettings us)
        {
            BinaryFormatter binFormat = new BinaryFormatter();
            using (System.IO.Stream fStream = new System.IO.FileStream(FXFW.SqlDB.StyleSettingsPath, System.IO.FileMode.Create, System.IO.FileAccess.Write, System.IO.FileShare.None))
            {
                binFormat.Serialize(fStream, us);
                fStream.Close();
            }
        }
        void InitSkinGallery()
        {
            SkinHelper.InitSkinGallery(mbRetCenterSkins, true);
        }
        private void LoadUserPriv(string RoleID)
        {
            //Hide All Tools
            SQLProvider.FillUserPrv();
            for (int i = 0; i < ribbonControl.Items.Count; i++)
            {
                if (ribbonControl.Items[i].GetType().Name == "BarButtonItem")
                {
                    if (ribbonControl.Items[i].Name == "mbRetCenterHelp" || ribbonControl.Items[i].Name == "mbRetCenterExit" || ribbonControl.Items[i].Name == "mbRetCenterAbout" ||
                        ribbonControl.Items[i].Name == "mbRetCenterSkins" || ribbonControl.Items[i].Name == "mbRetCenterInfo" || ribbonControl.Items[i].Name == "mbRetCenterStatus" ||
                        ribbonControl.Items[i].Name == "mbRetCenterPasswordChanger")
                        continue;
                    ribbonControl.Items[i].Visibility = BarItemVisibility.Never;
                }

            }
            //Customizing menu visibility depand on user roles
            foreach (DataSources.dsRetirementCenter.RoleDetialRow row in SQLProvider.ds.RoleDetial)
            {
                for (int i = 0; i < ribbonControl.Items.Count; i++)
                {
                    if (row.MenuItemName == ribbonControl.Items[i].Name)
                        ribbonControl.Items[i].Visibility = BarItemVisibility.Always;                        
                }
            }
        }
        #endregion
        #region -   Event Handlers   -

        private void FrmMain_Load(object sender, EventArgs e)
        {
            LoadUserPriv(FXFW.SqlDB.UserInfo.UserID);

            this.Text += " - " + Program.UserInfo.RealName;
            //Qry00Frm frm = new Qry00Frm();
            //frm.ShowDialog();
          int num = (int)(new DataSources.dsRetirementCenterTableAdapters.TBLremindTableAdapter().GetTodayReminders(Program.UserInfo.UserId));
          if (num > 0)
          {
              msgDlg.Show(string.Format("áÏíß {0} ÇÔÚÇÑÇÊ Çáíæã", num), msgDlg.msgButtons.Close);
          }
        }
        private void MainFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }
        private void iMembersExit_ItemClick(object sender, ItemClickEventArgs e)
        {
            Application.Exit();
        }
        private void mbMembersAbout_ItemClick(object sender, ItemClickEventArgs e)
        {
            RetirementCenter.Forms.Main.AboutUs abus = new Forms.Main.AboutUs();
            abus.ShowDialog();
        }
        void rgbiSkins_GalleryItemClick(object sender, DevExpress.XtraBars.Ribbon.GalleryItemClickEventArgs e)
        {
            FXFW.UserSkinSettings us = new FXFW.UserSkinSettings();
            us.SkinName = UserLookAndFeel.Default.ActiveSkinName;
            SaveSettings(us);
        }
        private void mbDBChange_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (msgDlg.Show("åá ÇäÊ ãÊÃßÏ¿", msgDlg.msgButtons.YesNo) == System.Windows.Forms.DialogResult.No)
                return;
            if (File.Exists(SQLProvider.DBPath))
            {
                File.Delete(SQLProvider.DBPath);
                Application.Restart();
            }
        }
        private void siInfo_ItemDoubleClick(object sender, ItemClickEventArgs e)
        {
            Program.Logger.ShowHideLogWindow = true;
        }
        private void repositoryItemLookUpEditCRRep_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //if (e.Button.Kind != DevExpress.XtraEditors.Controls.ButtonPredefines.OK)
            //    return;
            //RepCRGeneralFrm RepForm = new RepCRGeneralFrm();
            //if (mbReportsMembers.EditValue == null)
            //    return;

            //CrystalDecisions.Shared.TableLogOnInfos crtableLogoninfos = new CrystalDecisions.Shared.TableLogOnInfos();
            //CrystalDecisions.Shared.TableLogOnInfo crtableLogoninfo = new CrystalDecisions.Shared.TableLogOnInfo();
            //CrystalDecisions.Shared.ConnectionInfo crConnectionInfo = new CrystalDecisions.Shared.ConnectionInfo();
            //CrystalDecisions.CrystalReports.Engine.Tables CrTables = SQLProvider.crRep[Convert.ToInt16(mbReportsMembers.EditValue)].CRReport.Database.Tables;
            //System.Data.OleDb.OleDbConnectionStringBuilder ConString = new System.Data.OleDb.OleDbConnectionStringBuilder(SQLProvider.AccConStr);
            //crConnectionInfo.ServerName = ConString.DataSource;
            //crConnectionInfo.DatabaseName = ConString.FileName;
            ////crConnectionInfo.UserID = ConString.UserID;
            ////crConnectionInfo.Password = ConString.Password;
            //SQLProvider.crRep[Convert.ToInt16(mbReportsMembers.EditValue)].CRReport.DataSourceConnections[0].SetConnection(ConString.DataSource, ConString.FileName, string.Empty, string.Empty);
            //SQLProvider.crRep[Convert.ToInt16(mbReportsMembers.EditValue)].CRReport.SetDatabaseLogon(string.Empty, string.Empty, ConString.DataSource, ConString.FileName, true);

            //foreach (CrystalDecisions.Shared.IConnectionInfo info in SQLProvider.crRep[Convert.ToInt16(mbReportsMembers.EditValue)].CRReport.DataSourceConnections)
            //{
            //    info.SetConnection(ConString.DataSource, ConString.FileName, string.Empty, string.Empty);
            //}
            //foreach (CrystalDecisions.CrystalReports.Engine.ReportDocument sub in SQLProvider.crRep[Convert.ToInt16(mbReportsMembers.EditValue)].CRReport.Subreports)
            //{
            //    foreach (CrystalDecisions.Shared.IConnectionInfo info in sub.DataSourceConnections)
            //    {
            //        info.SetConnection(ConString.DataSource, ConString.FileName, string.Empty, string.Empty);
            //    }
            //}

            //foreach (CrystalDecisions.CrystalReports.Engine.Table CrTable in CrTables)
            //{
            //    crtableLogoninfo = CrTable.LogOnInfo;
            //    crtableLogoninfo.ConnectionInfo = crConnectionInfo;
            //    CrTable.ApplyLogOnInfo(crtableLogoninfo);
            //}

            //RepForm.CRViewer.ReportSource = SQLProvider.crRep[Convert.ToInt16(mbReportsMembers.EditValue)].CRReport;
            //RepForm.CRViewer.Refresh();
            //RepForm.ReportName = SQLProvider.crRep[Convert.ToInt16(mbReportsMembers.EditValue)].RepCaption;
            //RepForm.MdiParent = this;
            //RepForm.Show();
        }
        private void mbMembersAppOptions_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                Forms.Main.AppOptionsFrm FrmData = new Forms.Main.AppOptionsFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["Options32.png"], 32, false) };
                FrmData.Show();    
            }));
            SplashScreenManager.CloseForm();
            
        }
        private void mbMembersPasswordChanger_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                Forms.Main.PasswordChangerFrm FrmData = new Forms.Main.PasswordChangerFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["Users.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbMembersRoles_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                RolesFrm FrmData = new RolesFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["Roles.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbMembersUsers_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                UsersFrm FrmData = new UsersFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["Users.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbMembersUserRoles_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                UserRolesFrm FrmData = new UserRolesFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["UserRoles.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }private void mbRetCenterRoleSyndicate_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                RoleSyndicateFrm FrmData = new RoleSyndicateFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["RoleSyndicate.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbMembersRoleDetail_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                RoleDetailFrm FrmData = new RoleDetailFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["RoleDetail.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbMembersCDGov_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CDGov) { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["CDGov.png"], 32, false) };
                FrmCode.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbMembersCDMarkez_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CDMarkez) { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["CDMarkez.png"], 32, false) };
                FrmCode.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbMembersCDSyndicate_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CDSyndicate) { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["CDSyndicate.png"], 32, false) };
                FrmCode.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbMembersCDSubCommitte_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CDSubCommitte) { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["CDSubCommitte.png"], 32, false) };
                FrmCode.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbMembersCDBirthPlace_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CDBirthPlace) { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["CDBirthPlace.png"], 32, false) };
                FrmCode.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbMembersCDJop_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CDJop) { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["CDJop.png"], 32, false) };
                FrmCode.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbMembersCDJobtitle_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CDJobtitle) { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["CDJop.png"], 32, false) };
                FrmCode.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbMembersCDJobDescription_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CDJobDescription) { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["CDJobDescription.png"], 32, false) };
                FrmCode.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbMembersCDGehaType_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CDGehaType) { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["CDGehaType.png"], 32, false) };
                FrmCode.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbMembersCDModerea_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CDModerea) { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["CDModerea.png"], 32, false) };
                FrmCode.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbMembersCDEDARET_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CDEDARET) { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["CDEDARET.png"], 32, false) };
                FrmCode.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbMembersCDGeha_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CDGeha) { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["CDGeha.png"], 32, false) };
                FrmCode.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbMembersCDQualification_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CDQualification) { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["CDQualification.png"], 32, false) };
                FrmCode.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbMembersCDSpecialization_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CDSpecialization) { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["CDSpecialization.png"], 32, false) };
                FrmCode.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbMembersCDEstefaaKed_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CDEstefaaKed) { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["CDEstefaaKed.png"], 32, false) };
                FrmCode.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbMembersCDAttachmentType_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CDAttachmentType) { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["CDAttachmentType.png"], 32, false) };
                FrmCode.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterCDsarfType_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CDsarfType) { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["CDsarfType.png"], 32, false) };
                FrmCode.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterTBLDofatSarf_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.TBLDofatSarf) { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["TBLDofatSarf.png"], 32, false) };
                FrmCode.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbMembersTBLMashat_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                TBLMashatFrm FrmData = new TBLMashatFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["TBLMembers.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterImportFromAccessFrm_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                ImportFromAccessFrm FrmData = new ImportFromAccessFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["ImportData.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterTBLMemberSarf_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                TBLMemberSarfFrm FrmData = new TBLMemberSarfFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["TBLMemberSarf.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterTBLMashatNIDFastEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                TBLMashatNIDFastEditFrm FrmData = new TBLMashatNIDFastEditFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["TBLMembers.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterTBLWarasaNIDFastEditFrm_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                TBLWarasaNIDFastEditFrm FrmData = new TBLWarasaNIDFastEditFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["TBLMembers.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterTBLWarasaSarf_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                TBLWarasaSarfFrm FrmData = new TBLWarasaSarfFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["TBLMemberSarf.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterDofatSarfActivity_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                DofatSarfActivityFrm FrmData = new DofatSarfActivityFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["TBLDofatSarf.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterTblMemberAmanat_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                TblMemberAmanatFrm FrmData = new TblMemberAmanatFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["TblMemberAmanat.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterTblWarasaAmanat_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                TblWarasaAmanatFrm FrmData = new TblWarasaAmanatFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["TblWarasaAmanat.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterTBLMemberSarf_arshefDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                TBLMemberSarf_arshefDeleteFrm FrmData = new TBLMemberSarf_arshefDeleteFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["archive32.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterTBLWarasaSarf_arshefDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                TBLWarasaSarf_arshefDeleteFrm FrmData = new TBLWarasaSarf_arshefDeleteFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["TBLMembers.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterRemoveTBLMashatNID_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                RemoveTBLMashatNIDFrm FrmData = new RemoveTBLMashatNIDFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["archive32.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterRemoveTBLWarasaNID_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                RemoveTBLWarasaNIDFrm FrmData = new RemoveTBLWarasaNIDFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["archive32.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterTblChekNid_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                TblChekNidFrm FrmData = new TblChekNidFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["TblChekNid32.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterTBLProofDoc_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                TBLProofDocFrm FrmData = new TBLProofDocFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["TBLProofDoc32.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterTBLBeanWarsa_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                TBLBeanWarsaFrm FrmData = new TBLBeanWarsaFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["TBLProofDoc32.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterActivateVisa_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                ActivateVisaFrm FrmData = new ActivateVisaFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["Bank32.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterActivateVisaWarasa_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                ActivateVisaWarasaFrm FrmData = new ActivateVisaWarasaFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["Bank32.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterStopYasrefByTBLBeanWarsa_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                StopYasrefByTBLBeanWarsaFrm FrmData = new StopYasrefByTBLBeanWarsaFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["TBLProofDoc32.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterTBLDeathMembers_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                TBLDeathMembersFrm FrmData = new TBLDeathMembersFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["TBLDeathMembers32.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCentertbladminremarks_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                tbladminremarksFrm FrmData = new tbladminremarksFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["tbladminremarks32.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterTBLEstefa_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                TBLEstefaFrm FrmData = new TBLEstefaFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["TBLEstefa32.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterTBLReprintMember_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                TBLReprintMemberFrm FrmData = new TBLReprintMemberFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["TBLAksat.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterTBLReprintWarasa_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                TBLReprintWarasaFrm FrmData = new TBLReprintWarasaFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["TBLAksat.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterTBLremind_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                TBLremindFrm FrmData = new TBLremindFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["TBLremind32.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterTBLMandoop_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                TBLMandoopFrm FrmData = new TBLMandoopFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["TBLMandoop32.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterTBLHafzaTasleem_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                TBLHafzaTasleemFrm FrmData = new TBLHafzaTasleemFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["TBLAksat.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterTBLReprintMemberTaslem_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                TBLReprintMemberTaslemFrm FrmData = new TBLReprintMemberTaslemFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["TBLHafzaTasleem32.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterTBLReprintWarasaTaslem_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                TBLReprintWarasaTaslemFrm FrmData = new TBLReprintWarasaTaslemFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["TBLHafzaTasleem32.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterTBLFrookWarasa_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                TBLFrookWarasaFrm FrmData = new TBLFrookWarasaFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["TBLMemberSarf.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterTBLFrookWarasaAdmin_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                TBLFrookWarasaAdminFrm FrmData = new TBLFrookWarasaAdminFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["TBLMemberSarf.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterTBLHafezSarf_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                TBLHafezSarfFrm FrmData = new TBLHafezSarfFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["TBLAksat.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterTBLDeathMembersAcc_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                TBLDeathMembersAccFrm FrmData = new TBLDeathMembersAccFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["TblMemberAmanat.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterTblMemberAmanatAcc_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                TblMemberAmanatAccFrm FrmData = new TblMemberAmanatAccFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["TBLDeathMembers32.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterTblMemberAmanatSarf_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                TblMemberAmanatSarfFrm FrmData = new TblMemberAmanatSarfFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["TblMemberAmanat.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterTBLMemberSarf_arshef_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                TBLMemberSarf_arshefFrm FrmData = new TBLMemberSarf_arshefFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["TBLMemberSarf.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterTBLWarasaSarf_arshef_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                TBLWarasaSarf_arshefFrm FrmData = new TBLWarasaSarf_arshefFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["TBLMemberSarf.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterTbWarasaAmanatSarf_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                TblWarasaAmanatSarfFrm FrmData = new TblWarasaAmanatSarfFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["TblWarasaAmanat.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterTblWarasaAmanatAcc_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                TblWarasaAmanatAccFrm FrmData = new TblWarasaAmanatAccFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["TblWarasaAmanat.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterBankExportedDataActivate_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                BankExportedDataActivateFrm FrmData = new BankExportedDataActivateFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["Visa32.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterBankExportedDataWarsaActivate_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                BankExportedDataWarsaActivateFrm FrmData = new BankExportedDataWarsaActivateFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["Visa32.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }

        private void mbRetCenterXRep01_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                XRep01 FrmRep = new XRep01();
                Misc.Misc.ShowPrintPreview(FrmRep);
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterXRep02a_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                XRep02a FrmRep = new XRep02a();
                Misc.Misc.ShowPrintPreview(FrmRep);
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterXRep02b_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                XRep02b FrmRep = new XRep02b();
                Misc.Misc.ShowPrintPreview(FrmRep);
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterXRep02c_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                XRep02c FrmRep = new XRep02c();
                Misc.Misc.ShowPrintPreview(FrmRep);
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterXRep02d_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                XRep02d FrmRep = new XRep02d();
                Misc.Misc.ShowPrintPreview(FrmRep);
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterXRep03a_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                XRep03a FrmRep = new XRep03a();
                Misc.Misc.ShowPrintPreview(FrmRep);
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterXRep03b_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                XRep03b FrmRep = new XRep03b();
                Misc.Misc.ShowPrintPreview(FrmRep);
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterXRep03c_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                XRep03c FrmRep = new XRep03c();
                Misc.Misc.ShowPrintPreview(FrmRep);
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterXRep03d_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                XRep03d FrmRep = new XRep03d();
                Misc.Misc.ShowPrintPreview(FrmRep);
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterXRep05_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                XRep05 FrmRep = new XRep05();
                Misc.Misc.ShowPrintPreview(FrmRep);
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterXRep06_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                XRep06 FrmRep = new XRep06();
                Misc.Misc.ShowPrintPreview(FrmRep);
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterXRep07_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                XRep07 FrmRep = new XRep07();
                Misc.Misc.ShowPrintPreview(FrmRep);
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterXRep08_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                XRep08 FrmRep = new XRep08();
                Misc.Misc.ShowPrintPreview(FrmRep);
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterXRep09_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                XRep09 FrmRep = new XRep09();
                Misc.Misc.ShowPrintPreview(FrmRep);
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterXRep10_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                XRep10 FrmRep = new XRep10();
                Misc.Misc.ShowPrintPreview(FrmRep);
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterXRep11_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                XRep11 FrmRep = new XRep11();
                Misc.Misc.ShowPrintPreview(FrmRep);
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterXRep12_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                XRep12 FrmRep = new XRep12();
                Misc.Misc.ShowPrintPreview(FrmRep);
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterXRep13_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                XRep13 FrmRep = new XRep13();
                Misc.Misc.ShowPrintPreview(FrmRep);
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterXRep14_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                XRep14 FrmRep = new XRep14();
                Misc.Misc.ShowPrintPreview(FrmRep);
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterXRep15_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                XRep15 FrmRep = new XRep15();
                Misc.Misc.ShowPrintPreview(FrmRep);
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterXRep16_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                XRep16 FrmRep = new XRep16();
                Misc.Misc.ShowPrintPreview(FrmRep);
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterXRep17_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                XRep17 FrmRep = new XRep17();
                Misc.Misc.ShowPrintPreview(FrmRep);
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterXRep18_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                XRep18 FrmRep = new XRep18();
                Misc.Misc.ShowPrintPreview(FrmRep);
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterXRep19_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                XRep19 FrmRep = new XRep19();
                Misc.Misc.ShowPrintPreview(FrmRep);
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterTBLDeathMembersPrint_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                TBLDeathMembersPrintFrm FrmData = new TBLDeathMembersPrintFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["Report.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterXRep21_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                XRep21 FrmRep = new XRep21();
                Misc.Misc.ShowPrintPreview(FrmRep, true);
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterXRep22_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                XRep22 FrmRep = new XRep22();
                Misc.Misc.ShowPrintPreview(FrmRep, true);
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterXRep23_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                XRep23 FrmRep = new XRep23();
                Misc.Misc.ShowPrintPreview(FrmRep, true);
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterXRep24_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                TblMemberAmanatPrintFrm FrmData = new TblMemberAmanatPrintFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["Report.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterXRep25_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                TblWarasaAmanatPrintFrm FrmData = new TblWarasaAmanatPrintFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["Report.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }

        private void mbRetCenterQry01_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                Qry01Frm FrmData = new Qry01Frm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["Qry.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterQry02_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                Qry02Frm FrmData = new Qry02Frm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["Qry.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterQry03_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                Qry03Frm FrmData = new Qry03Frm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["Qry.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterQry03A_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                Qry03AFrm FrmData = new Qry03AFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["Qry.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterQry04_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                Qry04Frm FrmData = new Qry04Frm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["Qry.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterQry05_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                Qry05Frm FrmData = new Qry05Frm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["Qry.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterQry06_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                Qry06Frm FrmData = new Qry06Frm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["Qry.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterQry07_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                Qry07Frm FrmData = new Qry07Frm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["Qry.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterQry08_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                Qry08Frm FrmData = new Qry08Frm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["Qry.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();

        }
        private void mbRetCenterQry09_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                Qry09Frm FrmData = new Qry09Frm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["Qry.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterQry10_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                Qry10Frm FrmData = new Qry10Frm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["Qry.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterQry11_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                Qry11Frm FrmData = new Qry11Frm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["Qry.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterQry12_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                Qry12Frm FrmData = new Qry12Frm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["Qry.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterQry13_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                Qry13Frm FrmData = new Qry13Frm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["Qry.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterQry14_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                Qry14Frm FrmData = new Qry14Frm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["Qry.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterQry15_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                Qry15Frm FrmData = new Qry15Frm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["Qry.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterQry16_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                Qry16Frm FrmData = new Qry16Frm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["Qry.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterQry17_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                Qry17Frm FrmData = new Qry17Frm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["Qry.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterQry18_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                Qry18Frm FrmData = new Qry18Frm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["Qry.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterQry19_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                Qry19Frm FrmData = new Qry19Frm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["Qry.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterQry20_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                Qry20Frm FrmData = new Qry20Frm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["Qry.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterQry21_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                Qry21Frm FrmData = new Qry21Frm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["Qry.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterQry22_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                Qry22Frm FrmData = new Qry22Frm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["Qry.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterQry23_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                Qry23Frm FrmData = new Qry23Frm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["Qry.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterQry24_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                Qry24Frm FrmData = new Qry24Frm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["Qry.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterQry25_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                Qry25Frm FrmData = new Qry25Frm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["Qry.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterQry26_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                Qry26Frm FrmData = new Qry26Frm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["Qry.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterQry27_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                Qry27Frm FrmData = new Qry27Frm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["Qry.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterQry28_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                Qry28Frm FrmData = new Qry28Frm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["Qry.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterQry31_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                Qry31Frm FrmData = new Qry31Frm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["Qry.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterQry32_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                Qry32Frm FrmData = new Qry32Frm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["Qry.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterQry33_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                Qry33Frm FrmData = new Qry33Frm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["Qry.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterQry34_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                Qry34Frm FrmData = new Qry34Frm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["Qry.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterQry35_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                Qry35Frm FrmData = new Qry35Frm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["Qry.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterQry36_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                Qry36Frm FrmData = new Qry36Frm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["Qry.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterQry37_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                Qry37Frm FrmData = new Qry37Frm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["Qry.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterQry38_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                Qry38Frm FrmData = new Qry38Frm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["Qry.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterQry39_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                Qry39Frm FrmData = new Qry39Frm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["Qry.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterQry40_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                Qry40Frm FrmData = new Qry40Frm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["Qry.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterQry41_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                Qry41Frm FrmData = new Qry41Frm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["Qry.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterQry42_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                Qry42Frm FrmData = new Qry42Frm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["Qry.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterQry43_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                Qry43Frm FrmData = new Qry43Frm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["Qry.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterQry38a_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                Qry38aFrm FrmData = new Qry38aFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["Qry.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterQry38b_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                Qry38bFrm FrmData = new Qry38bFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["Qry.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterQry38c_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                Qry38cFrm FrmData = new Qry38cFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["Qry.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterQry44_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                Qry44Frm FrmData = new Qry44Frm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["Qry.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterQry45_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                Qry45Frm FrmData = new Qry45Frm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["Qry.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterQry46_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                Qry46Frm FrmData = new Qry46Frm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["Qry.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterQry47_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                Qry47Frm FrmData = new Qry47Frm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["Qry.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterQry48_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                Qry48Frm FrmData = new Qry48Frm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["Qry.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterQry49_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                Qry49Frm FrmData = new Qry49Frm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["Qry.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterQry50_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                Qry50Frm FrmData = new Qry50Frm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["Qry.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterQry51_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                Qry51Frm FrmData = new Qry51Frm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["Qry.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterQry52_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                Qry52Frm FrmData = new Qry52Frm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["Qry.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterQry53_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                Qry53Frm FrmData = new Qry53Frm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["Qry.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterQry48A_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                Qry48AFrm FrmData = new Qry48AFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["Qry.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterQry54_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                Qry54Frm FrmData = new Qry54Frm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["Qry.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterQry55_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                Qry55Frm FrmData = new Qry55Frm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["Qry.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterQry56_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                Qry56Frm FrmData = new Qry56Frm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["Qry.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterQry60_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                Qry60Frm FrmData = new Qry60Frm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["Qry.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterQry61_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                Qry61Frm FrmData = new Qry61Frm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["Qry.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterQry62_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                Qry62Frm FrmData = new Qry62Frm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["Qry.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterQry63_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                Qry63Frm FrmData = new Qry63Frm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["Qry.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterQry64_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                Qry64Frm FrmData = new Qry64Frm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["Qry.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterQry66_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                Qry66Frm FrmData = new Qry66Frm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["Qry.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterQry67_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                Qry67Frm FrmData = new Qry67Frm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["Qry.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterQry38d_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                Qry38dFrm FrmData = new Qry38dFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["Qry.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterQry38e_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                Qry38eFrm FrmData = new Qry38eFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["Qry.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterQry68_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                Qry68Frm FrmData = new Qry68Frm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["Qry.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterQry69_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                Qry69Frm FrmData = new Qry69Frm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["Qry.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterQry70_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                Qry70Frm FrmData = new Qry70Frm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["Qry.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterQry71_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                Qry71Frm FrmData = new Qry71Frm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["Qry.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterQry72_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                Qry72Frm FrmData = new Qry72Frm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["Qry.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterQry73_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                Qry73Frm FrmData = new Qry73Frm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["Qry.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterQry74_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                Qry74Frm FrmData = new Qry74Frm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["Qry.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterQry75_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                Qry75Frm FrmData = new Qry75Frm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["Qry.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterQry76_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                Qry76Frm FrmData = new Qry76Frm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["Qry.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterQry77_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                Qry77Frm FrmData = new Qry77Frm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["Qry.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterQry78_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                Qry78Frm FrmData = new Qry78Frm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["Qry.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterQry79_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                Qry79Frm FrmData = new Qry79Frm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["Qry.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterQry80_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                Qry80Frm FrmData = new Qry80Frm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["Qry.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterQry82_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                Qry82Frm FrmData = new Qry82Frm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["Qry.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterQry83_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                Qry83Frm FrmData = new Qry83Frm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["Qry.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterQry85_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                Qry85Frm FrmData = new Qry85Frm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["Qry.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterQry86_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                Qry86Frm FrmData = new Qry86Frm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["Qry.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterQry87_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                Qry87Frm FrmData = new Qry87Frm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["Qry.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterQry61A_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                Qry61AFrm FrmData = new Qry61AFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["Qry.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterQry66A_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                Qry66AFrm FrmData = new Qry66AFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["Qry.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterQry88_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                Qry88Frm FrmData = new Qry88Frm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["Qry.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterQry89_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                Qry89Frm FrmData = new Qry89Frm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["Qry.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterQry90_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                Qry90Frm FrmData = new Qry90Frm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["Qry.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterQry91_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                Qry91Frm FrmData = new Qry91Frm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["Qry.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbRetCenterQry92_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                Qry92Frm FrmData = new Qry92Frm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["Qry.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        #endregion

        

        

        

        

        

    }

}