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
    public partial class Qry100Frm : DevExpress.XtraEditors.XtraForm
    {
        #region -   Functions   -
        public Qry100Frm()
        {
            InitializeComponent();
            SQLProvider.SetAllCommandTimeouts(vQry100TableAdapter, 0);
        }
        #endregion
        #region -   Event Handlers   -
        private void Qry06Frm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsQueries.TBLDofatSarf' table. You can move, or remove it, as needed.
            this.tBLDofatSarfTableAdapter.Fill(this.dsQueries.TBLDofatSarf);
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
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!dxvp.Validate())
                return;
            if (ceType.Checked)
                vQry100TableAdapter.FillByDof_Type(dsQueries.vQry100, Convert.ToInt32(lueDof.EditValue), Convert.ToByte(1));
            else
                vQry100TableAdapter.FillByDof(dsQueries.vQry100, Convert.ToInt32(lueDof.EditValue));
        }
        #endregion

    }
}
