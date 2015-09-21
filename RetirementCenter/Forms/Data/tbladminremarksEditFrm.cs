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
    public partial class tbladminremarksEditFrm : DevExpress.XtraEditors.XtraForm
    {
        DataSources.Linq.dsTeachersUnionViewsDataContext dsLinq = new DataSources.Linq.dsTeachersUnionViewsDataContext();
        DataSources.dsRetirementCenterTableAdapters.tbladminremarksTableAdapter adp = new DataSources.dsRetirementCenterTableAdapters.tbladminremarksTableAdapter();
        int _remarkid;

        public tbladminremarksEditFrm(int remarkid)
        {
            InitializeComponent();
            LSMSDATA.QueryableSource = dsLinq.vTBLMashats;
            _remarkid = remarkid;

            DataSources.dsRetirementCenter.tbladminremarksRow row = adp.GetDataByremarkid(_remarkid)[0];
            if (!row.IsadminremarkNull())
                tbadminremark.EditValue = row.adminremark;
            if (!row.IsfinishedNull())
                cefinished.Checked = row.finished;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbadminremark.EditValue == null || tbadminremark.EditValue.ToString() == string.Empty)
                return;
            try
            {
                adp.UpdateAdminRemark(tbadminremark.EditValue.ToString(), cefinished.Checked, _remarkid);
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