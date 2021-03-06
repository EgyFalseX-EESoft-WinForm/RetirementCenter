﻿using System;
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
    public partial class TBLHafezSarfAddFrm : DevExpress.XtraEditors.XtraForm
    {
        DataSources.Linq.dsTeachersUnionViewsDataContext dsLinq = new DataSources.Linq.dsTeachersUnionViewsDataContext();
        DataSources.dsRetirementCenterTableAdapters.TBLHafezSarfTableAdapter adp = new DataSources.dsRetirementCenterTableAdapters.TBLHafezSarfTableAdapter();

        public TBLHafezSarfAddFrm()
        {
            InitializeComponent();
            
        }
        private void TBLHafzaTasleemAddFrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsQueries1.CDSubCommitte' table. You can move, or remove it, as needed.
            this.cDSubCommitteTableAdapter.Fill(dsQueries.CDSubCommitte);
            // TODO: This line of code loads data into the 'dsQueries.TBLDofatSarf' table. You can move, or remove it, as needed.
            this.tBLDofatSarfTableAdapter.Fill(dsQueries.TBLDofatSarf);
            // TODO: This line of code loads data into the 'dsQueries.CDSyndicate' table. You can move, or remove it, as needed.
            this.cDSyndicateTableAdapter.Fill(dsQueries.CDSyndicate);

            tbremarks.EditValue = string.Empty;
        }
        private void lue_EditValueChanged(object sender, EventArgs e)
        {
            if (lueSyndicateId.EditValue != null)
            {
                cDSubCommitteTableAdapter.FillBySyndicateId(dsQueries.CDSubCommitte, Convert.ToInt32(lueSyndicateId.EditValue));
            }
            if (lueDofatSarfId.EditValue == null || lueSyndicateId.EditValue == null)
                return;
            tbcountmembers.EditValue = SQLProvider.adpQry.Get_TBLHafezSarf_countmembers(Convert.ToInt32(lueSyndicateId.EditValue), Convert.ToInt32(lueSub.EditValue), Convert.ToInt32(lueDofatSarfId.EditValue));
            tbcountwarasa.EditValue = SQLProvider.adpQry.Get_TBLHafezSarf_countwarasa(Convert.ToInt32(lueSyndicateId.EditValue), Convert.ToInt32(lueSub.EditValue), Convert.ToInt32(lueDofatSarfId.EditValue));
            tbhafezmembers.EditValue = SQLProvider.adpQry.Get_TBLHafezSarf_hafezmembers(Convert.ToInt32(lueSyndicateId.EditValue), Convert.ToInt32(lueSub.EditValue), Convert.ToInt32(lueDofatSarfId.EditValue));
            tbhafezwarasa.EditValue = SQLProvider.adpQry.Get_TBLHafezSarf_hafezwarasa(Convert.ToInt32(lueSyndicateId.EditValue), Convert.ToInt32(lueSub.EditValue), Convert.ToInt32(lueDofatSarfId.EditValue));

            double total = Convert.ToDouble(tbhafezmembers.EditValue) + Convert.ToDouble(tbhafezwarasa.EditValue);

            tbhafezSubCommitte.EditValue = total / 6;
            tbhafezSyndicate.EditValue = total / 6;
            tbhafezets.EditValue = total / 3;
            tbhafeztec.EditValue = total / 3;

        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                adp.Insert(Convert.ToInt32(lueSyndicateId.EditValue), Convert.ToInt32(lueSub.EditValue), Convert.ToInt32(lueDofatSarfId.EditValue), Convert.ToInt32(tbcountmembers.EditValue), Convert.ToInt32(tbcountwarasa.EditValue)
                    , Convert.ToDouble(tbhafezmembers.EditValue), Convert.ToDouble(tbhafezwarasa.EditValue)
                    , Convert.ToDouble(tbhafezSubCommitte.EditValue), Convert.ToDouble(tbhafezSyndicate.EditValue)
                    , Convert.ToDouble(tbhafezets.EditValue), Convert.ToDouble(tbhafeztec.EditValue)
                    , Convert.ToDouble(tbmaden.EditValue), Convert.ToDouble(tbdaen.EditValue)
                    , tbremarks.EditValue.ToString(), SQLProvider.ServerDateTime(), Program.UserInfo.UserId);
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