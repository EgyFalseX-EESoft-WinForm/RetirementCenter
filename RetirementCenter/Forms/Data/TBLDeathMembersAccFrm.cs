using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using DevExpress.XtraGrid.Views.Grid;

namespace RetirementCenter
{
    public partial class TBLDeathMembersAccFrm : XtraForm
    {
        bool _Insert, _Update, _Delete;
        DataSources.Linq.dsTeachersUnionViewsDataContext dsLinq = new DataSources.Linq.dsTeachersUnionViewsDataContext();
        
        #region -   Functions   -
        public TBLDeathMembersAccFrm()
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
                    //btnNew_Click(btnNew, new EventArgs());
                    break;
                case Keys.F6:
                    //repositoryItemButtonEditSave_ButtonClick(repositoryItemButtonEditSave, new DevExpress.XtraEditors.Controls.ButtonPressedEventArgs(new DevExpress.XtraEditors.Controls.EditorButton()));
                    break;
                case Keys.F8:
                    //repositoryItemButtonEditDel_ButtonClick(repositoryItemButtonEditDel, new DevExpress.XtraEditors.Controls.ButtonPressedEventArgs(new DevExpress.XtraEditors.Controls.EditorButton()));
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

            //btnNew.Visible = Inserting;
            //repositoryItemButtonEditDel.Buttons[0].Visible = Deleting;

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
        private void repositoryItemButtonEditUpdate_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            GridView GV = (GridView)gridControlData.MainView;
            DevExpress.Xpo.Metadata.XPDataTableObject row = (DevExpress.Xpo.Metadata.XPDataTableObject)GV.GetRow(GV.FocusedRowHandle);
            lbc.Items.Add(row.GetMemberValue("MMashatId"));
            MessageBox.Show("تم الاضافة في قائمة التعديلات", "رسالة", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            lbc.Items.Clear();
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lbc.Items.Count == 0)
                return;
            try
            {
                List<int> lst = new List<int>();
                foreach (object item in lbc.Items)
                    lst.Add(Convert.ToInt32(item));

                TBLDeathMembersAccWFrm frm = new TBLDeathMembersAccWFrm(lst, _Insert, _Update, _Delete);
                if (frm.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                    return;
                ResetGridCash();
                Program.ShowMsg("تم التعديل", false, this);
                Program.Logger.LogThis("تم التعديل", Text, FXFW.Logger.OpType.success, null, null, this);
                lbc.Items.Clear();
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