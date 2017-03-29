using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace RetirementCenter.Forms.Main
{
    public partial class SyncETSMobileFrm : DevExpress.XtraEditors.XtraForm
    {
        public SyncETSMobileFrm()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            System.Threading.ThreadPool.QueueUserWorkItem((o) => 
            {
                btnUpdateEnable = false;
                ProgressValue = 0;
                ProgressMax = 14;
                try
                {
                    // Set connection string
                    System.Data.SqlClient.SqlConnectionStringBuilder sql = new System.Data.SqlClient.SqlConnectionStringBuilder(Properties.Settings.Default.ETSMOBILEConnectionString);
                    SqlConnection connection = new SqlConnection(Properties.Settings.Default.ETSMOBILEConnectionString);
                    SqlBulkCopy bulkCopy = new SqlBulkCopy(connection) { BulkCopyTimeout = 0 };
                    connection.Open();
                    
                    sql.DataSource = tbServer.Text; sql.UserID = tbUser.Text; sql.Password = tbPass.Text;
                    Properties.Settings.Default["ETSMOBILEConnectionString"] = sql.ConnectionString;
                    //Datasets
                    DataSources.dsEtsMobile dsMob = new DataSources.dsEtsMobile();
                    DataSources.dsQueries dsQry = new DataSources.dsQueries();

                    //Get MaxIds
                    DataSources.dsEtsMobileTableAdapters.QueriesTableAdapter adpQry = new DataSources.dsEtsMobileTableAdapters.QueriesTableAdapter();
                    SetStatus = "Get missing recored in CDSyndicate";
                    int maxIdCDSyndicate = adpQry.CDSyndicate_MaxId() ?? 0;
                    ProgressValue += 1;
                    SetStatus = "Get missing recored in CDSubCommitte";
                    int maxIdCDSubCommitte = adpQry.CDSubCommitte_MaxId() ?? 0;
                    ProgressValue += 1;
                    SetStatus = "Get missing recored in TBLDofatSarf";
                    int maxIdTBLDofatSarf = adpQry.TBLDofatSarf_MaxId() ?? 0;
                    ProgressValue += 1;
                    SetStatus = "Get missing recored in TBLMashat";
                    int maxIdTBLMashat = adpQry.TBLMashat_MaxId() ?? 0;
                    ProgressValue += 1;
                    SetStatus = "Get missing recored in TBLWarasa";
                    int maxIdTBLWarasa = adpQry.TBLWarasa_MaxId() ?? 0;
                    ProgressValue += 1;
                    SetStatus = "Get missing recored in tblmemberbank";
                    long maxIdtblmemberbank = adpQry.tblmemberbank_MaxId() ?? 0;
                    ProgressValue += 1;
                    SetStatus = "Get missing recored in tblWarasabank";
                    long maxIdtblWarasabank = adpQry.tblWarasabank_MaxId() ?? 0;
                    ProgressValue += 1;
                    
                    //CDSyndicate
                    SetStatus = "prepare data in CDSyndicate";
                    new DataSources.dsQueriesTableAdapters.CDSyndicateTableAdapter().FillBy_ForMob(dsQry.CDSyndicate, maxIdCDSyndicate);
                    foreach (var item in dsQry.CDSyndicate)
                        dsMob.CDSyndicate.AddCDSyndicateRow(item.SyndicateId, item.Syndicate);
                    new DataSources.dsEtsMobileTableAdapters.CDSyndicateTableAdapter().Update(dsMob.CDSyndicate);
                    ProgressValue += 1;
                    //CDSubCommitte
                    SetStatus = "prepare data in CDSubCommitte";
                    new DataSources.dsQueriesTableAdapters.CDSubCommitteTableAdapter().FillBy_ForMob(dsQry.CDSubCommitte, maxIdCDSubCommitte);
                    foreach (var item in dsQry.CDSubCommitte)
                        dsMob.CDSubCommitte.AddCDSubCommitteRow(item.SubCommitteId, item.SubCommitte, item.SyndicateId, 0, 0);
                    new DataSources.dsEtsMobileTableAdapters.CDSubCommitteTableAdapter().Update(dsMob.CDSubCommitte);
                    ProgressValue += 1;
                    //TBLDofatSarf
                    SetStatus = "prepare data in TBLDofatSarf";
                    new DataSources.dsQueriesTableAdapters.TBLDofatSarfTableAdapter().FillBy_ForMob(dsQry.TBLDofatSarf, maxIdTBLDofatSarf);
                    foreach (var item in dsQry.TBLDofatSarf)
                        dsMob.TBLDofatSarf.AddTBLDofatSarfRow(item.DofatSarfId, item.DofatSarf, item.DofatSarfDatefrom, item.DofatSarfDateto, item.IsremdNull() ? string.Empty : item.remd, false);
                    new DataSources.dsEtsMobileTableAdapters.TBLDofatSarfTableAdapter().Update(dsMob.TBLDofatSarf);
                    ProgressValue += 1;
                    //TBLMashat
                    SetStatus = "prepare data in TBLMashat";
                    new DataSources.dsQueriesTableAdapters.TBLMashat_ForMobTableAdapter().Fill(dsQry.TBLMashat_ForMob, maxIdTBLMashat);
                    foreach (var item in dsQry.TBLMashat_ForMob)
                    {
                        DataSources.dsEtsMobile.TBLMashatRow row = dsMob.TBLMashat.NewTBLMashatRow();
                        row.MMashatId = item.MMashatId;
                        row.MMashatName = item.MMashatName;
                        row.SyndicateId = item.SyndicateId;
                        row.SubCommitteId = item.SubCommitteId;
                        row.MashHalaId = item.MashHalaId;
                        row.sarfnumber = item.sarfnumber;
                        if (!row.IshafzanoNull())
                            row.hafzano = item.hafza;
                        if (!row.IshafzadateNull())
                            row.hafzadate = item.hafzadate;
                        dsMob.TBLMashat.AddTBLMashatRow(row);
                    }
                    bulkCopy.ColumnMappings.Clear();
                    bulkCopy.ColumnMappings.Add("MMashatId", "MMashatId");
                    bulkCopy.ColumnMappings.Add("MMashatName", "MMashatName");
                    bulkCopy.ColumnMappings.Add("SyndicateId", "SyndicateId");
                    bulkCopy.ColumnMappings.Add("SubCommitteId", "SubCommitteId");
                    bulkCopy.ColumnMappings.Add("MashHalaId", "MashHalaId");
                    bulkCopy.ColumnMappings.Add("sarfnumber", "sarfnumber");
                    bulkCopy.ColumnMappings.Add("hafzano", "hafzano");
                    bulkCopy.ColumnMappings.Add("hafzadate", "hafzadate");
                    bulkCopy.DestinationTableName = "TBLMashat";
                    bulkCopy.BatchSize = dsMob.TBLMashat.Count;
                    bulkCopy.WriteToServer(dsMob.TBLMashat);
                    ProgressValue += 1;
                    //TBLWarasa
                    SetStatus = "prepare data in TBLWarasa";
                    new DataSources.dsQueriesTableAdapters.TBLWarasa_ForMobTableAdapter().Fill(dsQry.TBLWarasa_ForMob, maxIdTBLWarasa);
                    foreach (var item in dsQry.TBLWarasa_ForMob)
                        dsMob.TBLWarasa.AddTBLWarasaRow(item.PersonId, item.MMashatId, item.WarasaTypeId, item.personName, item.yasref, item.SyndicateId, item.SubCommitteId, item.responsiblesarf, item.responsiblesarfId, item.Iscode60Null() ? 0 : item.code60);
                    bulkCopy.ColumnMappings.Clear();
                    bulkCopy.ColumnMappings.Add("PersonId", "PersonId");
                    bulkCopy.ColumnMappings.Add("MMashatId", "MMashatId");
                    bulkCopy.ColumnMappings.Add("WarasaTypeId", "WarasaTypeId");
                    bulkCopy.ColumnMappings.Add("personName", "personName");
                    bulkCopy.ColumnMappings.Add("yasref", "yasref");
                    bulkCopy.ColumnMappings.Add("SyndicateId", "SyndicateId");
                    bulkCopy.ColumnMappings.Add("SubCommitteId", "SubCommitteId");
                    bulkCopy.ColumnMappings.Add("responsiblesarf", "responsiblesarf");
                    bulkCopy.ColumnMappings.Add("responsiblesarfId", "responsiblesarfId");
                    bulkCopy.ColumnMappings.Add("code60", "code60");
                    bulkCopy.DestinationTableName = "TBLWarasa";
                    bulkCopy.BatchSize = dsMob.TBLWarasa.Count;
                    bulkCopy.WriteToServer(dsMob.TBLWarasa);
                    ProgressValue += 1;
                    //tblmemberbank
                    SetStatus = "prepare data in tblmemberbank";
                    new DataSources.dsQueriesTableAdapters.tblmemberbank_ForMobTableAdapter().Fill(dsQry.tblmemberbank_ForMob, maxIdtblmemberbank);
                    foreach (var item in dsQry.tblmemberbank_ForMob)
                    {
                        DataSources.dsEtsMobile.tblmemberbankRow row = dsMob.tblmemberbank.NewtblmemberbankRow();
                        row.MMashatId = item.MMashatId;
                        row.DofatSarfId = item.DofatSarfId;
                        row.summony = item.summony;
                        row.AutoId = item.AutoId;
                        if (!item.IssendbankdateNull())
                            row.sendbankdate = item.sendbankdate;
                        if (!item.IsamanatmonyNull())
                            row.amanatmony = item.amanatmony;
                        if (!item.IsamanatwareddateNull())
                            row.amanatwareddate = item.amanatwareddate;

                        dsMob.tblmemberbank.AddtblmemberbankRow(row);
                    }
                    bulkCopy.ColumnMappings.Clear();
                    bulkCopy.ColumnMappings.Add("MMashatId", "MMashatId");
                    bulkCopy.ColumnMappings.Add("DofatSarfId", "DofatSarfId");
                    bulkCopy.ColumnMappings.Add("summony", "summony");
                    bulkCopy.ColumnMappings.Add("AutoId", "AutoId");
                    bulkCopy.ColumnMappings.Add("sendbankdate", "sendbankdate");
                    bulkCopy.ColumnMappings.Add("amanatmony", "amanatmony");
                    bulkCopy.ColumnMappings.Add("amanatwareddate", "amanatwareddate");
                    bulkCopy.DestinationTableName = "tblmemberbank";
                    bulkCopy.BatchSize = dsMob.tblmemberbank.Count;
                    bulkCopy.WriteToServer(dsMob.tblmemberbank);
                    ProgressValue += 1;
                    //tblWarasabank
                    SetStatus = "prepare data in tblWarasabank";
                    new DataSources.dsQueriesTableAdapters.tblWarasabank_ForMobTableAdapter().Fill(dsQry.tblWarasabank_ForMob, maxIdtblWarasabank);
                    foreach (var item in dsQry.tblWarasabank_ForMob)
                    {
                        DataSources.dsEtsMobile.tblWarasabankRow row = dsMob.tblWarasabank.NewtblWarasabankRow();
                        row.MMashatId = item.MMashatId;
                        row.DofatSarfId = item.DofatSarfId;
                        row.PersonId = item.PersonId;
                        row.visanumber = item.visanumber;
                        row.SyndicateId = item.SyndicateId;
                        row.SubCommitteId = item.SubCommitteId;
                        row.summony = item.summony;
                        if (!item.IssendbankdateNull())
                            row.sendbankdate = item.sendbankdate;
                        if (!item.IsamanatmonyNull())
                            row.amanatmony = item.amanatmony;
                        if (!item.IsamanatwareddateNull())
                            row.amanatwareddate = item.amanatwareddate;
                        row.datein = DateTime.Now;
                        row.userin = Program.UserInfo.UserId;
                        row.newid = item.newid;
                        row.AutoId = item.AutoId;

                        dsMob.tblWarasabank.AddtblWarasabankRow(row);
                            
                    }
                    bulkCopy.ColumnMappings.Clear();
                    bulkCopy.ColumnMappings.Add("MMashatId", "MMashatId");
                    bulkCopy.ColumnMappings.Add("DofatSarfId", "DofatSarfId");
                    bulkCopy.ColumnMappings.Add("PersonId", "PersonId");
                    bulkCopy.ColumnMappings.Add("visanumber", "visanumber");
                    bulkCopy.ColumnMappings.Add("SyndicateId", "SyndicateId");
                    bulkCopy.ColumnMappings.Add("SubCommitteId", "SubCommitteId");
                    bulkCopy.ColumnMappings.Add("summony", "summony");
                    bulkCopy.ColumnMappings.Add("newid", "newid");
                    bulkCopy.ColumnMappings.Add("AutoId", "AutoId");
                    bulkCopy.ColumnMappings.Add("sendbankdate", "sendbankdate");
                    bulkCopy.ColumnMappings.Add("amanatmony", "amanatmony");
                    bulkCopy.ColumnMappings.Add("amanatwareddate", "amanatwareddate");
                    bulkCopy.ColumnMappings.Add("datein", "datein");
                    bulkCopy.ColumnMappings.Add("userin", "userin");
                    bulkCopy.DestinationTableName = "tblWarasabank";
                    bulkCopy.BatchSize = dsMob.tblWarasabank.Count;
                    bulkCopy.WriteToServer(dsMob.tblWarasabank);
                    ProgressValue += 1;

                    connection.Close();
                    SetStatus = "...";
                }
                catch (Exception ex)
                {
                    SetStatus = ex.Message;
                }
                btnUpdateEnable = true;
            });
            
        }

        public int ProgressValue{
            get
            {
                return (int)pbcUpdate.EditValue;
            }
            set 
            {
                this.Invoke(new MethodInvoker(() => 
                {
                    pbcUpdate.EditValue = value;
                }));
            }
        }
        public int ProgressMax
        {
            get
            {
                return (int)pbcUpdate.Properties.Maximum;
            }
            set
            {
                this.Invoke(new MethodInvoker(() =>
                {
                    pbcUpdate.Properties.Maximum = value;
                }));
            }
        }
        public bool btnUpdateEnable
        {
            set
            {
                this.Invoke(new MethodInvoker(() =>
                {
                    btnUpdate.Enabled = value;
                }));
            }
        }
        public string SetStatus
        {
            set
            {
                this.Invoke(new MethodInvoker(() =>
                {
                    lblStatus.Text = value;
                }));
            }
        }

    }
}