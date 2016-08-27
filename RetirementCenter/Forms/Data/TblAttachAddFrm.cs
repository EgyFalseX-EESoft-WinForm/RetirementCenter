using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace RetirementCenter.Forms.Data
{
    public partial class TblAttachAddFrm : DevExpress.XtraEditors.XtraForm
    {
        DataSources.Linq.dsTeachersUnionViewsDataContext dsLinq = new DataSources.Linq.dsTeachersUnionViewsDataContext();
        DataSources.dsRetirementCenterTableAdapters.TblAttachTableAdapter adp = new DataSources.dsRetirementCenterTableAdapters.TblAttachTableAdapter();
        string DataPath = string.Empty;
        

        public TblAttachAddFrm()
        {
            InitializeComponent();
            LSMSMMashatId.QueryableSource = dsLinq.vTBLMashat01_V1s;
            LSMSAttachmentTypeId.QueryableSource = dsLinq.CDAttachmentTypes;
            try
            {
                DataPath = new DataSources.dsQueriesTableAdapters.QueriesTableAdapter().AppOptions_GetTblAttachPath();
                if (DataPath == string.Empty)
                {
                    msgDlg.Show("لا يوجد مسار محدد لمرفقات");
                    Close();
                }
                if (DataPath.Substring(DataPath.Length - 2) != @"\")
                    DataPath = DataPath + @"\";
            }
            catch (Exception ex)
            {
                msgDlg.Show(ex.Message);
                Close();
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void beattachpath_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
                return;
            beattachpath.EditValue = ofd.FileName;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dxVP.Validate() == false)
                return;
            DateTime ServerDatetime = SQLProvider.ServerDateTime();
            string filename = string.Format("{0}{1}{2}{3}{4}{5}", ServerDatetime.Year, ServerDatetime.Month, ServerDatetime.Day, ServerDatetime.Hour, ServerDatetime.Minute, ServerDatetime.Second);
            try
            {
                System.IO.File.Copy(beattachpath.EditValue.ToString(), DataPath + filename + ".jpg");
                adp.Insert(
                    Convert.ToInt32(lueAttachmentTypeId.EditValue)
                    ,Convert.ToInt32(lueMMashatId.EditValue)
                    , filename + ".jpg"
                    ,ServerDatetime
                    , Program.UserInfo.UserId);
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