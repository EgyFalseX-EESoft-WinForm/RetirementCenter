﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Linq;

namespace RetirementCenter.Forms.Data
{
    public partial class TBLWarasaDlg : DevExpress.XtraEditors.XtraForm
    {
        #region -   Variables   -
        private int MaxDofatSarfId = (int)new DataSources.dsQueriesTableAdapters.TBLDofatSarfTableAdapter().MaxId();
        DataSources.dsRetirementCenterTableAdapters.TBLEstefaTableAdapter adpEstefa = new DataSources.dsRetirementCenterTableAdapters.TBLEstefaTableAdapter();
        public enum OpenReason
        {
            Edit,
            Remark
        }
        DataSources.Linq.dsTeachersUnionViewsDataContext dsLinq = new DataSources.Linq.dsTeachersUnionViewsDataContext();

        DataSources.dsRetirementCenter.TBLWarasaDataTable _TBLWarasa;
        DataSources.dsRetirementCenter.TBLNoSarfWarsaDataTable _TBLNoSarfWarsa;
        DataSources.dsRetirementCenter.tblvisawarsaactiveDataTable _tblvisawarsaactive;
        DataSources.dsRetirementCenter.TBLEdafatWarsaDataTable _TBLEdafatWarsa;
        public bool DataChangedByUser = false;

