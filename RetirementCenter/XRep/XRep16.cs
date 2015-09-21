using System;
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
    public partial class XRep16 : DevExpress.XtraReports.UI.XtraReport
    {
        DataSources.dsReportsTableAdapters.QueriesTableAdapter adpQ = new DataSources.dsReportsTableAdapters.QueriesTableAdapter();
        DataSources.dsQueriesTableAdapters.CDSyndicateTableAdapter adpSyn = new DataSources.dsQueriesTableAdapters.CDSyndicateTableAdapter();
        public XRep16()
        {
            InitializeComponent();
            LoadDataSource();
        }
        private void LoadDataSource()
        {
            new DataSources.dsReportsTableAdapters.AppOptionsTableAdapter().Fill(dsReports.AppOptions);
            adpSyn.Fill(dsQueries.CDSyndicate);
        }
        private void XRep01_ParametersRequestBeforeShow(object sender, DevExpress.XtraReports.Parameters.ParametersRequestEventArgs e)
        {
            
        }
        private void XRep01_ParametersRequestSubmit(object sender, DevExpress.XtraReports.Parameters.ParametersRequestEventArgs e)
        {
            if (Parameters["pramDof"].Value == DBNull.Value)
                return;
            int Dof = Convert.ToInt32(Parameters["pramDof"].Value);

            if (Parameters["pramSyn"].Value == DBNull.Value)
                return;
            int Syn = Convert.ToInt32(Parameters["pramSyn"].Value);
            
            rep16_BTableAdapter.Fill(dsReports.Rep16_B, Dof, Syn);
            xrlSyn.Text = dsReports.Rep16_B[0].Syndicate;
        }

    }
}
