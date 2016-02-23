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
    public partial class Qry90Frm : DevExpress.XtraEditors.XtraForm
    {
        DataSources.Linq.dsTeachersUnionViewsDataContext dsLinq = new DataSources.Linq.dsTeachersUnionViewsDataContext();
        #region -   Functions   -
        public Qry90Frm()
        {
            InitializeComponent();
            LSMSSyn.QueryableSource = dsLinq.CDSyndicates;
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
        private void lueSyn_EditValueChanged(object sender, EventArgs e)
        {
            if (lueSyn.EditValue == null || lueDof.EditValue == null)
            {
                return;
            }
            vQry90TableAdapter.Fill(dsQueries.vQry90, Convert.ToInt32(lueSyn.EditValue), Convert.ToInt32(lueDof.EditValue));
        }
        #endregion

        
    }
}
