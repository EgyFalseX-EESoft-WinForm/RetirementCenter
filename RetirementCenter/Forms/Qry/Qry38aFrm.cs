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
using System.Data.SqlClient;

namespace RetirementCenter
{
    public partial class Qry38aFrm : DevExpress.XtraEditors.XtraForm
    {
        #region -   Functions   -
        public Qry38aFrm()
        {
            InitializeComponent();
            SQLProvider.SetAllCommandTimeouts(vQry38aTableAdapter, 0);
        }
        #endregion
        #region -   Event Handlers   -
        private void Qry06Frm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsQueries.vQry38' table. You can move, or remove it, as needed.
            this.vQry38aTableAdapter.Fill(this.dsQueries.vQry38a);
            
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
        private void btnSaveBackData_Click(object sender, EventArgs e)
        {
            if (msgDlg.Show("هل انت متأكد؟", msgDlg.msgButtons.YesNo) == System.Windows.Forms.DialogResult.No)
                return;
            panelControlMain.Enabled = false;
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            SplashScreenManager.Default.SetWaitFormDescription("جاري الحفظ ...");
            System.Threading.ThreadPool.QueueUserWorkItem((o) => 
            {
                SqlConnection con = new SqlConnection(Properties.Settings.Default.RetirementCenterConnectionString);
                SqlCommand cmd = new SqlCommand(@"INSERT INTO BankExportedData (MMashatId, ExportDate, userin) VALUES (@MMashatId, GetDate(), @userin)", con);
                SqlParameter PramId = new SqlParameter("@MMashatId", SqlDbType.Int);
                SqlParameter PramUser = new SqlParameter("@userin", SqlDbType.Int);
                cmd.Parameters.AddRange(new SqlParameter[] { PramId, PramUser });
                SqlTransaction trn = null;
                try
                {
                    con.Open();
                    trn = con.BeginTransaction(); cmd.Transaction = trn;
                    
                    for (int i = 0; i < gridViewData.DataRowCount; i++)
                    {
                        RetirementCenter.DataSources.dsQueries.vQry38aRow row = (RetirementCenter.DataSources.dsQueries.vQry38aRow)((DataRowView)gridViewData.GetRow(i)).Row;
                        PramId.Value = row.MMashatId; PramUser.Value = Program.UserInfo.UserId;
                        cmd.ExecuteNonQuery();
                    }
                    trn.Commit();
                }
                catch (SqlException ex)
                {
                    trn.Rollback();
                    msgDlg.Show(ex.Message, msgDlg.msgButtons.Close);
                }
                con.Close();
                Invoke(new MethodInvoker(() => { panelControlMain.Enabled = true; SplashScreenManager.CloseForm(); msgDlg.Show("تم الحفظ", msgDlg.msgButtons.Close); }));
            });
            
        }
                    
        #endregion

    }
}