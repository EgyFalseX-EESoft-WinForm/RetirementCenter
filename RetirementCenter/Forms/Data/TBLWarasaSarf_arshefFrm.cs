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
    public partial class TBLWarasaSarf_arshefFrm : DevExpress.XtraEditors.XtraForm
    {
        DataSources.Linq.dsTeachersUnionViewsDataContext dsLinq = new DataSources.Linq.dsTeachersUnionViewsDataContext() { ObjectTrackingEnabled = false };
        DataSources.dsRetirementCenterTableAdapters.TBLWarasaSarf_arshefTableAdapter adp = new DataSources.dsRetirementCenterTableAdapters.TBLWarasaSarf_arshefTableAdapter();

        public TBLWarasaSarf_arshefFrm()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            LSMSDATA.QueryableSource = dsLinq.vTBLWarasaSarf_arshefs;
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
            RetirementCenter.DataSources.Linq.vTBLWarasaSarf_arshef row = (RetirementCenter.DataSources.Linq.vTBLWarasaSarf_arshef)gridViewData.GetRow(gridViewData.FocusedRowHandle);
            TBLWarasaSarf_arshefEditFrm frm = new TBLWarasaSarf_arshefEditFrm(row);
            frm.ShowDialog();
            RefreshData();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            TBLWarasaSarf_arshefEditFrm frm = new TBLWarasaSarf_arshefEditFrm();
            frm.ShowDialog();
            RefreshData();
        }
        private void repositoryItemButtonEditDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (msgDlg.Show("هل انت متأكد؟", msgDlg.msgButtons.YesNo) == System.Windows.Forms.DialogResult.No)
                return;
            RetirementCenter.DataSources.Linq.vTBLWarasaSarf_arshef row = (RetirementCenter.DataSources.Linq.vTBLWarasaSarf_arshef)gridViewData.GetRow(gridViewData.FocusedRowHandle);
            int effected = adp.Delete(row.PersonId, row.DofatSarfId, row.SarfTypeedadId);
            if (effected > 0)
            {
                Program.ShowMsg("تم الحذف", false, this, true);
                Program.Logger.LogThis("تم الحفظ", Text, FXFW.Logger.OpType.success, null, null, this);
                RefreshData();
            }
        }

    }
}