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
    public partial class TBLWarasaSarf_arshefEditFrm : DevExpress.XtraEditors.XtraForm
    {
        DataSources.Linq.dsTeachersUnionViewsDataContext dsLinq = new DataSources.Linq.dsTeachersUnionViewsDataContext();
        DataSources.dsRetirementCenterTableAdapters.TBLWarasaSarf_arshefTableAdapter adp = new DataSources.dsRetirementCenterTableAdapters.TBLWarasaSarf_arshefTableAdapter();
        DataSources.dsRetirementCenter.TBLWarasaSarf_arshefDataTable tbl = new DataSources.dsRetirementCenter.TBLWarasaSarf_arshefDataTable();
        DataSources.Linq.vTBLWarasaSarf_arshef _row = null;

        public TBLWarasaSarf_arshefEditFrm(DataSources.Linq.vTBLWarasaSarf_arshef row)
        {
            InitializeComponent();
            LSMSPersonId.QueryableSource = dsLinq.vTBLWarasa_TBLMashats;
            LSMSDofatSarfId.QueryableSource = dsLinq.TBLDofatSarfs;
            LSMSSarfTypeedadId.QueryableSource = dsLinq.CDSarfTypeedads;

            _row = row;
            tbAuto.EditValue = row.amanatAutoId;
            lueDofatSarfId.EditValue = row.DofatSarfId;
            lueSarfTypeedadId.EditValue = row.SarfTypeedadId;
            luePersonId.EditValue = row.PersonId;
            tbmonymonth.EditValue = row.monymonth;
            tbrsmmonth.EditValue = row.rsmmonth;
            tbeshtrakmonth.EditValue = row.eshtrakmonth;
            tbestktaa.EditValue = row.estktaa;
            if (row.sarfcheek == null)
                cesarfcheek.EditValue = false;
            else
                cesarfcheek.EditValue = row.sarfcheek;
        }
        public TBLWarasaSarf_arshefEditFrm()
        {
            InitializeComponent();
            LSMSPersonId.QueryableSource = dsLinq.vTBLWarasa_TBLMashats;
            LSMSDofatSarfId.QueryableSource = dsLinq.TBLDofatSarfs;
            LSMSSarfTypeedadId.QueryableSource = dsLinq.CDSarfTypeedads;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!dxvp.Validate())
                return;
            try
            {
                DataSources.Linq.TBLDofatSarf dof = (DataSources.Linq.TBLDofatSarf)lueDofatSarfId.GetSelectedDataRow();
                RetirementCenter.DataSources.Linq.vTBLWarasa_TBLMashat mem = (RetirementCenter.DataSources.Linq.vTBLWarasa_TBLMashat)luePersonId.GetSelectedDataRow();
                int effected = 0;
                if (_row == null)
                {
                    effected = adp.Insert(Convert.ToInt32(luePersonId.EditValue), Convert.ToInt32(lueDofatSarfId.EditValue), Convert.ToByte(lueSarfTypeedadId.EditValue)
                    , dof.DofatSarfDatefrom, dof.DofatSarfDateto, Convert.ToDouble(tbmonymonth.EditValue), Convert.ToDouble(tbrsmmonth.EditValue), Convert.ToDouble(tbeshtrakmonth.EditValue), Convert.ToDouble(tbestktaa.EditValue)
                    , true, SQLProvider.ServerDateTime(), Program.UserInfo.UserId, false, (int)mem.SyndicateId, (int)mem.SubCommitteId, Convert.ToInt32(tbAuto.EditValue), cesarfcheek.Checked);
                }
                else
                {
                    effected = adp.Update(Convert.ToInt32(luePersonId.EditValue), Convert.ToInt32(lueDofatSarfId.EditValue), Convert.ToByte(lueSarfTypeedadId.EditValue)
                    , dof.DofatSarfDatefrom, dof.DofatSarfDateto, Convert.ToDouble(tbmonymonth.EditValue), Convert.ToDouble(tbrsmmonth.EditValue), Convert.ToDouble(tbeshtrakmonth.EditValue), Convert.ToDouble(tbestktaa.EditValue)
                    , true, SQLProvider.ServerDateTime(), Program.UserInfo.UserId, false, (int)mem.SyndicateId, (int)mem.SubCommitteId, Convert.ToInt32(tbAuto.EditValue), cesarfcheek.Checked, _row.PersonId, _row.DofatSarfId, _row.SarfTypeedadId);
                }
                
                if (effected > 0)
                {
                    Program.ShowMsg("تم الحفظ", false, this, true);
                    Program.Logger.LogThis("تم الحفظ", Text, FXFW.Logger.OpType.success, null, null, this);
                    Close();    
                }
            }
            catch (Exception ex)
            {
                Program.ShowMsg(ex.Message, true, this, true);
                Program.Logger.LogThis(ex.Message, Text, FXFW.Logger.OpType.fail, ex, null, this);
            }
        }
    }
}