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
    public partial class Qry44Frm : DevExpress.XtraEditors.XtraForm
    {
        #region -   Functions   -
        public Qry44Frm()
        {
            InitializeComponent();
            btnPrintExport.Visible = Program.UserInfo.IsAdmin;
        }
        #endregion
        #region -   Event Handlers   -
        private void Qry06Frm_Load(object sender, EventArgs e)
        {
            SQLProvider.SetAllCommandTimeouts(vQry44TableAdapter, 0);
            // TODO: This line of code loads data into the 'dsQueries.vQry44' table. You can move, or remove it, as needed.
            this.vQry44TableAdapter.Fill(this.dsQueries.vQry44);
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

    }
}
