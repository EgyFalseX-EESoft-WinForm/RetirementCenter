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
    public partial class TblMemberAmanatWGridFrm : DevExpress.XtraEditors.XtraForm
    {
        public double Amount = 0;
        public TblMemberAmanatWGridFrm(int MMashatId, int DofatSarfAId)
        {
            InitializeComponent();
            // TODO: This line of code loads data into the 'dsRetirementCenter.tblmemberbank' table. You can move, or remove it, as needed.
            this.tblmemberbankTableAdapter.FillByID_NotExistInAmanat(this.dsRetirementCenter.tblmemberbank, MMashatId, DofatSarfAId, DofatSarfAId);
            
        }

        private void TblMemberAmanatWGridFrm_Load(object sender, EventArgs e)
        {
            if (dsRetirementCenter.tblmemberbank.Count == 0)
            {
                DialogResult = System.Windows.Forms.DialogResult.Cancel;
                Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (gridViewMain.GetFocusedRow() == null)
                return;
            DataSources.dsRetirementCenter.tblmemberbankRow row = (DataSources.dsRetirementCenter.tblmemberbankRow)((DataRowView)gridViewMain.GetRow(gridViewMain.FocusedRowHandle)).Row;
            Amount = row.amanatmony;
            DialogResult = System.Windows.Forms.DialogResult.OK;

        }
    }
}