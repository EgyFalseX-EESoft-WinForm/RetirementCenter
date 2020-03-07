using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace RetirementCenter.Forms.Data
{
    public partial class TBLDeathMembersPrintFrm : DevExpress.XtraEditors.XtraForm
    {
        public TBLDeathMembersPrintFrm()
        {
            InitializeComponent();
        }
        private void TBLDeathMembersPrintFrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsQueries.vQry84' table. You can move, or remove it, as needed.
            this.vQry84TableAdapter.Fill(this.dsQueries.vQry84);
        }
        private void ceCheckAll_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < gridViewMain.RowCount; i++)
            {
                gridViewMain.GetDataRow(gridViewMain.GetVisibleRowHandle(i))["Selected"] = ceCheckAll.Checked;
            }
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            DataSources.dsQueries.vQry84DataTable tblPrint = new DataSources.dsQueries.vQry84DataTable();

            for (var i = 0; i < gridViewMain.RowCount; i++)
            {
                var drv = gridViewMain.GetRow(gridViewMain.GetVisibleRowHandle(i));
                if (drv == null)
                    continue;
                DataSources.dsQueries.vQry84Row row = (DataSources.dsQueries.vQry84Row)((DataRowView)drv).Row;
                if (row.IsSelectedNull() || !row.Selected)
                    continue;
                DataSources.dsQueries.vQry84Row rowPrint = tblPrint.NewvQry84Row();
                rowPrint.MMashatId = row.MMashatId;
                rowPrint.deathdate = row.deathdate;
                rowPrint.mosthhek = row.mosthhek;
                rowPrint.MMashatName = row.MMashatName;
                rowPrint.SyndicateId = row.SyndicateId;
                rowPrint.SubCommitteId = row.SubCommitteId;
                rowPrint.sarfnumber = row.sarfnumber;
                rowPrint.Syndicate = row.Syndicate;
                rowPrint.SubCommitte = row.SubCommitte;
                rowPrint.yasref = row.yasref;
                rowPrint.datein = row.datein;
                rowPrint.userin = row.userin;
                if (!row.IsMMashatNIdNull())
                    rowPrint.MMashatNId = row.MMashatNId;
                rowPrint.MashHala = row.MashHala;
                if (!row.IsmosthhekNidNull())
                    rowPrint.mosthhekNid = row.mosthhekNid;
                if (!row.IsmosthhekmonyNull())
                    rowPrint.mosthhekmony = row.mosthhekmony;
                if (!row.IsestktaaNull())
                    rowPrint.estktaa = row.estktaa;
                if (!row.Isnet_valueNull())
                    rowPrint.net_value = row.net_value;

                if (!row.IssefaNull())
                    rowPrint.sefa = row.sefa;
                if (!row.IssarfNull())
                    rowPrint.sarf = row.sarf;
                if (!row.IssheeknoNull())
                    rowPrint.sheekno = row.sheekno;
                if (!row.IssheekdateNull())
                    rowPrint.sheekdate = row.sheekdate;

                tblPrint.AddvQry84Row(rowPrint);
            }
            XRep20 FrmRep = new XRep20(tblPrint);
            Misc.Misc.ShowPrintPreview(FrmRep);
        }

        
    }
}
