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
    public partial class TBLReprintWarasaEditFrm : DevExpress.XtraEditors.XtraForm
    {
        DataSources.Linq.dsTeachersUnionViewsDataContext dsLinq = new DataSources.Linq.dsTeachersUnionViewsDataContext();
        DataSources.dsRetirementCenterTableAdapters.TBLReprintWarasaTableAdapter adp = new DataSources.dsRetirementCenterTableAdapters.TBLReprintWarasaTableAdapter();
        int _reprintid;

        public TBLReprintWarasaEditFrm(int reprintid)
        {
            InitializeComponent();
            LSMSCDreprintreson.QueryableSource = dsLinq.CDreprintresons;
            LSMSSyn.QueryableSource = dsLinq.CDSyndicates;
            LSMSSub.QueryableSource = dsLinq.CDSubCommittes;
            LSMSDATA.QueryableSource = dsLinq.vTBLReprintWarasa01s;
            _reprintid = reprintid;

            DataSources.dsRetirementCenter.TBLReprintWarasaRow row = adp.GetDataByID(_reprintid)[0];

            luevisa.EditValue = row.visa;
            dereprintdate.EditValue = row.reprintdate;
            luereprintresonid.EditValue = row.reprintresonid;
            tbreprintremark.EditValue = row.IsreprintremarkNull() ? string.Empty : row.reprintremark;
            if (!row.IssendbankdateNull())
                desendbankdate.EditValue = row.sendbankdate;
            if (!row.IswaredbankdateNull())
                dewaredbankdate.EditValue = row.waredbankdate;
            if (!row.IsNew_SyndicateIdNull())
                lueNew_SyndicateId.EditValue = row.New_SyndicateId;
            if (!row.IsNew_SubCommitteIdNull())
                lueNew_SubCommitteId.EditValue = row.New_SubCommitteId;

        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime? sendbankdate = null;
                if (desendbankdate.EditValue != null)
                    sendbankdate = (DateTime)desendbankdate.EditValue;
                DateTime? waredbankdate = null;
                if (dewaredbankdate.EditValue != null)
                    waredbankdate = (DateTime)dewaredbankdate.EditValue;
                int? syn = null;
                if (!FXFW.SqlDB.IsNullOrEmpty(lueNew_SyndicateId.EditValue))
                    syn = Convert.ToInt32(lueNew_SyndicateId.EditValue);
                int? sub = null;
                if (!FXFW.SqlDB.IsNullOrEmpty(lueNew_SubCommitteId.EditValue))
                    sub = Convert.ToInt32(lueNew_SubCommitteId.EditValue);

                adp.Update(
                     Convert.ToByte(luereprintresonid.EditValue)
                     , luevisa.EditValue.ToString()
                     , Convert.ToDateTime(dereprintdate.EditValue)
                    , tbreprintremark.EditValue == null ? string.Empty : tbreprintremark.EditValue.ToString()
                    , sendbankdate
                    , waredbankdate
                    , Program.UserInfo.UserId
                    , SQLProvider.ServerDateTime()
                    ,syn, sub
                    , luevisa.EditValue.ToString(), Convert.ToDateTime(dereprintdate.EditValue));
                    
                    
                Program.ShowMsg("تم الحفظ", false, this, true);
                Program.Logger.LogThis("تم الحفظ", Text, FXFW.Logger.OpType.success, null, null, this);
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