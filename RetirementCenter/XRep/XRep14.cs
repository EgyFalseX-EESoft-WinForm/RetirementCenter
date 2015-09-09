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
    public partial class XRep14 : DevExpress.XtraReports.UI.XtraReport
    {
        DataSources.dsReportsTableAdapters.QueriesTableAdapter adpQ = new DataSources.dsReportsTableAdapters.QueriesTableAdapter();
        public XRep14()
        {
            InitializeComponent();
            LoadDataSource();
        }
        private void LoadDataSource()
        {
            new DataSources.dsReportsTableAdapters.AppOptionsTableAdapter().Fill(dsReports.AppOptions);
            rep14_ATableAdapter.Fill(dsReports.Rep14_A);
        }
      
        private void XRep01_ParametersRequestBeforeShow(object sender, DevExpress.XtraReports.Parameters.ParametersRequestEventArgs e)
        {
            
        }
        private void XRep01_ParametersRequestSubmit(object sender, DevExpress.XtraReports.Parameters.ParametersRequestEventArgs e)
        {
            if (Parameters["pramDof"].Value == DBNull.Value)
                return;
            int Dof = Convert.ToInt32(Parameters["pramDof"].Value);
            
            rep14_BTableAdapter.Fill(dsReports.Rep14_B, Dof);
            xlDof.Text = adpQ.GetDofatSarfByDofatSarfId(Dof).ToString();
        }

    }
}
