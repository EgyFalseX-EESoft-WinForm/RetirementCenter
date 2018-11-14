using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Linq;

namespace RetirementCenter.Forms.Data
{
    public partial class TransferToMemberFrm : DevExpress.XtraEditors.XtraForm
    {
        DataSources.Linq.dsTeachersUnionViewsDataContext dsLinq = new DataSources.Linq.dsTeachersUnionViewsDataContext();

        public TransferToMemberFrm()
        {
            InitializeComponent();
            LSMSTBLMashat.QueryableSource = dsLinq.vTBLMashats;
            
        }
        private void DofatSarfActivityFrm_Load(object sender, EventArgs e)
        {
            
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!dxvp.Validate())
                return;
            System.Linq.IQueryable<RetirementCenter.DataSources.Linq.vTBLMashat> name = (from q in dsLinq.vTBLMashats where q.MMashatId == Convert.ToInt32(glueCode.EditValue.ToString()) select q);
            

            //System.Linq.IQueryable<RetirementCenter.DataSources.Linq.vTBLMashat>


            if (name == null || name.Count() == 0)
            {
                msgDlg.Show("رقم خطــاء", msgDlg.msgButtons.Close);
                return;
            }
            if (msgDlg.Show("اسم العضو " + name.ToList<RetirementCenter.DataSources.Linq.vTBLMashat>()[0].MMashatName + Environment.NewLine + "هل انت متأكد؟", msgDlg.msgButtons.YesNo) == System.Windows.Forms.DialogResult.No)
                return;
            int result = SQLProvider.adpQry.UpdateTransferToMember(Convert.ToInt32(glueCode.EditValue.ToString()));
            if (result > 0)
                msgDlg.Show("تم التحويل", msgDlg.msgButtons.Close);
            else
                msgDlg.Show("لم يتم التحويل", msgDlg.msgButtons.Close);
        }
        

    }
}