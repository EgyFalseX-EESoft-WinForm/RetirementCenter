
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using DevExpress.XtraGrid.Views.Grid;

namespace RetirementCenter
{
    public partial class TBLDeathMembersFrm : XtraForm
    {
        bool _Insert, _Update, _Delete;
        DataSources.Linq.dsTeachersUnionViewsDataContext dsLinq = new DataSources.Linq.dsTeachersUnionViewsDataContext();
        
        #region -   Functions   -
        public TBLDeathMembersFrm()
        {
            InitializeComponent();
            XPSCSData.Session.ConnectionString = Properties.Settings.Default.RetirementCenterConnectionString;
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
                    btnNew_Click(btnNew, new EventArgs());
                    break;
                case Keys.F6:
                    //repositoryItemButtonEditSave_ButtonClick(repositoryItemButtonEditSave, new DevExpress.XtraEditors.Controls.ButtonPressedEventArgs(new DevExpress.XtraEditors.Controls.EditorButton()));
                    break;
                case Keys.F8:
                    repositoryItemButtonEditDel_ButtonClick(repositoryItemButtonEditDel, new DevExpress.XtraEditors.Controls.ButtonPressedEventArgs(new DevExpress.XtraEditors.Controls.EditorButton()));
                    break;
                case Keys.F10:
                    //repositoryItemButtonEditSave_ButtonClick(repositoryItemButtonEditSave, new DevExpress.XtraEditors.Controls.ButtonPressedEventArgs(new DevExpress.XtraEditors.Controls.EditorButton()));
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

            btnNew.Visible = Inserting;
            repositoryItemButtonEditDel.Buttons[0].Visible = Deleting;

            _Insert = Inserting; _Update = Updateing; _Delete = Deleting;
        }
        private void ResetGridCash()
        {
            XPSCSData.Session.DropChanges();
            XPSCSData.Session.DropIdentityMap();
            XPSCSData.Reload();
            gridViewData.RefreshData(); 
        }
        #endregion
        #region - Event Handlers -
        private void FormFrm_Load(object sender, EventArgs e)
        {
            ActivePriv();
        }
        
        private void btnNew_Click(object sender, EventArgs e)
        {
            DataSources.dsRetirementCenter ds = new DataSources.dsRetirementCenter();
            DataSources.dsRetirementCenter.TBLDeathMembersRow row = ds.TBLDeathMembers.NewTBLDeathMembersRow();
            row.MMashatId = -1; row.mosthhek = string.Empty; row.sefa = "وريث"; row.mosthhekmony = 1000;
            //row.deathdate = SQLProvider.ServerDateTime();
            

            TBLDeathMembersWFrm frm = new TBLDeathMembersWFrm(row, _Insert, _Update, _Delete);
            if (frm.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                return;
            ds.TBLDeathMembers.AddTBLDeathMembersRow(row);
            int effected = tblDeathMembersTableAdapter.Update(ds.TBLDeathMembers);
            ResetGridCash();
            btnNew_Click(btnNew, EventArgs.Empty);
        }
        private void repositoryItemButtonEditUpdate_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            GridView GV = (GridView)gridControlData.MainView;
            DevExpress.Xpo.Metadata.XPDataTableObject row = (DevExpress.Xpo.Metadata.XPDataTableObject)GV.GetRow(GV.FocusedRowHandle);
            try
            {
                int MMashatId = (int)row.GetMemberValue("MMashatId");
                DataSources.dsRetirementCenter ds = new DataSources.dsRetirementCenter();
                tblDeathMembersTableAdapter.FillByMMashatId(ds.TBLDeathMembers, MMashatId);
                TBLDeathMembersWFrm frm = new TBLDeathMembersWFrm(ds.TBLDeathMembers[0], _Insert, _Update, _Delete);
                if (frm.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                    return;
                ds.TBLDeathMembers[0].EndEdit();
                tblDeathMembersTableAdapter.Update(ds.TBLDeathMembers);
                ResetGridCash();
                Program.ShowMsg("تم التعديل", false, this);
                Program.Logger.LogThis("تم التعديل", Text, FXFW.Logger.OpType.success, null, null, this);
            }
            catch (Exception ex)
            {
                Program.ShowMsg(Misc.Misc.ExceptionMessage(ex), true, this);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, ex, null, this);
            }
        }
        private void repositoryItemButtonEditDel_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            GridView GV = (GridView)gridControlData.MainView;
            DevExpress.Xpo.Metadata.XPDataTableObject row = (DevExpress.Xpo.Metadata.XPDataTableObject)GV.GetRow(GV.FocusedRowHandle);
            if (MessageBox.Show("هل انت متأكد؟", "تحزير ...", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
                return;
            try
            {
                int MMashatId = (int)row.GetMemberValue("MMashatId");
                if (tblDeathMembersTableAdapter.Delete(MMashatId) > 0)
                {
                    gridViewData.DeleteRow(GV.FocusedRowHandle);
                    ResetGridCash();
                    Program.ShowMsg("تم الحذف", false, this);
                    Program.Logger.LogThis("تم الحذف", Text, FXFW.Logger.OpType.success, null, null, this);
                }
                else
                {
                    Program.ShowMsg("لم يتم الحذف", true, this);
                    Program.Logger.LogThis("لم يتم الحذف", Text, FXFW.Logger.OpType.fail, null, null, this);
                }
                
            }
            catch (Exception ex)
            {
                Program.ShowMsg(Misc.Misc.ExceptionMessage(ex), true, this);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, ex, null, this);
            }
        }
        #endregion

    }
}