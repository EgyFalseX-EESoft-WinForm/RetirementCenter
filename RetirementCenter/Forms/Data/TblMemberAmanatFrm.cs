
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using DevExpress.XtraGrid.Views.Grid;

namespace RetirementCenter
{
    public partial class TblMemberAmanatFrm : XtraForm
    {
        bool _Insert, _Update, _Delete;
        DataSources.Linq.dsTeachersUnionViewsDataContext dsLinq = new DataSources.Linq.dsTeachersUnionViewsDataContext();
        
        #region -   Functions   -
        public TblMemberAmanatFrm()
        {
            InitializeComponent();
        }
        private void ActiveKeyDownEvent(object sender, KeyEventArgs e)
        {
            return;
            if (e.KeyData != Keys.F5 && e.KeyData != Keys.F6 && e.KeyData != Keys.F10 && e.KeyData != Keys.F8)
                return;
            switch (e.KeyData)
            {
                case Keys.F1:
                    break;
                case Keys.F5:
                    btnNew_Click(btnNew, new EventArgs());
                    break;
                case Keys.F6:
                    repositoryItemButtonEditSave_ButtonClick(repositoryItemButtonEditSave, new DevExpress.XtraEditors.Controls.ButtonPressedEventArgs(new DevExpress.XtraEditors.Controls.EditorButton()));
                    break;
                case Keys.F8:
                    repositoryItemButtonEditDel_ButtonClick(repositoryItemButtonEditDel, new DevExpress.XtraEditors.Controls.ButtonPressedEventArgs(new DevExpress.XtraEditors.Controls.EditorButton()));
                    break;
                case Keys.F10:
                    repositoryItemButtonEditSave_ButtonClick(repositoryItemButtonEditSave, new DevExpress.XtraEditors.Controls.ButtonPressedEventArgs(new DevExpress.XtraEditors.Controls.EditorButton()));
                    break;
                default:
                    break;
            }
        }
        private void ActivePriv()
        {
            bool Selecting = false, Inserting = false, Updateing = false, Deleting = false;
            SQLProvider.GetFormPriv(this.Name, ref Selecting, ref Inserting, ref  Updateing, ref  Deleting);
            gridControlData.Visible = Selecting;

            btnNew.Visible = Inserting;
            repositoryItemButtonEditSave.Buttons[0].Visible = Updateing;
            repositoryItemButtonEditDel.Buttons[0].Visible = Deleting;

            _Insert = Inserting; _Update = Updateing; _Delete = Deleting;
        }
        #endregion
        #region - Event Handlers -
        private void FormFrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsRetirementCenter.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.dsRetirementCenter.Users);
            LSMSTBLMashat.QueryableSource = dsLinq.vTBLMashats;
            LSMSDofatSarfId.QueryableSource = dsLinq.TBLDofatSarfs;
            LSMScd_amanattype.QueryableSource = dsLinq.cd_amanattypes;
            // TODO: This line of code loads data into the 'dsRetirementCenter.CdDofaatAmanat' table. You can move, or remove it, as needed.
            this.cdDofaatAmanatTableAdapter.Fill(this.dsRetirementCenter.CdDofaatAmanat);
            // TODO: This line of code loads data into the 'dsRetirementCenter.TblMemberAmanat' table. You can move, or remove it, as needed.
            this.tblMemberAmanatTableAdapter.FillByMoreInfo(this.dsRetirementCenter.TblMemberAmanat);
            ActivePriv();
        }
        private void gridViewData_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            DataRowView DRV = (DataRowView)e.Row;
            //Fellowship.DataSources.DSFellowship.TBLSheekWaredRow row = (Fellowship.DataSources.DSFellowship.TBLSheekWaredRow)DRV.Row;

            if (e.ErrorText.Contains("SyndicateId"))
            {
                e.ErrorText = "من فضلك بجب ادخال الفرعيه";
                return;
            }
            if (e.ErrorText.Contains("autoID"))
            {
                //e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;
                DRV["autoID"] = "-1";
                return;
            }

        }
        private void repositoryItemButtonEditSave_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            GridView GV = (GridView)gridControlData.MainView;
            DataSources.dsRetirementCenter.TblMemberAmanatRow row = (DataSources.dsRetirementCenter.TblMemberAmanatRow)GV.GetFocusedDataRow();
            if (!row.IsaccReviewNull() && row.accReview == true)//&& Program.UserInfo.IsAdmin == false
            {
                msgDlg.Show("لا يمكن تعديل بعد معاينة الحسابات", msgDlg.msgButtons.Close);
                return;
            }
            if (!row.IsdateinNull() && row.datein != SQLProvider.ServerDateTime() && Program.UserInfo.IsAdmin == false)
            {
                msgDlg.Show("التعديل متاح في يوم الادخال فقط", msgDlg.msgButtons.Close);
                return;
            }
            Update(row, false);
            
        }
        private void repositoryItemButtonEditDel_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            GridView GV = (GridView)gridControlData.MainView;
            DataSources.dsRetirementCenter.TblMemberAmanatRow row = (DataSources.dsRetirementCenter.TblMemberAmanatRow)GV.GetFocusedDataRow();

            if (row.RowState == DataRowState.Detached)
                return;

            if (MessageBox.Show("هل انت متأكد؟", "تحزير ...", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
                return;
            try
            {
                if (!row.IsaccReviewNull() && row.accReview && Program.UserInfo.IsAdmin == false)
                {
                    Program.ShowMsg("لا يمكن حذف عنصر تم مراجعتة", true, this);
                    Program.Logger.LogThis("لا يمكن حذف عنصر تم مراجعتة", Text, FXFW.Logger.OpType.warning, null, null, this);
                    return;
                }
                if (!row.IsdateinNull() && row.datein.Date != SQLProvider.ServerDateTime().Date && Program.UserInfo.IsAdmin == false)
                {
                    msgDlg.Show("الحذف متاح في يوم الادخال فقط", msgDlg.msgButtons.Close);
                    return;
                }
                tblMemberAmanatTableAdapter.Delete(row.MMashatId, row.DofatSarfAId, row.amanattypeid);
                gridViewData.DeleteRow(GV.FocusedRowHandle);
                
                Program.ShowMsg("تم الحذف", false, this);
                Program.Logger.LogThis("تم الحذف", Text, FXFW.Logger.OpType.success, null, null, this);
            }
            catch (Exception ex)
            {
                Program.ShowMsg(Misc.Misc.ExceptionMessage(ex), true, this);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, ex, null, this);
            }
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            DataSources.dsRetirementCenter.TblMemberAmanatRow row = dsRetirementCenter.TblMemberAmanat.NewTblMemberAmanatRow();
            row.amanattypeid = (int)Program.cd_amanattype.amanat;
            row.estktaa = 0; row.sefa = "العضو";
            Update(row, false);
        }
        private void Update(DataSources.dsRetirementCenter.TblMemberAmanatRow row, bool DetailsTabFocus)
        {
            TblMemberAmanatWFrm frm;
            if (DetailsTabFocus)
                frm = new TblMemberAmanatWFrm(row, _Insert, _Update, _Delete);
            else
                frm = new TblMemberAmanatWFrm(row, _Insert, _Update, _Delete);
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
                return;

            try
            {
                bool newRecord = false;
                if (row.RowState == DataRowState.Detached)
                {
                    dsRetirementCenter.TblMemberAmanat.AddTblMemberAmanatRow(row);
                    newRecord = true;
                }
                tblMemberAmanatBindingSource.EndEdit();
                int effected = tblMemberAmanatTableAdapter.Update(row);
                if (effected == 0)
                {
                    Program.ShowMsg("لم يتم الحفظ", true, this, true);
                    Program.Logger.LogThis("لم يتم الحفظ", Text, FXFW.Logger.OpType.fail, null, null, this);
                }
                else
                {
                    if (newRecord && !row.sarfcheek)
                        frm.UpdateActive();
                    dsRetirementCenter.TblMemberAmanat.AcceptChanges();
                    Program.ShowMsg("تم الحفظ", false, this, true);
                    Program.Logger.LogThis("تم الحفظ", Text, FXFW.Logger.OpType.success, null, null, this);
                    btnNew_Click(btnNew, EventArgs.Empty);
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("is already present."))
                {
                    Program.ShowMsg("لم نتمكن من الحفظ ... موجود مسبقا", true, this, true);
                }
                Program.ShowMsg(Misc.Misc.ExceptionMessage(ex), true, this);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, ex, null, this);
            }
        }
        private void repositoryItemButtonEditAccReview_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            
            GridView GV = (GridView)gridControlData.MainView;
            DataSources.dsRetirementCenter.TblMemberAmanatRow row = (DataSources.dsRetirementCenter.TblMemberAmanatRow)GV.GetFocusedDataRow();
            if (!row.IsaccReviewNull() && row.accReview)
            {
                msgDlg.Show("تم معاينة الحسابات مسبقا", msgDlg.msgButtons.Close);
                return;
            }
            if (msgDlg.Show("هل انت متأكد؟", msgDlg.msgButtons.YesNo) == System.Windows.Forms.DialogResult.No)
                return;
            row.accReview = true;
            row.dateReview = SQLProvider.ServerDateTime();
            row.useracc = Program.UserInfo.UserId;
            tblMemberAmanatBindingSource.EndEdit();

            TblMemberAmanatWFrm frm = new TblMemberAmanatWFrm(row, _Insert, _Update, _Delete);
            if (!row.sarfcheek)
                frm.UpdateActive();
            tblMemberAmanatTableAdapter.Update(row);
            Program.ShowMsg("تم الحفظ", false, this, true);
            Program.Logger.LogThis("تم الحفظ", Text, FXFW.Logger.OpType.success, null, null, this);
        }
        #endregion

       

    }
}