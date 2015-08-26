using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using System.Linq;

namespace RetirementCenter
{
    public partial class TBLDeathMembersWFrm : DevExpress.XtraEditors.XtraForm
    {
        DataSources.dsRetirementCenter.TBLDeathMembersRow _row;
        DataSources.Linq.dsTeachersUnionViewsDataContext dsLinq = new DataSources.Linq.dsTeachersUnionViewsDataContext();
        DataSources.dsQueriesTableAdapters.QueriesTableAdapter adpQ = new DataSources.dsQueriesTableAdapters.QueriesTableAdapter();
        DataSources.dsRetirementCenterTableAdapters.TBLMashatTableAdapter adpTBLMashat = new DataSources.dsRetirementCenterTableAdapters.TBLMashatTableAdapter();
        
        bool _Insert, _Update, _Delete;
        public TBLDeathMembersWFrm()
        {
            InitializeComponent();
        }
        public TBLDeathMembersWFrm(DataSources.dsRetirementCenter.TBLDeathMembersRow row, bool insert, bool update, bool delete)
        {
            InitializeComponent();
            _row = row;
            _Insert = insert;
            _Update = update;
            _Delete = delete;

            LSMSSyn.QueryableSource = from q in dsLinq.CDSyndicates select q;
        }
        private void ActivePriv()
        {
        }
        private void LoadBinding()
        {
            if (_row.IsmosthhekNidNull())
                _row.mosthhekNid = string.Empty;
            if (_row.IsNull("mosthhekmony"))
                _row.mosthhekmony = 0;

            lueSyn.EditValue = adpQ.GetSynForMM(_row.MMashatId);
            lueMMashatId.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", _row, "MMashatId", true));
            dedeathdate.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", _row, "deathdate", true));
            tbmosthhekNid.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", _row, "mosthhekNid", true));
            tbmosthhekmony.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", _row, "mosthhekmony", true));
            tbmosthhek.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", _row, "mosthhek", true));
        }
        private void FormWFrm_Load(object sender, EventArgs e)
        {
            ActivePriv();
            LoadBinding();
        }
        private void lueDofatSarfAId_EditValueChanged(object sender, EventArgs e)
        {
            if (lueSyn.EditValue == null || lueSyn.EditValue.ToString() == string.Empty)
                return;
            LSMSTBLMashat.QueryableSource = from q in dsLinq.vTBLMashats where q.SyndicateId == Convert.ToInt32(lueSyn.EditValue) select q;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (lueMMashatId.EditValue == null)
                return;
            int MMashatId = Convert.ToInt32(lueMMashatId.EditValue);
            DateTime ServerDatetime = SQLProvider.ServerDateTime();
            DataSources.dsRetirementCenter.TBLMashatDataTable Tbl = adpTBLMashat.GetDataByMMashatId(MMashatId);
            if (Tbl[0].yasref && Tbl[0].MashHalaId == (byte)Program.CDMashHala.Asda2)
            {
                DataSources.dsRetirementCenterTableAdapters.TBLNoSarfDetelsTableAdapter adp = new DataSources.dsRetirementCenterTableAdapters.TBLNoSarfDetelsTableAdapter();
                int result = adp.Insert(MMashatId, false, ServerDatetime, "ايقاف للتسجيل في اعانة الوفاة", ServerDatetime, Program.UserInfo.UserId);
                if (result == 1)
                    adpTBLMashat.UpdateQueryYasref(false, ServerDatetime, Program.UserInfo.UserId, MMashatId);
            }

            DialogResult = System.Windows.Forms.DialogResult.OK;
            _row.datein = SQLProvider.ServerDateTime();
            _row.userin = Program.UserInfo.UserId;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
        private void lueMMashatId_EditValueChanged(object sender, EventArgs e)
        {
            lblMemType.Text = string.Empty; ceYasref.Checked = false;
            if (lueMMashatId.EditValue == null)
            {
                return;
            }
            lblMemType.Text = adpQ.GetMashHalaByMMashatId(Convert.ToInt32(lueMMashatId.EditValue));
            ceYasref.Checked = (bool)adpQ.GetYasrefByMMashatId(Convert.ToInt32(lueMMashatId.EditValue));
        }
       
    }
}
