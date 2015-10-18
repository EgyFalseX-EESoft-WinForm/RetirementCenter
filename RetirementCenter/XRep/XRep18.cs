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
    public partial class XRep18 : DevExpress.XtraReports.UI.XtraReport
    {
        public XRep18()
        {
            InitializeComponent();
            LoadDataSource();
            SQLProvider.SetAllCommandTimeouts(rep18_CTableAdapter, 0);
        }
        private void LoadDataSource()
        {
            new DataSources.dsReportsTableAdapters.AppOptionsTableAdapter().Fill(dsReports.AppOptions);
            rep18_ATableAdapter.Fill(dsReports.Rep18_A);
            rep18_BTableAdapter.Fill(dsReports.Rep18_B);
        }
        private void XRep01_ParametersRequestBeforeShow(object sender, DevExpress.XtraReports.Parameters.ParametersRequestEventArgs e)
        {
        }
        private void XRep01_ParametersRequestSubmit(object sender, DevExpress.XtraReports.Parameters.ParametersRequestEventArgs e)
        {
            if (Parameters["pramDof"].Value == DBNull.Value || Parameters["pramSynd"].Value == DBNull.Value)
                return;
            int Date = Convert.ToInt32(Parameters["pramDof"].Value);
            int Synd = Convert.ToInt32(Parameters["pramSynd"].Value);

            rep18_CTableAdapter.Fill(dsReports.Rep18_C, Date, Synd);
            if (dsReports.Rep18_C.Count != 0)
            {
                xlDof.Text = dsReports.Rep18_C[0].DofatSarf;
                xlSynd.Text = dsReports.Rep18_C[0].Syndicate;
            }
        }

    }
}
