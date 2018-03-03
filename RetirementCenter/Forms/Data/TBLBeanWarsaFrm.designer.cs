namespace RetirementCenter
{
    partial class TBLBeanWarsaFrm
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
            this.gridControlData = new DevExpress.XtraGrid.GridControl();
            this.XPSCSData = new DevExpress.Xpo.XPServerCollectionSource();
            this.UOWData = new DevExpress.Xpo.UnitOfWork();
            this.gridViewData = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDofatSarfAId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMMashatId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colamanatrem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoExEditremarks = new DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit();
            this.colBeandate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEditDMY = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.coldateremember = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldeleted = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldatein = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEditdatein = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.coluserin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEdituserin = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.usersBindingSource = new System.Windows.Forms.BindingSource();
            this.dsRetirementCenter = new RetirementCenter.DataSources.dsRetirementCenter();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colRealName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnSave = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEditSave = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridColumnDelete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEditDel = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colMMashatName1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsarfnumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSyndicate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubCommitte = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEDARET = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEDARET1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEdaraMandopName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnkapaMandopName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btnNew = new DevExpress.XtraEditors.SimpleButton();
            this.usersTableAdapter = new RetirementCenter.DataSources.dsRetirementCenterTableAdapters.UsersTableAdapter();
            this.tBLBeanWarsaTableAdapter = new RetirementCenter.DataSources.dsRetirementCenterTableAdapters.TBLBeanWarsaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.XPSCSData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UOWData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoExEditremarks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDMY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDMY.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditdatein)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditdatein.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdituserin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRetirementCenter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditDel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControlData
            // 
            this.gridControlData.DataSource = this.XPSCSData;
            this.gridControlData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlData.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gridControlData.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControlData.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControlData.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControlData.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gridControlData.Location = new System.Drawing.Point(2, 21);
            this.gridControlData.MainView = this.gridViewData;
            this.gridControlData.Name = "gridControlData";
            this.gridControlData.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEditSave,
            this.repositoryItemButtonEditDel,
            this.repositoryItemDateEditdatein,
            this.repositoryItemGridLookUpEdituserin,
            this.repositoryItemMemoExEditremarks,
            this.repositoryItemDateEditDMY});
            this.gridControlData.Size = new System.Drawing.Size(1051, 273);
            this.gridControlData.TabIndex = 0;
            this.gridControlData.UseEmbeddedNavigator = true;
            this.gridControlData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewData});
            this.gridControlData.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ActiveKeyDownEvent);
            // 
            // XPSCSData
            // 
            this.XPSCSData.AllowEdit = true;
            this.XPSCSData.AllowNew = true;
            this.XPSCSData.AllowRemove = true;
            this.XPSCSData.ObjectType = typeof(RetirementCenter.DataSources.dsQueries.vQry59DataTable);
            this.XPSCSData.Session = this.UOWData;
            // 
            // UOWData
            // 
            this.UOWData.TrackPropertiesModifications = false;
            // 
            // gridViewData
            // 
            this.gridViewData.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDofatSarfAId,
            this.colMMashatId,
            this.colamanatrem,
            this.colBeandate,
            this.coldateremember,
            this.coldeleted,
            this.coldatein,
            this.coluserin,
            this.gridColumnSave,
            this.gridColumnDelete,
            this.colMMashatName1,
            this.colsarfnumber,
            this.colSyndicate,
            this.colSubCommitte,
            this.gridColumn1,
            this.gridColumn3});
            this.gridViewData.GridControl = this.gridControlData;
            this.gridViewData.Name = "gridViewData";
            this.gridViewData.NewItemRowText = "اضغط لاضافة جديد";
            this.gridViewData.OptionsNavigation.AutoFocusNewRow = true;
            this.gridViewData.OptionsView.ColumnAutoWidth = false;
            this.gridViewData.OptionsView.ShowAutoFilterRow = true;
            this.gridViewData.OptionsView.ShowDetailButtons = false;
            this.gridViewData.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.coldatein, DevExpress.Data.ColumnSortOrder.Descending)});
            // 
            // colDofatSarfAId
            // 
            this.colDofatSarfAId.AppearanceCell.Options.UseTextOptions = true;
            this.colDofatSarfAId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDofatSarfAId.AppearanceHeader.Options.UseTextOptions = true;
            this.colDofatSarfAId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDofatSarfAId.Caption = "الدفعة";
            this.colDofatSarfAId.FieldName = "DofatSarf";
            this.colDofatSarfAId.Name = "colDofatSarfAId";
            this.colDofatSarfAId.OptionsColumn.AllowEdit = false;
            this.colDofatSarfAId.Visible = true;
            this.colDofatSarfAId.VisibleIndex = 0;
            this.colDofatSarfAId.Width = 128;
            // 
            // colMMashatId
            // 
            this.colMMashatId.AppearanceCell.Options.UseTextOptions = true;
            this.colMMashatId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMMashatId.AppearanceHeader.Options.UseTextOptions = true;
            this.colMMashatId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMMashatId.Caption = "اسم الوريث";
            this.colMMashatId.FieldName = "personName";
            this.colMMashatId.Name = "colMMashatId";
            this.colMMashatId.OptionsColumn.AllowEdit = false;
            this.colMMashatId.Visible = true;
            this.colMMashatId.VisibleIndex = 5;
            this.colMMashatId.Width = 150;
            // 
            // colamanatrem
            // 
            this.colamanatrem.AppearanceCell.Options.UseTextOptions = true;
            this.colamanatrem.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colamanatrem.AppearanceHeader.Options.UseTextOptions = true;
            this.colamanatrem.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colamanatrem.Caption = "ملاحظات";
            this.colamanatrem.ColumnEdit = this.repositoryItemMemoExEditremarks;
            this.colamanatrem.FieldName = "remarks";
            this.colamanatrem.Name = "colamanatrem";
            this.colamanatrem.Visible = true;
            this.colamanatrem.VisibleIndex = 9;
            this.colamanatrem.Width = 55;
            // 
            // repositoryItemMemoExEditremarks
            // 
            this.repositoryItemMemoExEditremarks.AutoHeight = false;
            this.repositoryItemMemoExEditremarks.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemMemoExEditremarks.Name = "repositoryItemMemoExEditremarks";
            // 
            // colBeandate
            // 
            this.colBeandate.AppearanceCell.Options.UseTextOptions = true;
            this.colBeandate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBeandate.AppearanceHeader.Options.UseTextOptions = true;
            this.colBeandate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBeandate.Caption = "التاريخ";
            this.colBeandate.ColumnEdit = this.repositoryItemDateEditDMY;
            this.colBeandate.FieldName = "Beandate";
            this.colBeandate.Name = "colBeandate";
            this.colBeandate.Visible = true;
            this.colBeandate.VisibleIndex = 10;
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
            // coldateremember
            // 
            this.coldateremember.AppearanceCell.Options.UseTextOptions = true;
            this.coldateremember.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coldateremember.AppearanceHeader.Options.UseTextOptions = true;
            this.coldateremember.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coldateremember.Caption = "تاريخ التذكير";
            this.coldateremember.FieldName = "dateremember";
            this.coldateremember.Name = "coldateremember";
            this.coldateremember.Visible = true;
            this.coldateremember.VisibleIndex = 11;
            // 
            // coldeleted
            // 
            this.coldeleted.AppearanceCell.Options.UseTextOptions = true;
            this.coldeleted.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coldeleted.AppearanceHeader.Options.UseTextOptions = true;
            this.coldeleted.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coldeleted.Caption = "منع";
            this.coldeleted.FieldName = "deleted";
            this.coldeleted.Name = "coldeleted";
            this.coldeleted.OptionsColumn.AllowEdit = false;
            this.coldeleted.Visible = true;
            this.coldeleted.VisibleIndex = 8;
            // 
            // coldatein
            // 
            this.coldatein.AppearanceCell.Options.UseTextOptions = true;
            this.coldatein.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coldatein.AppearanceHeader.Options.UseTextOptions = true;
            this.coldatein.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coldatein.Caption = "تاريخ الادخال";
            this.coldatein.ColumnEdit = this.repositoryItemDateEditdatein;
            this.coldatein.FieldName = "datein";
            this.coldatein.Name = "coldatein";
            this.coldatein.OptionsColumn.AllowEdit = false;
            this.coldatein.Visible = true;
            this.coldatein.VisibleIndex = 12;
            this.coldatein.Width = 94;
            // 
            // repositoryItemDateEditdatein
            // 
            this.repositoryItemDateEditdatein.AutoHeight = false;
            this.repositoryItemDateEditdatein.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEditdatein.DisplayFormat.FormatString = "g";
            this.repositoryItemDateEditdatein.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEditdatein.EditFormat.FormatString = "g";
            this.repositoryItemDateEditdatein.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEditdatein.Mask.EditMask = "g";
            this.repositoryItemDateEditdatein.Name = "repositoryItemDateEditdatein";
            this.repositoryItemDateEditdatein.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            // 
            // coluserin
            // 
            this.coluserin.AppearanceCell.Options.UseTextOptions = true;
            this.coluserin.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coluserin.AppearanceHeader.Options.UseTextOptions = true;
            this.coluserin.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coluserin.Caption = "مسئول الادخال";
            this.coluserin.ColumnEdit = this.repositoryItemGridLookUpEdituserin;
            this.coluserin.FieldName = "userin";
            this.coluserin.Name = "coluserin";
            this.coluserin.OptionsColumn.AllowEdit = false;
            this.coluserin.Width = 97;
            // 
            // repositoryItemGridLookUpEdituserin
            // 
            this.repositoryItemGridLookUpEdituserin.AutoHeight = false;
            this.repositoryItemGridLookUpEdituserin.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEdituserin.DataSource = this.usersBindingSource;
            this.repositoryItemGridLookUpEdituserin.DisplayMember = "RealName";
            this.repositoryItemGridLookUpEdituserin.Name = "repositoryItemGridLookUpEdituserin";
            this.repositoryItemGridLookUpEdituserin.NullText = "";
            this.repositoryItemGridLookUpEdituserin.ValueMember = "UserID";
            this.repositoryItemGridLookUpEdituserin.View = this.gridView2;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.dsRetirementCenter;
            // 
            // dsRetirementCenter
            // 
            this.dsRetirementCenter.DataSetName = "dsRetirementCenter";
            this.dsRetirementCenter.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colRealName});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colRealName
            // 
            this.colRealName.FieldName = "RealName";
            this.colRealName.Name = "colRealName";
            this.colRealName.Visible = true;
            this.colRealName.VisibleIndex = 0;
            // 
            // gridColumnSave
            // 
            this.gridColumnSave.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumnSave.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnSave.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnSave.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnSave.Caption = "حفظ";
            this.gridColumnSave.ColumnEdit = this.repositoryItemButtonEditSave;
            this.gridColumnSave.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this.gridColumnSave.Name = "gridColumnSave";
            this.gridColumnSave.Visible = true;
            this.gridColumnSave.VisibleIndex = 13;
            this.gridColumnSave.Width = 55;
            // 
            // repositoryItemButtonEditSave
            // 
            this.repositoryItemButtonEditSave.AutoHeight = false;
            this.repositoryItemButtonEditSave.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.OK)});
            this.repositoryItemButtonEditSave.Name = "repositoryItemButtonEditSave";
            this.repositoryItemButtonEditSave.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemButtonEditSave.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositoryItemButtonEditSave_ButtonClick);
            // 
            // gridColumnDelete
            // 
            this.gridColumnDelete.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumnDelete.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnDelete.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnDelete.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnDelete.Caption = "حذف";
            this.gridColumnDelete.ColumnEdit = this.repositoryItemButtonEditDel;
            this.gridColumnDelete.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this.gridColumnDelete.Name = "gridColumnDelete";
            this.gridColumnDelete.Visible = true;
            this.gridColumnDelete.VisibleIndex = 14;
            this.gridColumnDelete.Width = 51;
            // 
            // repositoryItemButtonEditDel
            // 
            this.repositoryItemButtonEditDel.AutoHeight = false;
            this.repositoryItemButtonEditDel.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.repositoryItemButtonEditDel.Name = "repositoryItemButtonEditDel";
            this.repositoryItemButtonEditDel.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemButtonEditDel.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositoryItemButtonEditDel_ButtonClick);
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
            this.colMMashatName1.OptionsColumn.AllowEdit = false;
            this.colMMashatName1.Visible = true;
            this.colMMashatName1.VisibleIndex = 2;
            // 
            // colsarfnumber
            // 
            this.colsarfnumber.AppearanceCell.Options.UseTextOptions = true;
            this.colsarfnumber.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colsarfnumber.AppearanceHeader.Options.UseTextOptions = true;
            this.colsarfnumber.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colsarfnumber.Caption = "رقم صرف";
            this.colsarfnumber.FieldName = "sarfnumber";
            this.colsarfnumber.Name = "colsarfnumber";
            this.colsarfnumber.OptionsColumn.AllowEdit = false;
            this.colsarfnumber.Visible = true;
            this.colsarfnumber.VisibleIndex = 3;
            // 
            // colSyndicate
            // 
            this.colSyndicate.AppearanceCell.Options.UseTextOptions = true;
            this.colSyndicate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSyndicate.AppearanceHeader.Options.UseTextOptions = true;
            this.colSyndicate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSyndicate.Caption = "فرعية";
            this.colSyndicate.FieldName = "Syndicate";
            this.colSyndicate.Name = "colSyndicate";
            this.colSyndicate.OptionsColumn.AllowEdit = false;
            this.colSyndicate.Visible = true;
            this.colSyndicate.VisibleIndex = 6;
            // 
            // colSubCommitte
            // 
            this.colSubCommitte.AppearanceCell.Options.UseTextOptions = true;
            this.colSubCommitte.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSubCommitte.AppearanceHeader.Options.UseTextOptions = true;
            this.colSubCommitte.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSubCommitte.Caption = "لجنة";
            this.colSubCommitte.FieldName = "SubCommitte";
            this.colSubCommitte.Name = "colSubCommitte";
            this.colSubCommitte.OptionsColumn.AllowEdit = false;
            this.colSubCommitte.Visible = true;
            this.colSubCommitte.VisibleIndex = 7;
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.Caption = "كود الاب";
            this.gridColumn1.FieldName = "MMashatId";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn3.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn3.Caption = "كود60";
            this.gridColumn3.FieldName = "code60";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 4;
            // 
            // colEDARET
            // 
            this.colEDARET.AppearanceCell.Options.UseTextOptions = true;
            this.colEDARET.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEDARET.AppearanceHeader.Options.UseTextOptions = true;
            this.colEDARET.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEDARET.Caption = "اسم الاداره";
            this.colEDARET.FieldName = "EDARET";
            this.colEDARET.Name = "colEDARET";
            this.colEDARET.Visible = true;
            this.colEDARET.VisibleIndex = 0;
            // 
            // colEDARET1
            // 
            this.colEDARET1.AppearanceCell.Options.UseTextOptions = true;
            this.colEDARET1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEDARET1.AppearanceHeader.Options.UseTextOptions = true;
            this.colEDARET1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEDARET1.Caption = "الادارة";
            this.colEDARET1.FieldName = "EDARET";
            this.colEDARET1.Name = "colEDARET1";
            this.colEDARET1.Visible = true;
            this.colEDARET1.VisibleIndex = 0;
            // 
            // colEdaraMandopName
            // 
            this.colEdaraMandopName.AppearanceCell.Options.UseTextOptions = true;
            this.colEdaraMandopName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEdaraMandopName.AppearanceHeader.Options.UseTextOptions = true;
            this.colEdaraMandopName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEdaraMandopName.Caption = "الاسم";
            this.colEdaraMandopName.FieldName = "EdaraMandopName";
            this.colEdaraMandopName.Name = "colEdaraMandopName";
            this.colEdaraMandopName.Visible = true;
            this.colEdaraMandopName.VisibleIndex = 0;
            // 
            // colnkapaMandopName
            // 
            this.colnkapaMandopName.AppearanceCell.Options.UseTextOptions = true;
            this.colnkapaMandopName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colnkapaMandopName.AppearanceHeader.Options.UseTextOptions = true;
            this.colnkapaMandopName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colnkapaMandopName.Caption = "الاسم";
            this.colnkapaMandopName.FieldName = "nkapaMandopName";
            this.colnkapaMandopName.Name = "colnkapaMandopName";
            this.colnkapaMandopName.Visible = true;
            this.colnkapaMandopName.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.Caption = "اسم الشهر";
            this.gridColumn2.FieldName = "MonthName";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.gridControlData);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1055, 296);
            this.groupControl1.TabIndex = 1;
            // 
            // groupControl2
            // 
            this.groupControl2.AllowTouchScroll = true;
            this.groupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl2.Controls.Add(this.btnNew);
            this.groupControl2.Location = new System.Drawing.Point(12, 314);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1055, 62);
            this.groupControl2.TabIndex = 2;
            // 
            // btnNew
            // 
            this.btnNew.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnNew.Image = global::RetirementCenter.Properties.Resources.Add;
            this.btnNew.Location = new System.Drawing.Point(850, 23);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(200, 35);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "جديد";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // tBLBeanWarsaTableAdapter
            // 
            this.tBLBeanWarsaTableAdapter.ClearBeforeFill = true;
            // 
            // TBLBeanWarsaFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 388);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "TBLBeanWarsaFrm";
            this.Text = "بيان الورثة";
            this.Load += new System.EventHandler(this.FormFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.XPSCSData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UOWData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoExEditremarks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDMY.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDMY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditdatein.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditdatein)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdituserin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRetirementCenter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditDel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlData;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewData;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEditSave;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEditDel;
        private DevExpress.XtraGrid.Columns.GridColumn colEDARET;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnSave;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDelete;
        private DevExpress.XtraGrid.Columns.GridColumn colEDARET1;
        private DevExpress.XtraGrid.Columns.GridColumn colEdaraMandopName;
        private DevExpress.XtraGrid.Columns.GridColumn colnkapaMandopName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btnNew;
        private DevExpress.XtraGrid.Columns.GridColumn coldatein;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEditdatein;
        private DevExpress.XtraGrid.Columns.GridColumn coluserin;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdituserin;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit repositoryItemMemoExEditremarks;
        private DataSources.dsRetirementCenter dsRetirementCenter;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colMMashatId;
        private DevExpress.XtraGrid.Columns.GridColumn colDofatSarfAId;
        private DevExpress.XtraGrid.Columns.GridColumn colamanatrem;
        private DataSources.dsRetirementCenterTableAdapters.UsersTableAdapter usersTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colRealName;
        private DataSources.dsRetirementCenterTableAdapters.TBLBeanWarsaTableAdapter tBLBeanWarsaTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colBeandate;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEditDMY;
        private DevExpress.XtraGrid.Columns.GridColumn coldateremember;
        private DevExpress.XtraGrid.Columns.GridColumn coldeleted;
        private DevExpress.Xpo.XPServerCollectionSource XPSCSData;
        private DevExpress.Xpo.UnitOfWork UOWData;
        private DevExpress.XtraGrid.Columns.GridColumn colMMashatName1;
        private DevExpress.XtraGrid.Columns.GridColumn colsarfnumber;
        private DevExpress.XtraGrid.Columns.GridColumn colSyndicate;
        private DevExpress.XtraGrid.Columns.GridColumn colSubCommitte;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
    }
}