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
    public partial class TBLReprintMemberFrm : DevExpress.XtraEditors.XtraForm
    {
        DataSources.Linq.dsTeachersUnionViewsDataContext dsLinq = new DataSources.Linq.dsTeachersUnionViewsDataContext() { ObjectTrackingEnabled = false };

        public TBLReprintMemberFrm()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            //XPSCSData.Session.ConnectionString = Properties.Settings.Default.RetirementCenterConnectionString;
            LSMSDATA.QueryableSource = dsLinq.vTBLReprintMembers;
        }
        private void RefreshData()
        {
            LSMSDATA.Reload();
            gridViewData.RefreshData();
        }
        private void DofatSarfActivityFrm_Load(object sender, EventArgs e)
        {
        }
        private void repositoryItemButtonEditTransferSave_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            RetirementCenter.DataSources.Linq.vTBLReprintMember row = (RetirementCenter.DataSources.Linq.vTBLReprintMember)gridViewData.GetRow(gridViewData.FocusedRowHandle);
            TBLReprintMemberEditFrm frm = new TBLReprintMemberEditFrm(row.reprintid);
            frm.ShowDialog();
            RefreshData();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            TBLReprintMemberAddFrm frm = new TBLReprintMemberAddFrm();
            frm.ShowDialog();
            RefreshData();
        }
        private void repositoryItemButtonEditDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (msgDlg.Show("هل انت متأكد؟", msgDlg.msgButtons.YesNo) == System.Windows.Forms.DialogResult.No)
                return;
            RetirementCenter.DataSources.Linq.vTBLReprintMember row = (RetirementCenter.DataSources.Linq.vTBLReprintMember)gridViewData.GetRow(gridViewData.FocusedRowHandle);
            adp.Delete(row.reprintdate, row.MMashatId);
            Program.ShowMsg("تم الحذف", false, this, true);
            Program.Logger.LogThis("تم الحفظ", Text, FXFW.Logger.OpType.success, null, null, this);
            RefreshData();
        }
        private void btnUpdateBackDate_Click(object sender, EventArgs e)
        {
            if (deFrom.EditValue == null || deTo.EditValue == null)
                return;
            if (msgDlg.Show("هل انت متأكد؟", msgDlg.msgButtons.YesNo) == System.Windows.Forms.DialogResult.No)
                return;
            adp.Updatesendbankdate(SQLProvider.ServerDateTime(), (DateTime)deFrom.EditValue, (DateTime)deTo.EditValue, -1, SQLProvider.ServerDateTime());
            Program.ShowMsg("تم التعديل", false, this, true);
            Program.Logger.LogThis("تم التعديل", Text, FXFW.Logger.OpType.success, null, null, this);
            RefreshData();
        }

    }
}