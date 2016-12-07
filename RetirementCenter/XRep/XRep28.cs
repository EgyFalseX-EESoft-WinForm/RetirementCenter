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
    public partial class XRep28 : DevExpress.XtraReports.UI.XtraReport
    {
        public XRep28()
        {
            InitializeComponent();
            LoadDataSource();
            SQLProvider.SetAllCommandTimeouts(rep28TableAdapter, 0);
        }
        private void LoadDataSource()
        {
            new DataSources.dsReportsTableAdapters.AppOptionsTableAdapter().Fill(dsReports.AppOptions);
            new DataSources.dsReportsTableAdapters.Rep28_ATableAdapter().Fill(dsReports.Rep28_A);
        }
        private void XRep01_ParametersRequestBeforeShow(object sender, DevExpress.XtraReports.Parameters.ParametersRequestEventArgs e)
        {
        }
        private void XRep01_ParametersRequestSubmit(object sender, DevExpress.XtraReports.Parameters.ParametersRequestEventArgs e)
        {
            if (Parameters["pramSyn"].Value == DBNull.Value || Parameters["pramDate"].Value == DBNull.Value)
                return;
            int Syn = Convert.ToInt32(Parameters["pramSyn"].Value);
            DateTime Date = Convert.ToDateTime(Parameters["pramDate"].Value);
            rep28TableAdapter.Fill(dsReports.Rep28, Syn, Date);
            if (dsReports.Rep28.Count != 0)
            {
                xlSyn.Text = dsReports.Rep28[0].Syndicate;
                xlDate.Text = dsReports.Rep28[0].reprintdate.ToShortDateString();
                xlMostalem.Text = dsReports.Rep28[0].IsmostlemNull() ? string.Empty : dsReports.Rep28[0].mostlem;
            }
        }

    }
}
