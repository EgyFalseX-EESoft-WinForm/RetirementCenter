using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using System.Linq;

namespace RetirementCenter
{
    public partial class TBLDeathMembersAccWFrm : DevExpress.XtraEditors.XtraForm
    {
        List<int> _ids = new List<int>();
        DataSources.Linq.dsTeachersUnionViewsDataContext dsLinq = new DataSources.Linq.dsTeachersUnionViewsDataContext();
        DataSources.dsQueriesTableAdapters.QueriesTableAdapter adpQ = new DataSources.dsQueriesTableAdapters.QueriesTableAdapter();
        
        
        bool _Insert, _Update, _Delete;
        public TBLDeathMembersAccWFrm()
        {
            InitializeComponent();

        }
        public TBLDeathMembersAccWFrm(List<int> ids, bool insert, bool update, bool delete)
        {
            InitializeComponent();
            _ids = ids;
            _Insert = insert;
            _Update = update;
            _Delete = delete;
            //if (row.GetMemberValue("sarf") == null)
            //    cesarf.EditValue = false;
            //else
            //    cesarf.EditValue = row.GetMemberValue("sarf");
            //if (row.GetMemberValue("sheekno") != null)
            //    tbsheekno.EditValue = row.GetMemberValue("sheekno");

            //if (row.GetMemberValue("sheekdate") != null)
            //    desheekdate.EditValue = row.GetMemberValue("sheekdate");
        }
        private void ActivePriv()
        {
        }
        private void FormWFrm_Load(object sender, EventArgs e)
        {
            ActivePriv();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbsheekno.EditValue == null || desheekdate.EditValue == null)
            {
                msgDlg.Show("يجب ادخال البيانات المطلوبة", msgDlg.msgButtons.Close);
                return;
            }
            DateTime ServerDatetime = SQLProvider.ServerDateTime();
            foreach (int id in _ids)
            {
                adp.UpdateAcc(Convert.ToBoolean(cesarf.EditValue), Convert.ToInt64(tbsheekno.EditValue), Convert.ToDateTime(desheekdate.EditValue)
                , Program.UserInfo.UserId, SQLProvider.ServerDateTime(), id, id);
            }
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
       
    }
}
