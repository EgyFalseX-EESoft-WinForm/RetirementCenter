using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace RetirementCenter.Forms.Data
{
    public partial class TransferResponsibleFrm : DevExpress.XtraEditors.XtraForm
    {
        DataSources.Linq.dsTeachersUnionViewsDataContext dsLinq = new DataSources.Linq.dsTeachersUnionViewsDataContext();

        public TransferResponsibleFrm()
        {
            InitializeComponent();
            
        }
        private void DofatSarfActivityFrm_Load(object sender, EventArgs e)
        {
            
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!dxvp.Validate())
                return;
            if (msgDlg.Show("هل انت متأكد؟", msgDlg.msgButtons.YesNo) == System.Windows.Forms.DialogResult.No)
                return;
            int result = SQLProvider.adpQry.UpdateTransferResponsible(Convert.ToInt32(tbCode.EditValue.ToString()));
            if (result > 0)
                msgDlg.Show("تم التحويل", msgDlg.msgButtons.Close);
            else
                msgDlg.Show("لم يتم التحويل", msgDlg.msgButtons.Close);
        }
        

    }
}