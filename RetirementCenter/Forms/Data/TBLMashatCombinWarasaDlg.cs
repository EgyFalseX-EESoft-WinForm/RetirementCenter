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
        DataSources.dsRetirementCenter.TBLWarasaRow _row;


        public TBLMashatCombinWarasaDlg(DataSources.dsRetirementCenter.TBLWarasaRow row)
        {
            InitializeComponent();
            _row = row;
            getPersonIdByMMashatIdTableAdapter.FillByRespons(dsQueries.GetPersonIdByMMashatId, row.MMashatId);

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
            if (row.IsvisaNull())
            {
                Program.ShowMsg("لا توجد فيزا", true, this, true);
                return;
            }
            if (row.IsActivateNull() || row.IsActivateDateNull())
            {
                Program.ShowMsg("الفيزا غير مفعله", true, this, true);
                return;
            }
            if (row.Iscode60Null())
            {
                Program.ShowMsg("لا يوجد كود 60", true, this, true);
                return;
            }

            int result = SQLProvider.adpQry.UpdateTblWarasaCombine(row.PersonId, row.visa, row.Activate, row.ActivateDate, row.code60, _row.PersonId);
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