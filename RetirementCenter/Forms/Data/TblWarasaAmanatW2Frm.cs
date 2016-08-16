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
    public partial class TblWarasaAmanatW2Frm : DevExpress.XtraEditors.XtraForm
    {
        DataSources.dsRetirementCenter.TblWarasaAmanatRow _row;
        DataSources.Linq.dsTeachersUnionViewsDataContext dsLinq = new DataSources.Linq.dsTeachersUnionViewsDataContext();
        DataSources.dsRetirementCenterTableAdapters.tblWarasabankTableAdapter adpBank = new DataSources.dsRetirementCenterTableAdapters.tblWarasabankTableAdapter();
        bool IsBinding = false;
        bool _Insert, _Update, _Delete;
        public TblWarasaAmanatW2Frm()
        {
            InitializeComponent();
            //LSMSTBLWarasa.KeyExpression = "AutoId";
            //this.LSMSTBLWarasa.ElementType = typeof(RetirementCenter.DataSources.Linq.vtblWarasabank);
            //LSMSTBLWarasa.QueryableSource = from q in dsLinq.vtblWarasabank2s where q.amanatmony > 0 select q;
        }
        public TblWarasaAmanatW2Frm(DataSources.dsRetirementCenter.TblWarasaAmanatRow row, bool insert, bool update, bool delete)
        {
            InitializeComponent();
            //LSMSTBLWarasa.KeyExpression = "AutoId";
            //this.LSMSTBLWarasa.ElementType = typeof(RetirementCenter.DataSources.Linq.vtblWarasabank);
            //LSMSTBLWarasa.QueryableSource = from q in dsLinq.vtblWarasabank2s where q.amanatmony > 0 select q;
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
                //FillWarasaData();
            }
            if (!_row.IsNull("PersonId"))
            {
                //IsBinding = true;
                luePersonId.EditValue = _row.PersonId;
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
                lueDofatSarfId.EditValue = _row.DofatSarfId;
            if (!_row.IsNull("amanattypeid"))
                lueamanattypeid.EditValue = _row.amanattypeid;
        }
        
        private void FillFromWarasaBank()
        {
            tbamanatmony.EditValue = 0;
            tbestktaa.EditValue = 0;
            //double? money = Convert.ToDouble(adpBank.GetSummonyByID(Convert.ToInt32(lueDofatSarfAId.EditValue), Convert.ToInt32(luePersonId.EditValue)));
            //if (money == null)
            //    return;
            RetirementCenter.Forms.Data.TblWarasaAmanatWGridFrm dlg = new Forms.Data.TblWarasaAmanatWGridFrm(Convert.ToInt32(luePersonId.EditValue), Convert.ToInt32(lueDofatSarfAId.EditValue));
            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
                return;
            tbamanatmony.EditValue = dlg.Amount;
            tbestktaa.EditValue = 0;
            tbsefa.EditValue = "العضو";
        }
        private void FormWFrm_Load(object sender, EventArgs e)
        {
            IsBinding = true;
            LSMSTBLWarasa.QueryableSource = from q in dsLinq.vTBLWarasa_TBLMashats where q.responsiblesarf == true select q;
            LSMSDofatSarfId.QueryableSource = from q in dsLinq.TBLDofatSarfs where q.dofclosed == false select q;
            LSMScd_amanattype.QueryableSource = dsLinq.cd_amanattypes;
            // TODO: This line of code loads data into the 'dsRetirementCenter.CdDofaatAmanat' table. You can move, or remove it, as needed.
            this.cdDofaatAmanatTableAdapter.Fill(this.dsRetirementCenter.CdDofaatAmanat);
            ActivePriv();
            if (_row.RowState != DataRowState.Detached)
            { }
            LoadBinding();

            IsBinding = false;
        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (lueDofatSarfId.EditValue == null || lueDofatSarfId.EditValue.ToString() == string.Empty)
            {
                msgDlg.Show("يجب اختيار الدفعه", msgDlg.msgButtons.Close);
                return;
            }
            if (new DataSources.dsQueriesTableAdapters.QueriesTableAdapter().CheckExistsTBLWarasaSarf_arshefbyPrama(Convert.ToInt32(lueDofatSarfId.EditValue), Convert.ToInt32(luePersonId.EditValue)) == null)
                msgDlg.Show("عليك مراجعة اعادة الصرف للوريث", msgDlg.msgButtons.Close);
            
            if (lueDofatSarfAId.EditValue != null)
                _row.DofatSarfAId = Convert.ToInt32(lueDofatSarfAId.EditValue);
            if (luePersonId.EditValue != null)
                _row.PersonId = Convert.ToInt32(luePersonId.EditValue);
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
            if (lueamanattypeid.EditValue != null)
                _row.amanattypeid = Convert.ToByte(lueamanattypeid.EditValue);
            _row.datein = SQLProvider.ServerDateTime();
            _row.userin = Program.UserInfo.UserId;

            if (lueDofatSarfId.EditValue != null && lueDofatSarfId.EditValue.ToString() != string.Empty)
            {
                _row.DofatSarfId = Convert.ToInt32(lueDofatSarfId.EditValue);
                var result = SQLProvider.adpQry.ExistsTblWarasaAmanat1(_row.PersonId, _row.DofatSarfId);
                if (result != null && (int)result != _row.AutoId)
                {
                    msgDlg.Show("موجود مسبقا", msgDlg.msgButtons.Close);
                    return;
                }
            }
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
        private void luePersonId_EditValueChanged(object sender, EventArgs e)
        {
            if (IsBinding)
                return;
            if (luePersonId.EditValue != null)
            {
                object obj = luePersonId.GetSelectedDataRow();
                if (obj != null)
                {
                    if (obj.GetType() == typeof(RetirementCenter.DataSources.Linq.vtblWarasabank2))
                        tbmostahek.EditValue = "ورثة - " + ((RetirementCenter.DataSources.Linq.vtblWarasabank2)obj).MMashatName;
                    else
                        tbmostahek.EditValue = "ورثة - " + ((RetirementCenter.DataSources.Linq.vTBLWarasa_TBLMashat)obj).MMashatName;
                }
            }
            if (ceamantvisa.Checked && lueDofatSarfAId.EditValue != null && luePersonId.EditValue != null && lueDofatSarfAId.EditValue.ToString() != string.Empty && luePersonId.EditValue.ToString() != string.Empty)
            {
                FillFromWarasaBank();
            }
        }
        private void lueDofatSarfAId_EditValueChanged(object sender, EventArgs e)
        {
            if (IsBinding)
                return;
            if (ceamantvisa.Checked && lueDofatSarfAId.EditValue != null && luePersonId.EditValue != null && lueDofatSarfAId.EditValue.ToString() != string.Empty && luePersonId.EditValue.ToString() != string.Empty)
            {
                FillFromWarasaBank();
            }
        }
        private void ceamantvisa_CheckedChanged(object sender, EventArgs e)
        {
            tbamanatmony.Properties.ReadOnly = ceamantvisa.Checked;
            //tbestktaa.Properties.ReadOnly = ceamantvisa.Checked;
            tbmostahek.Properties.ReadOnly = ceamantvisa.Checked;
            tbsefa.Properties.ReadOnly = ceamantvisa.Checked;
            if (ceamantvisa.Checked)
            {
                LSMSTBLWarasa.KeyExpression = "";
                this.LSMSTBLWarasa.ElementType = typeof(RetirementCenter.DataSources.Linq.vtblWarasabank2);
                LSMSTBLWarasa.QueryableSource = from q in dsLinq.vtblWarasabank2s where q.amanatmony > 0 select q;
                luePersonId.Properties.ValueMember = "responsiblesarfId";
                LSMSTBLWarasa.KeyExpression = "AutoId";
                
                //FillFromWarasaBank();
            }
            else
            {
                LSMSTBLWarasa.KeyExpression = "";
                this.LSMSTBLWarasa.ElementType = typeof(RetirementCenter.DataSources.Linq.vTBLWarasa_TBLMashat);
                LSMSTBLWarasa.QueryableSource = from q in dsLinq.vTBLWarasa_TBLMashats where q.responsiblesarf == true select q;
                luePersonId.Properties.ValueMember = "PersonId";
                LSMSTBLWarasa.KeyExpression = "PersonId";
            }

        }
        
       
    }
}
