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
    public partial class XRep20 : DevExpress.XtraReports.UI.XtraReport
    {
        public XRep20(DataSources.dsQueries.vQry84DataTable tbl)
        {
            InitializeComponent();
            LoadDataSource(tbl);
            //SQLProvider.SetAllCommandTimeouts(rep19_BTableAdapter, 0);
        }
        private void LoadDataSource(DataSources.dsQueries.vQry84DataTable tbl)
        {
            new DataSources.dsReportsTableAdapters.AppOptionsTableAdapter().Fill(dsReports.AppOptions);
            //rep19_A1TableAdapter.Fill(dsReports.Rep19_A);
            foreach (DataSources.dsQueries.vQry84Row item in tbl.Rows)
            {
                
                if (!item.IssarfNull() && item.sarf)
                    continue;
                DataSources.dsReports.Rep19_BRow row = dsReports.Rep19_B.NewRep19_BRow();

                row.MMashatId = item.MMashatId;
                row.datein = item.datein;
                
                row.MMashatName = item.MMashatName;
                row.deathdate = item.deathdate;
                row.mosthhek = item.mosthhek;
                row.SyndicateId = item.SyndicateId;
                row.sarfnumber = item.sarfnumber;
                row.Syndicate = item.Syndicate;
                if (!row.IssefaNull())
                    row.sefa = item.sefa;
                row.mosthhekmony = item.mosthhekmony;
                dsReports.Rep19_B.AddRep19_BRow(row);
                
            }
        }
        private void XRep01_ParametersRequestBeforeShow(object sender, DevExpress.XtraReports.Parameters.ParametersRequestEventArgs e)
        {
        }
        private void XRep01_ParametersRequestSubmit(object sender, DevExpress.XtraReports.Parameters.ParametersRequestEventArgs e)
        {
            //if (Parameters["pramDateStart"].Value == DBNull.Value || Parameters["pramDateEnd"].Value == DBNull.Value || Parameters["pramSynd"].Value == DBNull.Value)
            //    return;
            //int Synd = Convert.ToInt32(Parameters["pramSynd"].Value);
            //DateTime DateStart = Convert.ToDateTime(Parameters["pramDateStart"].Value);
            //DateTime DateEnd = Convert.ToDateTime(Parameters["pramDateEnd"].Value);

            //rep19_BTableAdapter.Fill(dsReports.Rep19_B, Synd, DateStart, DateEnd);
            //if (dsReports.Rep19_B.Count != 0)
            //{
            //    xlSynd.Text = dsReports.Rep19_B[0].Syndicate;
            //    xlFrom.Text = DateStart.ToShortDateString();
            //    xlTo.Text = DateEnd.ToShortDateString();
            //}
           
        }

    }
}
