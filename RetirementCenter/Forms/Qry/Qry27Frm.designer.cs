﻿namespace RetirementCenter
{
    partial class Qry27Frm
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
            this.LSMS = new DevExpress.Data.Linq.LinqServerModeSource();
            this.gridViewData = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMMashatId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsarfdatefrom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsarfdateto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmonymonth = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colrsmmonth = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coleshtrakmonth = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colestktaa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsarf = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEdafat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMMashatName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsarfnumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDofatSarf = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSarfTypeedad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSyndicate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubCommitte = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldatein = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEditDMY = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.coluserin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdituserin = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsRetirementCenter = new RetirementCenter.DataSources.dsRetirementCenter();
            this.colCurrent_Yasref = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSendBank = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colActivate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colamanatvisa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsarfcheek = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSendBankDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoExEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit();
            this.panelControlMain = new DevExpress.XtraEditors.PanelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.tbCodeEnd = new DevExpress.XtraEditors.TextEdit();
            this.tbCodeStart = new DevExpress.XtraEditors.TextEdit();
            this.btnBank = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lueSynd = new DevExpress.XtraEditors.LookUpEdit();
            this.LSMSSyn = new DevExpress.Data.Linq.LinqServerModeSource();
            this.lueDof = new DevExpress.XtraEditors.LookUpEdit();
            this.LSMSDof = new DevExpress.Data.Linq.LinqServerModeSource();
            this.btnPrintExport = new DevExpress.XtraEditors.SimpleButton();
            this.usersTableAdapter = new RetirementCenter.DataSources.dsRetirementCenterTableAdapters.UsersTableAdapter();
            this.LueFilter = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDMY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDMY.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdituserin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRetirementCenter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoExEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlMain)).BeginInit();
            this.panelControlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbCodeEnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCodeStart.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueSynd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSSyn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueDof.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSDof)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LueFilter.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlData
            // 
            this.gridControlData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlData.DataSource = this.LSMS;
            this.gridControlData.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControlData.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControlData.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControlData.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gridControlData.EmbeddedNavigator.TextStringFormat = "صف {0} من {1}";
            this.gridControlData.Location = new System.Drawing.Point(0, 116);
            this.gridControlData.MainView = this.gridViewData;
            this.gridControlData.Name = "gridControlData";
            this.gridControlData.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEditDMY,
            this.repositoryItemMemoExEdit1,
            this.repositoryItemLookUpEdituserin});
            this.gridControlData.Size = new System.Drawing.Size(734, 341);
            this.gridControlData.TabIndex = 4;
            this.gridControlData.UseEmbeddedNavigator = true;
            this.gridControlData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewData});
            // 
            // LSMS
            // 
            this.LSMS.ElementType = typeof(RetirementCenter.DataSources.Linq.vQry27);
            this.LSMS.KeyExpression = "MMashatId;DofatSarfId;SarfTypeedadId";
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
            this.colsarfdatefrom,
            this.colsarfdateto,
            this.colmonymonth,
            this.colrsmmonth,
            this.coleshtrakmonth,
            this.colestktaa,
            this.colsarf,
            this.colEdafat,
            this.colMMashatName,
            this.colsarfnumber,
            this.colDofatSarf,
            this.colSarfTypeedad,
            this.colSyndicate,
            this.colSubCommitte,
            this.coldatein,
            this.coluserin,
            this.colCurrent_Yasref,
            this.colSendBank,
            this.colActivate,
            this.colamanatvisa,
            this.colsarfcheek,
            this.colSendBankDate});
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
            this.colMMashatId.Caption = "كود العضو";
            this.colMMashatId.FieldName = "MMashatId";
            this.colMMashatId.Name = "colMMashatId";
            this.colMMashatId.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Equals;
            this.colMMashatId.Visible = true;
            this.colMMashatId.VisibleIndex = 0;
            // 
            // colsarfdatefrom
            // 
            this.colsarfdatefrom.AppearanceCell.Options.UseTextOptions = true;
            this.colsarfdatefrom.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colsarfdatefrom.AppearanceHeader.Options.UseTextOptions = true;
            this.colsarfdatefrom.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colsarfdatefrom.Caption = "من";
            this.colsarfdatefrom.FieldName = "sarfdatefrom";
            this.colsarfdatefrom.Name = "colsarfdatefrom";
            this.colsarfdatefrom.Visible = true;
            this.colsarfdatefrom.VisibleIndex = 4;
            // 
            // colsarfdateto
            // 
            this.colsarfdateto.AppearanceCell.Options.UseTextOptions = true;
            this.colsarfdateto.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colsarfdateto.AppearanceHeader.Options.UseTextOptions = true;
            this.colsarfdateto.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colsarfdateto.Caption = "الي";
            this.colsarfdateto.FieldName = "sarfdateto";
            this.colsarfdateto.Name = "colsarfdateto";
            this.colsarfdateto.Visible = true;
            this.colsarfdateto.VisibleIndex = 5;
            // 
            // colmonymonth
            // 
            this.colmonymonth.AppearanceCell.Options.UseTextOptions = true;
            this.colmonymonth.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colmonymonth.AppearanceHeader.Options.UseTextOptions = true;
            this.colmonymonth.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colmonymonth.Caption = "المبلغ";
            this.colmonymonth.FieldName = "monymonth";
            this.colmonymonth.Name = "colmonymonth";
            this.colmonymonth.Visible = true;
            this.colmonymonth.VisibleIndex = 6;
            // 
            // colrsmmonth
            // 
            this.colrsmmonth.AppearanceCell.Options.UseTextOptions = true;
            this.colrsmmonth.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colrsmmonth.AppearanceHeader.Options.UseTextOptions = true;
            this.colrsmmonth.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colrsmmonth.Caption = "رسم";
            this.colrsmmonth.FieldName = "rsmmonth";
            this.colrsmmonth.Name = "colrsmmonth";
            this.colrsmmonth.Visible = true;
            this.colrsmmonth.VisibleIndex = 7;
            // 
            // coleshtrakmonth
            // 
            this.coleshtrakmonth.AppearanceCell.Options.UseTextOptions = true;
            this.coleshtrakmonth.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coleshtrakmonth.AppearanceHeader.Options.UseTextOptions = true;
            this.coleshtrakmonth.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coleshtrakmonth.Caption = "اشتراك";
            this.coleshtrakmonth.FieldName = "eshtrakmonth";
            this.coleshtrakmonth.Name = "coleshtrakmonth";
            this.coleshtrakmonth.Visible = true;
            this.coleshtrakmonth.VisibleIndex = 8;
            // 
            // colestktaa
            // 
            this.colestktaa.AppearanceCell.Options.UseTextOptions = true;
            this.colestktaa.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colestktaa.AppearanceHeader.Options.UseTextOptions = true;
            this.colestktaa.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colestktaa.Caption = "استقطاع";
            this.colestktaa.FieldName = "estktaa";
            this.colestktaa.Name = "colestktaa";
            this.colestktaa.Visible = true;
            this.colestktaa.VisibleIndex = 9;
            // 
            // colsarf
            // 
            this.colsarf.AppearanceCell.Options.UseTextOptions = true;
            this.colsarf.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colsarf.AppearanceHeader.Options.UseTextOptions = true;
            this.colsarf.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colsarf.Caption = "يصرف";
            this.colsarf.FieldName = "sarf";
            this.colsarf.Name = "colsarf";
            this.colsarf.Visible = true;
            this.colsarf.VisibleIndex = 10;
            // 
            // colEdafat
            // 
            this.colEdafat.AppearanceCell.Options.UseTextOptions = true;
            this.colEdafat.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEdafat.AppearanceHeader.Options.UseTextOptions = true;
            this.colEdafat.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEdafat.Caption = "اضافات";
            this.colEdafat.FieldName = "Edafat";
            this.colEdafat.Name = "colEdafat";
            this.colEdafat.Visible = true;
            this.colEdafat.VisibleIndex = 11;
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
            this.colMMashatName.VisibleIndex = 1;
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
            this.colsarfnumber.VisibleIndex = 12;
            // 
            // colDofatSarf
            // 
            this.colDofatSarf.AppearanceCell.Options.UseTextOptions = true;
            this.colDofatSarf.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDofatSarf.AppearanceHeader.Options.UseTextOptions = true;
            this.colDofatSarf.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDofatSarf.Caption = "الدفعه";
            this.colDofatSarf.FieldName = "DofatSarf";
            this.colDofatSarf.Name = "colDofatSarf";
            this.colDofatSarf.Visible = true;
            this.colDofatSarf.VisibleIndex = 2;
            // 
            // colSarfTypeedad
            // 
            this.colSarfTypeedad.AppearanceCell.Options.UseTextOptions = true;
            this.colSarfTypeedad.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSarfTypeedad.AppearanceHeader.Options.UseTextOptions = true;
            this.colSarfTypeedad.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSarfTypeedad.Caption = "نوع الصرف";
            this.colSarfTypeedad.FieldName = "SarfTypeedad";
            this.colSarfTypeedad.Name = "colSarfTypeedad";
            this.colSarfTypeedad.Visible = true;
            this.colSarfTypeedad.VisibleIndex = 3;
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
            this.colSyndicate.VisibleIndex = 13;
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
            this.colSubCommitte.VisibleIndex = 14;
            // 
            // coldatein
            // 
            this.coldatein.AppearanceCell.Options.UseTextOptions = true;
            this.coldatein.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coldatein.AppearanceHeader.Options.UseTextOptions = true;
            this.coldatein.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coldatein.Caption = "تاريخ الادخال";
            this.coldatein.ColumnEdit = this.repositoryItemDateEditDMY;
            this.coldatein.FieldName = "datein";
            this.coldatein.Name = "coldatein";
            this.coldatein.Visible = true;
            this.coldatein.VisibleIndex = 15;
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
            this.coluserin.Visible = true;
            this.coluserin.VisibleIndex = 16;
            // 
            // repositoryItemLookUpEdituserin
            // 
            this.repositoryItemLookUpEdituserin.AutoHeight = false;
            this.repositoryItemLookUpEdituserin.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdituserin.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("UserID", "User ID", 59, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("RealName", "Real Name", 61, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.repositoryItemLookUpEdituserin.DataSource = this.usersBindingSource;
            this.repositoryItemLookUpEdituserin.DisplayMember = "RealName";
            this.repositoryItemLookUpEdituserin.Name = "repositoryItemLookUpEdituserin";
            this.repositoryItemLookUpEdituserin.NullText = "";
            this.repositoryItemLookUpEdituserin.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemLookUpEdituserin.ValueMember = "UserID";
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
            // colCurrent_Yasref
            // 
            this.colCurrent_Yasref.AppearanceCell.Options.UseTextOptions = true;
            this.colCurrent_Yasref.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCurrent_Yasref.AppearanceHeader.Options.UseTextOptions = true;
            this.colCurrent_Yasref.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCurrent_Yasref.Caption = "يصرف حاليا";
            this.colCurrent_Yasref.FieldName = "Current_Yasref";
            this.colCurrent_Yasref.Name = "colCurrent_Yasref";
            this.colCurrent_Yasref.Visible = true;
            this.colCurrent_Yasref.VisibleIndex = 17;
            // 
            // colSendBank
            // 
            this.colSendBank.AppearanceCell.Options.UseTextOptions = true;
            this.colSendBank.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSendBank.AppearanceHeader.Options.UseTextOptions = true;
            this.colSendBank.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSendBank.Caption = "تم الاعداد";
            this.colSendBank.FieldName = "SendBank";
            this.colSendBank.Name = "colSendBank";
            this.colSendBank.Visible = true;
            this.colSendBank.VisibleIndex = 18;
            // 
            // colActivate
            // 
            this.colActivate.AppearanceCell.Options.UseTextOptions = true;
            this.colActivate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colActivate.AppearanceHeader.Options.UseTextOptions = true;
            this.colActivate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colActivate.Caption = "مفعل";
            this.colActivate.FieldName = "Activate";
            this.colActivate.Name = "colActivate";
            this.colActivate.Visible = true;
            this.colActivate.VisibleIndex = 19;
            // 
            // colamanatvisa
            // 
            this.colamanatvisa.AppearanceCell.Options.UseTextOptions = true;
            this.colamanatvisa.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colamanatvisa.AppearanceHeader.Options.UseTextOptions = true;
            this.colamanatvisa.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colamanatvisa.Caption = "امانات فيزا";
            this.colamanatvisa.FieldName = "amanatvisa";
            this.colamanatvisa.Name = "colamanatvisa";
            this.colamanatvisa.Visible = true;
            this.colamanatvisa.VisibleIndex = 20;
            // 
            // colsarfcheek
            // 
            this.colsarfcheek.AppearanceCell.Options.UseTextOptions = true;
            this.colsarfcheek.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colsarfcheek.AppearanceHeader.Options.UseTextOptions = true;
            this.colsarfcheek.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colsarfcheek.Caption = "شيك";
            this.colsarfcheek.FieldName = "sarfcheek";
            this.colsarfcheek.Name = "colsarfcheek";
            this.colsarfcheek.Visible = true;
            this.colsarfcheek.VisibleIndex = 21;
            // 
            // colSendBankDate
            // 
            this.colSendBankDate.AppearanceCell.Options.UseTextOptions = true;
            this.colSendBankDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSendBankDate.AppearanceHeader.Options.UseTextOptions = true;
            this.colSendBankDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSendBankDate.Caption = "تاريخ";
            this.colSendBankDate.FieldName = "SendBankDate";
            this.colSendBankDate.Name = "colSendBankDate";
            this.colSendBankDate.Visible = true;
            this.colSendBankDate.VisibleIndex = 22;
            // 
            // repositoryItemMemoExEdit1
            // 
            this.repositoryItemMemoExEdit1.AutoHeight = false;
            this.repositoryItemMemoExEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemMemoExEdit1.Name = "repositoryItemMemoExEdit1";
            // 
            // panelControlMain
            // 
            this.panelControlMain.Controls.Add(this.labelControl4);
            this.panelControlMain.Controls.Add(this.labelControl3);
            this.panelControlMain.Controls.Add(this.tbCodeEnd);
            this.panelControlMain.Controls.Add(this.tbCodeStart);
            this.panelControlMain.Controls.Add(this.btnBank);
            this.panelControlMain.Controls.Add(this.labelControl2);
            this.panelControlMain.Controls.Add(this.labelControl1);
            this.panelControlMain.Controls.Add(this.lueSynd);
            this.panelControlMain.Controls.Add(this.LueFilter);
            this.panelControlMain.Controls.Add(this.lueDof);
            this.panelControlMain.Controls.Add(this.btnPrintExport);
            this.panelControlMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControlMain.Location = new System.Drawing.Point(0, 0);
            this.panelControlMain.Name = "panelControlMain";
            this.panelControlMain.Size = new System.Drawing.Size(734, 110);
            this.panelControlMain.TabIndex = 0;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(232, 88);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(35, 13);
            this.labelControl4.TabIndex = 5;
            this.labelControl4.Text = "الي كود";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(232, 64);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(32, 13);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "من كود";
            // 
            // tbCodeEnd
            // 
            this.tbCodeEnd.Location = new System.Drawing.Point(100, 85);
            this.tbCodeEnd.Name = "tbCodeEnd";
            this.tbCodeEnd.Properties.DisplayFormat.FormatString = "n0";
            this.tbCodeEnd.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.tbCodeEnd.Properties.EditFormat.FormatString = "n0";
            this.tbCodeEnd.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.tbCodeEnd.Properties.Mask.EditMask = "n0";
            this.tbCodeEnd.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.tbCodeEnd.Size = new System.Drawing.Size(125, 20);
            this.tbCodeEnd.TabIndex = 4;
            // 
            // tbCodeStart
            // 
            this.tbCodeStart.Location = new System.Drawing.Point(100, 61);
            this.tbCodeStart.Name = "tbCodeStart";
            this.tbCodeStart.Properties.DisplayFormat.FormatString = "n0";
            this.tbCodeStart.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.tbCodeStart.Properties.EditFormat.FormatString = "n0";
            this.tbCodeStart.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.tbCodeStart.Properties.Mask.EditMask = "n0";
            this.tbCodeStart.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.tbCodeStart.Size = new System.Drawing.Size(125, 20);
            this.tbCodeStart.TabIndex = 3;
            // 
            // btnBank
            // 
            this.btnBank.Location = new System.Drawing.Point(12, 6);
            this.btnBank.Name = "btnBank";
            this.btnBank.Size = new System.Drawing.Size(75, 49);
            this.btnBank.TabIndex = 5;
            this.btnBank.Text = "اعداد البنك";
            this.btnBank.Click += new System.EventHandler(this.btnBank_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(232, 38);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(34, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "الفرعية";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(237, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(29, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "الدفعة";
            // 
            // lueSynd
            // 
            this.lueSynd.Location = new System.Drawing.Point(100, 35);
            this.lueSynd.Name = "lueSynd";
            this.lueSynd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueSynd.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Syndicate", "الاسم", 57, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.lueSynd.Properties.DataSource = this.LSMSSyn;
            this.lueSynd.Properties.DisplayMember = "Syndicate";
            this.lueSynd.Properties.NullText = "";
            this.lueSynd.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lueSynd.Properties.ValueMember = "SyndicateId";
            this.lueSynd.Size = new System.Drawing.Size(125, 20);
            this.lueSynd.TabIndex = 2;
            // 
            // LSMSSyn
            // 
            this.LSMSSyn.ElementType = typeof(RetirementCenter.DataSources.Linq.CDSyndicate);
            this.LSMSSyn.KeyExpression = "[SyndicateId]";
            // 
            // lueDof
            // 
            this.lueDof.Location = new System.Drawing.Point(100, 9);
            this.lueDof.Name = "lueDof";
            this.lueDof.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueDof.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DofatSarf", "الاسم", 61, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.lueDof.Properties.DataSource = this.LSMSDof;
            this.lueDof.Properties.DisplayMember = "DofatSarf";
            this.lueDof.Properties.NullText = "";
            this.lueDof.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lueDof.Properties.ValueMember = "DofatSarfId";
            this.lueDof.Size = new System.Drawing.Size(125, 20);
            this.lueDof.TabIndex = 1;
            // 
            // LSMSDof
            // 
            this.LSMSDof.ElementType = typeof(RetirementCenter.DataSources.Linq.TBLDofatSarf);
            this.LSMSDof.KeyExpression = "[DofatSarfId]";
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
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // LueFilter
            // 
            this.LueFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LueFilter.Location = new System.Drawing.Point(588, 41);
            this.LueFilter.Name = "LueFilter";
            this.LueFilter.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LueFilter.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DofatSarf", "الاسم", 61, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.LueFilter.Properties.DataSource = this.LSMSDof;
            this.LueFilter.Properties.DisplayMember = "DofatSarf";
            this.LueFilter.Properties.NullText = "";
            this.LueFilter.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.LueFilter.Properties.ValueMember = "DofatSarfId";
            this.LueFilter.Size = new System.Drawing.Size(134, 20);
            this.LueFilter.TabIndex = 1;
            this.LueFilter.EditValueChanged += new System.EventHandler(this.LueFilter_EditValueChanged);
            // 
            // Qry27Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 462);
            this.Controls.Add(this.panelControlMain);
            this.Controls.Add(this.gridControlData);
            this.Name = "Qry27Frm";
            this.Text = "ارشيف صرف الاعضاء";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Qry06Frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDMY.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDMY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdituserin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRetirementCenter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoExEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlMain)).EndInit();
            this.panelControlMain.ResumeLayout(false);
            this.panelControlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbCodeEnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCodeStart.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueSynd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSSyn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueDof.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSDof)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LueFilter.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlData;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewData;
        private DevExpress.XtraEditors.PanelControl panelControlMain;
        private DevExpress.XtraEditors.SimpleButton btnPrintExport;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEditDMY;
        private DevExpress.Data.Linq.LinqServerModeSource LSMS;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit repositoryItemMemoExEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colMMashatId;
        private DevExpress.XtraGrid.Columns.GridColumn colsarfdatefrom;
        private DevExpress.XtraGrid.Columns.GridColumn colsarfdateto;
        private DevExpress.XtraGrid.Columns.GridColumn colmonymonth;
        private DevExpress.XtraGrid.Columns.GridColumn colrsmmonth;
        private DevExpress.XtraGrid.Columns.GridColumn coleshtrakmonth;
        private DevExpress.XtraGrid.Columns.GridColumn colestktaa;
        private DevExpress.XtraGrid.Columns.GridColumn colsarf;
        private DevExpress.XtraGrid.Columns.GridColumn colEdafat;
        private DevExpress.XtraGrid.Columns.GridColumn colMMashatName;
        private DevExpress.XtraGrid.Columns.GridColumn colsarfnumber;
        private DevExpress.XtraGrid.Columns.GridColumn colDofatSarf;
        private DevExpress.XtraGrid.Columns.GridColumn colSarfTypeedad;
        private DevExpress.XtraGrid.Columns.GridColumn colSyndicate;
        private DevExpress.XtraGrid.Columns.GridColumn colSubCommitte;
        private DevExpress.XtraGrid.Columns.GridColumn coldatein;
        private DevExpress.XtraGrid.Columns.GridColumn coluserin;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdituserin;
        private DataSources.dsRetirementCenter dsRetirementCenter;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private DataSources.dsRetirementCenterTableAdapters.UsersTableAdapter usersTableAdapter;
        private DevExpress.XtraEditors.SimpleButton btnBank;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LookUpEdit lueSynd;
        private DevExpress.XtraEditors.LookUpEdit lueDof;
        private DevExpress.Data.Linq.LinqServerModeSource LSMSDof;
        private DevExpress.Data.Linq.LinqServerModeSource LSMSSyn;
        private DevExpress.XtraGrid.Columns.GridColumn colCurrent_Yasref;
        private DevExpress.XtraGrid.Columns.GridColumn colSendBank;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit tbCodeEnd;
        private DevExpress.XtraEditors.TextEdit tbCodeStart;
        private DevExpress.XtraGrid.Columns.GridColumn colActivate;
        private DevExpress.XtraGrid.Columns.GridColumn colamanatvisa;
        private DevExpress.XtraGrid.Columns.GridColumn colsarfcheek;
        private DevExpress.XtraGrid.Columns.GridColumn colSendBankDate;
        private DevExpress.XtraEditors.LookUpEdit LueFilter;

    }
}