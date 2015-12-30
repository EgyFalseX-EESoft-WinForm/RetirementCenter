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
    public partial class XRep23 : DevExpress.XtraReports.UI.XtraReport
    {
        public XRep23()
        {
            InitializeComponent();
            LoadDataSource();
            SQLProvider.SetAllCommandTimeouts(rep23_BTableAdapter, 0);
        }
        private void LoadDataSource()
        {
            new DataSources.dsReportsTableAdapters.AppOptionsTableAdapter().Fill(dsReports.AppOptions);
            rep23_ATableAdapter.Fill(dsReports.Rep23_A);
        }
        private void XRep01_ParametersRequestBeforeShow(object sender, DevExpress.XtraReports.Parameters.ParametersRequestEventArgs e)
        {
        }
        private void XRep01_ParametersRequestSubmit(object sender, DevExpress.XtraReports.Parameters.ParametersRequestEventArgs e)
        {
            if (Parameters["pramDof"].Value == DBNull.Value)
                return;
            int Dof = Convert.ToInt32(Parameters["pramDof"].Value);
            rep23_BTableAdapter.Fill(dsReports.Rep23_B, Dof);
            if (dsReports.Rep23_B.Count != 0)
            {
                xlDof.Text = dsReports.Rep23_B[0].DofatSarf;
                xlFrom.Text = dsReports.Rep23_B[0].DofatSarfDatefrom.ToShortDateString();
                xlTo.Text = dsReports.Rep23_B[0].DofatSarfDateto.ToShortDateString();
            }
        }

    }
}
