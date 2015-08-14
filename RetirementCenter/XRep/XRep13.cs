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
    public partial class XRep13 : DevExpress.XtraReports.UI.XtraReport
    {
        public XRep13()
        {
            InitializeComponent();
            LoadDataSource();
        }
        private void LoadDataSource()
        {
            new DataSources.dsReportsTableAdapters.AppOptionsTableAdapter().Fill(dsReports.AppOptions);
        }
        private void XRep01_ParametersRequestBeforeShow(object sender, DevExpress.XtraReports.Parameters.ParametersRequestEventArgs e)
        {
        }
        private void XRep01_ParametersRequestSubmit(object sender, DevExpress.XtraReports.Parameters.ParametersRequestEventArgs e)
        {
            if (Parameters["pramDate"].Value == DBNull.Value || Parameters["pramSynd"].Value == DBNull.Value)
                return;
            DateTime Date = Convert.ToDateTime(Parameters["pramDate"].Value);
            int Synd = Convert.ToInt32(Parameters["pramSynd"].Value);

            rep13_CTableAdapter.Fill(dsReports.Rep13_C, Date, Synd);
            xlDate.Text = Date.ToShortDateString();
            if (dsReports.Rep11_C.Count != 0)
            {
                xlDof.Text = dsReports.Rep11_C[0].DofatSarf;
                xlSynd.Text = dsReports.Rep11_C[0].Syndicate;
            }
        }

    }
}
