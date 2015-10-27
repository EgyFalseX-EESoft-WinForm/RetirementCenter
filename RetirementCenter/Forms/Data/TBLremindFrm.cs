using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace RetirementCenter.Forms.Data
{
    public partial class TBLremindFrm : DevExpress.XtraEditors.XtraForm
    {
        DataSources.Linq.dsTeachersUnionViewsDataContext dsLinq = new DataSources.Linq.dsTeachersUnionViewsDataContext();

        public TBLremindFrm()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            XPSCSData.Session.ConnectionString = Properties.Settings.Default.RetirementCenterConnectionString;
        }
        private void ReloadData()
        {
            XPSCSData.Session.DropIdentityMap();
            XPSCSData.Session.DropChanges();
            XPSCSData.Reload();
            gridViewData.RefreshData();
        }
        private void DofatSarfActivityFrm_Load(object sender, EventArgs e)
        {
            
        }
        private void repositoryItemButtonEditTransferSave_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DevExpress.Xpo.Metadata.XPDataTableObject row = (DevExpress.Xpo.Metadata.XPDataTableObject)gridViewData.GetRow(gridViewData.FocusedRowHandle);
            try
            {
                row.SetMemberValue("userin", Program.UserInfo.UserId);
                row.SetMemberValue("datein", SQLProvider.ServerDateTime());
                row.Save();
                UOWData.Save(row);
                UOWData.CommitChanges();
                Program.ShowMsg("تم التعديل", false, this, true);
                Program.Logger.LogThis("تم التعديل", Text, FXFW.Logger.OpType.success, null, null, this);
            }
            catch (SqlException ex)
            {
                Program.ShowMsg(FXFW.SqlDB.CheckExp(ex), true, this, true);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, null, ex, this);
            }
        }
        private void repositoryItemButtonEditdel_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (msgDlg.Show("هل انت متأكد؟", msgDlg.msgButtons.YesNo) == System.Windows.Forms.DialogResult.No)
                return;
            DevExpress.Xpo.Metadata.XPDataTableObject row = (DevExpress.Xpo.Metadata.XPDataTableObject)gridViewData.GetRow(gridViewData.FocusedRowHandle);
            try
            {
                gridViewData.DeleteRow(gridViewData.FocusedRowHandle);
                UOWData.CommitChanges();
                Program.ShowMsg("تم التعديل", false, this, true);
                Program.Logger.LogThis("تم التعديل", Text, FXFW.Logger.OpType.success, null, null, this);
            }
            catch (SqlException ex)
            {
                Program.ShowMsg(FXFW.SqlDB.CheckExp(ex), true, this, true);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, null, ex, this);
            }
        }

    }
}