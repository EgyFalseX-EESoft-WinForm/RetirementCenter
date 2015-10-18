﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;

namespace RetirementCenter
{
    public partial class Qry47Frm : DevExpress.XtraEditors.XtraForm
    {
        DataSources.dsRetirementCenterTableAdapters.TBLNoSarfWarsaTableAdapter adp = new DataSources.dsRetirementCenterTableAdapters.TBLNoSarfWarsaTableAdapter();
        DataSources.dsRetirementCenter.TBLNoSarfWarsaDataTable dt = new DataSources.dsRetirementCenter.TBLNoSarfWarsaDataTable();
        #region -   Functions   -
        public Qry47Frm()
        {
            InitializeComponent();
            btnPrintExport.Visible = Program.UserInfo.IsAdmin;
        }
        #endregion
        #region -   Event Handlers   -
        private void Qry06Frm_Load(object sender, EventArgs e)
        {
            SQLProvider.SetAllCommandTimeouts(vQry47TableAdapter, 0);
            // TODO: This line of code loads data into the 'dsQueries.vQry47' table. You can move, or remove it, as needed.
            this.vQry47TableAdapter.Fill(this.dsQueries.vQry47);
            //gridViewData.BestFitColumns();
        }
        private void btnPrintExport_Click(object sender, EventArgs e)
        {
            // Check whether the GridControl can be previewed.
            if (!gridControlData.IsPrintingAvailable)
            {
                msgDlg.Show("The 'DevExpress.XtraPrinting' library is not found");
                return;
            }

            // Open the Preview window.
            gridControlData.ShowRibbonPrintPreview();
        }

        #endregion

        private void repositoryItemButtonEditStatus_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DataSources.dsQueries.vQry47Row row = (DataSources.dsQueries.vQry47Row)((DataRowView)gridViewData.GetRow(gridViewData.FocusedRowHandle)).Row;
            adp.FillByLastRecord(dt, row.PersonId);
            if (dt.Rows.Count == 0)
                return;

            string msg = string.Format("التاريخ : {0} \n\r الحالة : {1} \n\r ملاحظات : {2}", dt[0].datehala, dt[0].yasref == true ? "يصرف" : "لا يصرف", dt[0].halarem);
            MessageBox.Show(msg, "معلومات", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void repositoryItemButtonEditArc_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DataSources.dsQueries.vQry47Row row = (DataSources.dsQueries.vQry47Row)((DataRowView)gridViewData.GetRow(gridViewData.FocusedRowHandle)).Row;
            Qry77Frm frm = new Qry77Frm(row.PersonId);
            frm.ShowDialog();
        }

    }
}
