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
    public partial class TBLMashatCombinWarasaDlg : DevExpress.XtraEditors.XtraForm
    {
        int _id;


        public TBLMashatCombinWarasaDlg(int id)
        {
            InitializeComponent();
            _id = id;
            getPersonIdByMMashatIdTableAdapter.FillByRespons(dsQueries.GetPersonIdByMMashatId, id);

        }
        private void TBLMashatCombinWarasaDlg_Load(object sender, EventArgs e)
        {
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (lueRespons.EditValue == null)
                return;
            // code goes here
            int perdonId = Convert.ToInt32(lueRespons.EditValue);
            DataSources.dsQueries.GetPersonIdByMMashatIdRow row = (DataSources.dsQueries.GetPersonIdByMMashatIdRow)((System.Data.DataRowView)lueRespons.GetSelectedDataRow()).Row;
            SQLProvider.adpQry.UpdateTblWarasaCombine(row.PersonId, row.visa, row.Activate, row.ActivateDate, row.code60, _id);
            Program.ShowMsg("تم تعديل البيانات ", false, this, true);
            Program.Logger.LogThis("تم تعديل البيانات", Text, FXFW.Logger.OpType.success, null, null, this);
            
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
        
    }
}