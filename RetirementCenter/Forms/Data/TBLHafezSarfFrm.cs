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
    public partial class TBLHafezSarfFrm : DevExpress.XtraEditors.XtraForm
    {
        DataSources.Linq.dsTeachersUnionViewsDataContext dsLinq = new DataSources.Linq.dsTeachersUnionViewsDataContext() { ObjectTrackingEnabled = false };

        public TBLHafezSarfFrm()
        {
            InitializeComponent();
            LoadData();
        }
        private void ActivePriv()
        {
            //return;//ActivePrivReady
            bool Selecting = false, Inserting = false, Updateing = false, Deleting = false;
            SQLProvider.GetFormPriv(this.Name, ref Selecting, ref Inserting, ref  Updateing, ref  Deleting);

            btnAdd.Visible = Inserting;
            repositoryItemButtonEditDelete.Buttons[0].Visible = Deleting;
            repositoryItemButtonEditSave.Buttons[0].Visible =Updateing;
        }

        private void LoadData()
        {
            //XPSCSData.Session.ConnectionString = Properties.Settings.Default.RetirementCenterConnectionString;
            LSMSDATA.QueryableSource = dsLinq.vTBLHafezSarfs;
        }
        private void RefreshData()
        {
            LSMSDATA.Reload();
            gridViewData.RefreshData();
        }
        private void DofatSarfActivityFrm_Load(object sender, EventArgs e)
        {
        }
        private void repositoryItemButtonEditSave_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            RetirementCenter.DataSources.Linq.vTBLHafezSarf row = (RetirementCenter.DataSources.Linq.vTBLHafezSarf)gridViewData.GetRow(gridViewData.FocusedRowHandle);
            TBLHafezSarfEditFrm frm = new TBLHafezSarfEditFrm(row);
            frm.ShowDialog();
            RefreshData();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            TBLHafezSarfAddFrm frm = new TBLHafezSarfAddFrm();
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
            RetirementCenter.DataSources.Linq.vTBLHafezSarf row = (RetirementCenter.DataSources.Linq.vTBLHafezSarf)gridViewData.GetRow(gridViewData.FocusedRowHandle);
            adp.Delete(row.SyndicateId, row.DofatSarfId);
            Program.ShowMsg("تم الحذف", false, this, true);
            Program.Logger.LogThis("تم الحفظ", Text, FXFW.Logger.OpType.success, null, null, this);
            RefreshData();
        }

    }
}