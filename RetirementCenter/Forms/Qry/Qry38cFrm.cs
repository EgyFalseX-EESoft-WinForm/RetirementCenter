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
    public partial class Qry38cFrm : DevExpress.XtraEditors.XtraForm
    {
        #region -   Functions   -
        public Qry38cFrm()
        {
            InitializeComponent();
        }
        private bool PrepareNewId()
        {
            bool output = false;
            SqlConnection con = new SqlConnection(Properties.Settings.Default.RetirementCenterConnectionString);
            SqlCommand cmd = new SqlCommand(@"INSERT INTO AwarasaNewId
            SELECT (SELECT ISNULL(MAX(newid) + 1, 60000000) FROM AwarasaNewId) + ROW_NUMBER() OVER(ORDER BY PersonId), PersonId
            FROM TBLWarasa WHERE yasref = 1 AND responsiblesarf = 1
            AND NOT EXISTS(SELECT personid FROM [dbo].[AwarasaNewId] WHERE personid = TBLWarasa.PersonId)", con);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                output = true;
            }
            catch (Exception ex)
            {
                msgDlg.Show(ex.Message);
            }
            con.Dispose(); con = null; cmd.Dispose(); cmd = null;

            return output;
        }
        #endregion
        #region -   Event Handlers   -
        private void Qry06Frm_Load(object sender, EventArgs e)
        {
            if (!PrepareNewId())
                return;
            // TODO: This line of code loads data into the 'dsQueries.vQry38c' table. You can move, or remove it, as needed.
            this.vQry38cTableAdapter.Fill(this.dsQueries.vQry38c);

            gridViewData.BeginDataUpdate();
            try
            {
                gridViewData.ClearSorting();
                gridViewData.Columns["Syndicate"].SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
                gridViewData.Columns["SubCommitte"].SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
                gridViewData.Columns["newid"].SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
            }
            finally
            {
                gridViewData.EndDataUpdate();
            }

            
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
                SqlCommand cmd = new SqlCommand(@"INSERT INTO BankExportedDataWarsa (MMashatId, ExportDate, userin, PersonId) VALUES (@MMashatId, GetDate(), @userin, @PersonId)", con);
                SqlParameter PramId = new SqlParameter("@MMashatId", SqlDbType.Int);
                SqlParameter PramUser = new SqlParameter("@userin", SqlDbType.Int);
                SqlParameter PramPersonId = new SqlParameter("@PersonId", SqlDbType.Int);
                cmd.Parameters.AddRange(new SqlParameter[] { PramId, PramUser, PramPersonId });
                SqlTransaction trn = null;
                try
                {
                    con.Open();
                    trn = con.BeginTransaction(); cmd.Transaction = trn;
                    
                    for (int i = 0; i < gridViewData.DataRowCount; i++)
                    {
                        RetirementCenter.DataSources.dsQueries.vQry38cRow row = (RetirementCenter.DataSources.dsQueries.vQry38cRow)((DataRowView)gridViewData.GetRow(i)).Row;
                        PramId.Value = row.MMashatId; PramUser.Value = Program.UserInfo.UserId; PramPersonId.Value = row.PersonId;
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