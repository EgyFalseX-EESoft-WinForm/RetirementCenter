namespace RetirementCenter
{
    partial class Qry90Frm
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
            this.gridViewData = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnPrintExport = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lueSyn = new DevExpress.XtraEditors.LookUpEdit();
            this.LSMSSyn = new DevExpress.Data.Linq.LinqServerModeSource();
            this.dsQueries = new RetirementCenter.DataSources.dsQueries();
            this.vQry90BindingSource = new System.Windows.Forms.BindingSource();
            this.vQry90TableAdapter = new RetirementCenter.DataSources.dsQueriesTableAdapters.vQry90TableAdapter();
            this.colSubCommitteId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubCommitte = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotal_Mashat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotal_Warasa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotal_Mashat_Rasm = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotal_Warasa_Rasm = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEditn2 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lueDof = new DevExpress.XtraEditors.LookUpEdit();
            this.LSMSDof = new DevExpress.Data.Linq.LinqServerModeSource();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueSyn.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSSyn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsQueries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vQry90BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEditn2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueDof.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSDof)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlData
            // 
            this.gridControlData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlData.DataSource = this.vQry90BindingSource;
            this.gridControlData.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControlData.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControlData.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControlData.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gridControlData.EmbeddedNavigator.TextStringFormat = "صف {0} من {1}";
            this.gridControlData.Location = new System.Drawing.Point(0, 53);
            this.gridControlData.MainView = this.gridViewData;
            this.gridControlData.Name = "gridControlData";
            this.gridControlData.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEditn2});
            this.gridControlData.Size = new System.Drawing.Size(734, 404);
            this.gridControlData.TabIndex = 1;
            this.gridControlData.UseEmbeddedNavigator = true;
            this.gridControlData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewData});
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
            this.colSubCommitteId,
            this.colSubCommitte,
            this.colTotal_Mashat,
            this.colTotal_Warasa,
            this.colTotal_Mashat_Rasm,
            this.colTotal_Warasa_Rasm});
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
            this.gridViewData.OptionsView.ShowDetailButtons = false;
            this.gridViewData.OptionsView.ShowFooter = true;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.lueDof);
            this.panelControl1.Controls.Add(this.lueSyn);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.btnPrintExport);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(734, 47);
            this.panelControl1.TabIndex = 4;
            // 
            // btnPrintExport
            // 
            this.btnPrintExport.Location = new System.Drawing.Point(12, 12);
            this.btnPrintExport.Name = "btnPrintExport";
            this.btnPrintExport.Size = new System.Drawing.Size(134, 23);
            this.btnPrintExport.TabIndex = 0;
            this.btnPrintExport.Text = "طباعه و تصدير";
            this.btnPrintExport.Click += new System.EventHandler(this.btnPrintExport_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Location = new System.Drawing.Point(688, 17);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(34, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "الفرعية";
            // 
            // lueSyn
            // 
            this.lueSyn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lueSyn.Location = new System.Drawing.Point(520, 13);
            this.lueSyn.Name = "lueSyn";
            this.lueSyn.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueSyn.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Syndicate", "الاسم", 57, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.lueSyn.Properties.DataSource = this.LSMSSyn;
            this.lueSyn.Properties.DisplayMember = "Syndicate";
            this.lueSyn.Properties.NullText = "";
            this.lueSyn.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lueSyn.Properties.ValueMember = "SyndicateId";
            this.lueSyn.Size = new System.Drawing.Size(162, 20);
            this.lueSyn.TabIndex = 2;
            this.lueSyn.EditValueChanged += new System.EventHandler(this.lueSyn_EditValueChanged);
            // 
            // LSMSSyn
            // 
            this.LSMSSyn.ElementType = typeof(RetirementCenter.DataSources.Linq.CDSyndicate);
            this.LSMSSyn.KeyExpression = "[SyndicateId]";
            // 
            // dsQueries
            // 
            this.dsQueries.DataSetName = "dsQueries";
            this.dsQueries.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vQry90BindingSource
            // 
            this.vQry90BindingSource.DataMember = "vQry90";
            this.vQry90BindingSource.DataSource = this.dsQueries;
            // 
            // vQry90TableAdapter
            // 
            this.vQry90TableAdapter.ClearBeforeFill = true;
            // 
            // colSubCommitteId
            // 
            this.colSubCommitteId.AppearanceCell.Options.UseTextOptions = true;
            this.colSubCommitteId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSubCommitteId.AppearanceHeader.Options.UseTextOptions = true;
            this.colSubCommitteId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSubCommitteId.Caption = "كود";
            this.colSubCommitteId.FieldName = "SubCommitteId";
            this.colSubCommitteId.Name = "colSubCommitteId";
            this.colSubCommitteId.Visible = true;
            this.colSubCommitteId.VisibleIndex = 0;
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
            this.colSubCommitte.VisibleIndex = 1;
            this.colSubCommitte.Width = 117;
            // 
            // colTotal_Mashat
            // 
            this.colTotal_Mashat.AppearanceCell.Options.UseTextOptions = true;
            this.colTotal_Mashat.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTotal_Mashat.AppearanceHeader.Options.UseTextOptions = true;
            this.colTotal_Mashat.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTotal_Mashat.Caption = "عدد الاعضاء المسجل";
            this.colTotal_Mashat.ColumnEdit = this.repositoryItemTextEditn2;
            this.colTotal_Mashat.FieldName = "Total_Mashat";
            this.colTotal_Mashat.Name = "colTotal_Mashat";
            this.colTotal_Mashat.OptionsColumn.ReadOnly = true;
            this.colTotal_Mashat.Visible = true;
            this.colTotal_Mashat.VisibleIndex = 2;
            this.colTotal_Mashat.Width = 116;
            // 
            // colTotal_Warasa
            // 
            this.colTotal_Warasa.AppearanceCell.Options.UseTextOptions = true;
            this.colTotal_Warasa.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTotal_Warasa.AppearanceHeader.Options.UseTextOptions = true;
            this.colTotal_Warasa.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTotal_Warasa.Caption = "عدد الورثة المسجل";
            this.colTotal_Warasa.ColumnEdit = this.repositoryItemTextEditn2;
            this.colTotal_Warasa.FieldName = "Total_Warasa";
            this.colTotal_Warasa.Name = "colTotal_Warasa";
            this.colTotal_Warasa.OptionsColumn.ReadOnly = true;
            this.colTotal_Warasa.Visible = true;
            this.colTotal_Warasa.VisibleIndex = 3;
            this.colTotal_Warasa.Width = 107;
            // 
            // colTotal_Mashat_Rasm
            // 
            this.colTotal_Mashat_Rasm.AppearanceCell.Options.UseTextOptions = true;
            this.colTotal_Mashat_Rasm.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTotal_Mashat_Rasm.AppearanceHeader.Options.UseTextOptions = true;
            this.colTotal_Mashat_Rasm.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTotal_Mashat_Rasm.Caption = "قيمة الاعضاء";
            this.colTotal_Mashat_Rasm.ColumnEdit = this.repositoryItemTextEditn2;
            this.colTotal_Mashat_Rasm.FieldName = "Total_Mashat_Rasm";
            this.colTotal_Mashat_Rasm.Name = "colTotal_Mashat_Rasm";
            this.colTotal_Mashat_Rasm.OptionsColumn.ReadOnly = true;
            this.colTotal_Mashat_Rasm.Visible = true;
            this.colTotal_Mashat_Rasm.VisibleIndex = 4;
            this.colTotal_Mashat_Rasm.Width = 77;
            // 
            // colTotal_Warasa_Rasm
            // 
            this.colTotal_Warasa_Rasm.AppearanceCell.Options.UseTextOptions = true;
            this.colTotal_Warasa_Rasm.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTotal_Warasa_Rasm.AppearanceHeader.Options.UseTextOptions = true;
            this.colTotal_Warasa_Rasm.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTotal_Warasa_Rasm.Caption = "قمية الورثة";
            this.colTotal_Warasa_Rasm.ColumnEdit = this.repositoryItemTextEditn2;
            this.colTotal_Warasa_Rasm.FieldName = "Total_Warasa_Rasm";
            this.colTotal_Warasa_Rasm.Name = "colTotal_Warasa_Rasm";
            this.colTotal_Warasa_Rasm.OptionsColumn.ReadOnly = true;
            this.colTotal_Warasa_Rasm.Visible = true;
            this.colTotal_Warasa_Rasm.VisibleIndex = 5;
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
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl2.Location = new System.Drawing.Point(485, 16);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(29, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "الدفعة";
            // 
            // lueDof
            // 
            this.lueDof.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lueDof.Location = new System.Drawing.Point(317, 12);
            this.lueDof.Name = "lueDof";
            this.lueDof.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueDof.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DofatSarf", "الاسم", 57, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.lueDof.Properties.DataSource = this.LSMSDof;
            this.lueDof.Properties.DisplayMember = "DofatSarf";
            this.lueDof.Properties.NullText = "";
            this.lueDof.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lueDof.Properties.ValueMember = "DofatSarfId";
            this.lueDof.Size = new System.Drawing.Size(162, 20);
            this.lueDof.TabIndex = 2;
            this.lueDof.EditValueChanged += new System.EventHandler(this.lueSyn_EditValueChanged);
            // 
            // LSMSDof
            // 
            this.LSMSDof.ElementType = typeof(RetirementCenter.DataSources.Linq.TBLDofatSarf);
            this.LSMSDof.KeyExpression = "[DofatSarfId]";
            // 
            // Qry90Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 462);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.gridControlData);
            this.Name = "Qry90Frm";
            this.Text = "صرف الحافز - اللجنة";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Qry06Frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueSyn.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSSyn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsQueries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vQry90BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEditn2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueDof.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSDof)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlData;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewData;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnPrintExport;
        private DevExpress.XtraEditors.LookUpEdit lueSyn;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.Data.Linq.LinqServerModeSource LSMSSyn;
        private System.Windows.Forms.BindingSource vQry90BindingSource;
        private DataSources.dsQueries dsQueries;
        private DevExpress.XtraGrid.Columns.GridColumn colSubCommitteId;
        private DevExpress.XtraGrid.Columns.GridColumn colSubCommitte;
        private DevExpress.XtraGrid.Columns.GridColumn colTotal_Mashat;
        private DevExpress.XtraGrid.Columns.GridColumn colTotal_Warasa;
        private DevExpress.XtraGrid.Columns.GridColumn colTotal_Mashat_Rasm;
        private DevExpress.XtraGrid.Columns.GridColumn colTotal_Warasa_Rasm;
        private DataSources.dsQueriesTableAdapters.vQry90TableAdapter vQry90TableAdapter;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEditn2;
        private DevExpress.XtraEditors.LookUpEdit lueDof;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.Data.Linq.LinqServerModeSource LSMSDof;

    }
}