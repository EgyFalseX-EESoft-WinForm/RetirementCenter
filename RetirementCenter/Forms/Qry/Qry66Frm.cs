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
    public partial class Qry66Frm : DevExpress.XtraEditors.XtraForm
    {
        DataSources.Linq.dsTeachersUnionViewsDataContext dsLinq = new DataSources.Linq.dsTeachersUnionViewsDataContext();
        #region -   Functions   -
        public Qry66Frm()
        {
            InitializeComponent();
        }
        #endregion
        #region -   Event Handlers   -
        private void Qry06Frm_Load(object sender, EventArgs e)
        {
            LSMSTBLDofatSarf.QueryableSource = from q in dsLinq.TBLDofatSarfs select q;
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
                SqlCommand cmd = new SqlCommand(@"UPDATE [dbo].[tblWarasabank] SET [sendbankdate] = GETDATE() WHERE PersonId = @PersonId AND DofatSarfId = @DofatSarfId AND sendbankdate IS NULL", con);
                SqlParameter PramId = new SqlParameter("@PersonId", SqlDbType.Int);
                SqlParameter PramDofatSarfId = new SqlParameter("@DofatSarfId", SqlDbType.Int) { Value = Convert.ToInt32(LUETBLDofatSarf.EditValue) };
                cmd.Parameters.AddRange(new SqlParameter[] { PramId, PramDofatSarfId });
                SqlTransaction trn = null;
                try
                {
                    con.Open();
                    trn = con.BeginTransaction(); cmd.Transaction = trn;
                    
                    for (int i = 0; i < gridViewData.DataRowCount; i++)
                    {
                        RetirementCenter.DataSources.dsQueries.vQry66Row row = (RetirementCenter.DataSources.dsQueries.vQry66Row)((DataRowView)gridViewData.GetRow(i)).Row;
                        PramId.Value = row.PersonId;
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
        private void LUETBLDofatSarf_EditValueChanged(object sender, EventArgs e)
        {
            vQry66TableAdapter.Fill(dsQueries.vQry66, Convert.ToInt32(LUETBLDofatSarf.EditValue));
            gridControlData.DataSource = dsQueries.vQry66;
        }     
        #endregion

    }
}