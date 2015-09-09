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
    public partial class XRep15 : DevExpress.XtraReports.UI.XtraReport
    {
        DataSources.dsReportsTableAdapters.QueriesTableAdapter adpQ = new DataSources.dsReportsTableAdapters.QueriesTableAdapter();
        public XRep15()
        {
            InitializeComponent();
            LoadDataSource();
        }
        private void LoadDataSource()
        {
            new DataSources.dsReportsTableAdapters.AppOptionsTableAdapter().Fill(dsReports.AppOptions);
            rep15_ATableAdapter.Fill(dsReports.Rep15_A);
        }
      
        private void XRep01_ParametersRequestBeforeShow(object sender, DevExpress.XtraReports.Parameters.ParametersRequestEventArgs e)
        {
            
        }
        private void XRep01_ParametersRequestSubmit(object sender, DevExpress.XtraReports.Parameters.ParametersRequestEventArgs e)
        {
            if (Parameters["pramDof"].Value == DBNull.Value)
                return;
            int Dof = Convert.ToInt32(Parameters["pramDof"].Value);
            
            rep15_BTableAdapter.Fill(dsReports.Rep15_B, Dof);
            xlDof.Text = adpQ.GetDofatSarfByDofatSarfId(Dof).ToString();
        }

    }
}
