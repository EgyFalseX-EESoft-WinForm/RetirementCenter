using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using RetirementCenter.Misc;

namespace RetirementCenter.Forms.Data
{
    public partial class ChangeMemberNameWFrm : DevExpress.XtraEditors.XtraForm
    {
        int _id;
        string _name = string.Empty;
        DataSources.dsRetirementCenterTableAdapters.TBLMashatLOGTableAdapter tblMashatLOGTableAdapter = new DataSources.dsRetirementCenterTableAdapters.TBLMashatLOGTableAdapter();
        DataSources.dsRetirementCenterTableAdapters.TBLMashatTableAdapter adp = new DataSources.dsRetirementCenterTableAdapters.TBLMashatTableAdapter();
        public ChangeMemberNameWFrm(int id, string name)
        {
            InitializeComponent();
            _id = id;
            _name = name;
            tbName.EditValue = _name;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            adp.UpdateChangeName(tbName.EditValue.ToString(), _id, _id);
            tblMashatLOGTableAdapter.Insert(_id, (byte)Types.TBLMashatLog.EditName, _name, tbName.EditValue.ToString(), Program.UserInfo.UserId, SQLProvider.ServerDateTime());
            DialogResult = System.Windows.Forms.DialogResult.OK;
            Close();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
            Close();
        }

        
    }
}