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
    public partial class Qry111Frm : DevExpress.XtraEditors.XtraForm
    {
        DataSources.Linq.dsTeachersUnionViewsDataContext dsLinq = new DataSources.Linq.dsTeachersUnionViewsDataContext();
        #region -   Functions   -
        public Qry111Frm()
        {
            InitializeComponent();
            SQLProvider.SetAllCommandTimeouts(vQry111TableAdapter, 0);
            LSMS.QueryableSource = from q in dsLinq.TBLDofatSarfs select q;
            LSMSSarfTypeedadId.QueryableSource = from q in dsLinq.CDSarfTypeedads select q;
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
            if (lueDof.EditValue == null && lueSarfTypeedadId.EditValue == null)
                return;

            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                vQry111TableAdapter.Fill(dsQueries.vQry111, Convert.ToInt32(lueDof.EditValue), Convert.ToInt32(lueSarfTypeedadId.EditValue));
            }));
            SplashScreenManager.CloseForm();
        }
        #endregion

    }
}
