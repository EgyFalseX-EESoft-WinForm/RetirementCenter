using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace RetirementCenter.Forms.Data
{
    public partial class TBLFrookWarasaEditFrm : DevExpress.XtraEditors.XtraForm
    {
        DataSources.Linq.dsTeachersUnionViewsDataContext dsLinq = new DataSources.Linq.dsTeachersUnionViewsDataContext();
        DataSources.dsRetirementCenterTableAdapters.TBLFrookWarasaTableAdapter adp = new DataSources.dsRetirementCenterTableAdapters.TBLFrookWarasaTableAdapter();
        DataSources.dsRetirementCenter.TBLFrookWarasaRow row = null;
        int _id;

        public TBLFrookWarasaEditFrm(int id)
        {
            InitializeComponent();
            LSMSDofatSarfId.QueryableSource = from q in dsLinq.CDDofatSarfFrooks where q.Closed == false select q;
            LSMSfrookid.QueryableSource = dsLinq.CDFrooks;
            LSMSPersonId.QueryableSource = dsLinq.vTBLWarasa_TBLMashats;
            _id = id;
            row = adp.GetDataByID(_id)[0];
            luePersonId.EditValue = row.PersonId;
            lueDofatSarfId.EditValue = row.DofatSarfId;
            luefrookid.EditValue = row.frookid;
            tbfrookmony.EditValue = row.frookmony;
            tbfrookreson.EditValue = row.frookreson;
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
                int? userinadmin = null;
                if (!row.IsuserinadminNull())
                    userinadmin = row.userinadmin;

                adp.Update(
                    Convert.ToByte(luefrookid.EditValue)
                    ,Convert.ToDouble(tbfrookmony.EditValue)
                    ,tbfrookreson.EditValue.ToString()
                    ,row.adminconfirm
                    , userinadmin
                    , Program.UserInfo.UserId
                    ,SQLProvider.ServerDateTime()
                    ,row.PersonId, row.DofatSarfId);
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