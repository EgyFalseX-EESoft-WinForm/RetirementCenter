﻿using System;
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
    public partial class TblWarasaAmanatWFrm : DevExpress.XtraEditors.XtraForm
    {
        DataSources.dsRetirementCenter.TblWarasaAmanatRow _row;
        DataSources.Linq.dsTeachersUnionViewsDataContext dsLinq = new DataSources.Linq.dsTeachersUnionViewsDataContext();
        DataSources.dsRetirementCenterTableAdapters.tblWarasabankTableAdapter adpBank = new DataSources.dsRetirementCenterTableAdapters.tblWarasabankTableAdapter();
        bool IsBinding = false;
        bool _Insert, _Update, _Delete;
        public TblWarasaAmanatWFrm()
        {
            InitializeComponent();
            //LSMSTBLWarasa.KeyExpression = "AutoId";
            //this.LSMSTBLWarasa.ElementType = typeof(RetirementCenter.DataSources.Linq.vtblWarasabank);
            //LSMSTBLWarasa.QueryableSource = from q in dsLinq.vtblWarasabank2s where q.amanatmony > 0 select q;
        }
        public TblWarasaAmanatWFrm(DataSources.dsRetirementCenter.TblWarasaAmanatRow row, bool insert, bool update, bool delete)
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
                IsBinding = true;
                luePersonId.EditValue = _row.PersonId;
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
        }
        
        private void FillFromWarasaBank()
        {
            tbamanatmony.EditValue = 0;
            tbestktaa.EditValue = 0;
            double? money = Convert.ToDouble(adpBank.GetSummonyByID(Convert.ToInt32(lueDofatSarfAId.EditValue), Convert.ToInt32(luePersonId.EditValue)));
            if (money == null)
                return;
            tbamanatmony.EditValue = money;
            tbestktaa.EditValue = 0;
            tbsefa.EditValue = "العضو";
        }
        private void FormWFrm_Load(object sender, EventArgs e)
        {
            LSMSTBLWarasa.QueryableSource = from q in dsLinq.vTBLWarasa_TBLMashats where q.responsiblesarf == true select q;
            LSMSDofatSarfId.QueryableSource = dsLinq.TBLDofatSarfs;
            // TODO: This line of code loads data into the 'dsRetirementCenter.CdDofaatAmanat' table. You can move, or remove it, as needed.
            this.cdDofaatAmanatTableAdapter.Fill(this.dsRetirementCenter.CdDofaatAmanat);
            ActivePriv();
            if (_row.RowState != DataRowState.Detached)
            { }
            LoadBinding();
        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;

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
            _row.datein = SQLProvider.ServerDateTime();
            _row.userin = Program.UserInfo.UserId;
            if (lueDofatSarfId.EditValue != null)
                _row.DofatSarfId = Convert.ToInt32(lueDofatSarfId.EditValue);
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
        private void luePersonId_EditValueChanged(object sender, EventArgs e)
        {
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
                LSMSTBLWarasa.KeyExpression = "AutoId";
                this.LSMSTBLWarasa.ElementType = typeof(RetirementCenter.DataSources.Linq.vtblWarasabank);
                LSMSTBLWarasa.QueryableSource = from q in dsLinq.vtblWarasabank2s where q.amanatmony > 0 select q;
                luePersonId.Properties.ValueMember = "responsiblesarfId";
                
                //FillFromWarasaBank();
            }
            else
            {
                LSMSTBLWarasa.KeyExpression = "PersonId";
                this.LSMSTBLWarasa.ElementType = typeof(RetirementCenter.DataSources.Linq.vTBLWarasa_TBLMashat);
                LSMSTBLWarasa.QueryableSource = from q in dsLinq.vTBLWarasa_TBLMashats where q.responsiblesarf == true select q;
                luePersonId.Properties.ValueMember = "PersonId";
            }

        }
        
       
    }
}
