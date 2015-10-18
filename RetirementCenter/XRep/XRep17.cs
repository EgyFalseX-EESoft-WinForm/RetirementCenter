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
    public partial class XRep17 : DevExpress.XtraReports.UI.XtraReport
    {
        public XRep17()
        {
            InitializeComponent();
            LoadDataSource();
            SQLProvider.SetAllCommandTimeouts(rep17_CTableAdapter, 0);
        }
        private void LoadDataSource()
        {
            new DataSources.dsReportsTableAdapters.AppOptionsTableAdapter().Fill(dsReports.AppOptions);
            rep17_ATableAdapter.Fill(dsReports.Rep17_A);
            rep17_BTableAdapter1.Fill(dsReports.Rep17_B);
        }
        private void XRep01_ParametersRequestBeforeShow(object sender, DevExpress.XtraReports.Parameters.ParametersRequestEventArgs e)
        {
        }
        private void XRep01_ParametersRequestSubmit(object sender, DevExpress.XtraReports.Parameters.ParametersRequestEventArgs e)
        {
            if (Parameters["pramDof"].Value == DBNull.Value || Parameters["pramSynd"].Value == DBNull.Value)
                return;
            int Dof = Convert.ToInt32(Parameters["pramDof"].Value);
            int Synd = Convert.ToInt32(Parameters["pramSynd"].Value);
            rep17_CTableAdapter.Fill(dsReports.Rep17_C, Dof, Synd);
            if (dsReports.Rep17_C.Count != 0)
            {
                xlDof.Text = dsReports.Rep17_C[0].DofatSarf;
                xlSynd.Text = dsReports.Rep17_C[0].Syndicate;
            }
        }

    }
}
