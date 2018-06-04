namespace RetirementCenter.Forms.Data
{
    partial class BankExportedDataWarsaActivateFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule3 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            this.gridControlData = new DevExpress.XtraGrid.GridControl();
            this.LSMS = new DevExpress.Data.Linq.LinqServerModeSource();
            this.gridViewData = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMMashatId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExportDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEditDMY = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colvisa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvisawarddate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colhafza = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colhafzadate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltrteep = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colActivate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colActivateDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRealName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMMashatName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSyndicate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubCommitte = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEditTransferSave = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colMMashatName1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsarfnumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnewid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coluserin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdituserin = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.LSMSUser = new DevExpress.Data.Linq.LinqServerModeSource();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btnActive = new DevExpress.XtraEditors.SimpleButton();
            this.tbHafza = new DevExpress.XtraEditors.TextEdit();
            this.lueSub = new DevExpress.XtraEditors.LookUpEdit();
            this.LSMSSub = new DevExpress.Data.Linq.LinqServerModeSource();
            this.lueSyn = new DevExpress.XtraEditors.LookUpEdit();
            this.LSMSSn = new DevExpress.Data.Linq.LinqServerModeSource();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.dxvp = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider();
            this.colActivateMobileUser = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDMY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDMY.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditTransferSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdituserin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbHafza.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueSub.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSSub)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueSyn.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSSn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxvp)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlData
            // 
            this.gridControlData.DataSource = this.LSMS;
            this.gridControlData.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gridControlData.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControlData.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControlData.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControlData.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gridControlData.Location = new System.Drawing.Point(12, 110);
            this.gridControlData.MainView = this.gridViewData;
            this.gridControlData.Name = "gridControlData";
            this.gridControlData.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEditTransferSave,
            this.repositoryItemDateEditDMY,
            this.repositoryItemLookUpEdituserin});
            this.gridControlData.Size = new System.Drawing.Size(927, 277);
            this.gridControlData.TabIndex = 0;
            this.gridControlData.UseEmbeddedNavigator = true;
            this.gridControlData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewData});
            // 
            // LSMS
            // 
            this.LSMS.ElementType = typeof(RetirementCenter.DataSources.Linq.vBankExportedDataWarsa_Activate);
            this.LSMS.KeyExpression = "[PersonId]";
            // 
            // gridViewData
            // 
            this.gridViewData.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMMashatId,
            this.colExportDate,
            this.colvisa,
            this.colvisawarddate,
            this.colhafza,
            this.colhafzadate,
            this.coltrteep,
            this.colActivate,
            this.colActivateDate,
            this.colRealName,
            this.colMMashatName,
            this.colSyndicate,
            this.colSubCommitte,
            this.gridColumn1,
            this.colMMashatName1,
            this.colsarfnumber,
            this.colnewid,
            this.coluserin,
            this.colActivateMobileUser});
            this.gridViewData.GridControl = this.gridControlData;
            this.gridViewData.Name = "gridViewData";
            this.gridViewData.NewItemRowText = "اضغط لاضافة جديد";
            this.gridViewData.OptionsView.ColumnAutoWidth = false;
            this.gridViewData.OptionsView.ShowAutoFilterRow = true;
            this.gridViewData.OptionsView.ShowDetailButtons = false;
            this.gridViewData.OptionsView.ShowGroupPanel = false;
            // 
            // colMMashatId
            // 
            this.colMMashatId.AppearanceCell.Options.UseTextOptions = true;
            this.colMMashatId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMMashatId.AppearanceHeader.Options.UseTextOptions = true;
            this.colMMashatId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMMashatId.Caption = "كود";
            this.colMMashatId.FieldName = "PersonId";
            this.colMMashatId.Name = "colMMashatId";
            // 
            // colExportDate
            // 
            this.colExportDate.AppearanceCell.Options.UseTextOptions = true;
            this.colExportDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colExportDate.AppearanceHeader.Options.UseTextOptions = true;
            this.colExportDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colExportDate.ColumnEdit = this.repositoryItemDateEditDMY;
            this.colExportDate.FieldName = "ExportDate";
            this.colExportDate.Name = "colExportDate";
            this.colExportDate.Width = 77;
            // 
            // repositoryItemDateEditDMY
            // 
            this.repositoryItemDateEditDMY.AutoHeight = false;
            this.repositoryItemDateEditDMY.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEditDMY.DisplayFormat.FormatString = "d/M/yyyy";
            this.repositoryItemDateEditDMY.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEditDMY.EditFormat.FormatString = "d/M/yyyy";
            this.repositoryItemDateEditDMY.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEditDMY.Mask.EditMask = "d/M/yyyy";
            this.repositoryItemDateEditDMY.Name = "repositoryItemDateEditDMY";
            this.repositoryItemDateEditDMY.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            // 
            // colvisa
            // 
            this.colvisa.AppearanceCell.Options.UseTextOptions = true;
            this.colvisa.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colvisa.AppearanceHeader.Options.UseTextOptions = true;
            this.colvisa.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colvisa.Caption = "فيزا";
            this.colvisa.FieldName = "visa";
            this.colvisa.Name = "colvisa";
            this.colvisa.Visible = true;
            this.colvisa.VisibleIndex = 8;
            // 
            // colvisawarddate
            // 
            this.colvisawarddate.AppearanceCell.Options.UseTextOptions = true;
            this.colvisawarddate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colvisawarddate.AppearanceHeader.Options.UseTextOptions = true;
            this.colvisawarddate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colvisawarddate.Caption = "تاريخ توريد الفيزا";
            this.colvisawarddate.ColumnEdit = this.repositoryItemDateEditDMY;
            this.colvisawarddate.FieldName = "visawarddate";
            this.colvisawarddate.Name = "colvisawarddate";
            this.colvisawarddate.Width = 113;
            // 
            // colhafza
            // 
            this.colhafza.AppearanceCell.Options.UseTextOptions = true;
            this.colhafza.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colhafza.AppearanceHeader.Options.UseTextOptions = true;
            this.colhafza.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colhafza.Caption = "الحافظة";
            this.colhafza.FieldName = "hafza";
            this.colhafza.Name = "colhafza";
            this.colhafza.Visible = true;
            this.colhafza.VisibleIndex = 2;
            // 
            // colhafzadate
            // 
            this.colhafzadate.AppearanceCell.Options.UseTextOptions = true;
            this.colhafzadate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colhafzadate.AppearanceHeader.Options.UseTextOptions = true;
            this.colhafzadate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colhafzadate.Caption = "تاريخ الحافظة";
            this.colhafzadate.ColumnEdit = this.repositoryItemDateEditDMY;
            this.colhafzadate.FieldName = "hafzadate";
            this.colhafzadate.Name = "colhafzadate";
            this.colhafzadate.Visible = true;
            this.colhafzadate.VisibleIndex = 1;
            this.colhafzadate.Width = 78;
            // 
            // coltrteep
            // 
            this.coltrteep.AppearanceCell.Options.UseTextOptions = true;
            this.coltrteep.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coltrteep.AppearanceHeader.Options.UseTextOptions = true;
            this.coltrteep.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coltrteep.Caption = "ترتيب";
            this.coltrteep.FieldName = "trteep";
            this.coltrteep.Name = "coltrteep";
            this.coltrteep.Visible = true;
            this.coltrteep.VisibleIndex = 11;
            // 
            // colActivate
            // 
            this.colActivate.AppearanceCell.Options.UseTextOptions = true;
            this.colActivate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colActivate.AppearanceHeader.Options.UseTextOptions = true;
            this.colActivate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colActivate.Caption = "تم التفعيل";
            this.colActivate.FieldName = "Activate";
            this.colActivate.Name = "colActivate";
            this.colActivate.Visible = true;
            this.colActivate.VisibleIndex = 12;
            // 
            // colActivateDate
            // 
            this.colActivateDate.AppearanceCell.Options.UseTextOptions = true;
            this.colActivateDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colActivateDate.AppearanceHeader.Options.UseTextOptions = true;
            this.colActivateDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colActivateDate.Caption = "تاريخ التفعيل";
            this.colActivateDate.ColumnEdit = this.repositoryItemDateEditDMY;
            this.colActivateDate.FieldName = "ActivateDate";
            this.colActivateDate.Name = "colActivateDate";
            this.colActivateDate.Visible = true;
            this.colActivateDate.VisibleIndex = 0;
            this.colActivateDate.Width = 77;
            // 
            // colRealName
            // 
            this.colRealName.AppearanceCell.Options.UseTextOptions = true;
            this.colRealName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRealName.AppearanceHeader.Options.UseTextOptions = true;
            this.colRealName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRealName.Caption = "مدخل البيان";
            this.colRealName.FieldName = "RealName";
            this.colRealName.Name = "colRealName";
            this.colRealName.Visible = true;
            this.colRealName.VisibleIndex = 3;
            // 
            // colMMashatName
            // 
            this.colMMashatName.AppearanceCell.Options.UseTextOptions = true;
            this.colMMashatName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMMashatName.AppearanceHeader.Options.UseTextOptions = true;
            this.colMMashatName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMMashatName.Caption = "الاسم";
            this.colMMashatName.FieldName = "personName";
            this.colMMashatName.Name = "colMMashatName";
            this.colMMashatName.Visible = true;
            this.colMMashatName.VisibleIndex = 6;
            // 
            // colSyndicate
            // 
            this.colSyndicate.AppearanceCell.Options.UseTextOptions = true;
            this.colSyndicate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSyndicate.AppearanceHeader.Options.UseTextOptions = true;
            this.colSyndicate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSyndicate.Caption = "الفرعية";
            this.colSyndicate.FieldName = "Syndicate";
            this.colSyndicate.Name = "colSyndicate";
            this.colSyndicate.Visible = true;
            this.colSyndicate.VisibleIndex = 5;
            // 
            // colSubCommitte
            // 
            this.colSubCommitte.AppearanceCell.Options.UseTextOptions = true;
            this.colSubCommitte.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSubCommitte.AppearanceHeader.Options.UseTextOptions = true;
            this.colSubCommitte.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSubCommitte.Caption = "اللجنة";
            this.colSubCommitte.FieldName = "SubCommitte";
            this.colSubCommitte.Name = "colSubCommitte";
            this.colSubCommitte.Visible = true;
            this.colSubCommitte.VisibleIndex = 4;
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.Caption = "تعديل";
            this.gridColumn1.ColumnEdit = this.repositoryItemButtonEditTransferSave;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 13;
            // 
            // repositoryItemButtonEditTransferSave
            // 
            this.repositoryItemButtonEditTransferSave.AutoHeight = false;
            this.repositoryItemButtonEditTransferSave.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.OK)});
            this.repositoryItemButtonEditTransferSave.Name = "repositoryItemButtonEditTransferSave";
            this.repositoryItemButtonEditTransferSave.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemButtonEditTransferSave.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositoryItemButtonEditTransferSave_ButtonClick);
            // 
            // colMMashatName1
            // 
            this.colMMashatName1.AppearanceCell.Options.UseTextOptions = true;
            this.colMMashatName1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMMashatName1.AppearanceHeader.Options.UseTextOptions = true;
            this.colMMashatName1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMMashatName1.Caption = "اسم الاب";
            this.colMMashatName1.FieldName = "MMashatName";
            this.colMMashatName1.Name = "colMMashatName1";
            this.colMMashatName1.Visible = true;
            this.colMMashatName1.VisibleIndex = 10;
            // 
            // colsarfnumber
            // 
            this.colsarfnumber.AppearanceCell.Options.UseTextOptions = true;
            this.colsarfnumber.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colsarfnumber.AppearanceHeader.Options.UseTextOptions = true;
            this.colsarfnumber.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colsarfnumber.Caption = "رقم الصرف";
            this.colsarfnumber.FieldName = "sarfnumber";
            this.colsarfnumber.Name = "colsarfnumber";
            this.colsarfnumber.Visible = true;
            this.colsarfnumber.VisibleIndex = 9;
            // 
            // colnewid
            // 
            this.colnewid.AppearanceCell.Options.UseTextOptions = true;
            this.colnewid.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colnewid.AppearanceHeader.Options.UseTextOptions = true;
            this.colnewid.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colnewid.Caption = "كود60";
            this.colnewid.FieldName = "newid";
            this.colnewid.Name = "colnewid";
            this.colnewid.Visible = true;
            this.colnewid.VisibleIndex = 7;
            // 
            // coluserin
            // 
            this.coluserin.AppearanceCell.Options.UseTextOptions = true;
            this.coluserin.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coluserin.AppearanceHeader.Options.UseTextOptions = true;
            this.coluserin.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coluserin.Caption = "مسئول الادخال";
            this.coluserin.ColumnEdit = this.repositoryItemLookUpEdituserin;
            this.coluserin.FieldName = "userin";
            this.coluserin.Name = "coluserin";
            this.coluserin.OptionsColumn.ReadOnly = true;
            this.coluserin.Visible = true;
            this.coluserin.VisibleIndex = 14;
            this.coluserin.Width = 102;
            // 
            // repositoryItemLookUpEdituserin
            // 
            this.repositoryItemLookUpEdituserin.AutoHeight = false;
            this.repositoryItemLookUpEdituserin.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdituserin.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("RealName", "الاسم", 61, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.repositoryItemLookUpEdituserin.DataSource = this.LSMSUser;
            this.repositoryItemLookUpEdituserin.DisplayMember = "RealName";
            this.repositoryItemLookUpEdituserin.Name = "repositoryItemLookUpEdituserin";
            this.repositoryItemLookUpEdituserin.NullText = "";
            this.repositoryItemLookUpEdituserin.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemLookUpEdituserin.ValueMember = "UserID";
            // 
            // LSMSUser
            // 
            this.LSMSUser.ElementType = typeof(RetirementCenter.DataSources.Linq.User);
            this.LSMSUser.KeyExpression = "[UserID]";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnActive);
            this.layoutControl1.Controls.Add(this.tbHafza);
            this.layoutControl1.Controls.Add(this.lueSub);
            this.layoutControl1.Controls.Add(this.lueSyn);
            this.layoutControl1.Controls.Add(this.gridControlData);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(969, 201, 250, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(951, 399);
            this.layoutControl1.TabIndex = 3;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnActive
            // 
            this.btnActive.Location = new System.Drawing.Point(640, 84);
            this.btnActive.Name = "btnActive";
            this.btnActive.Size = new System.Drawing.Size(299, 22);
            this.btnActive.StyleController = this.layoutControl1;
            this.btnActive.TabIndex = 7;
            this.btnActive.Text = "تفعيل";
            this.btnActive.Click += new System.EventHandler(this.btnActive_Click);
            // 
            // tbHafza
            // 
            this.tbHafza.Location = new System.Drawing.Point(640, 60);
            this.tbHafza.Name = "tbHafza";
            this.tbHafza.Size = new System.Drawing.Size(241, 20);
            this.tbHafza.StyleController = this.layoutControl1;
            this.tbHafza.TabIndex = 6;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "This value is not valid";
            this.dxvp.SetValidationRule(this.tbHafza, conditionValidationRule1);
            // 
            // lueSub
            // 
            this.lueSub.Location = new System.Drawing.Point(640, 36);
            this.lueSub.Name = "lueSub";
            this.lueSub.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueSub.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SubCommitte", "الاسم", 76, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.lueSub.Properties.DataSource = this.LSMSSub;
            this.lueSub.Properties.DisplayMember = "SubCommitte";
            this.lueSub.Properties.NullText = "";
            this.lueSub.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lueSub.Properties.ValueMember = "SubCommitteId";
            this.lueSub.Size = new System.Drawing.Size(241, 20);
            this.lueSub.StyleController = this.layoutControl1;
            this.lueSub.TabIndex = 5;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "This value is not valid";
            this.dxvp.SetValidationRule(this.lueSub, conditionValidationRule2);
            // 
            // LSMSSub
            // 
            this.LSMSSub.ElementType = typeof(RetirementCenter.DataSources.Linq.CDSubCommitte);
            this.LSMSSub.KeyExpression = "[SubCommitteId]";
            // 
            // lueSyn
            // 
            this.lueSyn.Location = new System.Drawing.Point(640, 12);
            this.lueSyn.Name = "lueSyn";
            this.lueSyn.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueSyn.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Syndicate", "الاسم", 57, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.lueSyn.Properties.DataSource = this.LSMSSn;
            this.lueSyn.Properties.DisplayMember = "Syndicate";
            this.lueSyn.Properties.NullText = "";
            this.lueSyn.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lueSyn.Properties.ValueMember = "SyndicateId";
            this.lueSyn.Size = new System.Drawing.Size(241, 20);
            this.lueSyn.StyleController = this.layoutControl1;
            this.lueSyn.TabIndex = 4;
            conditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule3.ErrorText = "This value is not valid";
            this.dxvp.SetValidationRule(this.lueSyn, conditionValidationRule3);
            this.lueSyn.EditValueChanged += new System.EventHandler(this.lueSyn_EditValueChanged);
            // 
            // LSMSSn
            // 
            this.LSMSSn.ElementType = typeof(RetirementCenter.DataSources.Linq.CDSyndicate);
            this.LSMSSn.KeyExpression = "[SyndicateId]";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "Root";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.emptySpaceItem1,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(951, 399);
            this.layoutControlGroup1.Text = "Root";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControlData;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 98);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(931, 281);
            this.layoutControlItem1.Text = "layoutControlItem1";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextToControlDistance = 0;
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem2.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.layoutControlItem2.Control = this.lueSyn;
            this.layoutControlItem2.CustomizationFormText = "الفرعية";
            this.layoutControlItem2.Location = new System.Drawing.Point(628, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(303, 24);
            this.layoutControlItem2.Text = "الفرعية";
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Right;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(55, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(628, 98);
            this.emptySpaceItem1.Text = "emptySpaceItem1";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem3.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.layoutControlItem3.Control = this.lueSub;
            this.layoutControlItem3.CustomizationFormText = "اللجنة";
            this.layoutControlItem3.Location = new System.Drawing.Point(628, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(303, 24);
            this.layoutControlItem3.Text = "اللجنة";
            this.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Right;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(55, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem4.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.layoutControlItem4.Control = this.tbHafza;
            this.layoutControlItem4.CustomizationFormText = "رقم الحافظة";
            this.layoutControlItem4.Location = new System.Drawing.Point(628, 48);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(303, 24);
            this.layoutControlItem4.Text = "رقم الحافظة";
            this.layoutControlItem4.TextLocation = DevExpress.Utils.Locations.Right;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(55, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.btnActive;
            this.layoutControlItem5.CustomizationFormText = "layoutControlItem5";
            this.layoutControlItem5.Location = new System.Drawing.Point(628, 72);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(303, 26);
            this.layoutControlItem5.Text = "layoutControlItem5";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextToControlDistance = 0;
            this.layoutControlItem5.TextVisible = false;
            // 
            // colActivateMobileUser
            // 
            this.colActivateMobileUser.AppearanceCell.Options.UseTextOptions = true;
            this.colActivateMobileUser.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colActivateMobileUser.AppearanceHeader.Options.UseTextOptions = true;
            this.colActivateMobileUser.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colActivateMobileUser.Caption = "مستخدم التفعيل للموبيل";
            this.colActivateMobileUser.FieldName = "ActivateMobileUser";
            this.colActivateMobileUser.Name = "colActivateMobileUser";
            this.colActivateMobileUser.Visible = true;
            this.colActivateMobileUser.VisibleIndex = 15;
            // 
            // BankExportedDataWarsaActivateFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 399);
            this.Controls.Add(this.layoutControl1);
            this.Name = "BankExportedDataWarsaActivateFrm";
            this.Text = "تفعيل فيزا الورثة";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BankExportedDataWarsaActivateFrm_FormClosing);
            this.Load += new System.EventHandler(this.DofatSarfActivityFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDMY.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDMY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditTransferSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdituserin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbHafza.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueSub.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSSub)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueSyn.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSSn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxvp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlData;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewData;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEditTransferSave;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEditDMY;
        private DevExpress.Data.Linq.LinqServerModeSource LSMS;
        private DevExpress.XtraGrid.Columns.GridColumn colMMashatId;
        private DevExpress.XtraGrid.Columns.GridColumn colExportDate;
        private DevExpress.XtraGrid.Columns.GridColumn colvisa;
        private DevExpress.XtraGrid.Columns.GridColumn colvisawarddate;
        private DevExpress.XtraGrid.Columns.GridColumn colhafza;
        private DevExpress.XtraGrid.Columns.GridColumn colhafzadate;
        private DevExpress.XtraGrid.Columns.GridColumn coltrteep;
        private DevExpress.XtraGrid.Columns.GridColumn colActivate;
        private DevExpress.XtraGrid.Columns.GridColumn colActivateDate;
        private DevExpress.XtraGrid.Columns.GridColumn colRealName;
        private DevExpress.XtraGrid.Columns.GridColumn colMMashatName;
        private DevExpress.XtraGrid.Columns.GridColumn colSyndicate;
        private DevExpress.XtraGrid.Columns.GridColumn colSubCommitte;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.SimpleButton btnActive;
        private DevExpress.XtraEditors.TextEdit tbHafza;
        private DevExpress.XtraEditors.LookUpEdit lueSub;
        private DevExpress.XtraEditors.LookUpEdit lueSyn;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.Data.Linq.LinqServerModeSource LSMSSn;
        private DevExpress.Data.Linq.LinqServerModeSource LSMSSub;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxvp;
        private DevExpress.XtraGrid.Columns.GridColumn colMMashatName1;
        private DevExpress.XtraGrid.Columns.GridColumn colsarfnumber;
        private DevExpress.XtraGrid.Columns.GridColumn colnewid;
        private DevExpress.Data.Linq.LinqServerModeSource LSMSUser;
        private DevExpress.XtraGrid.Columns.GridColumn coluserin;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdituserin;
        private DevExpress.XtraGrid.Columns.GridColumn colActivateMobileUser;
    }
}