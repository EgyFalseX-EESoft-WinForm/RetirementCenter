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
    public partial class TblWarasaAmanatWGridFrm : DevExpress.XtraEditors.XtraForm
    {
        public double Amount = 0;
        public TblWarasaAmanatWGridFrm(int PersonId, int DofatSarfAId)
        {
            InitializeComponent();
            this.tblWarasabankTableAdapter.GetBy_visa_Dof(this.dsRetirementCenter.tblWarasabank, DofatSarfAId, PersonId);
        }

        private void TblMemberAmanatWGridFrm_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (gridViewMain.GetFocusedRow() == null)
                return;
            DataSources.dsRetirementCenter.tblWarasabankRow row = (DataSources.dsRetirementCenter.tblWarasabankRow)((DataRowView)gridViewMain.GetRow(gridViewMain.FocusedRowHandle)).Row;
            Amount = row.amanatmony;
            DialogResult = System.Windows.Forms.DialogResult.OK;

        }
    }
}