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
    public partial class Qry77Frm : DevExpress.XtraEditors.XtraForm
    {
        DataSources.Linq.dsTeachersUnionViewsDataContext dsLinq = new DataSources.Linq.dsTeachersUnionViewsDataContext();
        string _visa = string.Empty;
        #region -   Functions   -
        public Qry77Frm()
        {
            InitializeComponent();
        }
        public Qry77Frm(string visa)
        {
            InitializeComponent();
            _visa = visa;
        }
        #endregion
        #region -   Event Handlers   -
        private void Qry06Frm_Load(object sender, EventArgs e)
        {
            if (_visa == string.Empty)
                LSMS.QueryableSource = dsLinq.vQry77s;
            else
                LSMS.QueryableSource = from q in dsLinq.vQry77s where q.visanumber == _visa select q;
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