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
    public partial class TBLReprintMemberTaslemFrm : DevExpress.XtraEditors.XtraForm
    {
        DataSources.Linq.dsTeachersUnionViewsDataContext dsLinq = new DataSources.Linq.dsTeachersUnionViewsDataContext();
        DataSources.dsRetirementCenterTableAdapters.TBLReprintMemberTableAdapter adp = new DataSources.dsRetirementCenterTableAdapters.TBLReprintMemberTableAdapter();

        public TBLReprintMemberTaslemFrm()
        {
            InitializeComponent();
            LSMSDATA.QueryableSource = dsLinq.vTBLReprintMembers;
            LSMSCDSyndicate.QueryableSource = dsLinq.CDSyndicates;
        }
        private void Clear1()
        {
            lueMMashatId1.EditValue = null;
            dedatetasleem1.EditValue = SQLProvider.ServerDateTime();
            tbmostlem1.EditValue = null;
        }
        private void Clear2()
        {
            lueSyn2.EditValue = null;
            dereprintdate2.EditValue = null;
            dedatetasleem2.EditValue = SQLProvider.ServerDateTime();
            tbmostlem2.EditValue = null;
        }
        private void lueMMashatId_EditValueChanged(object sender, EventArgs e)
        {
            if (lueMMashatId1.EditValue == null || lueMMashatId1.EditValue.ToString() == string.Empty)
                return;
            tbmostlem1.EditValue = string.Empty;
            dedatetasleem1.EditValue = SQLProvider.ServerDateTime();
        }
        private void btnSave1_Click(object sender, EventArgs e)
        {
            if (dedatetasleem1.EditValue == null || tbmostlem1.EditValue == null)
                return;
            
            try
            {
                int effected = adp.UpdateMostalem(tbmostlem1.EditValue.ToString(), (DateTime)dedatetasleem1.EditValue, Convert.ToInt32(lueMMashatId1.EditValue), 0);
                if (effected > 0)
                {
                    Program.ShowMsg("تم الحفظ" + Environment.NewLine + effected, false, this, true);
                    Program.Logger.LogThis("تم الحفظ", Text, FXFW.Logger.OpType.success, null, null, this);
                    Clear1();    
                }
                else
                {
                    Program.ShowMsg("لم يتم التعديل", true, this, true);
                    Program.Logger.LogThis("لم يتم التعديل", Text, FXFW.Logger.OpType.fail, null, null, this);
                    return;
                }
            }
            catch (Exception ex)
            {
                Program.ShowMsg(ex.Message, true, this, true);
                Program.Logger.LogThis(ex.Message, Text, FXFW.Logger.OpType.fail, ex, null, this);
            }
        }
        private void btnSave2_Click(object sender, EventArgs e)
        {
            if (lueSyn2.EditValue == null || dereprintdate2.EditValue == null || tbmostlem2.EditValue == null || dedatetasleem2.EditValue == null)
            {
                msgDlg.Show("يجب ادخال كل البيانات", msgDlg.msgButtons.Close);
                return;
            }
            if (dereprintdate2.DateTime > dedatetasleem2.DateTime)
            {
                msgDlg.Show("تاريخ الاستعلام قبل تاريخ الطلب", msgDlg.msgButtons.Close);
                return;
            }
            try
            {
                int effected = adp.UpdateMostalem2(tbmostlem2.EditValue.ToString(), (DateTime)dedatetasleem2.EditValue, Convert.ToInt32(lueSyn2.EditValue), (DateTime)dereprintdate2.EditValue);

                if (effected > 0)
                {
                    Program.ShowMsg("تم الحفظ" + Environment.NewLine + effected, false, this, true);
                    Program.Logger.LogThis("تم الحفظ", Text, FXFW.Logger.OpType.success, null, null, this);
                    Clear2();
                }
                else
                {
                    Program.ShowMsg("لم يتم التعديل", true, this, true);
                    Program.Logger.LogThis("لم يتم التعديل", Text, FXFW.Logger.OpType.fail, null, null, this);
                    return;
                }
            }
            catch (Exception ex)
            {
                Program.ShowMsg(ex.Message, true, this, true);
                Program.Logger.LogThis(ex.Message, Text, FXFW.Logger.OpType.fail, ex, null, this);
            }
        }
    }
}