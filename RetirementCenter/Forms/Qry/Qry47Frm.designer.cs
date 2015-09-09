﻿namespace RetirementCenter
{
    partial class Qry47Frm
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
            this.vQry47BindingSource = new System.Windows.Forms.BindingSource();
            this.dsQueries = new RetirementCenter.DataSources.dsQueries();
            this.gridViewData = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colExportDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMMashatName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpersonName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSyndicate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubCommitte = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsarfnumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRealName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvisa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvisawarddate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colhafza = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colhafzadate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPersonId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMMashatId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNameOnCard = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnewid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colActivate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colActivateDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltrteep = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEditDMY = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.repositoryItemMemoExEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit();
            this.repositoryItemLookUpEdituserin = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnPrintExport = new DevExpress.XtraEditors.SimpleButton();
            this.vQry47TableAdapter = new RetirementCenter.DataSources.dsQueriesTableAdapters.vQry47TableAdapter();
            this.colActivateBank = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vQry47BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsQueries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDMY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDMY.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoExEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdituserin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControlData
            // 
            this.gridControlData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlData.DataSource = this.vQry47BindingSource;
            this.gridControlData.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gridControlData.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControlData.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControlData.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControlData.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gridControlData.EmbeddedNavigator.TextStringFormat = "صف {0} من {1}";
            this.gridControlData.Location = new System.Drawing.Point(0, 53);
            this.gridControlData.MainView = this.gridViewData;
            this.gridControlData.Name = "gridControlData";
            this.gridControlData.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEditDMY,
            this.repositoryItemMemoExEdit1,
            this.repositoryItemLookUpEdituserin});
            this.gridControlData.Size = new System.Drawing.Size(734, 404);
            this.gridControlData.TabIndex = 1;
            this.gridControlData.UseEmbeddedNavigator = true;
            this.gridControlData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewData});
            // 
            // vQry47BindingSource
            // 
            this.vQry47BindingSource.DataMember = "vQry47";
            this.vQry47BindingSource.DataSource = this.dsQueries;
            // 
            // dsQueries
            // 
            this.dsQueries.DataSetName = "dsQueries";
            this.dsQueries.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridViewData
            // 
            this.gridViewData.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.DarkGray;
            this.gridViewData.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.DarkGray;
            this.gridViewData.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.DimGray;
            this.gridViewData.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gridViewData.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gridViewData.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gridViewData.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.DarkGray;
            this.gridViewData.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.DarkGray;
            this.gridViewData.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Gainsboro;
            this.gridViewData.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gridViewData.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gridViewData.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gridViewData.Appearance.Empty.BackColor = System.Drawing.Color.DimGray;
            this.gridViewData.Appearance.Empty.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.gridViewData.Appearance.Empty.Options.UseBackColor = true;
            this.gridViewData.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.gridViewData.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridViewData.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.Gray;
            this.gridViewData.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.Gray;
            this.gridViewData.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gridViewData.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gridViewData.Appearance.FilterPanel.BackColor = System.Drawing.Color.Gray;
            this.gridViewData.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.gridViewData.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gridViewData.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gridViewData.Appearance.FocusedRow.BackColor = System.Drawing.Color.Black;
            this.gridViewData.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gridViewData.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridViewData.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridViewData.Appearance.FooterPanel.BackColor = System.Drawing.Color.DarkGray;
            this.gridViewData.Appearance.FooterPanel.BorderColor = System.Drawing.Color.DarkGray;
            this.gridViewData.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gridViewData.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gridViewData.Appearance.FooterPanel.Options.UseTextOptions = true;
            this.gridViewData.Appearance.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewData.Appearance.GroupButton.BackColor = System.Drawing.Color.Silver;
            this.gridViewData.Appearance.GroupButton.BorderColor = System.Drawing.Color.Silver;
            this.gridViewData.Appearance.GroupButton.Options.UseBackColor = true;
            this.gridViewData.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gridViewData.Appearance.GroupFooter.BackColor = System.Drawing.Color.Silver;
            this.gridViewData.Appearance.GroupFooter.BorderColor = System.Drawing.Color.Silver;
            this.gridViewData.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gridViewData.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gridViewData.Appearance.GroupPanel.BackColor = System.Drawing.Color.DimGray;
            this.gridViewData.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Gray;
            this.gridViewData.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gridViewData.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gridViewData.Appearance.GroupRow.BackColor = System.Drawing.Color.Silver;
            this.gridViewData.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gridViewData.Appearance.GroupRow.Options.UseBackColor = true;
            this.gridViewData.Appearance.GroupRow.Options.UseFont = true;
            this.gridViewData.Appearance.HeaderPanel.BackColor = System.Drawing.Color.DarkGray;
            this.gridViewData.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.DarkGray;
            this.gridViewData.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridViewData.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gridViewData.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.LightSlateGray;
            this.gridViewData.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gridViewData.Appearance.HorzLine.BackColor = System.Drawing.Color.LightGray;
            this.gridViewData.Appearance.HorzLine.Options.UseBackColor = true;
            this.gridViewData.Appearance.OddRow.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gridViewData.Appearance.OddRow.Options.UseBackColor = true;
            this.gridViewData.Appearance.Preview.BackColor = System.Drawing.Color.Gainsboro;
            this.gridViewData.Appearance.Preview.ForeColor = System.Drawing.Color.DimGray;
            this.gridViewData.Appearance.Preview.Options.UseBackColor = true;
            this.gridViewData.Appearance.Preview.Options.UseForeColor = true;
            this.gridViewData.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gridViewData.Appearance.Row.Options.UseBackColor = true;
            this.gridViewData.Appearance.RowSeparator.BackColor = System.Drawing.Color.DimGray;
            this.gridViewData.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gridViewData.Appearance.SelectedRow.BackColor = System.Drawing.Color.DimGray;
            this.gridViewData.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridViewData.Appearance.VertLine.BackColor = System.Drawing.Color.LightGray;
            this.gridViewData.Appearance.VertLine.Options.UseBackColor = true;
            this.gridViewData.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colExportDate,
            this.colMMashatName,
            this.colpersonName,
            this.colSyndicate,
            this.colSubCommitte,
            this.colsarfnumber,
            this.colRealName,
            this.colvisa,
            this.colvisawarddate,
            this.colhafza,
            this.colhafzadate,
            this.colPersonId,
            this.colMMashatId,
            this.colNameOnCard,
            this.colnewid,
            this.colActivate,
            this.colActivateDate,
            this.coltrteep,
            this.colActivateBank});
            this.gridViewData.GridControl = this.gridControlData;
            this.gridViewData.Name = "gridViewData";
            this.gridViewData.OptionsBehavior.ReadOnly = true;
            this.gridViewData.OptionsCustomization.AllowRowSizing = true;
            this.gridViewData.OptionsFind.AlwaysVisible = true;
            this.gridViewData.OptionsPrint.EnableAppearanceEvenRow = true;
            this.gridViewData.OptionsPrint.EnableAppearanceOddRow = true;
            this.gridViewData.OptionsView.ColumnAutoWidth = false;
            this.gridViewData.OptionsView.EnableAppearanceEvenRow = true;
            this.gridViewData.OptionsView.EnableAppearanceOddRow = true;
            this.gridViewData.OptionsView.ShowAutoFilterRow = true;
            this.gridViewData.OptionsView.ShowFooter = true;
            // 
            // colExportDate
            // 
            this.colExportDate.AppearanceCell.Options.UseTextOptions = true;
            this.colExportDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colExportDate.AppearanceHeader.Options.UseTextOptions = true;
            this.colExportDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colExportDate.Caption = "التاريخ";
            this.colExportDate.FieldName = "ExportDate";
            this.colExportDate.Name = "colExportDate";
            this.colExportDate.Visible = true;
            this.colExportDate.VisibleIndex = 0;
            // 
            // colMMashatName
            // 
            this.colMMashatName.AppearanceCell.Options.UseTextOptions = true;
            this.colMMashatName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMMashatName.AppearanceHeader.Options.UseTextOptions = true;
            this.colMMashatName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMMashatName.Caption = "الاسم العضو";
            this.colMMashatName.FieldName = "MMashatName";
            this.colMMashatName.Name = "colMMashatName";
            this.colMMashatName.Visible = true;
            this.colMMashatName.VisibleIndex = 1;
            // 
            // colpersonName
            // 
            this.colpersonName.AppearanceCell.Options.UseTextOptions = true;
            this.colpersonName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colpersonName.AppearanceHeader.Options.UseTextOptions = true;
            this.colpersonName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colpersonName.Caption = "اسم الوريث";
            this.colpersonName.FieldName = "personName";
            this.colpersonName.Name = "colpersonName";
            this.colpersonName.Visible = true;
            this.colpersonName.VisibleIndex = 2;
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
            this.colSyndicate.VisibleIndex = 3;
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
            this.colsarfnumber.VisibleIndex = 5;
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
            this.colRealName.VisibleIndex = 6;
            // 
            // colvisa
            // 
            this.colvisa.AppearanceCell.Options.UseTextOptions = true;
            this.colvisa.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colvisa.AppearanceHeader.Options.UseTextOptions = true;
            this.colvisa.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colvisa.Caption = "رقم الفيزا";
            this.colvisa.FieldName = "visa";
            this.colvisa.Name = "colvisa";
            this.colvisa.Visible = true;
            this.colvisa.VisibleIndex = 7;
            // 
            // colvisawarddate
            // 
            this.colvisawarddate.AppearanceCell.Options.UseTextOptions = true;
            this.colvisawarddate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colvisawarddate.AppearanceHeader.Options.UseTextOptions = true;
            this.colvisawarddate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colvisawarddate.Caption = "تاريخ الوارد";
            this.colvisawarddate.FieldName = "visawarddate";
            this.colvisawarddate.Name = "colvisawarddate";
            this.colvisawarddate.Visible = true;
            this.colvisawarddate.VisibleIndex = 8;
            // 
            // colhafza
            // 
            this.colhafza.AppearanceCell.Options.UseTextOptions = true;
            this.colhafza.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colhafza.AppearanceHeader.Options.UseTextOptions = true;
            this.colhafza.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colhafza.Caption = "رقم الحافظة";
            this.colhafza.FieldName = "hafza";
            this.colhafza.Name = "colhafza";
            this.colhafza.Visible = true;
            this.colhafza.VisibleIndex = 9;
            // 
            // colhafzadate
            // 
            this.colhafzadate.AppearanceCell.Options.UseTextOptions = true;
            this.colhafzadate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colhafzadate.AppearanceHeader.Options.UseTextOptions = true;
            this.colhafzadate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colhafzadate.Caption = "تاريخ الحافظة";
            this.colhafzadate.FieldName = "hafzadate";
            this.colhafzadate.Name = "colhafzadate";
            this.colhafzadate.Visible = true;
            this.colhafzadate.VisibleIndex = 10;
            // 
            // colPersonId
            // 
            this.colPersonId.AppearanceCell.Options.UseTextOptions = true;
            this.colPersonId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPersonId.AppearanceHeader.Options.UseTextOptions = true;
            this.colPersonId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPersonId.Caption = "كود الوريث";
            this.colPersonId.FieldName = "PersonId";
            this.colPersonId.Name = "colPersonId";
            this.colPersonId.Visible = true;
            this.colPersonId.VisibleIndex = 11;
            // 
            // colMMashatId
            // 
            this.colMMashatId.AppearanceCell.Options.UseTextOptions = true;
            this.colMMashatId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMMashatId.AppearanceHeader.Options.UseTextOptions = true;
            this.colMMashatId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMMashatId.Caption = "كود الاب";
            this.colMMashatId.FieldName = "MMashatId";
            this.colMMashatId.Name = "colMMashatId";
            this.colMMashatId.Visible = true;
            this.colMMashatId.VisibleIndex = 12;
            // 
            // colNameOnCard
            // 
            this.colNameOnCard.AppearanceCell.Options.UseTextOptions = true;
            this.colNameOnCard.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNameOnCard.AppearanceHeader.Options.UseTextOptions = true;
            this.colNameOnCard.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNameOnCard.Caption = "الاسم علي الكارت";
            this.colNameOnCard.FieldName = "NameOnCard";
            this.colNameOnCard.Name = "colNameOnCard";
            this.colNameOnCard.Visible = true;
            this.colNameOnCard.VisibleIndex = 13;
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
            this.colnewid.VisibleIndex = 14;
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
            this.colActivate.VisibleIndex = 15;
            // 
            // colActivateDate
            // 
            this.colActivateDate.AppearanceCell.Options.UseTextOptions = true;
            this.colActivateDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colActivateDate.AppearanceHeader.Options.UseTextOptions = true;
            this.colActivateDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colActivateDate.Caption = "تاريخ التفعيل";
            this.colActivateDate.FieldName = "ActivateDate";
            this.colActivateDate.Name = "colActivateDate";
            this.colActivateDate.Visible = true;
            this.colActivateDate.VisibleIndex = 16;
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
            this.coltrteep.VisibleIndex = 17;
            // 
            // repositoryItemDateEditDMY
            // 
            this.repositoryItemDateEditDMY.AutoHeight = false;
            this.repositoryItemDateEditDMY.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEditDMY.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.repositoryItemDateEditDMY.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEditDMY.EditFormat.FormatString = "dd/MM/yyyy";
            this.repositoryItemDateEditDMY.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEditDMY.Mask.EditMask = "dd/MM/yyyy";
            this.repositoryItemDateEditDMY.Name = "repositoryItemDateEditDMY";
            this.repositoryItemDateEditDMY.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            // 
            // repositoryItemMemoExEdit1
            // 
            this.repositoryItemMemoExEdit1.AutoHeight = false;
            this.repositoryItemMemoExEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemMemoExEdit1.Name = "repositoryItemMemoExEdit1";
            // 
            // repositoryItemLookUpEdituserin
            // 
            this.repositoryItemLookUpEdituserin.AutoHeight = false;
            this.repositoryItemLookUpEdituserin.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdituserin.DisplayMember = "RealName";
            this.repositoryItemLookUpEdituserin.Name = "repositoryItemLookUpEdituserin";
            this.repositoryItemLookUpEdituserin.NullText = "";
            this.repositoryItemLookUpEdituserin.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemLookUpEdituserin.ValueMember = "UserID";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnPrintExport);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(734, 47);
            this.panelControl1.TabIndex = 3;
            // 
            // btnPrintExport
            // 
            this.btnPrintExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrintExport.Location = new System.Drawing.Point(588, 12);
            this.btnPrintExport.Name = "btnPrintExport";
            this.btnPrintExport.Size = new System.Drawing.Size(134, 23);
            this.btnPrintExport.TabIndex = 0;
            this.btnPrintExport.Text = "طباعه و تصدير";
            this.btnPrintExport.Click += new System.EventHandler(this.btnPrintExport_Click);
            // 
            // vQry47TableAdapter
            // 
            this.vQry47TableAdapter.ClearBeforeFill = true;
            // 
            // colActivateBank
            // 
            this.colActivateBank.AppearanceCell.Options.UseTextOptions = true;
            this.colActivateBank.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colActivateBank.AppearanceHeader.Options.UseTextOptions = true;
            this.colActivateBank.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colActivateBank.Caption = "تم التفعيل جدول بنك";
            this.colActivateBank.FieldName = "ActivateBank";
            this.colActivateBank.Name = "colActivateBank";
            this.colActivateBank.Visible = true;
            this.colActivateBank.VisibleIndex = 18;
            // 
            // Qry47Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 462);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.gridControlData);
            this.Name = "Qry47Frm";
            this.Text = "البيانات المصدرة للبنك - ورثة";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Qry06Frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vQry47BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsQueries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDMY.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDMY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoExEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdituserin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlData;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewData;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnPrintExport;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEditDMY;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit repositoryItemMemoExEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdituserin;
        private DataSources.dsQueries dsQueries;
        private DevExpress.XtraGrid.Columns.GridColumn colExportDate;
        private DevExpress.XtraGrid.Columns.GridColumn colMMashatName;
        private DevExpress.XtraGrid.Columns.GridColumn colSyndicate;
        private DevExpress.XtraGrid.Columns.GridColumn colSubCommitte;
        private DevExpress.XtraGrid.Columns.GridColumn colsarfnumber;
        private DevExpress.XtraGrid.Columns.GridColumn colRealName;
        private DevExpress.XtraGrid.Columns.GridColumn colvisa;
        private DevExpress.XtraGrid.Columns.GridColumn colvisawarddate;
        private DevExpress.XtraGrid.Columns.GridColumn colhafza;
        private DevExpress.XtraGrid.Columns.GridColumn colhafzadate;
        private System.Windows.Forms.BindingSource vQry47BindingSource;
        private DataSources.dsQueriesTableAdapters.vQry47TableAdapter vQry47TableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colpersonName;
        private DevExpress.XtraGrid.Columns.GridColumn colPersonId;
        private DevExpress.XtraGrid.Columns.GridColumn colMMashatId;
        private DevExpress.XtraGrid.Columns.GridColumn colNameOnCard;
        private DevExpress.XtraGrid.Columns.GridColumn colnewid;
        private DevExpress.XtraGrid.Columns.GridColumn colActivate;
        private DevExpress.XtraGrid.Columns.GridColumn colActivateDate;
        private DevExpress.XtraGrid.Columns.GridColumn coltrteep;
        private DevExpress.XtraGrid.Columns.GridColumn colActivateBank;

    }
}