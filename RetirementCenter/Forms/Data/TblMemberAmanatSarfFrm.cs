﻿
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using DevExpress.XtraGrid.Views.Grid;

namespace RetirementCenter
{
    public partial class TblMemberAmanatSarfFrm : XtraForm
    {
        bool _Insert, _Update, _Delete;
        DataSources.Linq.dsTeachersUnionViewsDataContext dsLinq = new DataSources.Linq.dsTeachersUnionViewsDataContext();
        DataSources.dsRetirementCenterTableAdapters.ForInsertTBLMemberSarf_arshefTableAdapter adp = new DataSources.dsRetirementCenterTableAdapters.ForInsertTBLMemberSarf_arshefTableAdapter();
        #region -   Functions   -
        public TblMemberAmanatSarfFrm()
        {
            InitializeComponent();
            SQLProvider.SetAllCommandTimeouts(adp, 0);
            SQLProvider.SetAllCommandTimeouts(tblMemberAmanatTableAdapter, 0);
        }
        private void ActiveKeyDownEvent(object sender, KeyEventArgs e)
        {
            return;
            if (e.KeyData != Keys.F5 && e.KeyData != Keys.F6 && e.KeyData != Keys.F10 && e.KeyData != Keys.F8)
                return;
            switch (e.KeyData)
            {
                case Keys.F1:
                    break;
                case Keys.F5:
                    //btnNew_Click(btnNew, new EventArgs());
                    break;
                case Keys.F6:
                    repositoryItemButtonEditSave_ButtonClick(repositoryItemButtonEditSave, new DevExpress.XtraEditors.Controls.ButtonPressedEventArgs(new DevExpress.XtraEditors.Controls.EditorButton()));
                    break;
                case Keys.F8:
                    //repositoryItemButtonEditDel_ButtonClick(repositoryItemButtonEditDel, new DevExpress.XtraEditors.Controls.ButtonPressedEventArgs(new DevExpress.XtraEditors.Controls.EditorButton()));
                    break;
                case Keys.F10:
                    repositoryItemButtonEditSave_ButtonClick(repositoryItemButtonEditSave, new DevExpress.XtraEditors.Controls.ButtonPressedEventArgs(new DevExpress.XtraEditors.Controls.EditorButton()));
                    break;
                default:
                    break;
            }
        }
        private void ActivePriv()
        {
            bool Selecting = false, Inserting = false, Updateing = false, Deleting = false;
            SQLProvider.GetFormPriv(this.Name, ref Selecting, ref Inserting, ref  Updateing, ref  Deleting);
            gridControlData.Visible = Selecting;

            //btnNew.Visible = Inserting;
            repositoryItemButtonEditSave.Buttons[0].Visible = Updateing;
            //repositoryItemButtonEditDel.Buttons[0].Visible = Deleting;

            _Insert = Inserting; _Update = Updateing; _Delete = Deleting;
        }
        #endregion
        #region - Event Handlers -
        private void FormFrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsRetirementCenter.TBLDofatSarf' table. You can move, or remove it, as needed.
            this.tBLDofatSarfTableAdapter.Fill(this.dsRetirementCenter.TBLDofatSarf);
            // TODO: This line of code loads data into the 'dsRetirementCenter.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.dsRetirementCenter.Users);
            LSMSTBLMashat.QueryableSource = dsLinq.vTBLMashats;
            LSMScd_amanattype.QueryableSource = dsLinq.cd_amanattypes;
            // TODO: This line of code loads data into the 'dsRetirementCenter.CdDofaatAmanat' table. You can move, or remove it, as needed.
            this.cdDofaatAmanatTableAdapter.Fill(this.dsRetirementCenter.CdDofaatAmanat);
            // TODO: This line of code loads data into the 'dsRetirementCenter.TblMemberAmanat' table. You can move, or remove it, as needed.
            this.tblMemberAmanatTableAdapter.FillByaccReview(this.dsRetirementCenter.TblMemberAmanat);
            ActivePriv();
        }
        private void gridViewData_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            DataRowView DRV = (DataRowView)e.Row;
            //Fellowship.DataSources.DSFellowship.TBLSheekWaredRow row = (Fellowship.DataSources.DSFellowship.TBLSheekWaredRow)DRV.Row;

