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
    public partial class ActivateVisaWFrm : DevExpress.XtraEditors.XtraForm
    {
        DataSources.Linq.dsTeachersUnionViewsDataContext dsLinq = new DataSources.Linq.dsTeachersUnionViewsDataContext();
        DataSources.dsRetirementCenterTableAdapters.BankExportedDataTableAdapter adpInsert = new DataSources.dsRetirementCenterTableAdapters.BankExportedDataTableAdapter();
        bool _Insert, _Update, _Delete;
        public ActivateVisaWFrm()
        {
            InitializeComponent();
        }
        public ActivateVisaWFrm(bool insert, bool update, bool delete)
        {
            InitializeComponent();
            _Insert = insert;
            _Update = update;
            _Delete = delete;

        }
        private void ActivePriv()
        {
        }
        private void FormWFrm_Load(object sender, EventArgs e)
        {
            LSMSTBLMashat.QueryableSource = dsLinq.vTBLMashat01_V1s;
            ActivePriv();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (lueMMashatId.EditValue == null || deExportDate.EditValue == null)
                return;
            try
            {
                if (adpInsert.InsertExportDate(Convert.ToInt32(lueMMashatId.EditValue), deExportDate.DateTime, Program.UserInfo.UserId) > 0)
                {
                    DialogResult = System.Windows.Forms.DialogResult.OK;
                    Close();
                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                Program.ShowMsg(FXFW.SqlDB.CheckExp(ex), true, this, true);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, null, ex, this);
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
       
    }
}