        #endregion
        #region -   Functions   -
        public TBLWarasaDlg(DataSources.dsRetirementCenter.TBLWarasaDataTable TBLWarasa, DataSources.dsRetirementCenter.TBLNoSarfWarsaDataTable TBLNoSarfWarsa
            , DataSources.dsRetirementCenter.tblvisawarsaactiveDataTable tblvisawarsaactive, 
            DataSources.dsRetirementCenter.TBLEdafatWarsaDataTable TBLEdafatWarsa, OpenReason openReason)
        {
            InitializeComponent();

            LSMSCDWarasaType.QueryableSource = new DataSources.Linq.dsTeachersUnionViewsDataContext().CDWarasaTypes;
            LSMSCDMashHala.QueryableSource = dsLinq.CDMashHalas;
            LSMSTBLDofatSarf.QueryableSource = dsLinq.TBLDofatSarfs;
            LSMSTBLDofatSarf2.QueryableSource = from q in dsLinq.TBLDofatSarfs where q.resarfd == true select q;
            LSMSCdDofaatAmanat.QueryableSource = dsLinq.CdDofaatAmanats;
            LSMSCDSyndicate.QueryableSource = dsLinq.CDSyndicates;
            LSMSCDSubCommitte.QueryableSource = dsLinq.CDSubCommittes;
            LSMSCDnationalty.QueryableSource = dsLinq.CDnationalties;
            LSMSsarfresonid.QueryableSource = dsLinq.cd_sarfresons;
            LSMSUsers.QueryableSource = dsLinq.Users;
            LSMSTBLWarasa.QueryableSource =

            LSMSTBLWarasa.QueryableSource = from q in dsLinq.vTBLWarasas where q.MMashatId == TBLWarasa[0].MMashatId select q;
            _TBLWarasa = TBLWarasa;
            _TBLNoSarfWarsa = TBLNoSarfWarsa;
            _tblvisawarsaactive = tblvisawarsaactive;
            _TBLEdafatWarsa = TBLEdafatWarsa;

            switch (openReason)
            {
                case  OpenReason.Remark:
                    gcCommands.Visible = false;
                    tabMain.PageVisible = false;
                    tabExtra.PageVisible = false;
                    tabSarfExpetion.PageVisible = false;
                    tabResarf.PageVisible = false;
                    
                    ReloadRemark();
                    return;
                case OpenReason.Edit:
                    tabRemark.PageVisible = false;
                    break;
            }
            if (TBLWarasa[0].PersonId == -1)
            {
                xtraTabPageTBLWarasaMadunea.PageVisible = false;
            }

            tbpersonName.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", _TBLWarasa, "personName", true));
            lueWarasaTypeId.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", _TBLWarasa, "WarasaTypeId", true));
            luenationaltyId.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", _TBLWarasa, "nationaltyId", true));
            tbpersonNID.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", _TBLWarasa, "personNID", true));
            depersonbirth.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", _TBLWarasa, "personbirth", true));
            tbpersonmobile.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", _TBLWarasa, "personmobile", true));
            tbpersonAddres.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", _TBLWarasa, "personAddres", true));
            ceyasref.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", _TBLWarasa, "yasref", false)); //ceyasref.Checked = _TBLWarasa[0].IsyasrefNull() == null ? false : _TBLWarasa[0].yasref;
            LUESyndicateId.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", _TBLWarasa, "SyndicateId", true));
            LUESubCommitteId.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", _TBLWarasa, "SubCommitteId", true));
            ceresponsiblesarf.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", _TBLWarasa, "responsiblesarf", false)); //ceresponsiblesarf.Checked = _TBLWarasa[0].IsresponsiblesarfNull() ? false : _TBLWarasa[0].responsiblesarf;
            LUEresponsiblesarfId.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", _TBLWarasa, "responsiblesarfId", true));
            tbvisa.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", _TBLWarasa, "visa", true));
            ceActivate.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", _TBLWarasa, "Activate", false)); //ceActivate.Checked = _TBLWarasa[0].IsActivateNull() ? false : _TBLWarasa[0].Activate;
            luesarfresonid.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", _TBLWarasa, "sarfresonid", true));
            tbCode60.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", _TBLWarasa, "code60", true));

            cewcompletesarf.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", _TBLWarasa, "wcompletesarf", true));
            tbwmony.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", _TBLWarasa, "wmony", true));
            tbwestktaat.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", _TBLWarasa, "westktaat", true));
            tbwelrasm.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", _TBLWarasa, "welrasm", true));

            luesarfTypeId.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", _TBLEdafatWarsa, "sarfTypeId", true));
            tbestktaa.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", _TBLEdafatWarsa, "estktaa", true));
            lueDofatSarfId.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", _TBLEdafatWarsa, "DofatSarfId", true));
            dedatesarf.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", _TBLEdafatWarsa, "datesarf", true));

            //edit visa for admin only
            tbvisa.Visible = lblvisa .Visible = Program.UserInfo.IsAdmin;
            lblActivate.Visible = (Program.UserInfo.IsAdmin || Program.UserInfo.IsRole28);
            ceActivate.Visible = (Program.UserInfo.IsAdmin || Program.UserInfo.IsRole28);
            
            tbCode60.Visible = tbCode60.Visible = Program.UserInfo.IsAdmin;

            if (_TBLEdafatWarsa.Count > 0)
                ceEnableEdafat.Checked = true;

            if (_TBLWarasa[0].RowState == DataRowState.Added)
            {
                tabResarf.PageVisible = false;
                tabSarfExpetion.PageVisible = false;
            }
            else
            {
                this.tBLReSarfWarasaTableAdapter.FillBy(this.dsRetirementCenter.TBLReSarfWarasa, _TBLWarasa[0].PersonId);
                if ((bool)SQLProvider.adpQry.TBLMashat_GetSarfExpetion(_TBLWarasa[0].MMashatId))
                    this.tBLSarfExpetionTableAdapter.FillByPersonId(this.dsRetirementCenter.TBLSarfExpetion, _TBLWarasa[0].PersonId);
                else
                    tabSarfExpetion.PageVisible = false;
            }

            if (TBLWarasa[0].yasref == false && (TBLWarasa[0].IspersonNIDNull() || TBLWarasa[0].personNID.ToString() == string.Empty))
            {
                ceyasref.Enabled = false;
            }
            
            //if (ceyasref.Checked)
            //{
            //    DataSources.dsQueriesTableAdapters.QueriesTableAdapter adpQ = new DataSources.dsQueriesTableAdapters.QueriesTableAdapter();
            //    if (adpQ.ResponsibleCount(_TBLWarasa[0].PersonId) > 0)
            //    {
            //        ceyasref.Enabled = false;
            //        ceyasref.Text = "تم منع التعديل نظرا لان هذا الوريث مسئول عن ورثة اخرين";
            //        ceyasref.ForeColor = Color.Red;
            //    }
            //}

        }
        private void ReloadRemark()
        {
            // TODO: This line of code loads data into the 'dsRetirementCenter.TBLWarasaremarks' table. You can move, or remove it, as needed.
            this.tBLWarasaremarksTableAdapter.FillByPersonId(this.dsRetirementCenter.TBLWarasaremarks, _TBLWarasa[0].PersonId);
        }
        private void AddEventHandlerToDataChange(bool Add)
        {
            if (Add)
            {
                lueWarasaTypeId.EditValueChanged += DataChanged;
                luenationaltyId.EditValueChanged += DataChanged;
                tbpersonNID.EditValueChanged += DataChanged;
                depersonbirth.EditValueChanged += DataChanged;
                tbpersonmobile.EditValueChanged += DataChanged;
                tbpersonAddres.EditValueChanged += DataChanged;
                ceyasref.EditValueChanged += DataChanged;
                luesarfresonid.EditValueChanged += DataChanged;
                LUESyndicateId.EditValueChanged += DataChanged;
                LUESubCommitteId.EditValueChanged += DataChanged;
                ceresponsiblesarf.EditValueChanged += DataChanged;
                LUEresponsiblesarfId.EditValueChanged += DataChanged;
                //tbvisa.EditValueChanged += DataChanged;
                //ceActivate.EditValueChanged += DataChanged;
                //tbCode60.EditValueChanged += DataChanged;
            }
            else
            {
                lueWarasaTypeId.EditValueChanged -= DataChanged;
                luenationaltyId.EditValueChanged -= DataChanged;
                tbpersonNID.EditValueChanged -= DataChanged;
                depersonbirth.EditValueChanged -= DataChanged;
                tbpersonmobile.EditValueChanged -= DataChanged;
                tbpersonAddres.EditValueChanged -= DataChanged;
                ceyasref.EditValueChanged -= DataChanged;
                luesarfresonid.EditValueChanged -= DataChanged;
                LUESyndicateId.EditValueChanged -= DataChanged;
                LUESubCommitteId.EditValueChanged -= DataChanged;
                ceresponsiblesarf.EditValueChanged -= DataChanged;
                LUEresponsiblesarfId.EditValueChanged -= DataChanged;
                //tbvisa.EditValueChanged -= DataChanged;
                //ceActivate.EditValueChanged -= DataChanged;
                //tbCode60.EditValueChanged -= DataChanged;
            }
        }
        private void DataChanged(object o, EventArgs e)
        {
            DataChangedByUser = true;
        }
        #endregion
        #region - Event Handlers -
        private void TBLWarasaDlg_Load(object sender, EventArgs e)
        {
            this.tBLDofatSarfMaduneaTableAdapter.Fill(this.dsRetirementCenter.TBLDofatSarfMadunea);
            if (_TBLWarasa[0] != null)
            {
                this.tBLWarasaMaduneaTableAdapter.FillByPersonId(this.dsRetirementCenter.TBLWarasaMadunea, _TBLWarasa[0].PersonId);
                tblvisawarsaactiveTableAdapter.FillByPersonId(dsRetirementCenter.tblvisawarsaactive, _TBLWarasa[0].PersonId);
            }
            ceActivate.Visible = (Program.UserInfo.IsAdmin || Program.UserInfo.IsRole28);
            repositoryItemButtonEditResarfDel.Buttons[0].Visible = Program.UserInfo.IsAdmin;
            repositoryItemButtonEditTBLWarasaMaduneaDel.Buttons[0].Visible = Program.UserInfo.IsAdmin;

            xtraTabControlMain.SelectedTabPage = tabExtra;
            xtraTabControlMain.SelectedTabPage = tabMain;

            tbpersonName.EditValueChanged += DataChanged;
            AddEventHandlerToDataChange(true);

            
            if (ceresponsiblesarf.Checked == false && !_TBLWarasa[0].IsvisaNull())
                ceresponsiblesarf.Enabled = false;
        }