            if (e.ErrorText.Contains("SyndicateId"))
            {
                e.ErrorText = "من فضلك بجب ادخال الفرعيه";
                return;
            }
            if (e.ErrorText.Contains("autoID"))
            {
                //e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;
                DRV["autoID"] = "-1";
                return;
            }

        }
        private void repositoryItemButtonEditSave_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            GridView GV = (GridView)gridControlData.MainView;
            DataSources.dsRetirementCenter.TblMemberAmanatRow row = (DataSources.dsRetirementCenter.TblMemberAmanatRow)GV.GetFocusedDataRow();
            row.EndEdit();
            //tblMemberAmanatTableAdapter.Update(row);
            tblMemberAmanatTableAdapter.UpdateDofatSarfId(row.DofatSarfId, row.MMashatId, row.DofatSarfAId);
            msgDlg.Show("تم حفظ التعديل", msgDlg.msgButtons.Close);
            
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انت متأكد؟", "تحزير ...", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
                return;
            SqlConnection con = new SqlConnection(Properties.Settings.Default.RetirementCenterConnectionString);
            SqlCommand cmd = new SqlCommand(@"INSERT INTO TBLMemberSarf_arshef (MMashatId, DofatSarfId, SarfTypeedadId, sarfdatefrom, sarfdateto, monymonth, rsmmonth, eshtrakmonth, estktaa, sarf, datein, userin, Edafat, SyndicateId, SubCommitteId, SendBank, amanatvisa, amanatAutoId, sarfcheek) 
            VALUES (@MMashatId, @DofatSarfId, @SarfTypeedadId, @sarfdatefrom, @sarfdateto, @monymonth, @rsmmonth, @eshtrakmonth, @estktaa, @sarf, GETDATE(), @userin, @Edafat, @SyndicateId, @SubCommitteId, @SendBank, @amanatvisa, @amanatAutoId, @sarfcheek)
            ", con);
            SqlParameter paramMMashatId = new SqlParameter("@MMashatId", SqlDbType.Int);
            SqlParameter paramDofatSarfId = new SqlParameter("@DofatSarfId", SqlDbType.Int);
            SqlParameter paramSarfTypeedadId = new SqlParameter("@SarfTypeedadId", SqlDbType.TinyInt);
            SqlParameter paramsarfdatefrom = new SqlParameter("@sarfdatefrom", SqlDbType.DateTime);
            SqlParameter paramsarfdateto = new SqlParameter("@sarfdateto", SqlDbType.DateTime);
            SqlParameter parammonymonth = new SqlParameter("@monymonth", SqlDbType.Float);
            SqlParameter paramrsmmonth = new SqlParameter("@rsmmonth", SqlDbType.Float);
            SqlParameter parameshtrakmonth = new SqlParameter("@eshtrakmonth", SqlDbType.Float);
            SqlParameter paramestktaa = new SqlParameter("@estktaa", SqlDbType.Float);
            SqlParameter paramsarf = new SqlParameter("@sarf", SqlDbType.Bit) { Value = true };
            SqlParameter paramuserin = new SqlParameter("@userin", SqlDbType.Int) { Value = Program.UserInfo.UserId };
            SqlParameter paramEdafat = new SqlParameter("@Edafat", SqlDbType.Bit) { Value = false };
            SqlParameter paramSyndicateId = new SqlParameter("@SyndicateId", SqlDbType.Int);
            SqlParameter paramSubCommitteId = new SqlParameter("@SubCommitteId", SqlDbType.Int);
            SqlParameter paramSendBank = new SqlParameter("@SendBank", SqlDbType.Bit);
            SqlParameter paramamanatvisa = new SqlParameter("@amanatvisa", SqlDbType.Bit);
            SqlParameter paramamanatAutoId = new SqlParameter("@amanatAutoId", SqlDbType.Int);
            SqlParameter paramsarfcheek = new SqlParameter("@sarfcheek", SqlDbType.Bit);
            cmd.Parameters.AddRange(new[] { paramMMashatId, paramDofatSarfId, paramSarfTypeedadId, paramsarfdatefrom, paramsarfdateto, parammonymonth, paramrsmmonth, parameshtrakmonth, paramestktaa
                , paramsarf, paramuserin, paramEdafat, paramSyndicateId, paramSubCommitteId, paramSendBank, paramamanatvisa, paramamanatAutoId, paramsarfcheek});

            SqlCommand cmdCheck = new SqlCommand("SELECT COUNT(*) FROM TBLMemberSarf_arshef WHERE MMashatId = @MMashatId AND DofatSarfId = @DofatSarfId AND SarfTypeedadId = 6", con);
            SqlParameter paramCheckMMashatId = new SqlParameter("@MMashatId", SqlDbType.Int);
            SqlParameter paramCheckDofatSarfId = new SqlParameter("@DofatSarfId", SqlDbType.Int);
            cmdCheck.Parameters.AddRange(new[] { paramCheckMMashatId, paramCheckDofatSarfId });

            DataSources.dsRetirementCenter.ForInsertTBLMemberSarf_arshefDataTable tbl = adp.GetData(Program.UserInfo.UserId);
            int effected = 0;
            con.Open();
            foreach (DataSources.dsRetirementCenter.ForInsertTBLMemberSarf_arshefRow item in tbl)
            {
                paramCheckMMashatId.Value = item.MMashatId;
                paramCheckDofatSarfId.Value = item.DofatSarfId;
                if ((int)cmdCheck.ExecuteScalar() != 0)
                    continue;
                paramMMashatId.Value = item.MMashatId;
                paramDofatSarfId.Value = item.DofatSarfId;
                paramSarfTypeedadId.Value = item.SarfTypeedadId;
                paramsarfdatefrom.Value = item.DofatSarfDatefrom;
                paramsarfdateto.Value = item.DofatSarfDateto;
                parammonymonth.Value = item.amanatmony;
                paramrsmmonth.Value = item.rsmmonth;
                parameshtrakmonth.Value = item.eshtrakmonth;
                paramestktaa.Value = item.estktaa;
                paramSyndicateId.Value = item.SyndicateId;
                paramSubCommitteId.Value = item.SubCommitteId;
                paramSendBank.Value = 0;
                paramamanatvisa.Value = item.amantvisa;
                paramamanatAutoId.Value = item.AutoId;
                paramsarfcheek.Value = item.sarfcheek;
                cmd.ExecuteNonQuery();
                effected++;
            }
            con.Close();
            Program.ShowMsg("تم الاضافة" + Environment.NewLine + effected + "من اجمالي" + Environment.NewLine + tbl.Count, false, this, true);
            Program.Logger.LogThis("تم الاضافة" + Environment.NewLine + effected + "من اجمالي" + Environment.NewLine + tbl.Count, Text, FXFW.Logger.OpType.success, null, null, this);
        }
        private void btnSarf_Click(object sender, EventArgs e)
        {
            TblMemberAmanatSarf2Frm frm = new TblMemberAmanatSarf2Frm();
            frm.MdiParent = this.ParentForm;
            frm.Show();
        }
        #endregion

    }
}