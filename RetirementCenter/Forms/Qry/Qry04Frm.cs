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
    public partial class Qry04Frm : DevExpress.XtraEditors.XtraForm
    {
        DataSources.Linq.dsTeachersUnionViewsDataContext dsLinq = new DataSources.Linq.dsTeachersUnionViewsDataContext();
        #region -   Functions   -
        public Qry04Frm()
        {
            InitializeComponent();
            //btnPrintExport.Visible = Program.UserInfo.IsAdmin;
        }
        #endregion
        #region -   Event Handlers   -
        private void QryTblAhteatyFrm_Load(object sender, EventArgs e)
        {
            //if (Program.UserInfo.IsAdmin)
            //    LSMS.QueryableSource = dsLinq.vTBLMashats;
            //else
            //    LSMS.QueryableSource = from q in dsLinq.vTBLMashats where Program.UserInfo.Syndicates.Contains((int)q.SyndicateId) select q;

            LSMS.QueryableSource = dsLinq.vTBLMashats;

            gridViewData.BestFitColumns();
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