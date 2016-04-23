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
    public partial class XRep26 : DevExpress.XtraReports.UI.XtraReport
    {
        int counter = 0;
        public XRep26(int Dof, int Syn, byte type)
        {
            InitializeComponent();
            LoadDataSource(Dof, Syn, type);
        }
        private void LoadDataSource(int Dof, int Syn, byte type)
        {
            new DataSources.dsReportsTableAdapters.AppOptionsTableAdapter().Fill(dsReports.AppOptions);
            counter = 0;
            rep26TableAdapter.Fill(dsReports.Rep26, Dof, Syn, type);
            if (dsReports.Rep26.Rows.Count > 0)
            {
                xlFrom.Text = dsReports.Rep26[0].sarfdatefrom.ToString("yyyy-M-d");
                xlTo.Text = dsReports.Rep26[0].sarfdateto.ToString("yyyy-M-d");
                xlSyndicate.Text = dsReports.Rep26[0].Syndicate;
                xlDofatSarf.Text = dsReports.Rep26[0].DofatSarf;
                xlSubCommitte.Text = dsReports.Rep26[0].SubCommitte;
                lblSarfTypeedad.Text = dsReports.Rep26[0].SarfTypeedad;
            }
        }
        private void xtcNo_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            //counter++;
            //((XRLabel)sender).Text = string.Format("Record Number = {0}", counter);
        }
        private void xlGroupAutoNo_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            counter++;
            ((XRLabel)sender).Text = string.Format("{0}", counter);
        }

    }
}
