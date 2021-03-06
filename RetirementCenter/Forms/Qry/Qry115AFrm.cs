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
    public partial class Qry115AFrm : DevExpress.XtraEditors.XtraForm
    {
        DataSources.Linq.dsTeachersUnionViewsDataContext dsLinq = new DataSources.Linq.dsTeachersUnionViewsDataContext() { CommandTimeout = 0, ObjectTrackingEnabled = false };
        #region -   Functions   -
        public Qry115AFrm()
        {
            InitializeComponent();
            SQLProvider.SetAllCommandTimeouts(vQry115ATableAdapter, 0);
        }
        #endregion
        #region -   Event Handlers   -
        private void Qry06Frm_Load(object sender, EventArgs e)
        {
            LSMSDof.QueryableSource = from q in dsLinq.TBLDofatSarfs select q;
        }
       
        private void LueFilter_EditValueChanged(object sender, EventArgs e)
        {
            vQry115ATableAdapter.Fill(dsQueries.vQry115A, Convert.ToInt32(LueFilter.EditValue));
            if (dsQueries.vQry115A.Rows.Count == 0)
            {
                msgDlg.Show("لا يوجد بيانات", msgDlg.msgButtons.Close);
                return;
            }
            DataSources.dsQueries.vQry115ARow row = dsQueries.vQry115A[0];
            if (row.IsrsmmonthNull() || row.IsmonymonthNull() || row.IseshtrakmonthNull() || row.IsestktaaNull() || row.IsrsmmonthNull())
            {
                msgDlg.Show("لا يوجد بيانات", msgDlg.msgButtons.Close);
                return;
            }
            tbTotal.EditValue = row.monymonth;
            tbRasm.EditValue = row.rsmmonth;
            tbEshtrak.EditValue = row.eshtrakmonth;
            tbEstktaa.EditValue = row.estktaa;
            tbNet.EditValue = row.monymonth - row.rsmmonth - row.eshtrakmonth - row.estktaa;
        }
        #endregion
    }
}
