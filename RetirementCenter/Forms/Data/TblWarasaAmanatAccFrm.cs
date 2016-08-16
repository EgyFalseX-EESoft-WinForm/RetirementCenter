
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using DevExpress.XtraGrid.Views.Grid;

namespace RetirementCenter
{
    public partial class TblWarasaAmanatAccFrm : XtraForm
    {
        bool _Insert, _Update, _Delete;
        DataSources.Linq.dsTeachersUnionViewsDataContext dsLinq = new DataSources.Linq.dsTeachersUnionViewsDataContext();
        
        #region -   Functions   -
        public TblWarasaAmanatAccFrm()
        {
            InitializeComponent();
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
            LSMSTBLWarasa.QueryableSource = dsLinq.vTBLWarasa_TBLMashats;
            // TODO: This line of code loads data into the 'dsRetirementCenter.CdDofaatAmanat' table. You can move, or remove it, as needed.
            this.cdDofaatAmanatTableAdapter.Fill(this.dsRetirementCenter.CdDofaatAmanat);
            // TODO: This line of code loads data into the 'dsRetirementCenter.TblWarasaAmanat' table. You can move, or remove it, as needed.
            this.tblWarasaAmanatTableAdapter.FillByMoreInfo(this.dsRetirementCenter.TblWarasaAmanat);
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
            DataSources.dsRetirementCenter.TblWarasaAmanatRow row = (DataSources.dsRetirementCenter.TblWarasaAmanatRow)GV.GetFocusedDataRow();
            row.useracc = Program.UserInfo.UserId;
            row.EndEdit();
            if (row["cheekno", DataRowVersion.Original] != row["cheekno", DataRowVersion.Current])
            {
                if (!row.IstasleemdateNull())
                {
                    msgDlg.Show("لا يمكن تعديل رقم الشيك لهذا الحقل ذلك للاعتبارات التالية" + Environment.NewLine + "تم التسليم", msgDlg.msgButtons.Close);
                    return;
                }
                row.userincheek = Program.UserInfo.UserId;
                row.datincheek = SQLProvider.ServerDateTime();
            }
            string orgAccCheck = row["accReview", DataRowVersion.Original] == null ? string.Empty : row["accReview", DataRowVersion.Original].ToString();
            string curAccCheck = row["accReview", DataRowVersion.Current] == null ? string.Empty : row["accReview", DataRowVersion.Current].ToString();
            if (orgAccCheck != curAccCheck)
            {
                row.useracc = Program.UserInfo.UserId;
                row.dateReview = SQLProvider.ServerDateTime();
            }
            row.EndEdit();
            tblWarasaAmanatTableAdapter.Update(row);
            //ReActive any Person with same visa as current Person
            if (row.accReview)
            {
                int result1 = new DataSources.dsQueriesTableAdapters.QueriesTableAdapter().Update_TblWarasa_Active_byVisa(row.PersonId);
                int result2 = new DataSources.dsRetirementCenterTableAdapters.tblvisawarsaactiveTableAdapter().InsertForVisaByPerson("تم تقديم طلب امانات", Program.UserInfo.UserId, row.PersonId);
            }
            msgDlg.Show("تم حفظ التعديل", msgDlg.msgButtons.Close);
            
        }
        private void gridViewData_ShowingEditor(object sender, System.ComponentModel.CancelEventArgs e)
        {
            GridView view = sender as GridView;
            DataSources.dsRetirementCenter.TblWarasaAmanatRow row = (DataSources.dsRetirementCenter.TblWarasaAmanatRow)view.GetFocusedDataRow();
            if (row == null)
                return;

            if (view.FocusedColumn.FieldName == "cheekno" && !row.sarfcheek)
                e.Cancel = true;
        }
        #endregion

        

    }
}