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
            //Set DofatSarfAId from DefaultDofatSarfAId
            object DofId = SQLProvider.adpQry.GetDefaultDofatSarfId();
            if (DofId != null)
                lueDofatSarfAId.EditValue = DofId;
        }
        private void lueDofatSarfAId_EditValueChanged(object sender, EventArgs e)
        {
            if (lueDofatSarfAId.EditValue == null || lueDofatSarfAId.EditValue.ToString() == string.Empty || (FXFW.SqlDB.IsNullOrEmpty(lueMMashatId.EditValue) && FXFW.SqlDB.IsNullOrEmpty(tbCode60.EditValue)))
                return;
            LoadDetailsGrid();
        }
        private void lueMMashatId_EditValueChanged(object sender, EventArgs e)
        {
            if (lueDofatSarfAId.EditValue == null || lueDofatSarfAId.EditValue.ToString() == string.Empty || (FXFW.SqlDB.IsNullOrEmpty(lueMMashatId.EditValue) && FXFW.SqlDB.IsNullOrEmpty(tbCode60.EditValue)))
                return;
            LoadDetailsGrid();
        }
        private void LoadDetailsGrid()
        {
            if (!FXFW.SqlDB.IsNullOrEmpty(lueMMashatId.EditValue))
                tBLBeanWarsaTableAdapter.FillByDofaa_MMashatId(dsRetirementCenter.TBLBeanWarsa, Convert.ToInt32(lueMMashatId.EditValue), Convert.ToInt32(lueDofatSarfAId.EditValue));
            else
                tBLBeanWarsaTableAdapter.FillByDofaa_Code60(dsRetirementCenter.TBLBeanWarsa, Convert.ToInt32(tbCode60.EditValue), Convert.ToInt32(lueDofatSarfAId.EditValue));
            
            if (dsRetirementCenter.TBLBeanWarsa.Count == 0)
            {
                if (!FXFW.SqlDB.IsNullOrEmpty(lueMMashatId.EditValue))
                    adpGetPersonId.Fill(dsQry.GetPersonIdByMMashatId, Convert.ToInt32(lueMMashatId.EditValue));
                else
                    adpGetPersonId.FillByCode60(dsQry.GetPersonIdByMMashatId, Convert.ToInt32(tbCode60.EditValue));
                
                DateTime ServerDate = SQLProvider.ServerDateTime();
                foreach (DataSources.dsQueries.GetPersonIdByMMashatIdRow Person in dsQry.GetPersonIdByMMashatId)
                {
                    DataSources.dsRetirementCenter.TBLBeanWarsaRow row = dsRetirementCenter.TBLBeanWarsa.AddTBLBeanWarsaRow(Person.PersonId, Convert.ToInt32(lueDofatSarfAId.EditValue), ServerDate, false, string.Empty, ServerDate, Program.UserInfo.UserId, ServerDate, Person.code60);
                    row["personName"] = Person.personName;
                    row["responsiblesarf"] = Person.responsiblesarf;
                    row["WarasaType"] = Person.WarasaType;
                    if (!Person.IspersonNIDNull())
                        row["personNID"] = Person.personNID;
                }
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (FXFW.SqlDB.IsNullOrEmpty(lueDofatSarfAId.EditValue) || (FXFW.SqlDB.IsNullOrEmpty(lueMMashatId.EditValue) && FXFW.SqlDB.IsNullOrEmpty(tbCode60.EditValue)))
                return;
            //Get Information About Warasa

            DataSources.dsRetirementCenter.TBLWarasaDataTable tbl = null;
            if (!FXFW.SqlDB.IsNullOrEmpty(tbCode60.EditValue))
                tbl = adpWarasa.GetDataByCode60(Convert.ToInt32(tbCode60.EditValue));
            else
                tbl = adpWarasa.GetDataByMMashatId(Convert.ToInt32(lueMMashatId.EditValue));
            
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
