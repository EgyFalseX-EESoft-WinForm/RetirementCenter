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
    public partial class Qry94Frm : DevExpress.XtraEditors.XtraForm
    {
        DataSources.Linq.dsTeachersUnionViewsDataContext dsLinq = new DataSources.Linq.dsTeachersUnionViewsDataContext();
        #region -   Functions   -
        public Qry94Frm()
        {
            InitializeComponent();
            SQLProvider.SetAllCommandTimeouts(vQry94TableAdapter, 0);
            LSMSDof.QueryableSource = dsLinq.TBLDofatSarfs;

        }
        #endregion
        #region -   Event Handlers   -
        private void Qry06Frm_Load(object sender, EventArgs e)
        {
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
        private void lue_EditValueChanged(object sender, EventArgs e)
        {
            if (lueFrom.EditValue == null || lueTo.EditValue == null)
            {
                return;
            }
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                vQry94TableAdapter.Fill(dsQueries.vQry94, Convert.ToInt32(lueFrom.EditValue), Convert.ToInt32(lueTo.EditValue));
            }));
            SplashScreenManager.CloseForm();
        }
        #endregion

        
    }
}
