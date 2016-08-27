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
    public partial class TblAttachFrm : DevExpress.XtraEditors.XtraForm
    {
        DataSources.Linq.dsTeachersUnionViewsDataContext dsLinq = new DataSources.Linq.dsTeachersUnionViewsDataContext() { ObjectTrackingEnabled = false };

        public TblAttachFrm()
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
            LSMSDATA.QueryableSource = dsLinq.vTblAttaches;
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
            RetirementCenter.DataSources.Linq.vTblAttach row = (RetirementCenter.DataSources.Linq.vTblAttach)gridViewData.GetRow(gridViewData.FocusedRowHandle);
            TblAttachEditFrm frm = new TblAttachEditFrm(row);
            frm.ShowDialog();
            RefreshData();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            TblAttachAddFrm frm = new TblAttachAddFrm();
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
            RetirementCenter.DataSources.Linq.vTblAttach row = (RetirementCenter.DataSources.Linq.vTblAttach)gridViewData.GetRow(gridViewData.FocusedRowHandle);
            adp.Delete(row.AttachmentTypeId,row.MMashatId);
            Program.ShowMsg("تم الحذف", false, this, true);
            Program.Logger.LogThis("تم الحفظ", Text, FXFW.Logger.OpType.success, null, null, this);
            RefreshData();
        }

    }
}