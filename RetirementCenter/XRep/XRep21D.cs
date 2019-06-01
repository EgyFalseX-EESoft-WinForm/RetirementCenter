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
    public partial class XRep21D : DevExpress.XtraReports.UI.XtraReport
    {
        public XRep21D()
        {
            InitializeComponent();
            LoadDataSource();
            SQLProvider.SetAllCommandTimeouts(Rep21_DTableAdapter, 0);
        }
        private void LoadDataSource()
        {
            new DataSources.dsReportsTableAdapters.AppOptionsTableAdapter().Fill(dsReports.AppOptions);
            rep21_ATableAdapter.Fill(dsReports.Rep21_A);
            rep21_BTableAdapter.Fill(dsReports.Rep21_B);
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

            Rep21_DTableAdapter.Fill(dsReports.Rep21_D, Synd, Dof);
            if (dsReports.Rep21_D.Count != 0)
            {
                xlDof.Text = dsReports.Rep21_D[0].DofatSarf;
                xlSynd.Text = dsReports.Rep21_D[0].Syndicate;
            }
        }

    }
}