        private void ceyasref_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if ((bool)_TBLWarasa.Rows[0]["yasref", DataRowVersion.Current] == ceyasref.Checked)
                {
                    _TBLNoSarfWarsa.Clear();
                    return;
                }
            }
            catch { return; }
            
            if (ceyasref.Checked)
            {
                if (_TBLWarasa.Rows[0].RowState == DataRowState.Added)
                    return;
            }
            DataSources.dsRetirementCenter.TBLNoSarfWarsaRow row = _TBLNoSarfWarsa.NewTBLNoSarfWarsaRow();
            row.PersonId = -1; row.datehala = DateTime.Now; row.halarem = string.Empty; row.yasref = ceyasref.Checked;
            TBLNoSarfWarsaDlg dlg = new TBLNoSarfWarsaDlg(row);

            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                _TBLNoSarfWarsa.AddTBLNoSarfWarsaRow(row);
            else
                ceyasref.Checked = !ceyasref.Checked;
        }
        private void ceActivate_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if ((bool)_TBLWarasa.Rows[0]["Activate", DataRowVersion.Current] == ceActivate.Checked)
                {
                    _tblvisawarsaactive.Clear();
                    return;
                }
            }
            catch { return; }

            if (ceActivate.Checked)
            {
                if (_TBLWarasa.Rows[0].RowState == DataRowState.Added)
                    return;
            }
            DataSources.dsRetirementCenter.tblvisawarsaactiveRow row = _tblvisawarsaactive.NewtblvisawarsaactiveRow();
            row.PersonId = -1; row.datehala = DateTime.Now; row.halarem = string.Empty; row.activee = ceActivate.Checked;
            tblvisawarsaactiveDlg dlg = new tblvisawarsaactiveDlg(row);

            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                _tblvisawarsaactive.AddtblvisawarsaactiveRow(row);
            else
                ceActivate.Checked = !ceActivate.Checked;
        }
        private void ceEnableEdafat_CheckedChanged(object sender, EventArgs e)
        {
            if (!ceEnableEdafat.Checked)
            {
                pnlEdafat.Enabled = false;
                //lueDofatSarfId.EditValue = null;
                //luesarfTypeId.EditValue = null;
                //tbestktaa.EditValue = 0;
                //_TBLEdafatWarsa.Clear();
            }
            else
            {
                pnlEdafat.Enabled = true;

                if (_TBLEdafatWarsa.Count == 0)// if nothing then create new
                {
                    DataSources.dsRetirementCenter.TBLEdafatWarsaRow row = _TBLEdafatWarsa.NewTBLEdafatWarsaRow();
                    row.estktaa = 0; row.userin = Program.UserInfo.UserId; row.datein = SQLProvider.ServerDateTime();
                    row.sarfTypeId = 2;
                    row.PersonId = Convert.ToInt32(_TBLWarasa[0].PersonId);
                    row.EndEdit();
                    _TBLEdafatWarsa.AddTBLEdafatWarsaRow(row);
                }
                lueDofatSarfId.Focus();
                if (FXFW.SqlDB.IsNullOrEmpty(lueDofatSarfId.EditValue))
                    lueDofatSarfId.EditValue = MaxDofatSarfId;
            }
        }
        private void ceresponsiblesarf_CheckedChanged(object sender, EventArgs e)
        {
            LUEresponsiblesarfId.Enabled = !ceresponsiblesarf.Checked;

            //if (ceresponsiblesarf.Checked == true && !_TBLWarasa[0].IsvisaNull())
            //    ceresponsiblesarf.Checked = false;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            AddEventHandlerToDataChange(false);
            if (!dxValidationProviderMain.Validate())
                return;
            if (ceEnableEdafat.Checked)
            {
                if (!dxValidationProviderEdafat.Validate())
                    return;
            }
            _TBLWarasa[0].EndEdit();
            if (!_TBLWarasa[0].IspersonNIDNull() && _TBLWarasa[0].personNID.ToString() != string.Empty && _TBLWarasa[0].personNID.Length != 14)
            {
                msgDlg.Show("الرقم القومي يجب ان يكون 14 رقم");
                return;
            }
            
            if (_TBLWarasa.Rows[0].RowState == DataRowState.Added)
            {
                ((DataSources.dsRetirementCenter.TBLWarasaRow)_TBLWarasa.Rows[0]).PersonId = (int)SQLProvider.adpQry.TBLWarasaNewId();
                //Must Type NID
                if ((tbpersonNID.EditValue == null || tbpersonNID.EditValue.ToString() == string.Empty) && luenationaltyId.EditValue.ToString() == "1")
                {
                    Program.ShowMsg("يجب ادخال الرقم القومي", true, this, true);
                    return;
                }
            }
            else
            {
                //check if user remove responsiblesarf from this person and this person is responsiblesarf to other
                if ((_TBLWarasa[0]["responsiblesarf", DataRowVersion.Current].ToString() != _TBLWarasa[0]["responsiblesarf", DataRowVersion.Original].ToString()) && !_TBLWarasa[0].responsiblesarf)
                {
                    if (SQLProvider.adpQry.TBLWarasaPersonResponsibleSarfCount(_TBLWarasa[0].PersonId) > 0)
                    {
                        Program.ShowMsg("لا يمكن ازالة مسؤل الصرف عن هذا الوريث لانه مسئول صرف عن اخرين" + Environment.NewLine +
                        "قم بأزالة مسئوليته عن الاخرين ثم عاود التعديل", true, this, true);
                        return;
                    }
                    if (_TBLWarasa[0].responsiblesarfId == _TBLWarasa[0].PersonId)
                    {
                        Program.ShowMsg("مسئول الصرف يجب ان يكون مسئول", true, this, true);
                        return;
                    }
                }
                if (_TBLWarasa[0].yasref && !_TBLWarasa[0].responsiblesarf)
                {
                    if (_TBLWarasa[0].responsiblesarfId == _TBLWarasa[0].PersonId)
                    {
                        Program.ShowMsg("مسئول الصرف يجب ان يكون مسئول", true, this, true);
                        return;
                    }
                    object ResIsRes = new DataSources.dsQueriesTableAdapters.QueriesTableAdapter().GetResponsiblesarfByPersonId(_TBLWarasa[0].responsiblesarfId);
                    if (ResIsRes == null || !(bool)ResIsRes)
                    {
                        Program.ShowMsg("مسئول الصرف يجب ان يكون مسئول", true, this, true);
                        return;
                    }
                }
                
            }
            if (ceresponsiblesarf.Checked)
                ((DataSources.dsRetirementCenter.TBLWarasaRow)_TBLWarasa.Rows[0]).responsiblesarfId = ((DataSources.dsRetirementCenter.TBLWarasaRow)_TBLWarasa.Rows[0]).PersonId;
            

            if (tbpersonNID.EditValue != null && tbpersonNID.EditValue.ToString() != string.Empty)
            {
                if ((int)SQLProvider.adpQry.ExistsNID(tbpersonNID.EditValue.ToString(), -100, ((DataSources.dsRetirementCenter.TBLWarasaRow)_TBLWarasa.Rows[0]).PersonId) > 0)
                {
                    Program.ShowMsg("الرقم القومي موجود مسبقا", true, this, true);
                    return;
                }
                if (_TBLWarasa.Rows[0].RowState != DataRowState.Added)
                {
                    if ((_TBLWarasa[0]["personNID", DataRowVersion.Current].ToString() != _TBLWarasa[0]["personNID", DataRowVersion.Original].ToString()))
                        _TBLWarasa[0].ImportDateIn = SQLProvider.ServerDateTime();
                }
            }
            DataSources.dsRetirementCenter.TBLWarasaRow myrow = (DataSources.dsRetirementCenter.TBLWarasaRow)_TBLWarasa.Rows[0];
            if (!myrow.IspersonNIDNull() && myrow.personNID != string.Empty)
            {
                try
                {
                    myrow.personbirth = Convert.ToDateTime(Misc.Misc.IDExtraction(myrow.personNID)[1]);
                }
                catch (Exception ex)
                {
                    Program.ShowMsg("خطاء في الرقم القومي" + Environment.NewLine + ex.Message, true, this, true);
                    Program.Logger.LogThis("خطاء في الرقم القومي" + Environment.NewLine + ex.Message, Text, FXFW.Logger.OpType.fail, null, null, this);
                    return;
                }
            }
            //check if responsiblesarfId and his dependances have same visa
            if (_TBLWarasa[0].responsiblesarf && !_TBLWarasa[0].IsvisaNull())
            {
                if ((bool)FXFW.SqlDB.LoadDataTable(string.Format("SELECT CASE WHEN EXISTS(SELECT * FROM TBLWarasa WHERE responsiblesarfId = {0} AND visa IS NOT NULL AND visa <> '{1}') THEN CAST(0 AS bit) ELSE CAST(1 AS bit) END AS OK", _TBLWarasa[0].PersonId, _TBLWarasa[0].visa)).Rows[0][0] == false)
                {
                    Program.ShowMsg("رقم الفيزا للتابعين مختلف عن رقم الفيزا للمسئول", true, this, true);
                    Program.Logger.LogThis("رقم الفيزا للتابعين مختلف عن رقم الفيزا للمسئول", Text, FXFW.Logger.OpType.fail, null, null, this);
                    return;
                }
            }
            if (!_TBLWarasa[0].responsiblesarf && !_TBLWarasa[0].IsresponsiblesarfIdNull() && _TBLWarasa[0].responsiblesarfId != _TBLWarasa[0].PersonId && !_TBLWarasa[0].IsvisaNull())
            {
                DataTable visaTbl = FXFW.SqlDB.LoadDataTable("SELECT visa FROM TBLWarasa WHERE PersonId = " + _TBLWarasa[0].responsiblesarfId);
                if (visaTbl.Rows[0][0].ToString() != _TBLWarasa[0].visa)
                {
                    Program.ShowMsg("رقم الفيزا مختلف عن رقم الفيزا للمسئول", true, this, true);
                    Program.Logger.LogThis("رقم الفيزا مختلف عن رقم الفيزا للمسئول", Text, FXFW.Logger.OpType.fail, null, null, this);
                    return;
                }
            }
            //DataTable visaTbl = FXFW.SqlDB.LoadDataTable("SELECT visa FROM TBLWarasa WHERE PersonId = " + )

            foreach (DataSources.dsRetirementCenter.TBLNoSarfWarsaRow row in _TBLNoSarfWarsa.Rows)
            {
                row.PersonId = ((DataSources.dsRetirementCenter.TBLWarasaRow)_TBLWarasa.Rows[0]).PersonId;
            }
            foreach (DataSources.dsRetirementCenter.tblvisawarsaactiveRow row in _tblvisawarsaactive.Rows)
            {
                row.PersonId = ((DataSources.dsRetirementCenter.TBLWarasaRow)_TBLWarasa.Rows[0]).PersonId;
            }
            if (ceEnableEdafat.Checked)
            {
                foreach (DataSources.dsRetirementCenter.TBLEdafatWarsaRow row in _TBLEdafatWarsa.Rows)
                {
                    row.PersonId = ((DataSources.dsRetirementCenter.TBLWarasaRow)_TBLWarasa.Rows[0]).PersonId;
                }
            }
            else
                _TBLEdafatWarsa.Clear();
            
           
            DialogResult = System.Windows.Forms.DialogResult.OK;

        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
        private void LUESyndicateId_EditValueChanged(object sender, EventArgs e)
        {
            if (LUESyndicateId.EditValue == null || LUESyndicateId.EditValue.ToString() == string.Empty)
            {
                return;
            }
            LUESubCommitteId.Properties.DataSource = from q in dsLinq.CDSubCommittes where q.SyndicateId == Convert.ToInt32(LUESyndicateId.EditValue) select q;
        }
        private void repositoryItemButtonEditSave_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DataSources.dsRetirementCenter.TBLWarasaRow rowWarasa = _TBLWarasa[0];
            DataSources.dsRetirementCenter.TBLWarasaremarksRow row = (DataSources.dsRetirementCenter.TBLWarasaremarksRow)((DataRowView)
            gridViewRemarks.GetRow(gridViewRemarks.FocusedRowHandle)).Row;
            try
            {
                if (row.RowState != DataRowState.Detached && row.RowState != DataRowState.Added)
                {
                    Program.ShowMsg("لا يمكن تعديل", true, this, true);
                    Program.Logger.LogThis("لا يمكن تعديل", Text, FXFW.Logger.OpType.fail, null, null, this);
                    return;
                }
                row.rwid = (int)SQLProvider.adpQry.TBLWarasaremarksNewId();
                row.PersonId = rowWarasa.PersonId;
                row.datein = SQLProvider.ServerDateTime();
                row.userin = Program.UserInfo.UserId;

                tBLWarasaremarksBindingSource.EndEdit();
                tBLWarasaremarksTableAdapter.Update(row);
                ReloadRemark();
                Program.ShowMsg("تم اضافة الملاحظة", false, this, true);
                Program.Logger.LogThis("تم اضافة الملاحظة", Text, FXFW.Logger.OpType.success, null, null, this);
            }
            catch (SqlException ex)
            {
                Program.ShowMsg(FXFW.SqlDB.CheckExp(ex), true, this, true);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, null, ex, this);
            }
        }
        private void gridViewResarf_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            DataSources.dsRetirementCenter.TBLReSarfWarasaRow row = (DataSources.dsRetirementCenter.TBLReSarfWarasaRow)((DataRowView)
                gridViewResarf.GetRow(e.RowHandle)).Row;
            row.PersonId = _TBLWarasa[0].PersonId;
            row.userin = Program.UserInfo.UserId;
            row.datein = SQLProvider.ServerDateTime();
            row.reestktaa = 0;
        }
        private void repositoryItemButtonEditResarfSave_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DataSources.dsRetirementCenter.TBLReSarfWarasaRow row = (DataSources.dsRetirementCenter.TBLReSarfWarasaRow)((DataRowView)
           gridViewResarf.GetRow(gridViewResarf.FocusedRowHandle)).Row;
            try
            {
                tBLReSarfWarasaBindingSource.EndEdit();
                if (row.datefrom >= row.dateto)
                {
                    Program.ShowMsg("تاريخ بداية المدة يجب ان يكون اصغر من تاريخ نهاية المدة", true, this, true);
                    return;
                }
                double days = row.dateto.Subtract(row.datefrom).TotalDays;
                if (days < 30 || days > 470)
                {
                    Program.ShowMsg("الفرق ما بين تاريخ البداية و النهاية يجب ان يكون ما بين 30 و 470 يوم", true, this, true);
                    return;
                }
                // Set dateto to dof.DofatSarfDateto
                System.Linq.IQueryable<RetirementCenter.DataSources.Linq.CdDofaatAmanat> dofs_to = (from q in dsLinq.CdDofaatAmanats where q.DofatSarfAId == Convert.ToInt32(row.dofato) select q);
                foreach (RetirementCenter.DataSources.Linq.CdDofaatAmanat dof in dofs_to)
                    row.dateto = dof.DofatSarfDateto;

                System.Linq.IQueryable<RetirementCenter.DataSources.Linq.CdDofaatAmanat> dofs_from = (from q in dsLinq.CdDofaatAmanats where q.DofatSarfAId == Convert.ToInt32(row.dofafrom) select q);
                foreach (RetirementCenter.DataSources.Linq.CdDofaatAmanat dof in dofs_from)
                {
                    if (row.datefrom < dof.DofatSarfDatefrom || row.datefrom > dof.DofatSarfDateto)
                    {
                        if (!Program.UserInfo.IsAdmin)
                        {
                            msgDlg.Show("خطاء في من تاريخ");
                            return;
                        }
                        else
                        {
                            if (msgDlg.Show("خطاء في من تاريخ", msgDlg.msgButtons.YesNo) == System.Windows.Forms.DialogResult.No)
                                return;
                        }
                    }
                }
                int result = (int)SQLProvider.adpQry.TBLWarasaSarf_arshef_GetCount_Dof_ID(row.datefrom, row.dateto, row.PersonId);
                if (result > 0)
                {
                    if (!Program.UserInfo.IsAdmin && Convert.ToBoolean(SQLProvider.adpQry.RoleExists(Program.UserInfo.UserId, Program.SubAdminRole)) == false)
                    {
                        msgDlg.Show("تم صرف للعضو في الدفعات المدخله");
                        return;
                    }
                    else
                    {
                        if (msgDlg.Show("تم صرف للعضو في الدفعات المدخله", msgDlg.msgButtons.YesNo) == System.Windows.Forms.DialogResult.No)
                            return;
                    }
                }
                //ask if you wanna add all childs at once
                if (row.RowState == DataRowState.Added)
                {
                    if (msgDlg.Show("هل ترغب بأضافة كل الورثة المفعليين؟", msgDlg.msgButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                    {
                        string remarks = string.Empty;
                        if (!row.IsremarksNull())
                            remarks = row.remarks;
                        tBLReSarfWarasaTableAdapter.Update(row);
                        int inserted = tBLReSarfWarasaTableAdapter.InsertMulti(row.DofatSarfId, row.datefrom, row.dateto, row.reestktaa, row.datein, row.userin, remarks, row.dofafrom, row.dofato, _TBLWarasa[0].MMashatId);
                        Program.ShowMsg("تم اضافة " + inserted + " اخرين", false, this, true);
                    }
                    else
                        tBLReSarfWarasaTableAdapter.Update(row);
                }
                else
                    tBLReSarfWarasaTableAdapter.Update(row);
                
                Program.ShowMsg("تم تعديل بيانات اعادة الصرف", false, this, true);
                Program.Logger.LogThis("تم اضافة بيانات اعادة الصرف", Text, FXFW.Logger.OpType.success, null, null, this);
            }
            catch (SqlException ex)
            {
                Program.ShowMsg(FXFW.SqlDB.CheckExp(ex), true, this, true);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, null, ex, this);
            }
        }
        private void repositoryItemButtonEditResarfDel_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DataSources.dsRetirementCenter.TBLReSarfWarasaRow row = (DataSources.dsRetirementCenter.TBLReSarfWarasaRow)((DataRowView)
           gridViewResarf.GetRow(gridViewResarf.FocusedRowHandle)).Row;
            try
            {
                if (row.RowState == DataRowState.Detached)
                {
                    gridViewResarf.DeleteRow(gridViewResarf.FocusedRowHandle);
                    return;
                }
                if (msgDlg.Show("هل انت متأكد؟", msgDlg.msgButtons.YesNo) == System.Windows.Forms.DialogResult.No)
                    return;
                tBLReSarfWarasaBindingSource.EndEdit();
                tBLReSarfWarasaTableAdapter.Delete(_TBLWarasa[0].PersonId, row.DofatSarfId);
                gridViewResarf.DeleteRow(gridViewResarf.FocusedRowHandle);
                Program.ShowMsg("تم حذف بيانات اعادة الصرف", false, this, true);
                Program.Logger.LogThis("تم حذف بيانات اعادة الصرف", Text, FXFW.Logger.OpType.success, null, null, this);
            }
            catch (SqlException ex)
            {
                Program.ShowMsg(FXFW.SqlDB.CheckExp(ex), true, this, true);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, null, ex, this);
            }
        }
        private void gridViewTBLSarfExpetion_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            DataSources.dsRetirementCenter.TBLSarfExpetionRow row = (DataSources.dsRetirementCenter.TBLSarfExpetionRow)((DataRowView)
                gridViewTBLSarfExpetion.GetRow(e.RowHandle)).Row;
            row.PersonId = _TBLWarasa[0].PersonId;
            row.userin = Program.UserInfo.UserId;
            row.datein = SQLProvider.ServerDateTime();
        }
        private void repositoryItemButtonEditSarfExpetionSave_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DataSources.dsRetirementCenter.TBLSarfExpetionRow row = (DataSources.dsRetirementCenter.TBLSarfExpetionRow)((DataRowView)
          gridViewTBLSarfExpetion.GetRow(gridViewTBLSarfExpetion.FocusedRowHandle)).Row;
            try
            {
                tBLSarfExpetionBindingSource.EndEdit();
                tBLSarfExpetionTableAdapter.Update(row);
                Program.ShowMsg("تم تعديل بيانات الاستثناء", false, this, true);
                Program.Logger.LogThis("تم اضافة بيانات الاستثناء", Text, FXFW.Logger.OpType.success, null, null, this);
            }
            catch (SqlException ex)
            {
                Program.ShowMsg(FXFW.SqlDB.CheckExp(ex), true, this, true);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, null, ex, this);
            }
        }
        private void repositoryItemButtonEditSarfExpetionDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DataSources.dsRetirementCenter.TBLSarfExpetionRow row = (DataSources.dsRetirementCenter.TBLSarfExpetionRow)((DataRowView)
           gridViewTBLSarfExpetion.GetRow(gridViewTBLSarfExpetion.FocusedRowHandle)).Row;
            try
            {
                if (row.RowState == DataRowState.Detached)
                {
                    gridViewTBLSarfExpetion.DeleteRow(gridViewTBLSarfExpetion.FocusedRowHandle);
                    return;
                }
                if (msgDlg.Show("هل انت متأكد؟", msgDlg.msgButtons.YesNo) == System.Windows.Forms.DialogResult.No)
                    return;
                tBLSarfExpetionBindingSource.EndEdit();
                tBLSarfExpetionTableAdapter.Delete(row.DofatSarfId, _TBLWarasa[0].PersonId);
                gridViewTBLSarfExpetion.DeleteRow(gridViewTBLSarfExpetion.FocusedRowHandle);
                Program.ShowMsg("تم حذف بيانات الاستثناء", false, this, true);
                Program.Logger.LogThis("تم حذف بيانات الاستثناء", Text, FXFW.Logger.OpType.success, null, null, this);
            }
            catch (SqlException ex)
            {
                Program.ShowMsg(FXFW.SqlDB.CheckExp(ex), true, this, true);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, null, ex, this);
            }
        }
        private void cewcompletesarf_CheckedChanged(object sender, EventArgs e)
        {
            pnlPrivateSarf.Enabled = !cewcompletesarf.Checked;
        }
        private void gridViewTBLReSarfWarasa_new_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            DataSources.dsRetirementCenter.TBLWarasaMaduneaRow row = (DataSources.dsRetirementCenter.TBLWarasaMaduneaRow)((DataRowView)
           gridViewTBLWarasaMadunea.GetRow(e.RowHandle)).Row;
            row.PersonId = _TBLWarasa[0].PersonId;
            //row.DofatSarfMId = (int)SQLProvider.adpQry.MaxDofatSarfId();
            row.userin = Program.UserInfo.UserId;
            row.datein = SQLProvider.ServerDateTime();
        }
        private void gridViewResarf_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            DataSources.dsRetirementCenter.TBLReSarfWarasaRow row = (DataSources.dsRetirementCenter.TBLReSarfWarasaRow)((DataRowView)
            gridViewResarf.GetRow(gridViewResarf.FocusedRowHandle)).Row;
            if (row.IsNull("dofato"))
                return;
            System.Linq.IQueryable<RetirementCenter.DataSources.Linq.CdDofaatAmanat> dofs_to = (from q in dsLinq.CdDofaatAmanats where q.DofatSarfAId == Convert.ToInt32(row.dofato) select q);
            foreach (RetirementCenter.DataSources.Linq.CdDofaatAmanat dof in dofs_to)
                row.dateto = dof.DofatSarfDateto;
        }
        private void repositoryItemButtonEditTBLWarasaMaduneaSave_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DataSources.dsRetirementCenter.TBLWarasaMaduneaRow row = (DataSources.dsRetirementCenter.TBLWarasaMaduneaRow)((DataRowView)
                gridViewTBLWarasaMadunea.GetRow(gridViewTBLWarasaMadunea.FocusedRowHandle)).Row;
            
            try
            {
                row.userin = Program.UserInfo.UserId;
                row.datein = SQLProvider.ServerDateTime();
                tBLWarasaMaduneaBindingSource.EndEdit();
                tBLWarasaMaduneaTableAdapter.Update(row);
                Program.ShowMsg("تم تعديل بيانات المديونية", false, this, true);
                Program.Logger.LogThis("تم تعديل بيانات المديونية", Text, FXFW.Logger.OpType.success, null, null, this);
            }
            catch (SqlException ex)
            {
                Program.ShowMsg(FXFW.SqlDB.CheckExp(ex), true, this, true);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, null, ex, this);
            }
        }
        private void repositoryItemButtonEditTBLWarasaMaduneaDel_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DataSources.dsRetirementCenter.TBLWarasaMaduneaRow row = (DataSources.dsRetirementCenter.TBLWarasaMaduneaRow)((DataRowView)
           gridViewTBLWarasaMadunea.GetRow(gridViewTBLWarasaMadunea.FocusedRowHandle)).Row;
            try
            {
                if (row.RowState == DataRowState.Detached)
                {
                    gridViewTBLWarasaMadunea.DeleteRow(gridViewTBLWarasaMadunea.FocusedRowHandle);
                    return;
                }
                if (msgDlg.Show("هل انت متأكد؟", msgDlg.msgButtons.YesNo) == System.Windows.Forms.DialogResult.No)
                    return;
                row.userin = Program.UserInfo.UserId;
                row.datein = SQLProvider.ServerDateTime();
                tBLWarasaMaduneaBindingSource.EndEdit();
                tBLWarasaMaduneaTableAdapter.Delete(row.DofatSarfMId, row.PersonId);
                gridViewTBLWarasaMadunea.DeleteRow(gridViewTBLWarasaMadunea.FocusedRowHandle);
                Program.ShowMsg("تم الحذف", false, this, true);
                Program.Logger.LogThis("تم الحذف", Text, FXFW.Logger.OpType.success, null, null, this);
            }
            catch (SqlException ex)
            {
                Program.ShowMsg(FXFW.SqlDB.CheckExp(ex), true, this, true);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, null, ex, this);
            }
        }

        #endregion

    }
}