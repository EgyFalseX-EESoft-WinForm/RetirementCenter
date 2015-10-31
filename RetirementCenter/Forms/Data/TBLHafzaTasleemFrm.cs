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
    public partial class TBLHafzaTasleemFrm : DevExpress.XtraEditors.XtraForm
    {
        DataSources.Linq.dsTeachersUnionViewsDataContext dsLinq = new DataSources.Linq.dsTeachersUnionViewsDataContext() { ObjectTrackingEnabled = false };
        DataSources.dsRetirementCenterTableAdapters.TBLHafzaTasleemTableAdapter adp = new DataSources.dsRetirementCenterTableAdapters.TBLHafzaTasleemTableAdapter();

        public TBLHafzaTasleemFrm()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            LSMSDATA.QueryableSource = dsLinq.vTBLHafzaTasleems ;
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
            RetirementCenter.DataSources.Linq.vTBLHafzaTasleem row = (RetirementCenter.DataSources.Linq.vTBLHafzaTasleem)gridViewData.GetRow(gridViewData.FocusedRowHandle);
            TBLHafzaTasleemEditFrm frm = new TBLHafzaTasleemEditFrm(row.tasleemid);
            frm.ShowDialog();
            RefreshData();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            TBLHafzaTasleemAddFrm frm = new TBLHafzaTasleemAddFrm();
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                RefreshData();
                btnAdd_Click(btnAdd, EventArgs.Empty);
            }
        }
        private void repositoryItemButtonEditDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (msgDlg.Show("هل انت متأكد؟", msgDlg.msgButtons.YesNo) == System.Windows.Forms.DialogResult.No)
                return;
            RetirementCenter.DataSources.Linq.vTBLHafzaTasleem row = (RetirementCenter.DataSources.Linq.vTBLHafzaTasleem)gridViewData.GetRow(gridViewData.FocusedRowHandle);
            adp.Delete(row.tasleemtype, row.hafza, row.SyndicateId);
            Program.ShowMsg("تم الحذف", false, this, true);
            Program.Logger.LogThis("تم الحفظ", Text, FXFW.Logger.OpType.success, null, null, this);
            RefreshData();
        }

    }
}