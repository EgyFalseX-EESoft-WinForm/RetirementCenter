using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using System.Linq;

namespace RetirementCenter
{
    public partial class TBLBeanWarsaWFrm : DevExpress.XtraEditors.XtraForm
    {
        DataSources.Linq.dsTeachersUnionViewsDataContext dsLinq = new DataSources.Linq.dsTeachersUnionViewsDataContext();
        DataSources.dsQueries dsQry = new DataSources.dsQueries();
        DataSources.dsQueriesTableAdapters.GetPersonIdByMMashatIdTableAdapter adpGetPersonId = new DataSources.dsQueriesTableAdapters.GetPersonIdByMMashatIdTableAdapter();
        bool _Insert, _Update, _Delete;
        public TBLBeanWarsaWFrm()
        {
            InitializeComponent();
        }
        private void ActivePriv()
        {
        }
      
        private void FormWFrm_Load(object sender, EventArgs e)
        {
            LSMSTBLWarasa.QueryableSource = from q in dsLinq.vTBLMashats where q.yasref == true & q.MashHalaId == (int)Program.CDMashHala.Warasa select q;
            LSMSTBLDofatSarf.QueryableSource = dsLinq.TBLDofatSarfs;
            ActivePriv();
        }
        private void lueDofatSarfAId_EditValueChanged(object sender, EventArgs e)
        {
            if (lueDofatSarfAId.EditValue == null || lueMMashatId.EditValue.ToString() == string.Empty)
                return;
            LoadDetailsGrid();
        }
        private void lueMMashatId_EditValueChanged(object sender, EventArgs e)
        {
            if (lueDofatSarfAId.EditValue == null || lueMMashatId.EditValue == null)
                return;
            LoadDetailsGrid();
        }
        private void LoadDetailsGrid()
        {
            tBLBeanWarsaTableAdapter.FillByDofaa_MMashatId(dsRetirementCenter.TBLBeanWarsa, Convert.ToInt32(lueMMashatId.EditValue), Convert.ToInt32(lueDofatSarfAId.EditValue));
            if (dsRetirementCenter.TBLBeanWarsa.Count == 0)
            {
                adpGetPersonId.Fill(dsQry.GetPersonIdByMMashatId, Convert.ToInt32(lueMMashatId.EditValue));
                DateTime ServerDate = SQLProvider.ServerDateTime();
                foreach (DataSources.dsQueries.GetPersonIdByMMashatIdRow Person in dsQry.GetPersonIdByMMashatId)
                {
                    dsRetirementCenter.TBLBeanWarsa.AddTBLBeanWarsaRow(Person.PersonId, Convert.ToInt32(lueDofatSarfAId.EditValue), ServerDate, false, string.Empty, ServerDate, Program.UserInfo.UserId, ServerDate);
                }
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            DateTime ServerDate = SQLProvider.ServerDateTime();
            foreach (DataSources.dsRetirementCenter.TBLBeanWarsaRow row in dsRetirementCenter.TBLBeanWarsa)
            {
                row.datein = ServerDate;
                row.userin = Program.UserInfo.UserId;
            }
            try
            {
                tBLBeanWarsaTableAdapter.Update(dsRetirementCenter.TBLBeanWarsa);
                DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            catch (Exception ex)
            {
                msgDlg.Show("لم يتم الحفظ " + Environment.NewLine + ex.Message, msgDlg.msgButtons.Close);
            }
            
            
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        
       
    }
}
