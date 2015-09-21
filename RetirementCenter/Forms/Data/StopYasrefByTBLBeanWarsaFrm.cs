using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace RetirementCenter.Forms.Data
{
    public partial class StopYasrefByTBLBeanWarsaFrm : DevExpress.XtraEditors.XtraForm
    {
        DataSources.dsQueriesTableAdapters.QueriesTableAdapter adpQry = new DataSources.dsQueriesTableAdapters.QueriesTableAdapter();
        public StopYasrefByTBLBeanWarsaFrm()
        {
            InitializeComponent();
            SQLProvider.SetAllCommandTimeouts(vQry65TableAdapter, 0);
            SQLProvider.SetAllCommandTimeouts(tBLDofatSarfTableAdapter, 0);
            SQLProvider.SetAllCommandTimeouts(adpQry, 0);
        }

        private void StopYasrefByTBLBeanWarsaFrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsQueries.CDSubCommitte' table. You can move, or remove it, as needed.
            this.cDSubCommitteTableAdapter.Fill(this.dsQueries.CDSubCommitte);
            // TODO: This line of code loads data into the 'dsQueries.TBLDofatSarf' table. You can move, or remove it, as needed.
            this.tBLDofatSarfTableAdapter.Fill(this.dsQueries.TBLDofatSarf);
            // TODO: This line of code loads data into the 'dsQueries.CDSyndicate' table. You can move, or remove it, as needed.
            this.cDSyndicateTableAdapter.Fill(this.dsQueries.CDSyndicate);

        }
        private void lue_EditValueChanged(object sender, EventArgs e)
        {
            if (sender == lueSyn)
                cDSubCommitteTableAdapter.FillBySyndicateId(dsQueries.CDSubCommitte, Convert.ToInt32(lueSyn.EditValue));
            if (lueSyn.EditValue == null || lueDof.EditValue == null)
            {
                return;
            }
            //int count = (int)adpQry.CountOfWarasaToStopYasrefByBean(Convert.ToInt32(lueSyn.EditValue), Convert.ToInt32(lueSub.EditValue), Convert.ToInt32(lueDof.EditValue));
            //lblCount.Text = count.ToString();
            vQry65TableAdapter.Fill(dsQueries.vQry65, Convert.ToInt32(lueSyn.EditValue), Convert.ToInt32(lueSub.EditValue), Convert.ToInt32(lueDof.EditValue));
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            if (lueSyn.EditValue == null || lueDof.EditValue == null)
            {
                msgDlg.Show("من فضلك اختر فرعية و دفعة", msgDlg.msgButtons.Close);
                return;
            }
            if (msgDlg.Show("هل انت متأكد؟", msgDlg.msgButtons.YesNo) == System.Windows.Forms.DialogResult.No)
                return;
            try
            {
                int count2 = adpQry.InsertIntoTBLNoSarfWarsaByBean(Program.UserInfo.UserId, Convert.ToInt32(lueSyn.EditValue), Convert.ToInt32(lueSub.EditValue), Convert.ToInt32(lueDof.EditValue));
                int count = adpQry.UpdateYasrefByBean(Convert.ToInt32(lueSyn.EditValue), Convert.ToInt32(lueSub.EditValue), Convert.ToInt32(lueDof.EditValue));
//                SqlConnection con = new SqlConnection(Properties.Settings.Default.RetirementCenterConnectionString);
//                SqlCommand cmd = new SqlCommand(string.Format(@"WITH CTE1 AS
//                (
//                SELECT        TBLMashat.MMashatId
//                FROM            TBLMashat
//                WHERE        (TBLMashat.MashHalaId = 2) AND (TBLMashat.yasref = 1) AND SyndicateId = {0} AND SubCommitteId = {1}
//                AND NOT EXISTS(SELECT TBLBeanWarsa.PersonId FROM TBLBeanWarsa INNER JOIN TBLWarasa ON TBLBeanWarsa.PersonId = TBLWarasa.PersonId
//                WHERE TBLWarasa.MMashatId = TBLMashat.MMashatId AND DofatSarfId = {2})
//                ) 
//                INSERT INTO TBLNoSarfWarsa ([PersonId], [yasref], [datehala], [halarem], [datein], [userin])
//                SELECT PersonId, 0, GETDATE(), 'تم الايقاف لعدم وجود بيان معاش', GETDATE(), 1
//                FROM TBLWarasa INNER JOIN CTE1 ON TBLWarasa.MMashatId = CTE1.MMashatId 
//                WHERE yasref = 1
//                AND NOT EXISTS(SELECT PersonId FROM [dbo].[TBLEdafatWarsa] WHERE [PersonId] = TBLWarasa.PersonId AND [DofatSarfId] = {2})
//                ", lueSyn.EditValue, lueSub.EditValue, lueDof.EditValue.ToString()), con) { CommandTimeout = 99 };
//                con.Open();
//                int count2 = cmd.ExecuteNonQuery();
//                con.Close(); con.Dispose(); cmd.Dispose(); con = null; cmd = null;
                
                msgDlg.Show("تم ايقاف " + count.ToString() + Environment.NewLine + "تم اضافة " + count2.ToString() + " بيان للايقاف", msgDlg.msgButtons.Close);
            }
            catch (Exception ex)
            {
                Program.ShowMsg(ex.Message, true, this, true);
                Program.Logger.LogThis(ex.Message, Text, FXFW.Logger.OpType.fail, ex, null, this);
            }
        }
    }
}