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
        DataSources.dsRetirementCenterTableAdapters.TBLNoSarfWarsaTableAdapter adpUpdateNoSarf = new DataSources.dsRetirementCenterTableAdapters.TBLNoSarfWarsaTableAdapter();
        DataSources.dsRetirementCenterTableAdapters.TBLWarasaTableAdapter adpWarasa = new DataSources.dsRetirementCenterTableAdapters.TBLWarasaTableAdapter();
        bool _Insert, _Update, _Delete;
        public TBLBeanWarsaWFrm()
        {
            InitializeComponent();
        }
        private void ActivePriv()
        {
        }
        private void New()
        {
            LoadDetailsGrid();
            lueMMashatId.Focus();
        }
      
        private void FormWFrm_Load(object sender, EventArgs e)
        {
            LSMSTBLMashat.QueryableSource = from q in dsLinq.vTBLMashats where q.yasref == true & q.MashHalaId == (int)Program.CDMashHala.Warasa select q;
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
                    DataSources.dsRetirementCenter.TBLBeanWarsaRow row = dsRetirementCenter.TBLBeanWarsa.AddTBLBeanWarsaRow(Person.PersonId, Convert.ToInt32(lueDofatSarfAId.EditValue), ServerDate, false, string.Empty, ServerDate, Program.UserInfo.UserId, ServerDate);
                    row["personName"] = Person.personName;
                }
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (lueDofatSarfAId.EditValue == null || lueMMashatId.EditValue == null)
                return;
            //Get Information About Warasa
            DataSources.dsRetirementCenter.TBLWarasaDataTable tbl = adpWarasa.GetDataByMMashatId(Convert.ToInt32(lueMMashatId.EditValue));
            DataSources.dsRetirementCenter.TBLNoSarfWarsaDataTable NoSarfTbl = new DataSources.dsRetirementCenter.TBLNoSarfWarsaDataTable();

            DateTime ServerDate = SQLProvider.ServerDateTime();
            foreach (DataSources.dsRetirementCenter.TBLBeanWarsaRow row in dsRetirementCenter.TBLBeanWarsa)
            {
                row.datein = ServerDate;
                row.userin = Program.UserInfo.UserId;
                if (!row.deleted)
                    continue;

                //Check if Yasref need to update or not
                DataSources.dsRetirementCenter.TBLWarasaRow Person = tbl.FindByPersonId(row.PersonId);
                if (Person.yasref == false)
                    continue;
                // Change Yasref in TBLNoSarfWarsa Table
                DataSources.dsRetirementCenter.TBLNoSarfWarsaRow ChangeSarfInfo = NoSarfTbl.NewTBLNoSarfWarsaRow();
                ChangeSarfInfo.datehala = row.Beandate;
                ChangeSarfInfo.datein = ServerDate;
                string remak = string.Empty;
                if (row.deleted)
                    remak = "ايقاف طبقا لبيان معاش بتاريخ " +  row.Beandate.ToShortDateString();
                else
                    remak = "تفعيل طبقا لبيان معاش بتاريخ " + row.Beandate.ToShortDateString();
                ChangeSarfInfo.halarem = remak;
                ChangeSarfInfo.PersonId = row.PersonId;
                ChangeSarfInfo.userin = Program.UserInfo.UserId;
                ChangeSarfInfo.yasref = !row.deleted;
                NoSarfTbl.AddTBLNoSarfWarsaRow(ChangeSarfInfo);
                adpUpdateNoSarf.Update(ChangeSarfInfo);
                //Update Yaster in TBLWarasa Table
                adpWarasa.UpdateQueryYasrefByPersonId(ChangeSarfInfo.yasref, ChangeSarfInfo.PersonId);
            }
            try
            {
                
                tBLBeanWarsaTableAdapter.Update(dsRetirementCenter.TBLBeanWarsa);
                Program.ShowMsg("تم الحفظ", false, this, true);
                New();
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
