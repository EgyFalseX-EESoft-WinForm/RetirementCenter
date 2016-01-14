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
    public partial class TblMemberAmanatPrintFrm : DevExpress.XtraEditors.XtraForm
    {
        public TblMemberAmanatPrintFrm()
        {
            InitializeComponent();
        }
        private void TBLDeathMembersPrintFrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsReports.Rep24_A' table. You can move, or remove it, as needed.
            this.rep24_ATableAdapter.Fill(this.dsReports.Rep24_A);
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
            DataSources.dsReports.Rep24_ADataTable tblPrint = new DataSources.dsReports.Rep24_ADataTable();

            for (var i = 0; i < gridViewMain.RowCount; i++)
            {
                var drv = gridViewMain.GetRow(gridViewMain.GetVisibleRowHandle(i));
                if (drv == null)
                    continue;
                DataSources.dsReports.Rep24_ARow row = (DataSources.dsReports.Rep24_ARow)((DataRowView)drv).Row;
                if (!row.Selected)
                    continue;
                DataSources.dsReports.Rep24_ARow rowPrint = tblPrint.NewRep24_ARow();
                rowPrint.MMashatId = row.MMashatId;
                rowPrint.DofatSarfAId = row.DofatSarfAId;
                rowPrint.amanatmony = row.amanatmony == null ? 0 : row.amanatmony;
                if (!row.IsamanatremNull())
                    rowPrint.amanatrem = row.amanatrem;
                rowPrint.estktaa = row.estktaa == null ? 0 : row.estktaa;
                if (!row.IsNull("mostahek"))
                    rowPrint.mostahek = row.mostahek;
                if (!row.IsNull("sefa"))
                    rowPrint.sefa = row.sefa;
                rowPrint.DofatSarf = row.DofatSarf;
                rowPrint.Syndicate = row.Syndicate;
                rowPrint.datein = row.datein;
                rowPrint.sarfnumber = row.sarfnumber;
                rowPrint.MMashatName = row.MMashatName;
                rowPrint.Total = row.Total == null ? 0 : row.Total;
                rowPrint.Selected = row.Selected;
                rowPrint.sarfcheek = row.sarfcheek;
                
                tblPrint.AddRep24_ARow(rowPrint);
            }
            XRep24 FrmRep = new XRep24(tblPrint);
            Misc.Misc.ShowPrintPreview(FrmRep);
        }

        
    }
}
