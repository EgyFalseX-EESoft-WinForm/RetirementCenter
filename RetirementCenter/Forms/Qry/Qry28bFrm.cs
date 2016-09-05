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
    public partial class Qry28bFrm : DevExpress.XtraEditors.XtraForm
    {
        #region -   Functions   -
        public Qry28bFrm()
        {
            InitializeComponent();
            
            //btnPrintExport.Visible = Program.UserInfo.IsAdmin;
            SQLProvider.SetAllCommandTimeouts(vQry28bTableAdapter, 0);
            SQLProvider.SetAllCommandTimeouts(vQry102TableAdapter, 0);
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
            vQry28bTableAdapter.Fill(dsQueries.vQry28b, Convert.ToInt32(tbCode.EditValue));
            gridViewData.BestFitColumns();
            vQry102TableAdapter.Fill(dsQueries.vQry102, Convert.ToInt32(tbCode.EditValue));
            gridViewbank.BestFitColumns();
        }
        #endregion

        private void btnSearch60_Click(object sender, EventArgs e)
        {
            if (tbCode60.EditValue == null)
                return;
            vQry28bTableAdapter.FillBynewid(dsQueries.vQry28b, Convert.ToInt32(tbCode60.EditValue));
            gridViewData.BestFitColumns();
            vQry102TableAdapter.FillBycode60(dsQueries.vQry102, Convert.ToInt32(tbCode60.EditValue));
            gridViewbank.BestFitColumns();
        }
        
    }
}
