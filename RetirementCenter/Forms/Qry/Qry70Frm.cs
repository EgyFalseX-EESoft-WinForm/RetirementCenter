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
    public partial class Qry70Frm : DevExpress.XtraEditors.XtraForm
    {
        DataSources.Linq.dsTeachersUnionViewsDataContext dsLinq = new DataSources.Linq.dsTeachersUnionViewsDataContext();

        #region -   Functions   -
        public Qry70Frm()
        {
            InitializeComponent();

            LSMSDof.QueryableSource = from q in dsLinq.TBLDofatSarfs select q;
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
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (lueDof1.EditValue == null || lueDof2.EditValue == null)
                return;
            btnSearch.Enabled = false;
            vQry70TableAdapter.Fill(dsQueries.vQry70, Convert.ToInt32(lueDof1.EditValue), Convert.ToInt32(lueDof2.EditValue));
            btnSearch.Enabled = true;
            //System.Threading.ThreadPool.QueueUserWorkItem((o) => 
            //{
            //    try
            //    {
                    
            //    }
            //    catch (Exception ex)
            //    {
            //        msgDlg.Show(ex.Message, msgDlg.msgButtons.Close);
            //    }
            //    btnSearch.Invoke(new MethodInvoker(() => 
            //    {
            //        btnSearch.Enabled = true;
            //    }));
            //});
        }
        #endregion

       

    }
}
