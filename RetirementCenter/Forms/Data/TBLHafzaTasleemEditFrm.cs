using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace RetirementCenter.Forms.Data
{
    public partial class TBLHafzaTasleemEditFrm : DevExpress.XtraEditors.XtraForm
    {
        DataSources.Linq.dsTeachersUnionViewsDataContext dsLinq = new DataSources.Linq.dsTeachersUnionViewsDataContext();
        DataSources.dsRetirementCenterTableAdapters.TBLHafzaTasleemTableAdapter adp = new DataSources.dsRetirementCenterTableAdapters.TBLHafzaTasleemTableAdapter();
        DataSources.dsQueriesTableAdapters.QueriesTableAdapter adpQry = new DataSources.dsQueriesTableAdapters.QueriesTableAdapter();
        int _id = 0;
        int _hafza = 0; int _count = 0;

        public TBLHafzaTasleemEditFrm(int id)
        {
            InitializeComponent();
            _id = id;
            //LSMSDATA.QueryableSource = dsLinq.vQry81s;

            DataSources.dsRetirementCenter.TBLHafzaTasleemRow row = adp.GetDataByID(_id)[0];
            luetasleemtype.EditValue = row.tasleemtype;
            luehafza.EditValue = row.hafza;
            lueSyndicateId.EditValue = row.SyndicateId;
            tbcountrealy.EditValue = row.countrealy;
            lueMandoopId.EditValue = row.MandoopId;
            detasleemdate.EditValue = row.tasleemdate;
            tbcountindata.EditValue = row.countindata;

            _hafza = row.hafza;
            _count = row.countindata;

            // TODO: This line of code loads data into the 'dsRetirementCenter.TBLMandoop' table. You can move, or remove it, as needed.
            this.tBLMandoopTableAdapter.FillBySyndicateId(this.dsRetirementCenter.TBLMandoop, row.SyndicateId);
        }
        private void TBLHafzaTasleemAddFrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsQueries.CDSyndicate' table. You can move, or remove it, as needed.
            this.cDSyndicateTableAdapter.Fill(this.dsQueries.CDSyndicate);
            // TODO: This line of code loads data into the 'dsQueries.CDMashHala' table. You can move, or remove it, as needed.
            this.cDMashHalaTableAdapter.Fill(this.dsQueries.CDMashHala);
        }
        
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                //DataSources.Linq.vQry81 row = (DataSources.Linq.vQry81)luehafza.Properties.View.GetRow(luehafza.Properties.View.FocusedRowHandle);
                adp.Update(_count, Convert.ToInt32(tbcountrealy.EditValue), Convert.ToInt32(lueMandoopId.EditValue), Convert.ToDateTime(detasleemdate.EditValue), Program.UserInfo.UserId
                    , SQLProvider.ServerDateTime(), Convert.ToByte(luetasleemtype.EditValue), _hafza, Convert.ToInt32(lueSyndicateId.EditValue));
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
        
    }
}