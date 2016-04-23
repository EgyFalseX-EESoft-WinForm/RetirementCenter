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
    public partial class Qry27aFrm : DevExpress.XtraEditors.XtraForm
    {
        DataSources.Linq.dsTeachersUnionViewsDataContext dsLinq = new DataSources.Linq.dsTeachersUnionViewsDataContext();
        DataSources.dsRetirementCenterTableAdapters.TBLMemberSarf_arshefTableAdapter adpSarfArc = new DataSources.dsRetirementCenterTableAdapters.TBLMemberSarf_arshefTableAdapter();
        #region -   Functions   -
        public Qry27aFrm()
        {
            InitializeComponent();
            
            btnPrintExport.Visible = Program.UserInfo.IsAdmin;
            SQLProvider.SetAllCommandTimeouts(adpSarfArc, 0);
            
        }
        #endregion
        #region -   Event Handlers   -
        private void Qry06Frm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsRetirementCenter.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.dsRetirementCenter.Users);
            LSMSDof.QueryableSource = from q in dsLinq.TBLDofatSarfs select q;
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
        private void lueDof_EditValueChanged(object sender, EventArgs e)
        {
            if (FXFW.SqlDB.IsNullOrEmpty(lueDof.EditValue))
                return;
            LSMS.QueryableSource = from q in dsLinq.vQry27s where q.DofatSarfId == Convert.ToInt32(lueDof.EditValue) && q.SendBank == false select q;
        }
        #endregion

    }
}
