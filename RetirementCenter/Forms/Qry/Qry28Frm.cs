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
            btnBank.Visible = Program.UserInfo.IsAdmin;
            if (Program.UserInfo.IsAdmin || Convert.ToBoolean(SQLProvider.adpQry.RoleExists(Program.UserInfo.UserId, Program.SubAdminRole)))
                btnPrintExport.Visible = true;
            else
                btnPrintExport.Visible = false;
            LSMS.QueryableSource = dsLinq.vQry28s;
        }
        public Qry28Frm(int Code60)
        {
            InitializeComponent();
            SQLProvider.SetAllCommandTimeouts(adpSarfArc, 0);
            btnBank.Visible = Program.UserInfo.IsAdmin;
            btnPrintExport.Visible = Program.UserInfo.IsAdmin || Convert.ToBoolean(SQLProvider.adpQry.RoleExists(Program.UserInfo.UserId, Program.SubAdminRole));
            panelControlMain.Visible = false;
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
            if (lueDof.EditValue == null)
            {
                msgDlg.Show("يجب اختيار الدفعة ", msgDlg.msgButtons.Close);
                return;
            }
            if (msgDlg.Show("هل انت متأكد؟", msgDlg.msgButtons.YesNo) == System.Windows.Forms.DialogResult.No)
                return;
            int effected = 0;
            int codestart = 0;
            int codeend = 999999999;
            if (tbCodeStart.EditValue != null)
                codestart = Convert.ToInt32(tbCodeStart.EditValue);
            if (tbCodeEnd.EditValue != null)
                codeend = Convert.ToInt32(tbCodeEnd.EditValue);
            try
            {
                if (lueSynd.EditValue == null)
                    effected = adpSarfArc.InsertByDof(Program.UserInfo.UserId, Convert.ToInt32(lueDof.EditValue), codestart, codeend);
                else
                    effected = adpSarfArc.InsertByDof_Syn(Program.UserInfo.UserId, Convert.ToInt32(lueDof.EditValue), Convert.ToInt32(lueSynd.EditValue), codestart, codeend);

            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                Program.ShowMsg(FXFW.SqlDB.CheckExp(ex), true, this, true);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, null, ex, this);
            }
            Program.ShowMsg("تم الاضافة للبنك" + Environment.NewLine + effected, false, this, true);
        }
        #endregion

        

    }
}
