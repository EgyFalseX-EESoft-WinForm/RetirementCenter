using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace RetirementCenter.Forms.Data.dlg
{
    public partial class NoteDlg : DevExpress.XtraEditors.XtraForm
    {
        public string NOTE
        {
            get { return (string)txt.EditValue; }
        }

        public NoteDlg()
        {
            InitializeComponent();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txt.EditValue == null || txt.EditValue.ToString() == string.Empty)
            {
                msgDlg.Show("يجب ادخال البيانات المطلوبة", msgDlg.msgButtons.Close);
                return;
            }
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}