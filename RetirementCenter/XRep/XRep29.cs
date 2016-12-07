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
    public partial class XRep29 : DevExpress.XtraReports.UI.XtraReport
    {
        public XRep29()
        {
            InitializeComponent();
            LoadDataSource();
            SQLProvider.SetAllCommandTimeouts(rep29TableAdapter, 0);
        }
        private void LoadDataSource()
        {
            new DataSources.dsReportsTableAdapters.AppOptionsTableAdapter().Fill(dsReports.AppOptions);
            new DataSources.dsReportsTableAdapters.Rep29_ATableAdapter().Fill(dsReports.Rep29_A);
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
            rep29TableAdapter.Fill(dsReports.Rep29, Date, Syn);
            if (dsReports.Rep29.Count != 0)
            {
                xlSyn.Text = dsReports.Rep29[0].Syndicate;
                xlDate.Text = dsReports.Rep29[0].datetasleem.ToShortDateString();
                xlMostalem.Text = dsReports.Rep29[0].IsmostlemNull() ? string.Empty : dsReports.Rep29[0].mostlem;
            }
        }

    }
}
