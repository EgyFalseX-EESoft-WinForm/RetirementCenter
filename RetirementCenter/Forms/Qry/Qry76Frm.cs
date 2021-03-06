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
    public partial class Qry76Frm : DevExpress.XtraEditors.XtraForm
    {
        
        int _mmashatid = 0;
        #region -   Functions   -
        public Qry76Frm()
        {
            InitializeComponent();
            SQLProvider.SetAllCommandTimeouts(vQry76TableAdapter, 0);
            tBLDofatSarfTableAdapter.Fill(this.dsQueries.TBLDofatSarf);
        }
        public Qry76Frm(int mmashatid)
        {
            InitializeComponent();
            _mmashatid = mmashatid;
            SQLProvider.SetAllCommandTimeouts(vQry76TableAdapter, 0);
            tBLDofatSarfTableAdapter.Fill(this.dsQueries.TBLDofatSarf);
        }
        #endregion
        #region -   Event Handlers   -
        private void Qry06Frm_Load(object sender, EventArgs e)
        {
            if (_mmashatid != 0)
            {
                vQry76TableAdapter.FillByMMashatId(dsQueries.vQry76, _mmashatid);
                gridViewData.BestFitColumns();
            }
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!dxvp.Validate())
                return;
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                vQry76TableAdapter.Fill(dsQueries.vQry76, Convert.ToInt32(lueDof.EditValue));
            }));
            SplashScreenManager.CloseForm();
        }

    }
}
