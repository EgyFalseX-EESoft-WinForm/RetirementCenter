﻿using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;
using RetirementCenter.DataSources;
using DevExpress.XtraEditors;
using System.Windows.Forms;
using DevExpress.XtraReports.Parameters;
using DevExpress.XtraEditors.Controls;

namespace RetirementCenter
{
    public partial class XRep05 : DevExpress.XtraReports.UI.XtraReport
    {

        public XRep05()
        {
            InitializeComponent();
            sessionCDSyndicate.ConnectionString = Properties.Settings.Default.RetirementCenterConnectionString;
            sessionTBLDofatSarf.ConnectionString = Properties.Settings.Default.RetirementCenterConnectionString;
            LoadDataSource();
        }
        private void LoadDataSource()
        {
            new DataSources.dsReportsTableAdapters.AppOptionsTableAdapter().Fill(dsReports.AppOptions);

            //DataRow dtMain = SQLProvider.SelectTBLHafzaTasleem(_hafzaId).Rows[0];
            //xlHafzaId.Text = dtMain["HafzaId"].ToString();
            //xlSyndicate.Text = dtMain["Syndicate"].ToString();
            //xlMandoopName.Text = dtMain["MandoopName"].ToString();
            //xlHafzaDate.Text = FXFW.SqlDB.ConvertToDateDMY(dtMain["HafzaDate"].ToString());
            

            //DataTable dtDetails = SQLProvider.SelectTBLHafzaTasleemDeyails(_hafzaId);
            //this.DataSource = dtDetails;

            //xtcSyndicate.DataBindings.Add("Text", this.DataSource, "Syndicate");
            //xtcMemberShipNumber.DataBindings.Add("Text", this.DataSource, "MemberShipNumber");
            //xtcMemberName.DataBindings.Add("Text", this.DataSource, "MemberName");

            //xlCount.Text = dtDetails.Rows.Count.ToString();


        }
      
        private void XRep01_ParametersRequestBeforeShow(object sender, DevExpress.XtraReports.Parameters.ParametersRequestEventArgs e)
        {
            foreach (ParameterInfo info in e.ParametersInformation)
            {
                if (info.Parameter.Name == "pramSyndicateId")
                {
                    LookUpEdit LUE = new LookUpEdit();
                    LUE.Properties.DataSource = XPCDSyndicate;
                    LUE.Properties.DisplayMember = "Syndicate";
                    LUE.Properties.ValueMember = "SyndicateId";
                    LUE.Properties.Columns.Add(new LookUpColumnInfo("Syndicate", 0, "الفرعية"));
                    LUE.Properties.BestFit();
                    LUE.Properties.NullText = string.Empty;
                    LUE.Properties.TextEditStyle = TextEditStyles.Standard;
                    //LUE.Properties.NullText = "<اختر فرعيه>";
                    info.Editor = LUE;
                    info.Parameter.Value = DBNull.Value;
                    continue;
                }
                if (info.Parameter.Name == "pramDofatSarfId")
                {
                    LookUpEdit LUE = new LookUpEdit();
                    LUE.Properties.DataSource = XPTBLDofatSarf;
                    LUE.Properties.DisplayMember = "DofatSarf";
                    LUE.Properties.ValueMember = "DofatSarfId";
                    LUE.Properties.Columns.Add(new LookUpColumnInfo("DofatSarf", 0, "النوع"));
                    LUE.Properties.BestFit();
                    LUE.Properties.NullText = string.Empty;
                    LUE.Properties.TextEditStyle = TextEditStyles.Standard;
                    //LUE.Properties.NullText = "<اختر فرعيه>";
                    info.Editor = LUE;
                    info.Parameter.Value = DBNull.Value;
                    continue;
                }
            }
        }
        private void XRep01_ParametersRequestSubmit(object sender, DevExpress.XtraReports.Parameters.ParametersRequestEventArgs e)
        {
            if (Parameters["pramSyndicateId"].Value == DBNull.Value || Parameters["pramDofatSarfId"].Value == DBNull.Value)
            {
                return;
            }
            int SyndicateId = Convert.ToInt32(Parameters["pramSyndicateId"].Value);
            int DofatSarfId = Convert.ToInt32(Parameters["pramDofatSarfId"].Value);
            rep05TableAdapter.Fill(dsReports.Rep05, SyndicateId, DofatSarfId);
            
            foreach (ParameterInfo pram in e.ParametersInformation)
            {
                if (pram.Parameter.Name == "pramSyndicateId")
                {
                    xlSyndicate.Text = ((LookUpEdit)pram.Editor).Text;
                    continue;
                }
                if (pram.Parameter.Name == "pramDofatSarfId")
                {
                    xlDofatSarf.Text = ((LookUpEdit)pram.Editor).Text;
                    continue;
                }
                
            }
        }

    }
}
