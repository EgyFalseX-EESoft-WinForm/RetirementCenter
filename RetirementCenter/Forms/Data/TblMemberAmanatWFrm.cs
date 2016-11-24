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
        DataSources.dsRetirementCenterTableAdapters.tblmemberbankTableAdapter adpBank = new DataSources.dsRetirementCenterTableAdapters.tblmemberbankTableAdapter();
        DataSources.dsQueriesTableAdapters.QueriesTableAdapter adpQ = new DataSources.dsQueriesTableAdapters.QueriesTableAdapter();
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
                //IsBinding = true;
                lueMMashatId.EditValue = _row.MMashatId;
                //IsBinding = false;
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
            if (!_row.IsNull("amantvisa"))
                ceamantvisa.EditValue = _row.amantvisa;
            else
                ceamantvisa.Checked = false;
            if (!_row.IsNull("sarfcheek"))
                cesarfcheek.EditValue = _row.sarfcheek;
            else
                cesarfcheek.Checked = false;
            if (!_row.IsNull("DofatSarfId"))
            {
                lueDofatSarfId.EditValue = _row.DofatSarfId;
            }
            
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
        private void FillFromMemberBank()
        {
            if (IsBinding)
                return;
            tbamanatmony.EditValue = 0;
            tbestktaa.EditValue = 0;
            //DataSources.dsRetirementCenter.tblmemberbankDataTable tbl = adpBank.GetDataByID(Convert.ToInt32(lueMMashatId.EditValue), Convert.ToInt32(lueDofatSarfAId.EditValue));
            //if (tbl.Rows.Count == 0)
            //    return;
            RetirementCenter.Forms.Data.TblMemberAmanatWGridFrm dlg = new Forms.Data.TblMemberAmanatWGridFrm(Convert.ToInt32(lueMMashatId.EditValue), Convert.ToInt32(lueDofatSarfAId.EditValue));
            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
                return;
            tbamanatmony.EditValue = dlg.Amount;
            tbestktaa.EditValue = 0;
            tbsefa.EditValue = "الغضو";
        }
        private void FormWFrm_Load(object sender, EventArgs e)
        {
            IsBinding = true;
            LSMSDofatSarfId.QueryableSource = from q in dsLinq.CdDofaatAmanats where q.Closed == false select q;
            // TODO: This line of code loads data into the 'dsRetirementCenter.CdDofaatAmanat' table. You can move, or remove it, as needed.
            this.cdDofaatAmanatTableAdapter.Fill(this.dsRetirementCenter.CdDofaatAmanat);
            ActivePriv();

            if (_row.RowState != DataRowState.Detached)
            {

            }
            FillMemberData();
            LoadBinding();
            IsBinding = false;
            //lueMMashatId.EditValueChanged += lueMMashatId_EditValueChanged;
            //lueDofatSarfAId.EditValueChanged += lueDofatSarfAId_EditValueChanged;
            //RetirementCenter.DataSources.Linq.vTBLMashat01_V1 aaa;
        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (lueDofatSarfId.EditValue == null || lueDofatSarfId.EditValue.ToString() == string.Empty || lueDofatSarfAId.EditValue == null || lueDofatSarfAId.EditValue.ToString() == string.Empty)
            {
                msgDlg.Show("يجب اختيار الدفعه", msgDlg.msgButtons.Close);
                return;
            }
            
            if (new DataSources.dsQueriesTableAdapters.QueriesTableAdapter().CheckExistsTBLMemberSarf_arshefbyPrama(Convert.ToInt32(lueDofatSarfId.EditValue), Convert.ToInt32(lueMMashatId.EditValue)) == null)
                msgDlg.Show("عليك مراجعة اعادة الصرف للعضو", msgDlg.msgButtons.Close);

            DateTime serverDateTime = SQLProvider.ServerDateTime();

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
            _row.amantvisa = ceamantvisa.Checked;
            _row.sarfcheek = cesarfcheek.Checked;

            if (lueDofatSarfId.EditValue != null && lueDofatSarfId.EditValue.ToString() != string.Empty)
            {
                _row.DofatSarfId = Convert.ToInt32(lueDofatSarfId.EditValue);
                var result = SQLProvider.adpQry.ExistsTblMemberAmanat1(_row.MMashatId, _row.DofatSarfId);
                if (result != null && (int)result != _row.AutoId)
                {
                    msgDlg.Show("موجود مسبقا", msgDlg.msgButtons.Close);
                    return;
                }
            }

            if (ceamantvisa.Checked && Convert.ToInt32(lueDofatSarfAId.EditValue) > 7)// we should it acc reviewed if this condition active
            {
                _row.accReview = true;
                _row.useracc = Program.UserInfo.UserId;
                _row.dateReview = serverDateTime;
            }

            _row.datein = serverDateTime;
            _row.userin = Program.UserInfo.UserId;


            DialogResult = System.Windows.Forms.DialogResult.OK;
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
                
                var qry = from q in dsLinq.TBLMashats where q.MMashatId == row.MMashatId select q;
                foreach (DataSources.Linq.TBLMashat item in qry)
                {
                    if (item.MashHalaId == (byte)Program.CDMashHala.Warasa)
                    {
                        cesarfcheek.Checked = true;
                        cesarfcheek.Properties.ReadOnly = true;
                    }
                    else
                    {
                        cesarfcheek.Checked = false;
                        cesarfcheek.Properties.ReadOnly = false;
                    }
                }
            }
            if (ceamantvisa.Checked && lueDofatSarfAId.EditValue != null && lueMMashatId.EditValue != null && lueDofatSarfAId.EditValue.ToString() != string.Empty && lueMMashatId.EditValue.ToString() != string.Empty)
            {
                FillFromMemberBank();
            }

        }
        private void lueDofatSarfAId_EditValueChanged(object sender, EventArgs e)
        {
            if (ceamantvisa.Checked && lueDofatSarfAId.EditValue != null && lueMMashatId.EditValue != null && lueDofatSarfAId.EditValue.ToString() != string.Empty && lueMMashatId.EditValue.ToString() != string.Empty)
            {
                FillFromMemberBank();
            }
        }
        private void ceamantvisa_CheckedChanged(object sender, EventArgs e)
        {
            tbamanatmony.Properties.ReadOnly = ceamantvisa.Checked;
            //tbestktaa.Properties.ReadOnly = ceamantvisa.Checked;
            tbmostahek.Properties.ReadOnly = ceamantvisa.Checked;
            tbsefa.Properties.ReadOnly = ceamantvisa.Checked;
            if (ceamantvisa.Checked && lueDofatSarfAId.EditValue != null && lueMMashatId.EditValue != null && lueDofatSarfAId.EditValue.ToString() != string.Empty && lueMMashatId.EditValue.ToString() != string.Empty)
            {
                FillFromMemberBank();
            }

        }
        public void UpdateActive()
        {
            DataSources.dsRetirementCenter.TBLMashatDataTable tbl = new DataSources.dsRetirementCenter.TBLMashatDataTable();
            DataSources.dsRetirementCenterTableAdapters.TBLMashatTableAdapter adp = new DataSources.dsRetirementCenterTableAdapters.TBLMashatTableAdapter();
            adp.FillByMMashatId(tbl, _row.MMashatId);
            if (ceamantvisa.Checked && Convert.ToInt32(lueDofatSarfAId.EditValue) > 7 && tbl[0].MashHalaId == (byte)Program.CDMashHala.Asda2)// we should it acc reviewed if this condition active
            {
                int result1 = new DataSources.dsQueriesTableAdapters.QueriesTableAdapter().Update_TblMashat_Active_yasref_byID_ForAmanat(_row.MMashatId, Program.UserInfo.UserId);
            }
        }
       
    }
}
