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
    public partial class VerifyWarasaFrm : DevExpress.XtraEditors.XtraForm
    {
        DataSources.Linq.dsTeachersUnionViewsDataContext dsLinq = new DataSources.Linq.dsTeachersUnionViewsDataContext();

        public VerifyWarasaFrm()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            LSMSCDSyndicate.QueryableSource = dsLinq.CDSyndicates;
            LSMSCDSubCommitte.QueryableSource = dsLinq.CDSubCommittes;
            LSMSCDMashHala.QueryableSource = dsLinq.CDMashHalas;
            ReloadData();
        }
        private void ReloadData()
        {
            this.tBLMashatTableAdapter.FillByUnverifedWarasa(this.dsRetirementCenter.TBLMashat);
            gridViewData.RefreshData();
        }
        private void DofatSarfActivityFrm_Load(object sender, EventArgs e)
        {
           
        }
        private void repositoryItemButtonEditTransferSave_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DataSources.dsRetirementCenter.TBLMashatRow row = (DataSources.dsRetirementCenter.TBLMashatRow)((DataRowView)gridViewData.GetRow(gridViewData.FocusedRowHandle)).Row;
            try
            {
                row.EndEdit();
                if (row["verify_warasa", DataRowVersion.Default] != row["verify_warasa", DataRowVersion.Original])
                {
                    row.verify_warasa_datein = SQLProvider.ServerDateTime();
                    row.verify_warasa_userin = Program.UserInfo.UserId;
                }
                tBLMashatTableAdapter.Update(row);
                Program.ShowMsg("تم التعديل", false, this, true);
                Program.Logger.LogThis("تم التعديل", Text, FXFW.Logger.OpType.success, null, null, this);
                ReloadData();
            }
            catch (SqlException ex)
            {
                Program.ShowMsg(FXFW.SqlDB.CheckExp(ex), true, this, true);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, null, ex, this);
            }
        }

    }
}