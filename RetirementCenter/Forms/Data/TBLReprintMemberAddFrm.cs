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
    public partial class TBLReprintMemberAddFrm : DevExpress.XtraEditors.XtraForm
    {
        DataSources.Linq.dsTeachersUnionViewsDataContext dsLinq = new DataSources.Linq.dsTeachersUnionViewsDataContext();
        DataSources.dsRetirementCenterTableAdapters.TBLReprintMemberTableAdapter adp = new DataSources.dsRetirementCenterTableAdapters.TBLReprintMemberTableAdapter();

        public TBLReprintMemberAddFrm()
        {
            InitializeComponent();
            LSMSCDreprintreson.QueryableSource = dsLinq.CDreprintresons;
            LSMSDATA.QueryableSource = dsLinq.vTBLMashats;
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

                adp.Insert(
                    Convert.ToByte(luereprintresonid.EditValue)
                    ,(DateTime)dereprintdate.EditValue
                    ,(int)lueMMashatId.EditValue
                    ,tbreprintremark.EditValue == null ? string.Empty : tbreprintremark.EditValue.ToString()
                    , sendbankdate
                    , waredbankdate
                    , Program.UserInfo.UserId
                    ,SQLProvider.ServerDateTime());
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