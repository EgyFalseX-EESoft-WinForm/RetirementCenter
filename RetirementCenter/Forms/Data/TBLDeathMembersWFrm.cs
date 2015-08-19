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
            lueSyn.EditValue = adpQ.GetSynForMM(_row.MMashatId);
            lueMMashatId.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", _row, "MMashatId", true));
            dedeathdate.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", _row, "deathdate", true));
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
            DialogResult = System.Windows.Forms.DialogResult.OK;
            _row.datein = SQLProvider.ServerDateTime();
            _row.userin = Program.UserInfo.UserId;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
       
    }
}
