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
    public partial class Qry28Frm : DevExpress.XtraEditors.XtraForm
    {
        DataSources.Linq.dsTeachersUnionViewsDataContext dsLinq = new DataSources.Linq.dsTeachersUnionViewsDataContext();
        DataSources.dsRetirementCenterTableAdapters.TBLWarasaSarf_arshefTableAdapter adpSarfArc = new DataSources.dsRetirementCenterTableAdapters.TBLWarasaSarf_arshefTableAdapter();
        #region -   Functions   -
        public Qry28Frm()
        {
            InitializeComponent();
            SQLProvider.SetAllCommandTimeouts(adpSarfArc, 0);
            
            LSMS.QueryableSource = dsLinq.vQry28s;
        }
        public Qry28Frm(int Code60)
        {
            InitializeComponent();
            SQLProvider.SetAllCommandTimeouts(adpSarfArc, 0);
            LSMS.QueryableSource = from q in dsLinq.vQry28s where q.newid == Code60 select q;
        }
        #endregion
        #region -   Event Handlers   -
        private void Qry06Frm_Load(object sender, EventArgs e)
        {
            LSMSDof.QueryableSource = from q in dsLinq.TBLDofatSarfs select q;
            LSMSSyn.QueryableSource = from q in dsLinq.CDSyndicates select q;

            // TODO: This line of code loads data into the 'dsRetirementCenter.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.dsRetirementCenter.Users);
            
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
        private void btnBank_Click(object sender, EventArgs e)
        {
           
        }
        #endregion

        

    }
}
