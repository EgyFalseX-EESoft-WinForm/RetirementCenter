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
    public partial class TBLFrookWarasaAdminFrm : DevExpress.XtraEditors.XtraForm
    {
        DataSources.Linq.dsTeachersUnionViewsDataContext dsLinq = new DataSources.Linq.dsTeachersUnionViewsDataContext();
        DataSources.dsRetirementCenterTableAdapters.TBLFrookWarasaTableAdapter adp = new DataSources.dsRetirementCenterTableAdapters.TBLFrookWarasaTableAdapter();

        public TBLFrookWarasaAdminFrm()
        {
            InitializeComponent();
            LSMSPersonId.QueryableSource = dsLinq.vTBLFrookWarasas;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (luePersonId.EditValue == null || luePersonId.EditValue.ToString() == string.Empty)
                return;
            try
            {
                adp.UpdateAdmin(ceadminconfirm.Checked, Program.UserInfo.UserId, Convert.ToInt32(luePersonId.EditValue), 0, 0);
                Program.ShowMsg("تم الحفظ", false, this, true);
                Program.Logger.LogThis("تم الحفظ", Text, FXFW.Logger.OpType.success, null, null, this);
                luePersonId.EditValue = null; luePersonId.Focus();
            }
            catch (Exception ex)
            {
                Program.ShowMsg(ex.Message, true, this, true);
                Program.Logger.LogThis(ex.Message, Text, FXFW.Logger.OpType.fail, ex, null, this);
            }
        }
        private void luePersonId_EditValueChanged(object sender, EventArgs e)
        {
            if (luePersonId.EditValue == null)
            {
                return;
            }
            DataSources.Linq.vTBLFrookWarasa row = (DataSources.Linq.vTBLFrookWarasa)luePersonId.Properties.View.GetRow(luePersonId.Properties.View.FocusedRowHandle);
            ceadminconfirm.EditValue = row.adminconfirm;
        }
    }
}