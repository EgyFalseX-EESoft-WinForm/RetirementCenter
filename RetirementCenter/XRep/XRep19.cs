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
    public partial class XRep19 : DevExpress.XtraReports.UI.XtraReport
    {
        public XRep19()
        {
            InitializeComponent();
            LoadDataSource();
            SQLProvider.SetAllCommandTimeouts(rep19_BTableAdapter, 0);
        }
        private void LoadDataSource()
        {
            new DataSources.dsReportsTableAdapters.AppOptionsTableAdapter().Fill(dsReports.AppOptions);
            rep19_A1TableAdapter.Fill(dsReports.Rep19_A);
        }
        private void XRep01_ParametersRequestBeforeShow(object sender, DevExpress.XtraReports.Parameters.ParametersRequestEventArgs e)
        {
        }
        private void XRep01_ParametersRequestSubmit(object sender, DevExpress.XtraReports.Parameters.ParametersRequestEventArgs e)
        {
            if (Parameters["pramDateStart"].Value == DBNull.Value || Parameters["pramDateEnd"].Value == DBNull.Value || Parameters["pramSynd"].Value == DBNull.Value)
                return;
            int Synd = Convert.ToInt32(Parameters["pramSynd"].Value);
            DateTime DateStart = Convert.ToDateTime(Parameters["pramDateStart"].Value);
            DateTime DateEnd = Convert.ToDateTime(Parameters["pramDateEnd"].Value);

            rep19_BTableAdapter.Fill(dsReports.Rep19_B, Synd, DateStart, DateEnd);
            if (dsReports.Rep19_B.Count != 0)
            {
                xlSynd.Text = dsReports.Rep19_B[0].Syndicate;
                xlFrom.Text = DateStart.ToShortDateString();
                xlTo.Text = DateEnd.ToShortDateString();
            }
        }

    }
}
