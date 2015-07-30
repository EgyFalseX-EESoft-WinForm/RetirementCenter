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
        }
        #endregion
        #region -   Event Handlers   -
        private void Qry06Frm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsRetirementCenter.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.dsRetirementCenter.Users);
            LSMS.QueryableSource = dsLinq.vQry27s;
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

        #endregion

        private void btnBank_Click(object sender, EventArgs e)
        {
            if (lueDof.EditValue == null || lueSynd.EditValue == null)
            {
                msgDlg.Show("يجب اختيار الدفعة و الفرعية", msgDlg.msgButtons.Close);
                return;
            }
            if (msgDlg.Show("هل انت متأكد؟", msgDlg.msgButtons.YesNo) == System.Windows.Forms.DialogResult.No)
                return;
            int effected = 0;
            try
            {
                effected = adpSarfArc.InsertByDof_Syn(Program.UserInfo.UserId.ToString(), Convert.ToInt32(lueDof.EditValue), Convert.ToInt32(lueSynd.EditValue));
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                Program.ShowMsg(FXFW.SqlDB.CheckExp(ex), true, this, true);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, null, ex, this);
            }
            Program.ShowMsg("تم الاضافة للبنك" + Environment.NewLine + effected, false, this, true);
        }

    }
}
