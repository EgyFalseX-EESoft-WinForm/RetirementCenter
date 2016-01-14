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
    public partial class TBLMemberSarf_arshefEditFrm : DevExpress.XtraEditors.XtraForm
    {
        DataSources.Linq.dsTeachersUnionViewsDataContext dsLinq = new DataSources.Linq.dsTeachersUnionViewsDataContext();
        DataSources.dsRetirementCenterTableAdapters.TBLMemberSarf_arshefTableAdapter adp = new DataSources.dsRetirementCenterTableAdapters.TBLMemberSarf_arshefTableAdapter();
        DataSources.dsRetirementCenter.TBLMemberSarf_arshefDataTable tbl = new DataSources.dsRetirementCenter.TBLMemberSarf_arshefDataTable();
        DataSources.Linq.vTBLMemberSarf_arshef _row = null;

        public TBLMemberSarf_arshefEditFrm(DataSources.Linq.vTBLMemberSarf_arshef row)
        {
            InitializeComponent();
            LSMSEmp.QueryableSource = dsLinq.vTBLMashats;
            LSMSDofatSarfId.QueryableSource = dsLinq.TBLDofatSarfs;
            LSMSSarfTypeedadId.QueryableSource = dsLinq.CDSarfTypeedads;

            _row = row;

            lueDofatSarfId.EditValue = row.DofatSarfId;
            lueSarfTypeedadId.EditValue = row.SarfTypeedadId;
            lueMMashatId.EditValue = row.MMashatId;
            tbmonymonth.EditValue = row.monymonth;
            tbrsmmonth.EditValue = row.rsmmonth;
            tbeshtrakmonth.EditValue = row.eshtrakmonth;
            tbestktaa.EditValue = row.estktaa;
        }
        public TBLMemberSarf_arshefEditFrm()
        {
            InitializeComponent();
            LSMSEmp.QueryableSource = dsLinq.vTBLMashats;
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
                RetirementCenter.DataSources.Linq.vTBLMashat mem = (RetirementCenter.DataSources.Linq.vTBLMashat)lueMMashatId.GetSelectedDataRow();
                int effected = 0;
                if (_row == null)
                {
                    effected = adp.Insert(Convert.ToInt32(lueMMashatId.EditValue), Convert.ToInt32(lueDofatSarfId.EditValue), Convert.ToByte(lueSarfTypeedadId.EditValue)
                    , dof.DofatSarfDatefrom, dof.DofatSarfDateto, Convert.ToDouble(tbmonymonth.EditValue), Convert.ToDouble(tbrsmmonth.EditValue), Convert.ToDouble(tbeshtrakmonth.EditValue), Convert.ToDouble(tbestktaa.EditValue)
                    , true, SQLProvider.ServerDateTime(), Program.UserInfo.UserId, false, mem.SyndicateId, mem.SubCommitteId);
                }
                else
                {
                    effected = adp.Update(Convert.ToInt32(lueMMashatId.EditValue), Convert.ToInt32(lueDofatSarfId.EditValue), Convert.ToByte(lueSarfTypeedadId.EditValue)
                    , dof.DofatSarfDatefrom, dof.DofatSarfDateto, Convert.ToDouble(tbmonymonth.EditValue), Convert.ToDouble(tbrsmmonth.EditValue), Convert.ToDouble(tbeshtrakmonth.EditValue), Convert.ToDouble(tbestktaa.EditValue)
                    , true, SQLProvider.ServerDateTime(), Program.UserInfo.UserId, false, mem.SyndicateId, mem.SubCommitteId, _row.MMashatId, _row.DofatSarfId, _row.SarfTypeedadId);
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