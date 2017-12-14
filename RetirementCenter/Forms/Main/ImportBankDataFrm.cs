using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace RetirementCenter.Forms.Main
{
    public partial class ImportBankDataFrm : DevExpress.XtraEditors.XtraForm
    {
        public ImportBankDataFrm()
        {
            InitializeComponent();
        }

        private void btnImportMemberBank_Click(object sender, EventArgs e)
        {
             layoutControlMain.Enabled = false;

             System.Threading.ThreadPool.QueueUserWorkItem((o) =>
             {
                 try
                 {
                     //Clear Data
                     new DataSources.dsRetirementCenterTableAdapters.sdTableAdapter().ClearAllData();
                     //Get Data
                     DataSources.dsbamanatTableAdapters.اعضاء_TableAdapter adpData = new DataSources.dsbamanatTableAdapters.اعضاء_TableAdapter();
                     SQLProvider.SetAllCommandTimeouts(adpData, 0);
                     DataSources.dsQueriesTableAdapters.QueriesTableAdapter adpQry = new DataSources.dsQueriesTableAdapters.QueriesTableAdapter();
                     SQLProvider.SetAllCommandTimeouts(adpQry, 0);
                     DataSources.dsbamanat.اعضاء_DataTable TblData = new DataSources.dsbamanat.اعضاء_DataTable();
                     adpData.Fill(TblData);
                     //Import Data
                     SqlConnection connection = new SqlConnection(Properties.Settings.Default.RetirementCenterConnectionString);
                     SqlBulkCopy bulkCopy = new SqlBulkCopy(connection) { BulkCopyTimeout = 0 };
                     connection.Open();
                     bulkCopy.ColumnMappings.Clear();
                     bulkCopy.ColumnMappings.Add("معرف", "ãÚÑÝ");
                     bulkCopy.ColumnMappings.Add("معرف", "num");
                     bulkCopy.ColumnMappings.Add("[Customer ID]", "Customer_ID");
                     bulkCopy.ColumnMappings.Add("[Name]", "Name");
                     bulkCopy.ColumnMappings.Add("PAN", "PAN");
                     bulkCopy.ColumnMappings.Add("Organization", "Organization");
                     bulkCopy.ColumnMappings.Add("Department", "Department");
                     bulkCopy.DestinationTableName = "sd";
                     bulkCopy.BatchSize = TblData.Count;
                     bulkCopy.WriteToServer(TblData);
                     msgDlg.Show("تم استيراد " + TblData.Count + " عنصر" + Environment.NewLine + "سوف نقوم بتنفيذ الاجراء المخذن", msgDlg.msgButtons.Close);
                     object result = adpQry.sp_sd_Member();
                     msgDlg.Show("تم تنفيذ الاجراء بنجاح", msgDlg.msgButtons.Close);
                 }
                 catch (Exception ex)
                 {
                     msgDlg.Show(ex.Message, msgDlg.msgButtons.Close);
                 }
                 layoutControlMain.Invoke(new MethodInvoker(() => { layoutControlMain.Enabled = true; }));
             });
        }
        private void btnImportWarasaBank_Click(object sender, EventArgs e)
        {
            layoutControlMain.Enabled = false;

            System.Threading.ThreadPool.QueueUserWorkItem((o) =>
            {
                try
                {
                    //Clear Data
                    new DataSources.dsRetirementCenterTableAdapters.sdTableAdapter().ClearAllData();
                    //Get Data
                    DataSources.dsbamanatTableAdapters.ورثةTableAdapter adpData = new DataSources.dsbamanatTableAdapters.ورثةTableAdapter();
                    SQLProvider.SetAllCommandTimeouts(adpData, 0);
                    DataSources.dsQueriesTableAdapters.QueriesTableAdapter adpQry = new DataSources.dsQueriesTableAdapters.QueriesTableAdapter();
                    SQLProvider.SetAllCommandTimeouts(adpQry, 0);
                    DataSources.dsbamanat.ورثةDataTable TblData = new DataSources.dsbamanat.ورثةDataTable();
                    adpData.Fill(TblData);
                    //Import Data
                    SqlConnection connection = new SqlConnection(Properties.Settings.Default.RetirementCenterConnectionString);
                    SqlBulkCopy bulkCopy = new SqlBulkCopy(connection) { BulkCopyTimeout = 0 };
                    connection.Open();
                    bulkCopy.ColumnMappings.Clear();
                    bulkCopy.ColumnMappings.Add("معرف", "ãÚÑÝ");
                    bulkCopy.ColumnMappings.Add("معرف", "num");
                    bulkCopy.ColumnMappings.Add("[Customer ID]", "Customer_ID");
                    bulkCopy.ColumnMappings.Add("[Name]", "Name");
                    bulkCopy.ColumnMappings.Add("PAN", "PAN");
                    bulkCopy.ColumnMappings.Add("Organization", "Organization");
                    bulkCopy.ColumnMappings.Add("Department", "Department");
                    bulkCopy.DestinationTableName = "sd";
                    bulkCopy.BatchSize = TblData.Count;
                    bulkCopy.WriteToServer(TblData);
                    msgDlg.Show("تم استيراد " + TblData.Count + " عنصر" + Environment.NewLine + "سوف نقوم بتنفيذ الاجراء المخذن", msgDlg.msgButtons.Close);
                    object result = adpQry.sp_sd_Member();
                    msgDlg.Show("تم تنفيذ الاجراء بنجاح", msgDlg.msgButtons.Close);
                }
                catch (Exception ex)
                {
                    msgDlg.Show(ex.Message, msgDlg.msgButtons.Close);
                }
                layoutControlMain.Invoke(new MethodInvoker(() => { layoutControlMain.Enabled = true; }));
            });

            //sd_Warasa_Q1

        }

        
    }
}