﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using FXFW;
using DevExpress.XtraGrid.Views.Grid;
using System.Linq;
using DevExpress.XtraGrid;
using DevExpress.XtraSplashScreen;

namespace RetirementCenter
{
    public partial class TblWarasaAmanatSarf2Frm : DevExpress.XtraEditors.XtraForm
    {
        DataSources.Linq.dsTeachersUnionViewsDataContext dsLinq = new DataSources.Linq.dsTeachersUnionViewsDataContext();
        DataSources.dsRetirementCenterTableAdapters.TBLReSarfWarasaTableAdapter adpSarf = new DataSources.dsRetirementCenterTableAdapters.TBLReSarfWarasaTableAdapter();
        private int MaxDofatSarfId = (int)new DataSources.dsQueriesTableAdapters.TBLDofatSarfTableAdapter().MaxId();
        DataSources.dsRetirementCenterTableAdapters.TBLWarasaSarf_arshefTableAdapter adpArc = new DataSources.dsRetirementCenterTableAdapters.TBLWarasaSarf_arshefTableAdapter();

        #region -   Functions   -
        public TblWarasaAmanatSarf2Frm()
        {
            InitializeComponent();
            SQLProvider.SetAllCommandTimeouts(warasaExceptionDofaatCreatorTableAdapter, 0);
            SQLProvider.SetAllCommandTimeouts(warasaDofaatCreatorTableAdapter, 0);
            SQLProvider.SetAllCommandTimeouts(warasaExtraDofaatCreatorTableAdapter, 0);
            SQLProvider.SetAllCommandTimeouts(adpArc, 0);
            SQLProvider.SetAllCommandTimeouts(adpSarf, 0);
            SQLProvider.SetAllCommandTimeouts(tBLWarasaSarfTableAdapter, 0);
            SQLProvider.SetAllCommandTimeouts(tblMashatTableAdapter, 0);

        }
        private void ActivePriv()
        {
            return;
            //bool Selecting = false, Inserting = false, Updateing = false, Deleting = false;
            //SqlDB.GetFormPriv("Retirement" + Name.Replace("Frm", ""), ref Selecting, ref Inserting, ref  Updateing, ref  Deleting);
            //gridControlData.Visible = Selecting;
            //if (Inserting || Updateing)
            //    repositoryItemButtonEditSave.Buttons[0].Enabled = true;
            //else
            //    repositoryItemButtonEditSave.Buttons[0].Enabled = false;
            //repositoryItemButtonEditDel.Buttons[0].Enabled = Deleting;
        }
        private float GetMemberWarasa(int PersonId, float rasm)
        {
            return 0;
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter("", Properties.Settings.Default.RetirementCenterConnectionString);
            adp.SelectCommand.CommandText = string.Format(@"SELECT WarasaTypeId, responsiblesarf, responsiblesarfId, 0 as value,
            (SELECT countwife from TBLMashat where MMashatId = (SELECT MMashatId FROM TBLWarasa WHERE PersonId = {0})) AS countwife,
            (SELECT countson from TBLMashat where MMashatId = (SELECT MMashatId FROM TBLWarasa WHERE PersonId = {0})) AS countson,
            (SELECT sarffeatype from TBLMashat where MMashatId = (SELECT MMashatId FROM TBLWarasa WHERE PersonId = {0})) AS sarffeatype
            FROM TBLWarasa WHERE yasref = 1 AND MMashatId = (SELECT MMashatId FROM TBLWarasa WHERE PersonId = {0})", PersonId);
            adp.Fill(dt);
            byte sarffeatypec = (byte)dt.Rows[0]["sarffeatype"];
            switch (sarffeatypec)
            {
                case (byte)Misc.Types.CDsarfType.Armala:
                case (byte)Misc.Types.CDsarfType.Abnaa:
                    foreach (DataRow row in dt.Rows)
                        row["value"] = rasm / dt.Rows.Count;
                    break;
                case (byte)Misc.Types.CDsarfType.Abn_Abna:
                    return rasm;
                case (byte)Misc.Types.CDsarfType.Armala_Abnaa:
                    foreach (DataRow row in dt.Rows)
                    {
                        switch ((byte)row["WarasaTypeId"])
                        {
                            case (byte)Misc.Types.CDWarasaType.Abn:
                            case (byte)Misc.Types.CDWarasaType.Abna:

                                break;
                            case (byte)Misc.Types.CDWarasaType.Armala:

                                break;
                        }
                        row["value"] = (rasm / 2) / dt.Rows.Count;
                    }
                    break;
            }
            

        }
        private int TotalMonths(DateTime Bigdate, DateTime SmallDate)
        {
            int months = (Bigdate.Year * 12 + Bigdate.Month) - (SmallDate.Year * 12 + SmallDate.Month) + 1;
            if (SmallDate.Day != 1 && months > 0)
                months--;
            return months;
        }
        private void LoadTBLWarasaSarfArc()
        {
            if (LUETBLDofatSarf.EditValue != null && deDateIn.EditValue != null)
                adpArc.FillBy_Dof_UserIn(dsRetirementCenter.TBLWarasaSarf_arshef, Convert.ToInt32(LUETBLDofatSarf2.EditValue), deDateIn.DateTime.Date); 
        }
        private void UpdateTBLMashat_sarffeatype(int Dof, DateTime DateIn)
        {
            string Date = DateIn.Year + "-" + DateIn.Month + "-" + DateIn.Day;
            SqlConnection con = new SqlConnection(Properties.Settings.Default.RetirementCenterConnectionString);
            SqlConnection conUpdate = new SqlConnection(Properties.Settings.Default.RetirementCenterConnectionString);

            int updatedRows = tblMashatTableAdapter.UpdateQueryWarasaCount2();
            Program.ShowMsg("تم تحديث " + updatedRows + " عضو ", false, this, false);

            //Command to get all members to update
            SqlCommand cmdTBLMashat = new SqlCommand(string.Format(@"SELECT MMashatId, countwife, countson FROM TBLMashat WHERE MashHalaId = 2 
            AND Exists(SELECT * FROM vTBLWarasaSarf_arshef2 WHERE [MMashatId] = TBLMashat.MMashatId AND [DofatSarfId] = {0} and CAST([datein] AS DATE) = '{1}')", Dof, Date), con);
            cmdTBLMashat.CommandTimeout = 0;

            //Command to Update member depand on its Warasa type
            SqlCommand cmdUpdate = new SqlCommand("UPDATE TBLMashat SET sarffeatype = @sarffeatype WHERE MMashatId = @MMashatId", conUpdate);
            cmdUpdate.CommandTimeout = 0;
            SqlParameter pramsarffeatype = new SqlParameter("@sarffeatype", SqlDbType.TinyInt);
            SqlParameter pramUpdateMMashatId = new SqlParameter("@MMashatId", SqlDbType.Int);
            cmdUpdate.Parameters.Add(pramUpdateMMashatId); cmdUpdate.Parameters.Add(pramsarffeatype);

            con.Open();
            conUpdate.Open();

            DataTable dt = new DataTable();
            dt.Load(cmdTBLMashat.ExecuteReader());
            pbc.Properties.Maximum = dt.Rows.Count; lblMax.Text = dt.Rows.Count.ToString();
            pbc.EditValue = 0;
            foreach (DataRow row in dt.Rows)
            {
                pbc.EditValue = (int)pbc.EditValue + 1;

                pramUpdateMMashatId.Value = row["MMashatId"];
                if (row["countwife"] == null || row["countwife"].ToString() == "")
                    row["countwife"] = 0;
                if (row["countson"] == null || row["countson"].ToString() == "")
                    row["countson"] = 0;

                if (Convert.ToInt32(row["countwife"]) == 0 && Convert.ToInt32(row["countson"]) == 1)
                    pramsarffeatype.Value = (int)Misc.Types.CDsarfType.Abn_Abna;
                else if (Convert.ToInt32(row["countwife"]) == 0 && Convert.ToInt32(row["countson"]) > 1)
                    pramsarffeatype.Value = (int)Misc.Types.CDsarfType.Abnaa;
                else if (Convert.ToInt32(row["countwife"]) > 0 && Convert.ToInt32(row["countson"]) == 0)
                    pramsarffeatype.Value = (int)Misc.Types.CDsarfType.Armala;
                else if (Convert.ToInt32(row["countwife"]) > 0 && Convert.ToInt32(row["countson"]) > 0)
                    pramsarffeatype.Value = (int)Misc.Types.CDsarfType.Armala_Abnaa;
                else
                {
                    msgDlg.Show("العضو " + Environment.NewLine + row[0] + Environment.NewLine + "لا يوجد له زوجات و لا اولاد", msgDlg.msgButtons.Close);
                    pramsarffeatype.Value = 99;
                }
                cmdUpdate.ExecuteNonQuery();
                Application.DoEvents();
            }
            pbc.EditValue = 0;
            cmdTBLMashat.Dispose(); cmdUpdate.Dispose();
            con.Close(); con.Dispose(); conUpdate.Close(); conUpdate.Dispose();
        }
        private static void Getmonymonth(DataSources.dsQueries.WarasaExtraDofaatCreatorRow row,ref DataSources.dsRetirementCenter.TBLWarasaSarfRow record, int months)
        {
            switch (row.WarasaTypeId)
            {
                case (byte)Misc.Types.CDWarasaType.Armala:
                    switch (row.sarffeatype)
                    {
                        case (byte)Misc.Types.CDsarfType.Armala:
                            record.monymonth = (row.feasarf / row.countwife) * months;
                            break;
                        case (byte)Misc.Types.CDsarfType.Armala_Abnaa:
                            double money = row.feasarf / 2;
                            record.monymonth = (money / row.countwife) * months;
                            break;
                    }
                    break;
                case (byte)Misc.Types.CDWarasaType.Abn:
                case (byte)Misc.Types.CDWarasaType.Abna:
                    switch (row.sarffeatype)
                    {
                        case (byte)Misc.Types.CDsarfType.Abn_Abna:
                            record.monymonth = row.feasarf * months;
                            break;
                        case (byte)Misc.Types.CDsarfType.Abnaa:
                            record.monymonth = (row.feasarf / row.countson) * months;
                            break;
                        case (byte)Misc.Types.CDsarfType.Armala_Abnaa:
                            double money = row.feasarf / 2;
                            record.monymonth = (money / row.countson) * months;
                            break;
                    }
                    break;
            }
            //if (record.IsNull("monymonth"))
            //{
            //    string x = string.Empty;
            //}
        }
        private static void Getmonymonth(DataSources.dsQueries.WarasaDofaatCreatorRow row, ref DataSources.dsRetirementCenter.TBLWarasaSarfRow record, int months)
        {
           
            switch (row.WarasaTypeId)
            {
                case (byte)Misc.Types.CDWarasaType.Armala:
                    switch (row.sarffeatype)
                    {
                        case (byte)Misc.Types.CDsarfType.Armala:
                            record.monymonth = (row.feasarf / row.countwife) * months;
                            break;
                        case (byte)Misc.Types.CDsarfType.Armala_Abnaa:
                            double money = row.feasarf / 2;
                            record.monymonth = (money / row.countwife) * months;
                            break;
                    }
                    break;
                case (byte)Misc.Types.CDWarasaType.Abn:
                case (byte)Misc.Types.CDWarasaType.Abna:
                    switch (row.sarffeatype)
                    {
                        case (byte)Misc.Types.CDsarfType.Abn_Abna:
                            record.monymonth = row.feasarf * months;
                            break;
                        case (byte)Misc.Types.CDsarfType.Abnaa:
                            record.monymonth = (row.feasarf / row.countson) * months;
                            break;
                        case (byte)Misc.Types.CDsarfType.Armala_Abnaa:
                            double money = row.feasarf / 2;
                            record.monymonth = (money / row.countson) * months;
                            break;
                    }
                    break;
            }
            //if (record.IsNull("monymonth"))
            //{
            //    string x = string.Empty;
            //}
        }
        private static void Getrasmmonth(DataSources.dsQueries.WarasaExtraDofaatCreatorRow row, ref DataSources.dsRetirementCenter.TBLWarasaSarfRow record, double rasm, int months)
        {
            switch (row.WarasaTypeId)
            {
                case (byte)Misc.Types.CDWarasaType.Armala:
                    switch (row.sarffeatype)
                    {
                        case (byte)Misc.Types.CDsarfType.Armala:
                            record.rsmmonth = (rasm / row.countwife) * months;
                            break;
                        case (byte)Misc.Types.CDsarfType.Armala_Abnaa:
                            double money = rasm / 2;
                            record.rsmmonth = (money / row.countwife) * months;
                            break;
                    }
                    break;
                case (byte)Misc.Types.CDWarasaType.Abn:
                case (byte)Misc.Types.CDWarasaType.Abna:
                    switch (row.sarffeatype)
                    {
                        case (byte)Misc.Types.CDsarfType.Abn_Abna:
                            record.rsmmonth = rasm * months;
                            break;
                        case (byte)Misc.Types.CDsarfType.Abnaa:
                            record.rsmmonth = (rasm / row.countson) * months;
                            break;
                        case (byte)Misc.Types.CDsarfType.Armala_Abnaa:
                            double money = rasm / 2;
                            record.rsmmonth = (money / row.countson) * months;
                            break;
                    }
                    break;
            }
        }
        private static void Getrasmmonth(DataSources.dsQueries.WarasaDofaatCreatorRow row, ref DataSources.dsRetirementCenter.TBLWarasaSarfRow record, double rasm, int months)
        {
            switch (row.WarasaTypeId)
            {
                case (byte)Misc.Types.CDWarasaType.Armala:
                    switch (row.sarffeatype)
                    {
                        case (byte)Misc.Types.CDsarfType.Armala:
                            record.rsmmonth = (rasm / row.countwife) * months;
                            break;
                        case (byte)Misc.Types.CDsarfType.Armala_Abnaa:
                            double money = rasm / 2;
                            record.rsmmonth = (money / row.countwife) * months;
                            break;
                    }
                    break;
                case (byte)Misc.Types.CDWarasaType.Abn:
                case (byte)Misc.Types.CDWarasaType.Abna:
                    switch (row.sarffeatype)
                    {
                        case (byte)Misc.Types.CDsarfType.Abn_Abna:
                            record.rsmmonth = rasm * months;
                            break;
                        case (byte)Misc.Types.CDsarfType.Abnaa:
                            record.rsmmonth = (rasm / row.countson) * months;
                            break;
                        case (byte)Misc.Types.CDsarfType.Armala_Abnaa:
                            double money = rasm / 2;
                            record.rsmmonth = (money / row.countson) * months;
                            break;
                    }
                    break;
            }
        }

        #endregion
        #region - Event Handlers -
        private void TBLWarasaSarfFrm_Load(object sender, EventArgs e)
        {
            ActivePriv();
            LSMSTBLDofatSarf.QueryableSource = from q in dsLinq.TBLDofatSarfs select q;
            if (Program.UserInfo.IsAdmin)
                LSMSCDSyndicate.QueryableSource = dsLinq.CDSyndicates;
            else
                LSMSCDSyndicate.QueryableSource = from q in dsLinq.CDSyndicates where Program.UserInfo.Syndicates.Contains(q.SyndicateId) select q;

            LSMSCDSubCommitte.QueryableSource = dsLinq.CDSubCommittes;
            LSMSCDWarasaType.QueryableSource = dsLinq.CDWarasaTypes;

            if (FXFW.SqlDB.IsNullOrEmpty(LUETBLDofatSarf.EditValue))
                LUETBLDofatSarf.EditValue = MaxDofatSarfId;
        }
        private void LUE_EditValueChanged(object sender, EventArgs e)
        {
            return;
            if (LUETBLDofatSarf.EditValue == null || LUETBLDofatSarf.EditValue.ToString() == string.Empty || deDateIn.EditValue == null || deDateIn.EditValue.ToString() == string.Empty)
                return;
            LoadTBLWarasaSarfArc();
        }
        
        double summaryTotal = 0;
        private void gridViewData_CustomSummaryCalculate(object sender, DevExpress.Data.CustomSummaryEventArgs e)
        {
            GridColumnSummaryItem item = e.Item as GridColumnSummaryItem;
            GridView view = sender as GridView;

            if (item.FieldName == "personName")
            {
                switch (e.SummaryProcess)
                {
                    case DevExpress.Data.CustomSummaryProcess.Start:
                        summaryTotal = 0;
                        break;
                    case DevExpress.Data.CustomSummaryProcess.Calculate:
                        double plus = Convert.ToDouble(view.GetRowCellValue(e.RowHandle, "monymonth")) -
                            Convert.ToDouble(view.GetRowCellValue(e.RowHandle, "rsmmonth")) -
                            Convert.ToDouble(view.GetRowCellValue(e.RowHandle, "estktaa")) -
                            Convert.ToDouble(view.GetRowCellValue(e.RowHandle, "eshtrakmonth"));
                        summaryTotal += plus;
                        break;
                    case DevExpress.Data.CustomSummaryProcess.Finalize:
                        e.TotalValue = summaryTotal;
                        break;
                }
            }
        }
        private void btnAddAll_Click(object sender, EventArgs e)
        {
            try
            {
                if (LUETBLDofatSarf.EditValue == null || deDateIn.EditValue == null)
                {
                    Program.ShowMsg("من فضلك اختار الدفعة و اليوم", true, this, true);
                    return;
                }
                DataSources.Linq.TBLDofatSarf dofaa = (DataSources.Linq.TBLDofatSarf)LUETBLDofatSarf.GetSelectedDataRow();
                DataSources.Linq.TBLDofatSarf dofaa2 = (DataSources.Linq.TBLDofatSarf)LUETBLDofatSarf2.GetSelectedDataRow();
                if ((bool)dofaa2.dofclosed)
                {
                    Program.ShowMsg("لا يمكن اعداد دفعة مغلقه", true, this, true);
                    return;
                }
                if (msgDlg.Show("سوف يتم حذف البيانات من جدول الاعداد. هل انت متأكد؟", msgDlg.msgButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    new DataSources.dsQueriesTableAdapters.QueriesTableAdapter().DELETE_All_From_TBLWarasaSarf();
                }
                //if ((int)SQLProvider.adpQry.DofatSarfActivityClosed(Convert.ToInt32(deDateIn.EditValue), dofaa.DofatSarfId, (byte)Misc.Types.CDMashHala.Warasa) > 0)
                //{
                //    if (Program.UserInfo.IsAdmin)
                //    {
                //        if (msgDlg.Show("تم اغلاق هذه الفرعية, هل ترغب في اعادة فتحها؟", msgDlg.msgButtons.YesNo) == System.Windows.Forms.DialogResult.No)
                //            return;
                //        new DataSources.dsRetirementCenterTableAdapters.DofatSarfActivityTableAdapter().CloseUnCloseDofat(false, SQLProvider.ServerDateTime(), Program.UserInfo.UserId, Convert.ToInt32(deDateIn.EditValue), dofaa.DofatSarfId, (byte)Misc.Types.CDMashHala.Warasa);
                //    }
                //    else
                //    {
                //        Program.ShowMsg("تم اغلاق هذه الفرعية لا يمكن اعداد فرعية مغلقه", true, this, true);
                //        return;
                //    }
                //}
                if (msgDlg.Show("هل انت متأكد؟", msgDlg.msgButtons.YesNo) == System.Windows.Forms.DialogResult.No)
                    return;
                gcCommands.Enabled = false;
                pcProgress.Visible = true;

                dsRetirementCenter.TBLWarasaSarf.Clear();
                dsQueries.WarasaDofaatCreator.Clear();
                dsQueries.WarasaExtraDofaatCreator.Clear();

                double Rasm = Convert.ToDouble(SQLProvider.adpQry.ScalarQueryRasm());
                //Update Member's sarffeatype b4 start
                UpdateTBLMashat_sarffeatype(dofaa2.DofatSarfId, deDateIn.DateTime.Date);

                warasaExceptionDofaatCreatorTableAdapter.FillBy_Dof_DateIn(dsQueries.WarasaExceptionDofaatCreator, dofaa.DofatSarfId, deDateIn.DateTime.Date);
                warasaDofaatCreatorTableAdapter.FillBy_Dof_DateIn(dsQueries.WarasaDofaatCreator, dofaa.DofatSarfId, deDateIn.DateTime.Date);
                warasaExtraDofaatCreatorTableAdapter.FillBy_Dof_DateIn(dsQueries.WarasaExtraDofaatCreator, dofaa.DofatSarfId, deDateIn.DateTime.Date);
                

                pbc.Properties.Maximum = dsQueries.WarasaDofaatCreator.Count + dsQueries.WarasaExtraDofaatCreator.Count;
                lblMax.Text = pbc.Properties.Maximum.ToString(); pbc.EditValue = 0; lblValue.Text = "0";
                DateTime serverdatetime = SQLProvider.ServerDateTime();
                int debug_steps = 0;
                //Add Exception
                foreach (DataSources.dsQueries.WarasaExceptionDofaatCreatorRow row0 in dsQueries.WarasaExceptionDofaatCreator.Rows)
                {
                    DataSources.dsRetirementCenter.TBLWarasaSarfRow record = dsRetirementCenter.TBLWarasaSarf.NewTBLWarasaSarfRow();
                    record.DofatSarfId = dofaa2.DofatSarfId;
                    record.eshtrakmonth = 0;
                    record.estktaa = 0;
                    record.PersonId = row0.PersonId;
                    record.personName = row0.personName;
                    record.MMashatName = row0.MMashatName;
                    record.WarasaTypeId = row0.WarasaTypeId;
                    record.SyndicateIdMashat = row0.SyndicateIdMashat;
                    record.SubCommitteIdMashat = row0.SubCommitteIdMashat;
                    record.SyndicateId = row0.SyndicateId;
                    record.SubCommitteId = row0.SubCommitteId;
                    record.sarfnumber = row0.sarfnumber;

                    record.monymonth = row0.wmonymonth;
                    record.rsmmonth = row0.wrsmmonth;
                    record.sarf = true;
                    record.Edafat = true;
                    record.sarfdatefrom = dofaa2.DofatSarfDatefrom;
                    record.sarfdateto = dofaa2.DofatSarfDateto;
                    record.datein = serverdatetime;
                    record.userin = Program.UserInfo.UserId;
                    record.SarfTypeedadId = (int)Misc.Types.SarfTypeedadId.astsnaa_3;
                    if (dsRetirementCenter.TBLWarasaSarf.FindBySarfTypeedadIdPersonIdDofatSarfId(record.SarfTypeedadId, record.PersonId, record.DofatSarfId) == null)
                        dsRetirementCenter.TBLWarasaSarf.AddTBLWarasaSarfRow(record);
                    //debug_steps++; Console.WriteLine(debug_steps);
                    //if (debug_steps == 332)
                    //{ string x = ""; }
                }
                //Add Extra
                foreach (DataSources.dsQueries.WarasaExtraDofaatCreatorRow row1 in dsQueries.WarasaExtraDofaatCreator.Rows)
                {
                    DataSources.dsRetirementCenter.TBLWarasaSarfRow record = dsRetirementCenter.TBLWarasaSarf.NewTBLWarasaSarfRow();
                    record.DofatSarfId = dofaa2.DofatSarfId;
                    int months = TotalMonths(dofaa2.DofatSarfDateto, row1.datesarf);
                    if (months > 15)
                        months = 15;
                    record.eshtrakmonth = 0;
                    //record.monymonth = row1.feasarf * months;
                    record.estktaa = row1.estktaa;
                    record.PersonId = row1.PersonId;
                    record.personName = row1.personName;
                    record.MMashatName = row1.MMashatName;
                    record.WarasaTypeId = row1.WarasaTypeId;
                    record.SyndicateIdMashat = row1.SyndicateIdMashat;
                    record.SubCommitteIdMashat = row1.SubCommitteIdMashat;
                    record.SyndicateId = row1.SyndicateId;
                    record.SubCommitteId = row1.SubCommitteId;
                    record.sarfnumber = row1.sarfnumber;

                    Getmonymonth(row1, ref record, months);
                    Getrasmmonth(row1, ref record, Rasm, months);

                    record.sarf = true;
                    record.Edafat = true;
                    record.sarfdatefrom = row1.datesarf;
                    record.sarfdateto = dofaa2.DofatSarfDateto;
                    record.datein = serverdatetime;
                    record.userin = Program.UserInfo.UserId;
                    record.SarfTypeedadId = (int)Misc.Types.SarfTypeedadId.Unknown_1;

                    //if (record.IsNull("monymonth"))
                    //{
                    //    string x;
                    //}

                    dsRetirementCenter.TBLWarasaSarf.AddTBLWarasaSarfRow(record);
                    //debug_steps++; Console.WriteLine(debug_steps);
                    //if (debug_steps == 332)
                    //{ string x = ""; }
                    //Add Resarf
                    adpSarf.FillByPersonId_DofatSarfId(dsRetirementCenter.TBLReSarfWarasa, row1.PersonId, dofaa2.DofatSarfId);
                    foreach (DataSources.dsRetirementCenter.TBLReSarfWarasaRow ResarfRow in dsRetirementCenter.TBLReSarfWarasa)
                    {

                        DataSources.dsRetirementCenter.TBLWarasaSarfRow Resarfrecord = dsRetirementCenter.TBLWarasaSarf.NewTBLWarasaSarfRow();
                        Resarfrecord.DofatSarfId = dofaa2.DofatSarfId;
                        int ResarfManths = TotalMonths(ResarfRow.dateto, ResarfRow.datefrom);
                        if (ResarfManths > 15)
                            ResarfManths = 15;
                        Resarfrecord.eshtrakmonth = 0;
                        Resarfrecord.estktaa = ResarfRow.reestktaa;
                        Resarfrecord.PersonId = ResarfRow.PersonId;
                        Resarfrecord.SyndicateId = Convert.ToInt32(ResarfRow["SyndicateId"]);
                        Resarfrecord.SubCommitteId = Convert.ToInt32(ResarfRow["SubCommitteId"]);

                        Getmonymonth(row1, ref Resarfrecord, ResarfManths);
                        Getrasmmonth(row1, ref Resarfrecord, Rasm, ResarfManths);

                        Resarfrecord.sarf = true;
                        Resarfrecord.Edafat = true;

                        Resarfrecord.sarfdatefrom = ResarfRow.datefrom;
                        Resarfrecord.sarfdateto = ResarfRow.dateto;
                        Resarfrecord.datein = serverdatetime;
                        Resarfrecord.userin = Program.UserInfo.UserId;
                        Resarfrecord.SarfTypeedadId = (int)Misc.Types.SarfTypeedadId.Unknown_2;

                        //if (Resarfrecord.IsNull("monymonth"))
                        //{
                        //    string x;
                        //}
                        if (dsRetirementCenter.TBLWarasaSarf.FindBySarfTypeedadIdPersonIdDofatSarfId(Resarfrecord.SarfTypeedadId, Resarfrecord.PersonId, Resarfrecord.DofatSarfId) == null)
                            dsRetirementCenter.TBLWarasaSarf.AddTBLWarasaSarfRow(Resarfrecord);
                        //debug_steps++; Console.WriteLine(debug_steps);
                        //if (debug_steps == 332)
                        //{ string x = ""; }
                    }

                    pbc.EditValue = (int)pbc.EditValue + 1;
                    lblValue.Text = pbc.EditValue.ToString();
                    Application.DoEvents();
                }

                //Add Dofaa
                foreach (DataSources.dsQueries.WarasaDofaatCreatorRow row2 in dsQueries.WarasaDofaatCreator.Rows)
                {

                    DataSources.dsRetirementCenter.TBLWarasaSarfRow record = dsRetirementCenter.TBLWarasaSarf.NewTBLWarasaSarfRow();
                    record.DofatSarfId = dofaa2.DofatSarfId;
                    int months = TotalMonths(dofaa2.DofatSarfDateto, dofaa2.DofatSarfDatefrom);

                    if (months > 15)
                        months = 15;
                    record.eshtrakmonth = 0;
                    record.estktaa = 0;
                    record.PersonId = row2.PersonId;
                    record.personName = row2.personName;
                    record.MMashatName = row2.MMashatName;
                    record.WarasaTypeId = row2.WarasaTypeId;
                    record.SyndicateIdMashat = row2.SyndicateIdMashat;
                    record.SubCommitteIdMashat = row2.SubCommitteIdMashat;
                    record.SyndicateId = row2.SyndicateId;
                    record.SubCommitteId = row2.SubCommitteId;
                    record.sarfnumber = row2.sarfnumber;
                    if (row2.wcompletesarf)
                    {
                        Getmonymonth(row2, ref record, months);
                        Getrasmmonth(row2, ref record, Rasm, months);
                    }
                    else
                    {
                        record.monymonth = row2.wmony;
                        record.rsmmonth = row2.welrasm;
                        record.estktaa = row2.westktaat;
                    }

                    record.sarf = true;
                    record.Edafat = false;
                    record.sarfdatefrom = dofaa2.DofatSarfDatefrom;
                    record.sarfdateto = dofaa2.DofatSarfDateto;
                    record.datein = serverdatetime;
                    record.userin = Program.UserInfo.UserId;
                    record.SarfTypeedadId = (int)Misc.Types.SarfTypeedadId.Unknown_1;
                    if (dsRetirementCenter.TBLWarasaSarf.FindBySarfTypeedadIdPersonIdDofatSarfId(record.SarfTypeedadId, record.PersonId, record.DofatSarfId) == null)
                        dsRetirementCenter.TBLWarasaSarf.AddTBLWarasaSarfRow(record);
                    //debug_steps++; Console.WriteLine(debug_steps);
                    //if (debug_steps == 333)
                    //{ string x = ""; }
                    
                    //Add Resarf
                    adpSarf.FillByPersonId_DofatSarfId_Arc(dsRetirementCenter.TBLReSarfWarasa, row2.PersonId, dofaa2.DofatSarfId);
                    foreach (DataSources.dsRetirementCenter.TBLReSarfWarasaRow ResarfRow in dsRetirementCenter.TBLReSarfWarasa)
                    {
                        DataSources.dsRetirementCenter.TBLWarasaSarfRow Resarfrecord = dsRetirementCenter.TBLWarasaSarf.NewTBLWarasaSarfRow();
                        Resarfrecord.DofatSarfId = dofaa2.DofatSarfId;
                        int ResarfManths = TotalMonths(ResarfRow.dateto, ResarfRow.datefrom);
                        if (ResarfManths > 15)
                            ResarfManths = 15;
                        Resarfrecord.eshtrakmonth = 0;
                        Resarfrecord.estktaa = ResarfRow.reestktaa;
                        Resarfrecord.PersonId = ResarfRow.PersonId;
                        Resarfrecord.SyndicateId = row2.SyndicateId;
                        Resarfrecord.SubCommitteId = row2.SubCommitteId;

                        Getmonymonth(row2, ref Resarfrecord, ResarfManths);
                        Getrasmmonth(row2, ref Resarfrecord, Rasm, ResarfManths);

                        Resarfrecord.sarf = true;
                        Resarfrecord.Edafat = true;

                        Resarfrecord.sarfdatefrom = ResarfRow.datefrom;
                        Resarfrecord.sarfdateto = ResarfRow.dateto;
                        Resarfrecord.datein = serverdatetime;
                        Resarfrecord.userin = Program.UserInfo.UserId;
                        Resarfrecord.SarfTypeedadId = (int)Misc.Types.SarfTypeedadId.Unknown_2;
                        if (dsRetirementCenter.TBLWarasaSarf.FindBySarfTypeedadIdPersonIdDofatSarfId(Resarfrecord.SarfTypeedadId, Resarfrecord.PersonId, Resarfrecord.DofatSarfId) == null)
                            dsRetirementCenter.TBLWarasaSarf.AddTBLWarasaSarfRow(Resarfrecord);
                        //debug_steps++; Console.WriteLine(debug_steps);
                        //if (debug_steps == 332)
                        //{ string x = ""; }
                    }

                    pbc.EditValue = (int)pbc.EditValue + 1;
                    lblValue.Text = pbc.EditValue.ToString();
                    Application.DoEvents();
                }
                SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
                tBLWarasaSarfTableAdapter.Update(dsRetirementCenter.TBLWarasaSarf);
                new DataSources.dsRetirementCenterTableAdapters.TBLWarasaMaduneaTableAdapter().UpdateTBLWarasaSarf(dofaa2.DofatSarfId);
                new DataSources.dsRetirementCenterTableAdapters.TBLFrookWarasaTableAdapter().InsertIntoTBLWarasaSarf2(Program.UserInfo.UserId, dofaa2.DofatSarfId, deDateIn.DateTime.Date);
                tBLWarasaSarfTableAdapter.FillByDofatSarfId_DateIn(dsRetirementCenter.TBLWarasaSarf, dofaa2.DofatSarfId, deDateIn.DateTime.Date);
                SplashScreenManager.CloseForm();

                pbc.EditValue = 0; pcProgress.Visible = false; lblValue.Text = "0"; gcCommands.Enabled = true;
                LoadTBLWarasaSarfArc();
                Program.ShowMsg("تم الاعـــــداد", false, this, true);
            }
            catch (SqlException ex)
            {
                Program.ShowMsg(FXFW.SqlDB.CheckExp(ex), true, this, true);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, null, ex, this);
            }
        }
        private void repositoryItemButtonEditSave_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (!Program.UserInfo.IsAdmin)
            {
                Program.ShowMsg("غير مسموح بالتعديل ...", true, this, true);
                return;
            }
            DataSources.dsRetirementCenter.TBLWarasaSarfRow row =
               (DataSources.dsRetirementCenter.TBLWarasaSarfRow)((DataRowView)gridViewData.GetRow(gridViewData.FocusedRowHandle)).Row;
            try
            {
                row.datein = SQLProvider.ServerDateTime();
                row.userin = Program.UserInfo.UserId;

                tBLWarasaSarfBindingSource.EndEdit();
                tBLWarasaSarfTableAdapter.Update(row);

                Program.ShowMsg("تم التعديل", false, this, true);
                Program.Logger.LogThis("تم التعديل", Text, FXFW.Logger.OpType.success, null, null, this);
            }
            catch (SqlException ex)
            {
                Program.ShowMsg(FXFW.SqlDB.CheckExp(ex), true, this, true);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, null, ex, this);
            }
        }
        private void repositoryItemButtonEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (!Program.UserInfo.IsAdmin)
            {
                Program.ShowMsg("غير مسموح بالتعديل ...", true, this, true);
                return;
            }
            if (msgDlg.Show("هل انت متأكد؟", msgDlg.msgButtons.YesNo) == System.Windows.Forms.DialogResult.No)
                return;
            GridView GV = (GridView)gridControlData.MainView;
            DataSources.dsRetirementCenter.TBLWarasaSarfRow row =
               (DataSources.dsRetirementCenter.TBLWarasaSarfRow)((DataRowView)gridViewData.GetRow(gridViewData.FocusedRowHandle)).Row;
            try
            {

                tBLWarasaSarfTableAdapter.DeleteQuery(row.PersonId, row.DofatSarfId, row.SarfTypeedadId);
                dsRetirementCenter.TBLMemberSarf.AcceptChanges();
                GV.DeleteRow(GV.FocusedRowHandle);
                Program.ShowMsg("تم الحذف", false, this);
                Program.Logger.LogThis("تم الحذف", Text, FXFW.Logger.OpType.success, null, null, this);
            }
            catch (SqlException ex)
            {
                Program.ShowMsg(FXFW.SqlDB.CheckExp(ex), true, this, true);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, null, ex, this);
            }
        }
        private void btnArc_Click(object sender, EventArgs e)
        {
            if (msgDlg.Show("هل انت متأكد؟", msgDlg.msgButtons.YesNo) == System.Windows.Forms.DialogResult.No)
                return;
            int effected = 0;
            try
            {
                effected = tBLWarasaSarfTableAdapter.InsertIntoTBLWarasaSarf_arshef2(Convert.ToInt32(LUETBLDofatSarf2.EditValue));

            }
            catch (SqlException ex)
            {
                Program.ShowMsg(FXFW.SqlDB.CheckExp(ex), true, this, true);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, null, ex, this);
            }
            Program.ShowMsg("تم الاضافة للارشيف" + Environment.NewLine + effected, false, this, true);
        }
        #endregion

    }
}
