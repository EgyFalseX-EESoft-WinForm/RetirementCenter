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
    public partial class Qry77Frm : DevExpress.XtraEditors.XtraForm
    {
        
        string _visa = string.Empty;
        #region -   Functions   -
        public Qry77Frm()
        {
            InitializeComponent();
            this.tBLDofatSarfTableAdapter.Fill(this.dsQueries.TBLDofatSarf);
            SQLProvider.SetAllCommandTimeouts(vQry77TableAdapter, 0);
        }
        public Qry77Frm(string visa)
        {
            InitializeComponent();
            _visa = visa;
            this.tBLDofatSarfTableAdapter.Fill(this.dsQueries.TBLDofatSarf);
            SQLProvider.SetAllCommandTimeouts(vQry77TableAdapter, 0);
        }
        #endregion
        #region -   Event Handlers   -
        private void Qry06Frm_Load(object sender, EventArgs e)
        {
            if (_visa != string.Empty)
            {
                vQry77TableAdapter.FillByvisanumber(dsQueries.vQry77, _visa);
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
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!dxvp.Validate())
                return;
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                vQry77TableAdapter.Fill(dsQueries.vQry77, Convert.ToInt32(lueDof.EditValue));
            }));
            SplashScreenManager.CloseForm();
        }
        #endregion

        

    }
}
