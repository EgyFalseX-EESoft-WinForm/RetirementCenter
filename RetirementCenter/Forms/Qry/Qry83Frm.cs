using System;
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
    public partial class Qry83Frm : DevExpress.XtraEditors.XtraForm
    {
        DataSources.Linq.dsTeachersUnionViewsDataContext dsLinq = new DataSources.Linq.dsTeachersUnionViewsDataContext();
        #region -   Functions   -
        public Qry83Frm()
        {
            InitializeComponent();
        }
        #endregion
        #region -   Event Handlers   -
        private void Qry06Frm_Load(object sender, EventArgs e)
        {
            SQLProvider.SetAllCommandTimeouts(vQry83TableAdapter, 0);
            LSMS.QueryableSource = dsLinq.TBLDofatSarfs;
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (lue1.EditValue == null || lue2.EditValue == null)
                return;
            btnSearch.Enabled = false; Application.DoEvents();
            vQry83TableAdapter.Fill(dsQueries.vQry83, Convert.ToInt32(lue1.EditValue), Convert.ToInt32(lue2.EditValue));
            btnSearch.Enabled = true;
        }
    }
}
