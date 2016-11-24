namespace RetirementCenter
{
    partial class Qry108Frm
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
            this.components = new System.ComponentModel.Container();
            this.gridControlData = new DevExpress.XtraGrid.GridControl();
            this.vQry108BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsQueries = new RetirementCenter.DataSources.dsQueries();
            this.gridViewData = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAutoId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMMashatId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colamanatmony = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colamanatrem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldatein = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colestktaa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmostahek = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsefa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colaccReview = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldateReview = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colamantvisa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsarfcheek = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcheekno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltasleemdate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmostlemsheek = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldatincheek = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDofatSarf = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMMashatName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsarfnumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSyndicate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubCommitte = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coluserin_RealName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colaccuser_RealName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colusercheek_RealName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colarshef = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEditn2 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemDateEditYMD = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.btnPrintExport = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciPrint = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.vQry108TableAdapter = new RetirementCenter.DataSources.dsQueriesTableAdapters.vQry108TableAdapter();
            this.colDofatSarfAId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDofatSarfA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDofatSarfId = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vQry108BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsQueries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEditn2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditYMD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditYMD.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlData
            // 
            this.gridControlData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlData.DataSource = this.vQry108BindingSource;
            this.gridControlData.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControlData.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControlData.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControlData.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gridControlData.EmbeddedNavigator.TextStringFormat = "صف {0} من {1}";
            this.gridControlData.Location = new System.Drawing.Point(12, 38);
            this.gridControlData.MainView = this.gridViewData;
            this.gridControlData.Name = "gridControlData";
            this.gridControlData.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEditn2,
            this.repositoryItemDateEditYMD});
            this.gridControlData.Size = new System.Drawing.Size(710, 412);
            this.gridControlData.TabIndex = 1;
            this.gridControlData.UseEmbeddedNavigator = true;
            this.gridControlData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewData});
            // 
            // vQry108BindingSource
            // 
            this.vQry108BindingSource.DataMember = "vQry108";
            this.vQry108BindingSource.DataSource = this.dsQueries;
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
            this.colAutoId,
            this.colMMashatId,
            this.colamanatmony,
            this.colamanatrem,
            this.coldatein,
            this.colestktaa,
            this.colmostahek,
            this.colsefa,
            this.colaccReview,
            this.coldateReview,
            this.colamantvisa,
            this.colsarfcheek,
            this.colcheekno,
            this.coltasleemdate,
            this.colmostlemsheek,
            this.coldatincheek,
            this.colDofatSarf,
            this.colMMashatName,
            this.colsarfnumber,
            this.colSyndicate,
            this.colSubCommitte,
            this.coluserin_RealName,
            this.colaccuser_RealName,
            this.colusercheek_RealName,
            this.colarshef,
            this.colDofatSarfAId,
            this.colDofatSarfA,
            this.colDofatSarfId});
            this.gridViewData.GridControl = this.gridControlData;
            this.gridViewData.Name = "gridViewData";
            this.gridViewData.OptionsBehavior.ReadOnly = true;
            this.gridViewData.OptionsCustomization.AllowRowSizing = true;
            this.gridViewData.OptionsPrint.EnableAppearanceEvenRow = true;
            this.gridViewData.OptionsPrint.EnableAppearanceOddRow = true;
            this.gridViewData.OptionsView.ColumnAutoWidth = false;
            this.gridViewData.OptionsView.EnableAppearanceEvenRow = true;
            this.gridViewData.OptionsView.EnableAppearanceOddRow = true;
            this.gridViewData.OptionsView.ShowAutoFilterRow = true;
            this.gridViewData.OptionsView.ShowDetailButtons = false;
            this.gridViewData.OptionsView.ShowFooter = true;
            this.gridViewData.OptionsView.ShowGroupPanel = false;
            // 
            // colAutoId
            // 
            this.colAutoId.AppearanceCell.Options.UseTextOptions = true;
            this.colAutoId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAutoId.AppearanceHeader.Options.UseTextOptions = true;
            this.colAutoId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAutoId.Caption = "تلقائي";
            this.colAutoId.FieldName = "AutoId";
            this.colAutoId.Name = "colAutoId";
            this.colAutoId.Visible = true;
            this.colAutoId.VisibleIndex = 0;
            // 
            // colMMashatId
            // 
            this.colMMashatId.AppearanceCell.Options.UseTextOptions = true;
            this.colMMashatId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMMashatId.AppearanceHeader.Options.UseTextOptions = true;
            this.colMMashatId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMMashatId.Caption = "كود";
            this.colMMashatId.FieldName = "MMashatId";
            this.colMMashatId.Name = "colMMashatId";
            this.colMMashatId.Visible = true;
            this.colMMashatId.VisibleIndex = 3;
            // 
            // colamanatmony
            // 
            this.colamanatmony.AppearanceCell.Options.UseTextOptions = true;
            this.colamanatmony.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colamanatmony.AppearanceHeader.Options.UseTextOptions = true;
            this.colamanatmony.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colamanatmony.Caption = "مبلغ الامانات";
            this.colamanatmony.FieldName = "amanatmony";
            this.colamanatmony.Name = "colamanatmony";
            this.colamanatmony.Visible = true;
            this.colamanatmony.VisibleIndex = 9;
            this.colamanatmony.Width = 76;
            // 
            // colamanatrem
            // 
            this.colamanatrem.AppearanceCell.Options.UseTextOptions = true;
            this.colamanatrem.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colamanatrem.AppearanceHeader.Options.UseTextOptions = true;
            this.colamanatrem.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colamanatrem.Caption = "ملاحظات";
            this.colamanatrem.FieldName = "amanatrem";
            this.colamanatrem.Name = "colamanatrem";
            this.colamanatrem.Visible = true;
            this.colamanatrem.VisibleIndex = 27;
            // 
            // coldatein
            // 
            this.coldatein.AppearanceCell.Options.UseTextOptions = true;
            this.coldatein.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coldatein.AppearanceHeader.Options.UseTextOptions = true;
            this.coldatein.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coldatein.Caption = "تاريخ الادخال";
            this.coldatein.FieldName = "datein";
            this.coldatein.Name = "coldatein";
            this.coldatein.Visible = true;
            this.coldatein.VisibleIndex = 14;
            // 
            // colestktaa
            // 
            this.colestktaa.AppearanceCell.Options.UseTextOptions = true;
            this.colestktaa.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colestktaa.AppearanceHeader.Options.UseTextOptions = true;
            this.colestktaa.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colestktaa.Caption = "الاستقطاع";
            this.colestktaa.FieldName = "estktaa";
            this.colestktaa.Name = "colestktaa";
            this.colestktaa.Visible = true;
            this.colestktaa.VisibleIndex = 10;
            // 
            // colmostahek
            // 
            this.colmostahek.AppearanceCell.Options.UseTextOptions = true;
            this.colmostahek.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colmostahek.AppearanceHeader.Options.UseTextOptions = true;
            this.colmostahek.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colmostahek.Caption = "المستحق";
            this.colmostahek.FieldName = "mostahek";
            this.colmostahek.Name = "colmostahek";
            this.colmostahek.Visible = true;
            this.colmostahek.VisibleIndex = 17;
            // 
            // colsefa
            // 
            this.colsefa.AppearanceCell.Options.UseTextOptions = true;
            this.colsefa.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colsefa.AppearanceHeader.Options.UseTextOptions = true;
            this.colsefa.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colsefa.Caption = "الصفه";
            this.colsefa.FieldName = "sefa";
            this.colsefa.Name = "colsefa";
            this.colsefa.Visible = true;
            this.colsefa.VisibleIndex = 18;
            // 
            // colaccReview
            // 
            this.colaccReview.AppearanceCell.Options.UseTextOptions = true;
            this.colaccReview.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colaccReview.AppearanceHeader.Options.UseTextOptions = true;
            this.colaccReview.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colaccReview.Caption = "مراجعة الحسابات";
            this.colaccReview.FieldName = "accReview";
            this.colaccReview.Name = "colaccReview";
            this.colaccReview.Visible = true;
            this.colaccReview.VisibleIndex = 2;
            this.colaccReview.Width = 98;
            // 
            // coldateReview
            // 
            this.coldateReview.AppearanceCell.Options.UseTextOptions = true;
            this.coldateReview.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coldateReview.AppearanceHeader.Options.UseTextOptions = true;
            this.coldateReview.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coldateReview.Caption = "تاريخ مراجعة الحسابات";
            this.coldateReview.FieldName = "dateReview";
            this.coldateReview.Name = "coldateReview";
            this.coldateReview.Visible = true;
            this.coldateReview.VisibleIndex = 16;
            this.coldateReview.Width = 122;
            // 
            // colamantvisa
            // 
            this.colamantvisa.AppearanceCell.Options.UseTextOptions = true;
            this.colamantvisa.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colamantvisa.AppearanceHeader.Options.UseTextOptions = true;
            this.colamantvisa.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colamantvisa.Caption = "امانات فيزا";
            this.colamantvisa.FieldName = "amantvisa";
            this.colamantvisa.Name = "colamantvisa";
            this.colamantvisa.Visible = true;
            this.colamantvisa.VisibleIndex = 11;
            // 
            // colsarfcheek
            // 
            this.colsarfcheek.AppearanceCell.Options.UseTextOptions = true;
            this.colsarfcheek.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colsarfcheek.AppearanceHeader.Options.UseTextOptions = true;
            this.colsarfcheek.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colsarfcheek.Caption = "يصرف بشيك";
            this.colsarfcheek.FieldName = "sarfcheek";
            this.colsarfcheek.Name = "colsarfcheek";
            this.colsarfcheek.Visible = true;
            this.colsarfcheek.VisibleIndex = 12;
            this.colsarfcheek.Width = 77;
            // 
            // colcheekno
            // 
            this.colcheekno.AppearanceCell.Options.UseTextOptions = true;
            this.colcheekno.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colcheekno.AppearanceHeader.Options.UseTextOptions = true;
            this.colcheekno.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colcheekno.Caption = "رقم الشيك";
            this.colcheekno.FieldName = "cheekno";
            this.colcheekno.Name = "colcheekno";
            this.colcheekno.Visible = true;
            this.colcheekno.VisibleIndex = 19;
            // 
            // coltasleemdate
            // 
            this.coltasleemdate.AppearanceCell.Options.UseTextOptions = true;
            this.coltasleemdate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coltasleemdate.AppearanceHeader.Options.UseTextOptions = true;
            this.coltasleemdate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coltasleemdate.Caption = "تاريخ التسليم";
            this.coltasleemdate.FieldName = "tasleemdate";
            this.coltasleemdate.Name = "coltasleemdate";
            this.coltasleemdate.Visible = true;
            this.coltasleemdate.VisibleIndex = 20;
            this.coltasleemdate.Width = 81;
            // 
            // colmostlemsheek
            // 
            this.colmostlemsheek.AppearanceCell.Options.UseTextOptions = true;
            this.colmostlemsheek.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colmostlemsheek.AppearanceHeader.Options.UseTextOptions = true;
            this.colmostlemsheek.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colmostlemsheek.Caption = "المستلم";
            this.colmostlemsheek.FieldName = "mostlemsheek";
            this.colmostlemsheek.Name = "colmostlemsheek";
            this.colmostlemsheek.Visible = true;
            this.colmostlemsheek.VisibleIndex = 21;
            // 
            // coldatincheek
            // 
            this.coldatincheek.AppearanceCell.Options.UseTextOptions = true;
            this.coldatincheek.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coldatincheek.AppearanceHeader.Options.UseTextOptions = true;
            this.coldatincheek.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coldatincheek.Caption = "تاريخ الاستلام";
            this.coldatincheek.FieldName = "datincheek";
            this.coldatincheek.Name = "coldatincheek";
            this.coldatincheek.Visible = true;
            this.coldatincheek.VisibleIndex = 22;
            this.coldatincheek.Width = 83;
            // 
            // colDofatSarf
            // 
            this.colDofatSarf.AppearanceCell.Options.UseTextOptions = true;
            this.colDofatSarf.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDofatSarf.AppearanceHeader.Options.UseTextOptions = true;
            this.colDofatSarf.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDofatSarf.Caption = "الدفعة";
            this.colDofatSarf.FieldName = "DofatSarf";
            this.colDofatSarf.Name = "colDofatSarf";
            this.colDofatSarf.Visible = true;
            this.colDofatSarf.VisibleIndex = 8;
            // 
            // colMMashatName
            // 
            this.colMMashatName.AppearanceCell.Options.UseTextOptions = true;
            this.colMMashatName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMMashatName.AppearanceHeader.Options.UseTextOptions = true;
            this.colMMashatName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMMashatName.Caption = "الاسم";
            this.colMMashatName.FieldName = "MMashatName";
            this.colMMashatName.Name = "colMMashatName";
            this.colMMashatName.Visible = true;
            this.colMMashatName.VisibleIndex = 4;
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
            this.colsarfnumber.VisibleIndex = 23;
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
            this.colSyndicate.VisibleIndex = 24;
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
            this.colSubCommitte.VisibleIndex = 25;
            // 
            // coluserin_RealName
            // 
            this.coluserin_RealName.AppearanceCell.Options.UseTextOptions = true;
            this.coluserin_RealName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coluserin_RealName.AppearanceHeader.Options.UseTextOptions = true;
            this.coluserin_RealName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coluserin_RealName.Caption = "مسئول الادخال";
            this.coluserin_RealName.FieldName = "userin_RealName";
            this.coluserin_RealName.Name = "coluserin_RealName";
            this.coluserin_RealName.Visible = true;
            this.coluserin_RealName.VisibleIndex = 13;
            this.coluserin_RealName.Width = 88;
            // 
            // colaccuser_RealName
            // 
            this.colaccuser_RealName.AppearanceCell.Options.UseTextOptions = true;
            this.colaccuser_RealName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colaccuser_RealName.AppearanceHeader.Options.UseTextOptions = true;
            this.colaccuser_RealName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colaccuser_RealName.Caption = "مسئول الحسابات";
            this.colaccuser_RealName.FieldName = "accuser_RealName";
            this.colaccuser_RealName.Name = "colaccuser_RealName";
            this.colaccuser_RealName.Visible = true;
            this.colaccuser_RealName.VisibleIndex = 15;
            this.colaccuser_RealName.Width = 99;
            // 
            // colusercheek_RealName
            // 
            this.colusercheek_RealName.AppearanceCell.Options.UseTextOptions = true;
            this.colusercheek_RealName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colusercheek_RealName.AppearanceHeader.Options.UseTextOptions = true;
            this.colusercheek_RealName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colusercheek_RealName.Caption = "مسئول الشيك";
            this.colusercheek_RealName.FieldName = "usercheek_RealName";
            this.colusercheek_RealName.Name = "colusercheek_RealName";
            this.colusercheek_RealName.Visible = true;
            this.colusercheek_RealName.VisibleIndex = 26;
            this.colusercheek_RealName.Width = 87;
            // 
            // colarshef
            // 
            this.colarshef.AppearanceCell.Options.UseTextOptions = true;
            this.colarshef.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colarshef.AppearanceHeader.Options.UseTextOptions = true;
            this.colarshef.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colarshef.Caption = "الارشيف";
            this.colarshef.FieldName = "arshef";
            this.colarshef.Name = "colarshef";
            this.colarshef.OptionsColumn.ReadOnly = true;
            this.colarshef.Visible = true;
            this.colarshef.VisibleIndex = 1;
            // 
            // repositoryItemTextEditn2
            // 
            this.repositoryItemTextEditn2.AutoHeight = false;
            this.repositoryItemTextEditn2.DisplayFormat.FormatString = "n2";
            this.repositoryItemTextEditn2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemTextEditn2.EditFormat.FormatString = "n2";
            this.repositoryItemTextEditn2.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemTextEditn2.Mask.EditMask = "n2";
            this.repositoryItemTextEditn2.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.repositoryItemTextEditn2.Name = "repositoryItemTextEditn2";
            // 
            // repositoryItemDateEditYMD
            // 
            this.repositoryItemDateEditYMD.AutoHeight = false;
            this.repositoryItemDateEditYMD.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEditYMD.DisplayFormat.FormatString = "yyyy-MM-dd";
            this.repositoryItemDateEditYMD.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEditYMD.EditFormat.FormatString = "yyyy-MM-dd";
            this.repositoryItemDateEditYMD.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEditYMD.Mask.EditMask = "yyyy-MM-dd";
            this.repositoryItemDateEditYMD.Name = "repositoryItemDateEditYMD";
            this.repositoryItemDateEditYMD.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            // 
            // btnPrintExport
            // 
            this.btnPrintExport.Location = new System.Drawing.Point(12, 12);
            this.btnPrintExport.Name = "btnPrintExport";
            this.btnPrintExport.Size = new System.Drawing.Size(75, 22);
            this.btnPrintExport.StyleController = this.layoutControl1;
            this.btnPrintExport.TabIndex = 0;
            this.btnPrintExport.Text = "طباعه و تصدير";
            this.btnPrintExport.Click += new System.EventHandler(this.btnPrintExport_Click);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnPrintExport);
            this.layoutControl1.Controls.Add(this.gridControlData);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1014, 299, 369, 512);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(734, 462);
            this.layoutControl1.TabIndex = 5;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "Root";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciPrint,
            this.layoutControlItem2,
            this.emptySpaceItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(734, 462);
            this.layoutControlGroup1.Text = "Root";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // lciPrint
            // 
            this.lciPrint.Control = this.btnPrintExport;
            this.lciPrint.CustomizationFormText = "Print";
            this.lciPrint.Location = new System.Drawing.Point(0, 0);
            this.lciPrint.Name = "lciPrint";
            this.lciPrint.Size = new System.Drawing.Size(79, 26);
            this.lciPrint.Text = "Print";
            this.lciPrint.TextSize = new System.Drawing.Size(0, 0);
            this.lciPrint.TextToControlDistance = 0;
            this.lciPrint.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.gridControlData;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 26);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(714, 416);
            this.layoutControlItem2.Text = "layoutControlItem2";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextToControlDistance = 0;
            this.layoutControlItem2.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(79, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(635, 26);
            this.emptySpaceItem1.Text = "emptySpaceItem1";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // vQry108TableAdapter
            // 
            this.vQry108TableAdapter.ClearBeforeFill = true;
            // 
            // colDofatSarfAId
            // 
            this.colDofatSarfAId.AppearanceCell.Options.UseTextOptions = true;
            this.colDofatSarfAId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDofatSarfAId.AppearanceHeader.Options.UseTextOptions = true;
            this.colDofatSarfAId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDofatSarfAId.Caption = "كود دفعة الامانات";
            this.colDofatSarfAId.FieldName = "DofatSarfAId";
            this.colDofatSarfAId.Name = "colDofatSarfAId";
            this.colDofatSarfAId.Visible = true;
            this.colDofatSarfAId.VisibleIndex = 5;
            this.colDofatSarfAId.Width = 96;
            // 
            // colDofatSarfA
            // 
            this.colDofatSarfA.AppearanceCell.Options.UseTextOptions = true;
            this.colDofatSarfA.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDofatSarfA.AppearanceHeader.Options.UseTextOptions = true;
            this.colDofatSarfA.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDofatSarfA.Caption = "دفعة الامانات";
            this.colDofatSarfA.FieldName = "DofatSarfA";
            this.colDofatSarfA.Name = "colDofatSarfA";
            this.colDofatSarfA.Visible = true;
            this.colDofatSarfA.VisibleIndex = 6;
            this.colDofatSarfA.Width = 78;
            // 
            // colDofatSarfId
            // 
            this.colDofatSarfId.AppearanceCell.Options.UseTextOptions = true;
            this.colDofatSarfId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDofatSarfId.AppearanceHeader.Options.UseTextOptions = true;
            this.colDofatSarfId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDofatSarfId.Caption = "كود دفعة الصرف";
            this.colDofatSarfId.FieldName = "DofatSarfId";
            this.colDofatSarfId.Name = "colDofatSarfId";
            this.colDofatSarfId.Visible = true;
            this.colDofatSarfId.VisibleIndex = 7;
            this.colDofatSarfId.Width = 92;
            // 
            // Qry108Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 462);
            this.Controls.Add(this.layoutControl1);
            this.Name = "Qry108Frm";
            this.Text = "امانات الاعضاء";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Qry06Frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vQry108BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsQueries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEditn2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditYMD.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditYMD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPrint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlData;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewData;
        private DevExpress.XtraEditors.SimpleButton btnPrintExport;
        private DataSources.dsQueries dsQueries;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEditn2;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem lciPrint;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEditYMD;
        private System.Windows.Forms.BindingSource vQry108BindingSource;
        private DataSources.dsQueriesTableAdapters.vQry108TableAdapter vQry108TableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colAutoId;
        private DevExpress.XtraGrid.Columns.GridColumn colMMashatId;
        private DevExpress.XtraGrid.Columns.GridColumn colamanatmony;
        private DevExpress.XtraGrid.Columns.GridColumn colamanatrem;
        private DevExpress.XtraGrid.Columns.GridColumn coldatein;
        private DevExpress.XtraGrid.Columns.GridColumn colestktaa;
        private DevExpress.XtraGrid.Columns.GridColumn colmostahek;
        private DevExpress.XtraGrid.Columns.GridColumn colsefa;
        private DevExpress.XtraGrid.Columns.GridColumn colaccReview;
        private DevExpress.XtraGrid.Columns.GridColumn coldateReview;
        private DevExpress.XtraGrid.Columns.GridColumn colamantvisa;
        private DevExpress.XtraGrid.Columns.GridColumn colsarfcheek;
        private DevExpress.XtraGrid.Columns.GridColumn colcheekno;
        private DevExpress.XtraGrid.Columns.GridColumn coltasleemdate;
        private DevExpress.XtraGrid.Columns.GridColumn colmostlemsheek;
        private DevExpress.XtraGrid.Columns.GridColumn coldatincheek;
        private DevExpress.XtraGrid.Columns.GridColumn colDofatSarf;
        private DevExpress.XtraGrid.Columns.GridColumn colMMashatName;
        private DevExpress.XtraGrid.Columns.GridColumn colsarfnumber;
        private DevExpress.XtraGrid.Columns.GridColumn colSyndicate;
        private DevExpress.XtraGrid.Columns.GridColumn colSubCommitte;
        private DevExpress.XtraGrid.Columns.GridColumn coluserin_RealName;
        private DevExpress.XtraGrid.Columns.GridColumn colaccuser_RealName;
        private DevExpress.XtraGrid.Columns.GridColumn colusercheek_RealName;
        private DevExpress.XtraGrid.Columns.GridColumn colarshef;
        private DevExpress.XtraGrid.Columns.GridColumn colDofatSarfAId;
        private DevExpress.XtraGrid.Columns.GridColumn colDofatSarfA;
        private DevExpress.XtraGrid.Columns.GridColumn colDofatSarfId;

    }
}