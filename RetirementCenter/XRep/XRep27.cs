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
    public partial class XRep27 : DevExpress.XtraReports.UI.XtraReport
    {
        int counter = 0;
        public XRep27(int Dof, int Syn, byte type)
        {
            InitializeComponent();
            LoadDataSource(Dof, Syn, type);
        }
        private void LoadDataSource(int Dof, int Syn, byte type)
        {
            new DataSources.dsReportsTableAdapters.AppOptionsTableAdapter().Fill(dsReports.AppOptions);
            rep27TableAdapter.Fill(dsReports.Rep27, Dof, Syn, type);
            if (dsReports.Rep27.Rows.Count > 0)
            {
                xlFrom.Text = dsReports.Rep27[0].sarfdatefrom.ToString("yyyy-M-d");
                xlTo.Text = dsReports.Rep27[0].sarfdateto.ToString("yyyy-M-d");
                xlSyndicate.Text = dsReports.Rep27[0].Syndicate;
                xlDofatSarf.Text = dsReports.Rep27[0].DofatSarf;
                xlSubCommitte.Text = dsReports.Rep27[0].SubCommitte;
                lblSarfTypeedad.Text = dsReports.Rep27[0].SarfTypeedad;
            }   
        }
        private void xtcNo_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            counter++;
            ((XRLabel)sender).Text = string.Format("Record Number = {0}", counter);
        }
    }
}
