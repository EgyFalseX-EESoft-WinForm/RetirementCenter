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
                ProgressMax = 16;
                try
                {
                    // Set connection string
                    System.Data.SqlClient.SqlConnectionStringBuilder sql = new System.Data.SqlClient.SqlConnectionStringBuilder(Properties.Settings.Default.ETSMOBILEConnectionString);
                    sql.DataSource = tbServer.Text; sql.UserID = tbUser.Text; sql.Password = tbPass.Text;
                    Properties.Settings.Default["ETSMOBILEConnectionString"] = sql.ConnectionString;

                    SqlConnection connection = new SqlConnection(Properties.Settings.Default.ETSMOBILEConnectionString);
                    SqlBulkCopy bulkCopy = new SqlBulkCopy(connection) { BulkCopyTimeout = 0 };
                    connection.Open();
                    
                    //Datasets
                    DataSources.dsEtsMobile dsMob = new DataSources.dsEtsMobile();
                    DataSources.dsQueries dsQry = new DataSources.dsQueries();

                    //Get MaxIds
                    DataSources.dsEtsMobileTableAdapters.QueriesTableAdapter adpQry = new DataSources.dsEtsMobileTableAdapters.QueriesTableAdapter();
                    SQLProvider.SetAllCommandTimeouts(adpQry, 0);
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

                    //Update tblmemberbank
                    SetStatus = "update old data in tblmemberbank";
                    Updatetblmemberbank(bulkCopy, dsMob);
                    ProgressValue += 1;
                    //Update tblWarasabank
                    SetStatus = "update old data in tblWarasabank";
                    UpdatetblWarasabank(bulkCopy, dsMob);
                    ProgressValue += 1;
                    //CDSyndicate
                    SetStatus = "prepare data in CDSyndicate";
                    InsertCDSyndicate(dsMob, dsQry, maxIdCDSyndicate);
                    ProgressValue += 1;
                    //CDSubCommitte
                    SetStatus = "prepare data in CDSubCommitte";
                    InsertCDSubCommitte(dsMob, dsQry, maxIdCDSubCommitte);
                    ProgressValue += 1;
                    //TBLDofatSarf
                    SetStatus = "prepare data in TBLDofatSarf";
                    InsertTBLDofatSarf(dsMob, dsQry, maxIdTBLDofatSarf);
                    ProgressValue += 1;
                    //TBLMashat
                    SetStatus = "prepare data in TBLMashat";
                    InsertTBLMashat(bulkCopy, dsMob, dsQry, maxIdTBLMashat);
                    ProgressValue += 1;
                    //TBLWarasa
                    SetStatus = "prepare data in TBLWarasa";
                    InsertTBLWarasa(bulkCopy, dsMob, dsQry, maxIdTBLWarasa);
                    ProgressValue += 1;
                    //tblmemberbank
                    SetStatus = "prepare data in tblmemberbank";
                    Inserttblmemberbank(bulkCopy, dsMob, dsQry, maxIdtblmemberbank);
                    ProgressValue += 1;
                    //tblWarasabank
                    SetStatus = "prepare data in tblWarasabank";
                    InserttblWarasabank(bulkCopy, dsMob, dsQry, maxIdtblWarasabank);
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

        private static void Updatetblmemberbank(SqlBulkCopy bulkCopy, DataSources.dsEtsMobile dsMob)
        {
            SqlConnection connectionLocal = new SqlConnection(Properties.Settings.Default.RetirementCenterConnectionString);
            SqlBulkCopy bulkCopyLocal = new SqlBulkCopy(connectionLocal) { BulkCopyTimeout = 0 };
            connectionLocal.Open();

            SqlConnection con = new SqlConnection(Properties.Settings.Default["RetirementCenterConnectionString"].ToString());
            SqlCommand cmd = new SqlCommand("", con) { CommandTimeout = 0 };
            SqlDataReader dr = null;
            con.Open();
            //get data than need and update from Mob
            new DataSources.dsEtsMobileTableAdapters.UpdatetblmemberbankTableAdapter().Fill(dsMob.Updatetblmemberbank);
            string BulkTableName = string.Format("tmp{0}{1}{2}{3}{4}{5}{6}", DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second, DateTime.Now.Millisecond);
            cmd.CommandText = string.Format(@"SELECT AutoId, amanatwareddate, amanatmony INTO {0} FROM tblmemberbank WHERE 1 = 0;", BulkTableName);
            cmd.ExecuteNonQuery();
            bulkCopyLocal.ColumnMappings.Clear();
            bulkCopyLocal.ColumnMappings.Add("AutoId", "AutoId");
            bulkCopyLocal.ColumnMappings.Add("amanatmony", "amanatmony");
            bulkCopyLocal.ColumnMappings.Add("amanatwareddate", "amanatwareddate");
            bulkCopyLocal.DestinationTableName = BulkTableName;
            bulkCopyLocal.BatchSize = dsMob.Updatetblmemberbank.Count;
            bulkCopyLocal.WriteToServer(dsMob.Updatetblmemberbank);
            cmd.CommandText = string.Format(@"merge into {0} as Target 
                    using tblmemberbank as Source on Target.AutoId = Source.AutoId when matched then 
                    update set 
                    Target.amanatwareddate = Source.amanatwareddate,
                    Target.amanatmony = Source.amanatmony;", BulkTableName);
            cmd.ExecuteNonQuery();
            cmd.CommandText = string.Format("SELECT AutoId, amanatwareddate, amanatmony FROM {0} WHERE amanatwareddate IS NOT NULL", BulkTableName);
            dr = cmd.ExecuteReader();
            dsMob.Updatetblmemberbank.Clear();
            while (dr.Read())
            {
                DataSources.dsEtsMobile.UpdatetblmemberbankRow row = dsMob.Updatetblmemberbank.NewUpdatetblmemberbankRow();
                row.AutoId = dr.GetInt64(0);
                row.amanatwareddate = dr.GetDateTime(1);
                row.amanatmony = dr.GetDouble(2);
                dsMob.Updatetblmemberbank.AddUpdatetblmemberbankRow(row);
            }
            dr.Close();
            cmd.CommandText = string.Format(@"DROP TABLE {0}", BulkTableName);
            cmd.ExecuteNonQuery();
            con.Close();
            con.ConnectionString = Properties.Settings.Default["ETSMOBILEConnectionString"].ToString();
            con.Open();

            cmd.CommandText = string.Format(@"SELECT AutoId, amanatwareddate, amanatmony INTO {0} FROM tblmemberbank WHERE 1 = 0;", BulkTableName);
            cmd.ExecuteNonQuery();
            bulkCopy.ColumnMappings.Clear();
            bulkCopy.ColumnMappings.Add("AutoId", "AutoId");
            bulkCopy.ColumnMappings.Add("amanatmony", "amanatmony");
            bulkCopy.ColumnMappings.Add("amanatwareddate", "amanatwareddate");
            bulkCopy.DestinationTableName = BulkTableName;
            bulkCopy.BatchSize = dsMob.Updatetblmemberbank.Count;
            bulkCopy.WriteToServer(dsMob.Updatetblmemberbank);
            cmd.CommandText = string.Format(@"merge into tblmemberbank as Target 
                    using {0} as Source on Target.AutoId = Source.AutoId when matched then 
                    update set 
                    Target.amanatwareddate = Source.amanatwareddate,
                    Target.amanatmony = Source.amanatmony;", BulkTableName);
            cmd.ExecuteNonQuery();
            cmd.CommandText = string.Format(@"DROP TABLE {0}", BulkTableName);
            cmd.ExecuteNonQuery();
            con.Close(); con.Dispose(); cmd.Dispose();
        }
        private static void UpdatetblWarasabank(SqlBulkCopy bulkCopy, DataSources.dsEtsMobile dsMob)
        {
            SqlConnection connectionLocal = new SqlConnection(Properties.Settings.Default.RetirementCenterConnectionString);
            SqlBulkCopy bulkCopyLocal = new SqlBulkCopy(connectionLocal) { BulkCopyTimeout = 0 };
            connectionLocal.Open();

            SqlConnection con = new SqlConnection(Properties.Settings.Default["RetirementCenterConnectionString"].ToString());
            SqlCommand cmd = new SqlCommand("", con) { CommandTimeout = 0 };
            SqlDataReader dr = null;
            con.Open();
            //get data than need and update from Mob
            new DataSources.dsEtsMobileTableAdapters.UpdatetblWarasabankTableAdapter().Fill(dsMob.UpdatetblWarasabank);
            string BulkTableName = string.Format("tmp{0}{1}{2}{3}{4}{5}{6}", DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second, DateTime.Now.Millisecond);
            cmd.CommandText = string.Format(@"SELECT AutoId, amanatwareddate, amanatmony INTO {0} FROM tblWarasabank WHERE 1 = 0;", BulkTableName);
            cmd.ExecuteNonQuery();
            bulkCopyLocal.ColumnMappings.Clear();
            bulkCopyLocal.ColumnMappings.Add("AutoId", "AutoId");
            bulkCopyLocal.ColumnMappings.Add("amanatmony", "amanatmony");
            bulkCopyLocal.ColumnMappings.Add("amanatwareddate", "amanatwareddate");
            bulkCopyLocal.DestinationTableName = BulkTableName;
            bulkCopyLocal.BatchSize = dsMob.UpdatetblWarasabank.Count;
            bulkCopyLocal.WriteToServer(dsMob.UpdatetblWarasabank);
            cmd.CommandText = string.Format(@"merge into {0} as Target 
                    using tblWarasabank as Source on Target.AutoId = Source.AutoId when matched then 
                    update set 
                    Target.amanatwareddate = Source.amanatwareddate,
                    Target.amanatmony = Source.amanatmony;", BulkTableName);
            cmd.ExecuteNonQuery();
            cmd.CommandText = string.Format("SELECT AutoId, amanatwareddate, amanatmony FROM {0} WHERE amanatwareddate IS NOT NULL", BulkTableName);
            dr = cmd.ExecuteReader();
            dsMob.UpdatetblWarasabank.Clear();
            while (dr.Read())
            {
                DataSources.dsEtsMobile.UpdatetblWarasabankRow row = dsMob.UpdatetblWarasabank.NewUpdatetblWarasabankRow();
                row.AutoId = dr.GetInt64(0);
                row.amanatwareddate = dr.GetDateTime(1);
                row.amanatmony = dr.GetDouble(2);
                dsMob.UpdatetblWarasabank.AddUpdatetblWarasabankRow(row);
            }
            dr.Close();
            
            cmd.CommandText = string.Format(@"DROP TABLE {0}", BulkTableName);
            cmd.ExecuteNonQuery();
            con.Close();
            con.ConnectionString = Properties.Settings.Default["ETSMOBILEConnectionString"].ToString();
            con.Open();

            cmd.CommandText = string.Format(@"SELECT AutoId, amanatwareddate, amanatmony INTO {0} FROM tblWarasabank WHERE 1 = 0;", BulkTableName);
            cmd.ExecuteNonQuery();
            bulkCopy.ColumnMappings.Clear();
            bulkCopy.ColumnMappings.Add("AutoId", "AutoId");
            bulkCopy.ColumnMappings.Add("amanatmony", "amanatmony");
            bulkCopy.ColumnMappings.Add("amanatwareddate", "amanatwareddate");
            bulkCopy.DestinationTableName = BulkTableName;
            bulkCopy.BatchSize = dsMob.UpdatetblWarasabank.Count;
            bulkCopy.WriteToServer(dsMob.UpdatetblWarasabank);
            cmd.CommandText = string.Format(@"merge into tblWarasabank as Target 
                    using {0} as Source on Target.AutoId = Source.AutoId when matched then 
                    update set 
                    Target.amanatwareddate = Source.amanatwareddate,
                    Target.amanatmony = Source.amanatmony;", BulkTableName);
            cmd.ExecuteNonQuery();
            cmd.CommandText = string.Format(@"DROP TABLE {0}", BulkTableName);
            cmd.ExecuteNonQuery();
            con.Close(); con.Dispose(); cmd.Dispose();
        }
        private static void InserttblWarasabank(SqlBulkCopy bulkCopy, DataSources.dsEtsMobile dsMob, DataSources.dsQueries dsQry, long maxIdtblWarasabank)
        {
            DataSources.dsQueriesTableAdapters.tblWarasabank_ForMobTableAdapter adp = new DataSources.dsQueriesTableAdapters.tblWarasabank_ForMobTableAdapter();
            SQLProvider.SetAllCommandTimeouts(adp, 0);
            adp.Fill(dsQry.tblWarasabank_ForMob, maxIdtblWarasabank);
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
        }
        private static void Inserttblmemberbank(SqlBulkCopy bulkCopy, DataSources.dsEtsMobile dsMob, DataSources.dsQueries dsQry, long maxIdtblmemberbank)
        {
            DataSources.dsQueriesTableAdapters.tblmemberbank_ForMobTableAdapter adp = new DataSources.dsQueriesTableAdapters.tblmemberbank_ForMobTableAdapter();
            SQLProvider.SetAllCommandTimeouts(adp, 0);
            adp.Fill(dsQry.tblmemberbank_ForMob, maxIdtblmemberbank);
            SQLProvider.SetAllCommandTimeouts(adp, 0);
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
        }
        private static void InsertTBLWarasa(SqlBulkCopy bulkCopy, DataSources.dsEtsMobile dsMob, DataSources.dsQueries dsQry, int maxIdTBLWarasa)
        {
            DataSources.dsQueriesTableAdapters.TBLWarasa_ForMobTableAdapter adp = new DataSources.dsQueriesTableAdapters.TBLWarasa_ForMobTableAdapter();
            SQLProvider.SetAllCommandTimeouts(adp, 0);
            adp.Fill(dsQry.TBLWarasa_ForMob, maxIdTBLWarasa);
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
        }
        private static void InsertTBLMashat(SqlBulkCopy bulkCopy, DataSources.dsEtsMobile dsMob, DataSources.dsQueries dsQry, int maxIdTBLMashat)
        {
            DataSources.dsQueriesTableAdapters.TBLMashat_ForMobTableAdapter adp = new DataSources.dsQueriesTableAdapters.TBLMashat_ForMobTableAdapter();
            SQLProvider.SetAllCommandTimeouts(adp, 0);
            adp.Fill(dsQry.TBLMashat_ForMob, maxIdTBLMashat);
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
        }
        private static void InsertTBLDofatSarf(DataSources.dsEtsMobile dsMob, DataSources.dsQueries dsQry, int maxIdTBLDofatSarf)
        {
            DataSources.dsQueriesTableAdapters.TBLDofatSarfTableAdapter adp = new DataSources.dsQueriesTableAdapters.TBLDofatSarfTableAdapter();
            SQLProvider.SetAllCommandTimeouts(adp, 0);
            adp.FillBy_ForMob(dsQry.TBLDofatSarf, maxIdTBLDofatSarf);
            foreach (var item in dsQry.TBLDofatSarf)
                dsMob.TBLDofatSarf.AddTBLDofatSarfRow(item.DofatSarfId, item.DofatSarf, item.DofatSarfDatefrom, item.DofatSarfDateto, item.IsremdNull() ? string.Empty : item.remd, false);
            DataSources.dsEtsMobileTableAdapters.TBLDofatSarfTableAdapter adpUpdate = new DataSources.dsEtsMobileTableAdapters.TBLDofatSarfTableAdapter();
            SQLProvider.SetAllCommandTimeouts(adpUpdate, 0);
            adpUpdate.Update(dsMob.TBLDofatSarf);
        }
        private static void InsertCDSubCommitte(DataSources.dsEtsMobile dsMob, DataSources.dsQueries dsQry, int maxIdCDSubCommitte)
        {
            new DataSources.dsQueriesTableAdapters.CDSubCommitteTableAdapter().FillBy_ForMob(dsQry.CDSubCommitte, maxIdCDSubCommitte);
            foreach (var item in dsQry.CDSubCommitte)
                dsMob.CDSubCommitte.AddCDSubCommitteRow(item.SubCommitteId, item.SubCommitte, item.SyndicateId, 0, 0);
            new DataSources.dsEtsMobileTableAdapters.CDSubCommitteTableAdapter().Update(dsMob.CDSubCommitte);
        }
        private void InsertCDSyndicate(DataSources.dsEtsMobile dsMob, DataSources.dsQueries dsQry, int maxIdCDSyndicate)
        {            
            new DataSources.dsQueriesTableAdapters.CDSyndicateTableAdapter().FillBy_ForMob(dsQry.CDSyndicate, maxIdCDSyndicate);
            foreach (var item in dsQry.CDSyndicate)
                dsMob.CDSyndicate.AddCDSyndicateRow(item.SyndicateId, item.Syndicate);
            new DataSources.dsEtsMobileTableAdapters.CDSyndicateTableAdapter().Update(dsMob.CDSyndicate);
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