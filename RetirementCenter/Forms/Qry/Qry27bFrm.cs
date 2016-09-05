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
    public partial class Qry27bFrm : DevExpress.XtraEditors.XtraForm
    {
        #region -   Functions   -
        public Qry27bFrm()
        {
            InitializeComponent();
            
            //btnPrintExport.Visible = Program.UserInfo.IsAdmin;
            SQLProvider.SetAllCommandTimeouts(vQry27bTableAdapter, 0);
            SQLProvider.SetAllCommandTimeouts(vQry101TableAdapter, 0);
        }
        #endregion
        #region -   Event Handlers   -
        private void Qry06Frm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsRetirementCenter.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.dsRetirementCenter.Users);
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
            if (tbCode.EditValue == null)
                return;
            vQry27bTableAdapter.Fill(dsQueries.vQry27b, Convert.ToInt32(tbCode.EditValue));
            gridViewData.BestFitColumns();
            vQry101TableAdapter.Fill(dsQueries.vQry101, Convert.ToInt32(tbCode.EditValue));
            gridViewbank.BestFitColumns();
        }
        #endregion
        

    }
}
