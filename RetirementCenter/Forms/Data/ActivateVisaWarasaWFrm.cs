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
    public partial class ActivateVisaWarasaWFrm : DevExpress.XtraEditors.XtraForm
    {
        DataSources.Linq.dsTeachersUnionViewsDataContext dsLinq = new DataSources.Linq.dsTeachersUnionViewsDataContext();
        DataSources.dsRetirementCenterTableAdapters.BankExportedDataWarsaTableAdapter adpInsert = new DataSources.dsRetirementCenterTableAdapters.BankExportedDataWarsaTableAdapter();
        bool _Insert, _Update, _Delete;
        public ActivateVisaWarasaWFrm()
        {
            InitializeComponent();
        }
        public ActivateVisaWarasaWFrm(bool insert, bool update, bool delete)
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
            LSMSTBLWarasa.QueryableSource = dsLinq.vTBLWarasa_TBLMashats;
            ActivePriv();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (luePersonId.EditValue == null || deExportDate.EditValue == null)
                return;
            try
            {
                if (adpInsert.InsertExportDate(deExportDate.DateTime, Program.UserInfo.UserId, Convert.ToInt32(luePersonId.EditValue)) > 0)
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
