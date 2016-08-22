using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace RetirementCenter.Forms.Data
{
    public partial class BankExportedDataWarsaActivateFrm : DevExpress.XtraEditors.XtraForm
    {
        DataSources.Linq.dsTeachersUnionViewsDataContext dsLinq = new DataSources.Linq.dsTeachersUnionViewsDataContext() { ObjectTrackingEnabled = false };
        DataSources.dsQueriesTableAdapters.QueriesTableAdapter adpQry = new DataSources.dsQueriesTableAdapters.QueriesTableAdapter();

        public BankExportedDataWarsaActivateFrm()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            
            LSMS.QueryableSource = from q in dsLinq.vBankExportedDataWarsa_Activates where q.visa != string.Empty select q;
            LSMSSn.QueryableSource = dsLinq.CDSyndicates;
            LSMSSub.QueryableSource = dsLinq.CDSubCommittes;
            LSMSUser.QueryableSource = dsLinq.Users;
        }
        private void ReloadData()
        {
            LSMS.Reload();
        }
        private void DofatSarfActivityFrm_Load(object sender, EventArgs e)
        {
            
        }
        private void repositoryItemButtonEditTransferSave_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DataSources.Linq.vBankExportedDataWarsa_Activate row = (DataSources.Linq.vBankExportedDataWarsa_Activate)gridViewData.GetRow(gridViewData.FocusedRowHandle);
            DateTime ServerDatetime = SQLProvider.ServerDateTime();
            try
            {
                bool Active = false;
                if (row.Activate != null)
                    Active = (bool)row.Activate;
                if (Active)
                {
                    if (msgDlg.Show("انت علي وشك الغاء التفعيل" + Environment.NewLine + "هل انت متأكد؟", msgDlg.msgButtons.YesNo) == System.Windows.Forms.DialogResult.No)
                        return;
                    adpQry.Update_BankExportedDataWarsa_Active(!Active, Program.UserInfo.UserId, null, row.PersonId);
                }
                else
                    adpQry.Update_BankExportedDataWarsa_Active(!Active, Program.UserInfo.UserId, ServerDatetime, row.PersonId);
                ReloadData();
                //Program.ShowMsg("تم التعديل", false, this, true);
                Program.Logger.LogThis("تم التعديل", Text, FXFW.Logger.OpType.success, null, null, this);
            }
            catch (SqlException ex)
            {
                Program.ShowMsg(FXFW.SqlDB.CheckExp(ex), true, this, true);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, null, ex, this);
            }
        }
        private void lueSyn_EditValueChanged(object sender, EventArgs e)
        {
            if (lueSyn.EditValue != null)
            {
                LSMSSub.QueryableSource = from q in dsLinq.CDSubCommittes where q.SyndicateId == Convert.ToInt32(lueSyn.EditValue) select q;
            }
        }
        private void btnActive_Click(object sender, EventArgs e)
        {
            if (dxvp.Validate() == false)
                return;
            int Hafza;
            if (int.TryParse(tbHafza.EditValue.ToString(), out Hafza) == false)
            {
                Program.ShowMsg("يجب ادخال رقم في الحافظة", true, this, true);
                return;
            }
            int result = adpQry.Update_BankExportedDataWarsa_Active_ByHafza(true, Program.UserInfo.UserId, Convert.ToInt32(lueSyn.EditValue), Convert.ToInt32(lueSub.EditValue), Convert.ToInt32(tbHafza.EditValue));
            if (result > 0)
            {
                ReloadData();
                Program.ShowMsg("تم التعديل" + Environment.NewLine + result.ToString(), false, this, true);
                Program.Logger.LogThis("تم التعديل" + Environment.NewLine + result.ToString(), Text, FXFW.Logger.OpType.success, null, null, this);
            }
            else
            {
                Program.ShowMsg("لم يتم التعديل", true, this, true);
            }
        }
        private void BankExportedDataWarsaActivateFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            adpQry.Update_TBLWarasa_Active();
        }
    }
}