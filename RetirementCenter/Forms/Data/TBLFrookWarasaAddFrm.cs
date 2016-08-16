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
    public partial class TBLFrookWarasaAddFrm : DevExpress.XtraEditors.XtraForm
    {
        DataSources.Linq.dsTeachersUnionViewsDataContext dsLinq = new DataSources.Linq.dsTeachersUnionViewsDataContext();
        DataSources.dsRetirementCenterTableAdapters.TBLFrookWarasaTableAdapter adp = new DataSources.dsRetirementCenterTableAdapters.TBLFrookWarasaTableAdapter();

        public TBLFrookWarasaAddFrm()
        {
            InitializeComponent();
            LSMSDofatSarfId.QueryableSource = from q in dsLinq.CDDofatSarfFrooks where q.Closed == false select q;
            LSMSfrookid.QueryableSource = dsLinq.CDFrooks;
            LSMSPersonId.QueryableSource = dsLinq.vTBLWarasa_TBLMashats;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dxVP.Validate() == false)
                return;
            try
            {
                adp.Insert(
                    Convert.ToInt32(luePersonId.EditValue)
                    , Convert.ToInt32(lueDofatSarfId.EditValue)
                    ,Convert.ToByte(luefrookid.EditValue)
                    ,Convert.ToDouble(tbfrookmony.EditValue)
                    , tbfrookreson.EditValue.ToString()
                    , false
                    , null
                    , Program.UserInfo.UserId
                    ,SQLProvider.ServerDateTime());
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