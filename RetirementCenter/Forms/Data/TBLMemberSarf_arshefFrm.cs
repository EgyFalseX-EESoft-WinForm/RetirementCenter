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
    public partial class TBLMemberSarf_arshefFrm : DevExpress.XtraEditors.XtraForm
    {
        DataSources.Linq.dsTeachersUnionViewsDataContext dsLinq = new DataSources.Linq.dsTeachersUnionViewsDataContext() { ObjectTrackingEnabled = false };
        DataSources.dsRetirementCenterTableAdapters.TBLMemberSarf_arshefTableAdapter adp = new DataSources.dsRetirementCenterTableAdapters.TBLMemberSarf_arshefTableAdapter();

        public TBLMemberSarf_arshefFrm()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            LSMSDATA.QueryableSource = dsLinq.vTBLMemberSarf_arshefs;
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
            RetirementCenter.DataSources.Linq.vTBLMemberSarf_arshef row = (RetirementCenter.DataSources.Linq.vTBLMemberSarf_arshef)gridViewData.GetRow(gridViewData.FocusedRowHandle);
            TBLMemberSarf_arshefEditFrm frm = new TBLMemberSarf_arshefEditFrm(row);
            frm.ShowDialog();
            RefreshData();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            TBLMemberSarf_arshefEditFrm frm = new TBLMemberSarf_arshefEditFrm();
            frm.ShowDialog();
            RefreshData();
        }
        private void repositoryItemButtonEditDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (msgDlg.Show("هل انت متأكد؟", msgDlg.msgButtons.YesNo) == System.Windows.Forms.DialogResult.No)
                return;
            RetirementCenter.DataSources.Linq.vTBLMemberSarf_arshef row = (RetirementCenter.DataSources.Linq.vTBLMemberSarf_arshef)gridViewData.GetRow(gridViewData.FocusedRowHandle);
            int effected = adp.Delete(row.MMashatId, row.DofatSarfId, row.SarfTypeedadId);
            if (effected > 0)
            {
                Program.ShowMsg("تم الحذف", false, this, true);
                Program.Logger.LogThis("تم الحفظ", Text, FXFW.Logger.OpType.success, null, null, this);
                RefreshData();
            }
        }

    }
}