﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace RetirementCenter.Forms.Data
{
    public partial class TBLFrookWarasaFrm : DevExpress.XtraEditors.XtraForm
    {
        DataSources.Linq.dsTeachersUnionViewsDataContext dsLinq = new DataSources.Linq.dsTeachersUnionViewsDataContext() { ObjectTrackingEnabled = false };

        public TBLFrookWarasaFrm()
        {
            InitializeComponent();
            LoadData();
        }
        private void ActivePriv()
        {
            //return;//ActivePrivReady
            bool Selecting = false, Inserting = false, Updateing = false, Deleting = false;
            SQLProvider.GetFormPriv(this.Name, ref Selecting, ref Inserting, ref  Updateing, ref  Deleting);

            btnAdd.Visible = Inserting;
            repositoryItemButtonEditDelete.Buttons[0].Visible = Deleting;
            repositoryItemButtonEditSave.Buttons[0].Visible =Updateing;
        }

        private void LoadData()
        {
            //XPSCSData.Session.ConnectionString = Properties.Settings.Default.RetirementCenterConnectionString;
            LSMSDATA.QueryableSource = dsLinq.vTBLFrookWarasas;
        }
        private void RefreshData()
        {
            LSMSDATA.Reload();
            gridViewData.RefreshData();
        }
        private void DofatSarfActivityFrm_Load(object sender, EventArgs e)
        {
        }
        private void repositoryItemButtonEditSave_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            RetirementCenter.DataSources.Linq.vTBLFrookWarasa row = (RetirementCenter.DataSources.Linq.vTBLFrookWarasa)gridViewData.GetRow(gridViewData.FocusedRowHandle);
            TBLFrookWarasaEditFrm frm = new TBLFrookWarasaEditFrm(row.frookaouto);
            frm.ShowDialog();
            RefreshData();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            TBLFrookWarasaAddFrm frm = new TBLFrookWarasaAddFrm();
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                RefreshData();
                btnAdd_Click(btnAdd, EventArgs.Empty);
            }
        }
        private void repositoryItemButtonEditDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (msgDlg.Show("هل انت متأكد؟", msgDlg.msgButtons.YesNo) == System.Windows.Forms.DialogResult.No)
                return;
            RetirementCenter.DataSources.Linq.vTBLFrookWarasa row = (RetirementCenter.DataSources.Linq.vTBLFrookWarasa)gridViewData.GetRow(gridViewData.FocusedRowHandle);
            adp.Delete(row.PersonId, row.DofatSarfId);
            Program.ShowMsg("تم الحذف", false, this, true);
            Program.Logger.LogThis("تم الحفظ", Text, FXFW.Logger.OpType.success, null, null, this);
            RefreshData();
        }

    }
}