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

                adp.Update(
                     Convert.ToByte(luereprintresonid.EditValue)
                    , tbreprintremark.EditValue == null ? string.Empty : tbreprintremark.EditValue.ToString()
                    , sendbankdate
                    , waredbankdate
                    , Program.UserInfo.UserId
                    , SQLProvider.ServerDateTime()
                    , _reprintid, string.Empty, DateTime.Now);
                    
                    
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