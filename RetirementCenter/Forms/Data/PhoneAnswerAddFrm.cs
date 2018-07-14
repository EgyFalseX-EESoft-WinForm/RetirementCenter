using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace RetirementCenter.Forms.Data
{
    public partial class PhoneAnswerAddFrm : DevExpress.XtraEditors.XtraForm
    {
        DataSources.Linq.dsTeachersUnionViewsDataContext dsLinq = new DataSources.Linq.dsTeachersUnionViewsDataContext();
        DataSources.dsRetirementCenterTableAdapters.phone_answerTableAdapter adp = new DataSources.dsRetirementCenterTableAdapters.phone_answerTableAdapter();
        DateTime start_date;

        public PhoneAnswerAddFrm()
        {
            InitializeComponent();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbmobile.EditValue == null || tbmobile.EditValue == string.Empty)
                {
                    msgDlg.Show("من فضلك ادخل رقم الموبيل");
                    return;
                }
                string member_code = string.Empty;
                if (tbmember_code.EditValue != null)
                    member_code = tbmember_code.EditValue.ToString();

                string notes = string.Empty;
                if (tbnotes.EditValue != null)
                    notes = tbnotes.EditValue.ToString();

                int result = adp.Insert(Program.UserInfo.UserId, start_date, SQLProvider.ServerDateTime(), tbmobile.EditValue.ToString(), member_code, notes);
                if (result > 0)
                {
                    Program.ShowMsg("تم الحفظ", false, this, true);
                    Program.Logger.LogThis("تم الحفظ", Text, FXFW.Logger.OpType.success, null, null, this);
                    DialogResult = System.Windows.Forms.DialogResult.OK;
                    Close();
                }
                else
                {
                    Program.ShowMsg("لم يتم الحفظ", true, this, true);
                    Program.Logger.LogThis("لم يتم الحفظ", Text, FXFW.Logger.OpType.fail, null, null, this);
                }
            }
            catch (Exception ex)
            {
                Program.ShowMsg(ex.Message, true, this, true);
                Program.Logger.LogThis(ex.Message, Text, FXFW.Logger.OpType.fail, ex, null, this);
            }
        }

        private void TBLHafzaTasleemAddFrm_Load(object sender, EventArgs e)
        {
            start_date = SQLProvider.ServerDateTime();
        }
    }
}