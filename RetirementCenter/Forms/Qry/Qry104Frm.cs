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
    public partial class Qry104Frm : DevExpress.XtraEditors.XtraForm
    {
        #region -   Functions   -
        public Qry104Frm()
        {
            InitializeComponent();
            SQLProvider.SetAllCommandTimeouts(sp_002TableAdapter, 0);
        }
        #endregion
        #region -   Event Handlers   -
        private void Qry06Frm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsQueries.CDSarfTypeedad' table. You can move, or remove it, as needed.
            this.cDSarfTypeedadTableAdapter.Fill(this.dsQueries.CDSarfTypeedad);
            // TODO: This line of code loads data into the 'dsQueries.TBLDofatSarf' table. You can move, or remove it, as needed.
            this.tBLDofatSarfTableAdapter.Fill(this.dsQueries.TBLDofatSarf);
            //gridViewData.BestFitColumns();
        }
        private void ccbeDof_EditValueChanged(object sender, EventArgs e)
        {
            ((DevExpress.XtraEditors.CheckedComboBoxEdit)sender).RefreshEditValue();
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
            sp_002TableAdapter.Fill(dsQueries.sp_002, ccbeDof.EditValue.ToString(), ccbeSarfType.EditValue.ToString());
            
        }
        #endregion

       

    }
}
