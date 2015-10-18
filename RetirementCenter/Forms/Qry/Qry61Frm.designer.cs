﻿namespace RetirementCenter
{
    partial class Qry61Frm
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
            this.vQry61BindingSource = new System.Windows.Forms.BindingSource();
            this.dsQueries = new RetirementCenter.DataSources.dsQueries();
            this.gridViewData = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMMashatId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvisanumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsummony = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCurrency = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAction = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMMashatName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMMashatNId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSyndicateId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubCommitteId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsendbankdate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colamanatmony = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colamanatwareddate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldatein = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coluserin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsarfnumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSyndicate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubCommitte = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMMashatName1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colActivate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEditDate = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.repositoryItemPictureEditImg = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.repositoryItemDateEditMDY = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.panelControlMain = new DevExpress.XtraEditors.PanelControl();
            this.LUETBLDofatSarf = new DevExpress.XtraEditors.GridLookUpEdit();
            this.LSMSTBLDofatSarf = new DevExpress.Data.Linq.LinqServerModeSource();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDofatSarf = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.btnSaveBackData = new DevExpress.XtraEditors.SimpleButton();
            this.btnPrintExport = new DevExpress.XtraEditors.SimpleButton();
            this.vQry61TableAdapter = new RetirementCenter.DataSources.dsQueriesTableAdapters.vQry61TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vQry61BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsQueries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDate.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEditImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditMDY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditMDY.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlMain)).BeginInit();
            this.panelControlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LUETBLDofatSarf.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSTBLDofatSarf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlData
            // 
            this.gridControlData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlData.DataSource = this.vQry61BindingSource;
            this.gridControlData.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControlData.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControlData.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControlData.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gridControlData.EmbeddedNavigator.TextStringFormat = "صف {0} من {1}";
            this.gridControlData.Location = new System.Drawing.Point(0, 69);
            this.gridControlData.MainView = this.gridViewData;
            this.gridControlData.Name = "gridControlData";
            this.gridControlData.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEditDate,
            this.repositoryItemPictureEditImg,
            this.repositoryItemCheckEdit1,
            this.repositoryItemDateEditMDY});
            this.gridControlData.Size = new System.Drawing.Size(1353, 388);
            this.gridControlData.TabIndex = 1;
            this.gridControlData.UseEmbeddedNavigator = true;
            this.gridControlData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewData});
            // 
            // vQry61BindingSource
            // 
            this.vQry61BindingSource.DataMember = "vQry61";
            this.vQry61BindingSource.DataSource = this.dsQueries;
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
            this.colMMashatId,
            this.colvisanumber,
            this.gridColumn2,
            this.colsummony,
            this.colCurrency,
            this.colAction,
            this.colMMashatName,
            this.colMMashatNId,
            this.gridColumn1,
            this.colSyndicateId,
            this.colSubCommitteId,
            this.colsendbankdate,
            this.colamanatmony,
            this.colamanatwareddate,
            this.coldatein,
            this.coluserin,
            this.colsarfnumber,
            this.colSyndicate,
            this.colSubCommitte,
            this.colMMashatName1,
            this.colActivate});
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
            // colMMashatId
            // 
            this.colMMashatId.AppearanceCell.Options.UseTextOptions = true;
            this.colMMashatId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMMashatId.AppearanceHeader.Options.UseTextOptions = true;
            this.colMMashatId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMMashatId.Caption = "Customer ID";
            this.colMMashatId.FieldName = "MMashatId";
            this.colMMashatId.Name = "colMMashatId";
            this.colMMashatId.Visible = true;
            this.colMMashatId.VisibleIndex = 0;
            this.colMMashatId.Width = 79;
            // 
            // colvisanumber
            // 
            this.colvisanumber.AppearanceCell.Options.UseTextOptions = true;
            this.colvisanumber.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colvisanumber.AppearanceHeader.Options.UseTextOptions = true;
            this.colvisanumber.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colvisanumber.Caption = "PAN";
            this.colvisanumber.FieldName = "visa";
            this.colvisanumber.Name = "colvisanumber";
            this.colvisanumber.Visible = true;
            this.colvisanumber.VisibleIndex = 1;
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.Caption = "Account Number";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 2;
            this.gridColumn2.Width = 98;
            // 
            // colsummony
            // 
            this.colsummony.AppearanceCell.Options.UseTextOptions = true;
            this.colsummony.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colsummony.AppearanceHeader.Options.UseTextOptions = true;
            this.colsummony.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colsummony.Caption = "Amount";
            this.colsummony.FieldName = "summony";
            this.colsummony.Name = "colsummony";
            this.colsummony.Visible = true;
            this.colsummony.VisibleIndex = 3;
            // 
            // colCurrency
            // 
            this.colCurrency.AppearanceCell.Options.UseTextOptions = true;
            this.colCurrency.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCurrency.AppearanceHeader.Options.UseTextOptions = true;
            this.colCurrency.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCurrency.FieldName = "Currency";
            this.colCurrency.Name = "colCurrency";
            this.colCurrency.Visible = true;
            this.colCurrency.VisibleIndex = 4;
            // 
            // colAction
            // 
            this.colAction.AppearanceCell.Options.UseTextOptions = true;
            this.colAction.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAction.AppearanceHeader.Options.UseTextOptions = true;
            this.colAction.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAction.FieldName = "Action";
            this.colAction.Name = "colAction";
            this.colAction.Visible = true;
            this.colAction.VisibleIndex = 5;
            // 
            // colMMashatName
            // 
            this.colMMashatName.AppearanceCell.Options.UseTextOptions = true;
            this.colMMashatName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMMashatName.AppearanceHeader.Options.UseTextOptions = true;
            this.colMMashatName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMMashatName.Caption = "Customer Name";
            this.colMMashatName.Name = "colMMashatName";
            this.colMMashatName.Visible = true;
            this.colMMashatName.VisibleIndex = 6;
            this.colMMashatName.Width = 95;
            // 
            // colMMashatNId
            // 
            this.colMMashatNId.AppearanceCell.Options.UseTextOptions = true;
            this.colMMashatNId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMMashatNId.AppearanceHeader.Options.UseTextOptions = true;
            this.colMMashatNId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMMashatNId.Caption = "National ID";
            this.colMMashatNId.FieldName = "MMashatNId";
            this.colMMashatNId.Name = "colMMashatNId";
            this.colMMashatNId.Visible = true;
            this.colMMashatNId.VisibleIndex = 7;
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.Caption = "Description";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 8;
            // 
            // colSyndicateId
            // 
            this.colSyndicateId.AppearanceCell.Options.UseTextOptions = true;
            this.colSyndicateId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSyndicateId.AppearanceHeader.Options.UseTextOptions = true;
            this.colSyndicateId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSyndicateId.FieldName = "SyndicateId";
            this.colSyndicateId.Name = "colSyndicateId";
            this.colSyndicateId.Visible = true;
            this.colSyndicateId.VisibleIndex = 9;
            this.colSyndicateId.Width = 79;
            // 
            // colSubCommitteId
            // 
            this.colSubCommitteId.AppearanceCell.Options.UseTextOptions = true;
            this.colSubCommitteId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSubCommitteId.AppearanceHeader.Options.UseTextOptions = true;
            this.colSubCommitteId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSubCommitteId.FieldName = "SubCommitteId";
            this.colSubCommitteId.Name = "colSubCommitteId";
            this.colSubCommitteId.Visible = true;
            this.colSubCommitteId.VisibleIndex = 10;
            this.colSubCommitteId.Width = 98;
            // 
            // colsendbankdate
            // 
            this.colsendbankdate.AppearanceCell.Options.UseTextOptions = true;
            this.colsendbankdate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colsendbankdate.AppearanceHeader.Options.UseTextOptions = true;
            this.colsendbankdate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colsendbankdate.FieldName = "sendbankdate";
            this.colsendbankdate.Name = "colsendbankdate";
            this.colsendbankdate.Visible = true;
            this.colsendbankdate.VisibleIndex = 11;
            this.colsendbankdate.Width = 87;
            // 
            // colamanatmony
            // 
            this.colamanatmony.AppearanceCell.Options.UseTextOptions = true;
            this.colamanatmony.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colamanatmony.AppearanceHeader.Options.UseTextOptions = true;
            this.colamanatmony.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colamanatmony.FieldName = "amanatmony";
            this.colamanatmony.Name = "colamanatmony";
            this.colamanatmony.Visible = true;
            this.colamanatmony.VisibleIndex = 12;
            this.colamanatmony.Width = 81;
            // 
            // colamanatwareddate
            // 
            this.colamanatwareddate.AppearanceCell.Options.UseTextOptions = true;
            this.colamanatwareddate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colamanatwareddate.AppearanceHeader.Options.UseTextOptions = true;
            this.colamanatwareddate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colamanatwareddate.FieldName = "amanatwareddate";
            this.colamanatwareddate.Name = "colamanatwareddate";
            this.colamanatwareddate.Visible = true;
            this.colamanatwareddate.VisibleIndex = 13;
            this.colamanatwareddate.Width = 107;
            // 
            // coldatein
            // 
            this.coldatein.AppearanceCell.Options.UseTextOptions = true;
            this.coldatein.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coldatein.AppearanceHeader.Options.UseTextOptions = true;
            this.coldatein.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coldatein.FieldName = "datein";
            this.coldatein.Name = "coldatein";
            this.coldatein.Visible = true;
            this.coldatein.VisibleIndex = 14;
            // 
            // coluserin
            // 
            this.coluserin.AppearanceCell.Options.UseTextOptions = true;
            this.coluserin.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coluserin.AppearanceHeader.Options.UseTextOptions = true;
            this.coluserin.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coluserin.FieldName = "userin";
            this.coluserin.Name = "coluserin";
            this.coluserin.Visible = true;
            this.coluserin.VisibleIndex = 15;
            // 
            // colsarfnumber
            // 
            this.colsarfnumber.AppearanceCell.Options.UseTextOptions = true;
            this.colsarfnumber.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colsarfnumber.AppearanceHeader.Options.UseTextOptions = true;
            this.colsarfnumber.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colsarfnumber.FieldName = "sarfnumber";
            this.colsarfnumber.Name = "colsarfnumber";
            this.colsarfnumber.Visible = true;
            this.colsarfnumber.VisibleIndex = 16;
            // 
            // colSyndicate
            // 
            this.colSyndicate.AppearanceCell.Options.UseTextOptions = true;
            this.colSyndicate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSyndicate.AppearanceHeader.Options.UseTextOptions = true;
            this.colSyndicate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSyndicate.FieldName = "Syndicate";
            this.colSyndicate.Name = "colSyndicate";
            this.colSyndicate.Visible = true;
            this.colSyndicate.VisibleIndex = 17;
            // 
            // colSubCommitte
            // 
            this.colSubCommitte.AppearanceCell.Options.UseTextOptions = true;
            this.colSubCommitte.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSubCommitte.AppearanceHeader.Options.UseTextOptions = true;
            this.colSubCommitte.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSubCommitte.FieldName = "SubCommitte";
            this.colSubCommitte.Name = "colSubCommitte";
            this.colSubCommitte.Visible = true;
            this.colSubCommitte.VisibleIndex = 18;
            this.colSubCommitte.Width = 85;
            // 
            // colMMashatName1
            // 
            this.colMMashatName1.FieldName = "MMashatName";
            this.colMMashatName1.Name = "colMMashatName1";
            this.colMMashatName1.Visible = true;
            this.colMMashatName1.VisibleIndex = 19;
            // 
            // colActivate
            // 
            this.colActivate.AppearanceCell.Options.UseTextOptions = true;
            this.colActivate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colActivate.AppearanceHeader.Options.UseTextOptions = true;
            this.colActivate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colActivate.Caption = "Activate";
            this.colActivate.FieldName = "Activate";
            this.colActivate.Name = "colActivate";
            this.colActivate.Visible = true;
            this.colActivate.VisibleIndex = 20;
            // 
            // repositoryItemDateEditDate
            // 
            this.repositoryItemDateEditDate.AutoHeight = false;
            this.repositoryItemDateEditDate.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEditDate.DisplayFormat.FormatString = "u";
            this.repositoryItemDateEditDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEditDate.Mask.EditMask = "u";
            this.repositoryItemDateEditDate.Name = "repositoryItemDateEditDate";
            this.repositoryItemDateEditDate.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            // 
            // repositoryItemPictureEditImg
            // 
            this.repositoryItemPictureEditImg.Name = "repositoryItemPictureEditImg";
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // repositoryItemDateEditMDY
            // 
            this.repositoryItemDateEditMDY.AutoHeight = false;
            this.repositoryItemDateEditMDY.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEditMDY.DisplayFormat.FormatString = "MM/dd/yyyy";
            this.repositoryItemDateEditMDY.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEditMDY.EditFormat.FormatString = "MM/dd/yyyy";
            this.repositoryItemDateEditMDY.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEditMDY.Mask.EditMask = "MM/dd/yyyy";
            this.repositoryItemDateEditMDY.Name = "repositoryItemDateEditMDY";
            this.repositoryItemDateEditMDY.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            // 
            // panelControlMain
            // 
            this.panelControlMain.Controls.Add(this.LUETBLDofatSarf);
            this.panelControlMain.Controls.Add(this.labelControl7);
            this.panelControlMain.Controls.Add(this.btnSaveBackData);
            this.panelControlMain.Controls.Add(this.btnPrintExport);
            this.panelControlMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControlMain.Location = new System.Drawing.Point(0, 0);
            this.panelControlMain.Name = "panelControlMain";
            this.panelControlMain.Size = new System.Drawing.Size(1353, 63);
            this.panelControlMain.TabIndex = 3;
            // 
            // LUETBLDofatSarf
            // 
            this.LUETBLDofatSarf.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LUETBLDofatSarf.Location = new System.Drawing.Point(1070, 20);
            this.LUETBLDofatSarf.Name = "LUETBLDofatSarf";
            this.LUETBLDofatSarf.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.LUETBLDofatSarf.Properties.Appearance.Options.UseFont = true;
            this.LUETBLDofatSarf.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LUETBLDofatSarf.Properties.DataSource = this.LSMSTBLDofatSarf;
            this.LUETBLDofatSarf.Properties.DisplayMember = "DofatSarf";
            this.LUETBLDofatSarf.Properties.NullText = "";
            this.LUETBLDofatSarf.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.LUETBLDofatSarf.Properties.ValueMember = "DofatSarfId";
            this.LUETBLDofatSarf.Properties.View = this.gridLookUpEdit1View;
            this.LUETBLDofatSarf.Size = new System.Drawing.Size(236, 22);
            this.LUETBLDofatSarf.TabIndex = 2;
            this.LUETBLDofatSarf.EditValueChanged += new System.EventHandler(this.LUETBLDofatSarf_EditValueChanged);
            // 
            // LSMSTBLDofatSarf
            // 
            this.LSMSTBLDofatSarf.ElementType = typeof(RetirementCenter.DataSources.Linq.TBLDofatSarf);
            this.LSMSTBLDofatSarf.KeyExpression = "[DofatSarfId]";
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDofatSarf});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colDofatSarf
            // 
            this.colDofatSarf.AppearanceCell.Options.UseTextOptions = true;
            this.colDofatSarf.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDofatSarf.AppearanceHeader.Options.UseTextOptions = true;
            this.colDofatSarf.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDofatSarf.Caption = "اسم الدفعة";
            this.colDofatSarf.FieldName = "DofatSarf";
            this.colDofatSarf.Name = "colDofatSarf";
            this.colDofatSarf.Visible = true;
            this.colDofatSarf.VisibleIndex = 0;
            // 
            // labelControl7
            // 
            this.labelControl7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelControl7.Location = new System.Drawing.Point(1312, 23);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(29, 13);
            this.labelControl7.TabIndex = 3;
            this.labelControl7.Text = "الدفعة";
            // 
            // btnSaveBackData
            // 
            this.btnSaveBackData.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSaveBackData.Image = global::RetirementCenter.Properties.Resources.save_16x16;
            this.btnSaveBackData.Location = new System.Drawing.Point(12, 34);
            this.btnSaveBackData.Name = "btnSaveBackData";
            this.btnSaveBackData.Size = new System.Drawing.Size(134, 23);
            this.btnSaveBackData.TabIndex = 0;
            this.btnSaveBackData.Text = "حفظ بيانات البنك";
            this.btnSaveBackData.Click += new System.EventHandler(this.btnSaveBackData_Click);
            // 
            // btnPrintExport
            // 
            this.btnPrintExport.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnPrintExport.Location = new System.Drawing.Point(12, 5);
            this.btnPrintExport.Name = "btnPrintExport";
            this.btnPrintExport.Size = new System.Drawing.Size(134, 23);
            this.btnPrintExport.TabIndex = 0;
            this.btnPrintExport.Text = "طباعه و تصدير";
            this.btnPrintExport.Click += new System.EventHandler(this.btnPrintExport_Click);
            // 
            // vQry61TableAdapter
            // 
            this.vQry61TableAdapter.ClearBeforeFill = true;
            // 
            // Qry61Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1353, 462);
            this.Controls.Add(this.panelControlMain);
            this.Controls.Add(this.gridControlData);
            this.Name = "Qry61Frm";
            this.Text = "بيانات دفعات الاعضاء للبنك";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Qry06Frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vQry61BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsQueries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDate.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEditImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditMDY.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditMDY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlMain)).EndInit();
            this.panelControlMain.ResumeLayout(false);
            this.panelControlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LUETBLDofatSarf.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSTBLDofatSarf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlData;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewData;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEditDate;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEditImg;
        private DevExpress.XtraEditors.PanelControl panelControlMain;
        private DevExpress.XtraEditors.SimpleButton btnPrintExport;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEditMDY;
        private DataSources.dsQueries dsQueries;
        private DevExpress.XtraEditors.SimpleButton btnSaveBackData;
        private DevExpress.XtraEditors.GridLookUpEdit LUETBLDofatSarf;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colDofatSarf;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.Data.Linq.LinqServerModeSource LSMSTBLDofatSarf;
        private System.Windows.Forms.BindingSource vQry61BindingSource;
        private DataSources.dsQueriesTableAdapters.vQry61TableAdapter vQry61TableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colMMashatId;
        private DevExpress.XtraGrid.Columns.GridColumn colvisanumber;
        private DevExpress.XtraGrid.Columns.GridColumn colSyndicateId;
        private DevExpress.XtraGrid.Columns.GridColumn colSubCommitteId;
        private DevExpress.XtraGrid.Columns.GridColumn colsummony;
        private DevExpress.XtraGrid.Columns.GridColumn colsendbankdate;
        private DevExpress.XtraGrid.Columns.GridColumn colamanatmony;
        private DevExpress.XtraGrid.Columns.GridColumn colamanatwareddate;
        private DevExpress.XtraGrid.Columns.GridColumn coldatein;
        private DevExpress.XtraGrid.Columns.GridColumn coluserin;
        private DevExpress.XtraGrid.Columns.GridColumn colMMashatName;
        private DevExpress.XtraGrid.Columns.GridColumn colsarfnumber;
        private DevExpress.XtraGrid.Columns.GridColumn colSyndicate;
        private DevExpress.XtraGrid.Columns.GridColumn colSubCommitte;
        private DevExpress.XtraGrid.Columns.GridColumn colAction;
        private DevExpress.XtraGrid.Columns.GridColumn colCurrency;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn colMMashatNId;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn colMMashatName1;
        private DevExpress.XtraGrid.Columns.GridColumn colActivate;

    }
}