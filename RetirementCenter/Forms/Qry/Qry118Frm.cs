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
    public partial class Qry118Frm : DevExpress.XtraEditors.XtraForm
    {
        #region -   Functions   -
        public Qry118Frm()
        {
            InitializeComponent();
            SQLProvider.SetAllCommandTimeouts(vQry118TableAdapter, 0);
        }
        #endregion
        #region -   Event Handlers   -
        private void Qry06Frm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsQueries.vQry118' table. You can move, or remove it, as needed.
            this.vQry118TableAdapter.FillCount(this.dsQueries.vQry118);
            gridViewData.BestFitColumns();
        }
        private void ceQryType_CheckedChanged(object sender, EventArgs e)
        {
            if (ceQryType.Checked)
                this.vQry118TableAdapter.FillByCountMembers(this.dsQueries.vQry118);
            else
                this.vQry118TableAdapter.FillCount(this.dsQueries.vQry118);
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
