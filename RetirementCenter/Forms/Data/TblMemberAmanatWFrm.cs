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
    public partial class TblMemberAmanatWFrm : DevExpress.XtraEditors.XtraForm
    {
        DataSources.dsRetirementCenter.TblMemberAmanatRow _row;
        DataSources.Linq.dsTeachersUnionViewsDataContext dsLinq = new DataSources.Linq.dsTeachersUnionViewsDataContext();
        bool IsBinding = false;
        bool _Insert, _Update, _Delete;
        public TblMemberAmanatWFrm()
        {
            InitializeComponent();
        }
        public TblMemberAmanatWFrm(DataSources.dsRetirementCenter.TblMemberAmanatRow row, bool insert, bool update, bool delete)
        {
            InitializeComponent();
            _row = row;
            _Insert = insert;
            _Update = update;
            _Delete = delete;
        }
        private void ActivePriv()
        {
        }
        private void LoadBinding()
        {
            if (!_row.IsNull("DofatSarfAId"))
            {
                lueDofatSarfAId.EditValue = _row.DofatSarfAId;
                //FillMemberData();
            }
            if (!_row.IsNull("MMashatId"))
            {
                IsBinding = true;
                lueMMashatId.EditValue = _row.MMashatId;
                IsBinding = false;
            }
            if (!_row.IsNull("amanatmony"))
                tbamanatmony.EditValue = _row.amanatmony;
            if (!_row.IsNull("amanatrem"))
                tbamanatrem.EditValue = _row.amanatrem;

            if (!_row.IsNull("estktaa"))
                tbestktaa.EditValue = _row.estktaa;
            if (!_row.IsNull("mostahek"))
                tbmostahek.EditValue = _row.mostahek;
            if (!_row.IsNull("sefa"))
                tbsefa.EditValue = _row.sefa;
        }
        private void FillMemberData()
        {
            this.LSMSTBLMashat.ElementType = typeof(RetirementCenter.DataSources.Linq.vTBLMashat01_V1);
            LSMSTBLMashat.QueryableSource = dsLinq.vTBLMashat01_V1s;
            //if (DofatSarfAId < 1)
            //{
                
            //}
            //else
            //{
            //    this.LSMSTBLMashat.ElementType = typeof(RetirementCenter.DataSources.Linq.vTBLMashat01_V2);
            //    LSMSTBLMashat.QueryableSource = from q in dsLinq.vTBLMashat01_V2s where q.DofatSarfId == DofatSarfAId select q;
            //}
        }
        private void FormWFrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsRetirementCenter.CdDofaatAmanat' table. You can move, or remove it, as needed.
            this.cdDofaatAmanatTableAdapter.Fill(this.dsRetirementCenter.CdDofaatAmanat);
            ActivePriv();

            if (_row.RowState != DataRowState.Detached)
            {

            }
            FillMemberData();
            LoadBinding();
        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;

            if (lueDofatSarfAId.EditValue != null)
                _row.DofatSarfAId = Convert.ToInt32(lueDofatSarfAId.EditValue);
            if (lueMMashatId.EditValue != null)
                _row.MMashatId = Convert.ToInt32(lueMMashatId.EditValue);
            if (tbamanatrem.EditValue != null)
                _row.amanatrem = tbamanatrem.EditValue.ToString();
            if (tbamanatmony.EditValue != null)
                _row.amanatmony = Convert.ToDouble(tbamanatmony.EditValue);
            if (tbestktaa.EditValue != null)
                _row.estktaa = Convert.ToDouble(tbestktaa.EditValue);
            if (tbmostahek.EditValue != null)
                _row.mostahek = tbmostahek.EditValue.ToString();
            if (tbsefa.EditValue != null)
                _row.sefa = tbsefa.EditValue.ToString();
            _row.datein = SQLProvider.ServerDateTime();
            _row.userin = Program.UserInfo.UserId;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void lueMMashatId_EditValueChanged(object sender, EventArgs e)
        {
            if (lueMMashatId.EditValue != null)
            {
                //RetirementCenter.DataSources.Linq.vTBLMashat01_V1
                RetirementCenter.DataSources.Linq.vTBLMashat01_V1 row = (RetirementCenter.DataSources.Linq.vTBLMashat01_V1)lueMMashatId.GetSelectedDataRow();
                tbmostahek.EditValue = row.MMashatName;
            }
            
        }
       
    }
}
