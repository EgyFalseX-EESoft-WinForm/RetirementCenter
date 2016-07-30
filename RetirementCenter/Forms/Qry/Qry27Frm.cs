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
    public partial class Qry27Frm : DevExpress.XtraEditors.XtraForm
    {
        DataSources.Linq.dsTeachersUnionViewsDataContext dsLinq = new DataSources.Linq.dsTeachersUnionViewsDataContext();
        DataSources.dsRetirementCenterTableAdapters.TBLMemberSarf_arshefTableAdapter adpSarfArc = new DataSources.dsRetirementCenterTableAdapters.TBLMemberSarf_arshefTableAdapter();
        #region -   Functions   -
        public Qry27Frm()
        {
            InitializeComponent();
            
            SQLProvider.SetAllCommandTimeouts(adpSarfArc, 0);
            LSMS.QueryableSource = dsLinq.vQry27s;
        }
        public Qry27Frm(int Id)
        {
            InitializeComponent();
            
            SQLProvider.SetAllCommandTimeouts(adpSarfArc, 0);
            LSMS.QueryableSource = from q in dsLinq.vQry27s where q.MMashatId == Id select q;
        }
        #endregion
        #region -   Event Handlers   -
        private void Qry06Frm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsRetirementCenter.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.dsRetirementCenter.Users);
            
            LSMSDof.QueryableSource = from q in dsLinq.TBLDofatSarfs select q;
            LSMSSyn.QueryableSource = from q in dsLinq.CDSyndicates select q;

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
