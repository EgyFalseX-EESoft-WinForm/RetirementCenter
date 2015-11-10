using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace RetirementCenter.Forms.Data
{
    public partial class TBLHafzaTasleemAddFrm : DevExpress.XtraEditors.XtraForm
    {
        DataSources.Linq.dsTeachersUnionViewsDataContext dsLinq = new DataSources.Linq.dsTeachersUnionViewsDataContext();
        DataSources.dsRetirementCenterTableAdapters.TBLHafzaTasleemTableAdapter adp = new DataSources.dsRetirementCenterTableAdapters.TBLHafzaTasleemTableAdapter();

        public TBLHafzaTasleemAddFrm()
        {
            InitializeComponent();
            
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                DataSources.Linq.vQry81 row = (DataSources.Linq.vQry81)luehafza.Properties.View.GetRow(luehafza.Properties.View.FocusedRowHandle);

                adp.Insert(Convert.ToByte(luetasleemtype.EditValue), (int)row.hafza, Convert.ToInt32(lueSyndicateId.EditValue), (int)row.Num, Convert.ToInt32(tbcountrealy.EditValue)
                , Convert.ToInt32(lueMandoopId.EditValue), (DateTime)detasleemdate.EditValue, Program.UserInfo.UserId, SQLProvider.ServerDateTime());
                Program.ShowMsg("تم الحفظ", false, this, true);
                Program.Logger.LogThis("تم الحفظ", Text, FXFW.Logger.OpType.success, null, null, this);
                DialogResult = System.Windows.Forms.DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                Program.ShowMsg(ex.Message, true, this, true);
                Program.Logger.LogThis(ex.Message, Text, FXFW.Logger.OpType.fail, ex, null, this);
            }
        }

        private void TBLHafzaTasleemAddFrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsQueries.CDSyndicate' table. You can move, or remove it, as needed.
            this.cDSyndicateTableAdapter.Fill(this.dsQueries.CDSyndicate);
            // TODO: This line of code loads data into the 'dsQueries.CDMashHala' table. You can move, or remove it, as needed.
            this.cDMashHalaTableAdapter.Fill(this.dsQueries.CDMashHala);

            detasleemdate.EditValue = SQLProvider.ServerDateTime();
        }
        private void lue_EditValueChanged(object sender, EventArgs e)
        {
            if (luetasleemtype.EditValue == null || lueSyndicateId.EditValue == null)
                return;
            LSMSDATA.QueryableSource = from q in dsLinq.vQry81s where q.Type == Convert.ToInt32(luetasleemtype.EditValue) && q.SyndicateId == Convert.ToInt32(lueSyndicateId.EditValue) select q;
            this.tBLMandoopTableAdapter.FillBySyndicateId(this.dsRetirementCenter.TBLMandoop, Convert.ToInt32(lueSyndicateId.EditValue));
            //LSMSDATA.Reload();
        }
        private void luehafza_EditValueChanged(object sender, EventArgs e)
        {
            if (luehafza.EditValue == null)
                return;
            DataSources.Linq.vQry81 row = (DataSources.Linq.vQry81)luehafza.Properties.View.GetRow(luehafza.Properties.View.FocusedRowHandle);
            tbcountindata.EditValue = row.Num;
            tbcountrealy.EditValue = row.Num;
        }

    }
}