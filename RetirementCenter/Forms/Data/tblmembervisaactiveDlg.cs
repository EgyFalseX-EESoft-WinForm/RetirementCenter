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
    public partial class tblmembervisaactiveDlg : DevExpress.XtraEditors.XtraForm
    {
        DataSources.dsRetirementCenter.tblmembervisaactiveRow _row;

        public tblmembervisaactiveDlg(DataSources.dsRetirementCenter.tblmembervisaactiveRow row)
        {
            InitializeComponent();
            _row = row;
            dedatehala.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", _row, "datehala", true));
            tbhalarem.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", _row, "halarem", true));
        }
        public tblmembervisaactiveDlg()
        {
            InitializeComponent();
        }

        private void tblmembervisaactiveDlg_Load(object sender, EventArgs e)
        {
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!dxValidationProviderMain.Validate())
                return;
            if (_row != null)
            {
                _row.datein = SQLProvider.ServerDateTime();
                _row.userin = Program.UserInfo.UserId;
            }
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
        
    }
}