namespace RetirementCenter.Forms.Data
{
    partial class TblMemberAmanatPrintFrm
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.ceCheckAll = new DevExpress.XtraEditors.CheckEdit();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.gridControlMain = new DevExpress.XtraGrid.GridControl();
            this.rep24ABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsReports = new RetirementCenter.DataSources.dsReports();
            this.gridViewMain = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colamanatmony = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colestktaa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmostahek = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsefa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDofatSarf = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSyndicate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldatein = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEditYMD = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colsarfnumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMMashatName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSelected = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsarfcheek = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMMashatId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRealName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.dsQueries = new RetirementCenter.DataSources.dsQueries();
            this.rep24_ATableAdapter = new RetirementCenter.DataSources.dsReportsTableAdapters.Rep24_ATableAdapter();
            this.colDofatSarfAId = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ceCheckAll.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rep24ABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReports)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditYMD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditYMD.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsQueries)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.ceCheckAll);
            this.layoutControl1.Controls.Add(this.btnPrint);
            this.layoutControl1.Controls.Add(this.gridControlMain);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(805, 245, 250, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(948, 443);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // ceCheckAll
            // 
            this.ceCheckAll.Location = new System.Drawing.Point(12, 12);
            this.ceCheckAll.Name = "ceCheckAll";
            this.ceCheckAll.Properties.Caption = "اختيار الكل";
            this.ceCheckAll.Size = new System.Drawing.Size(90, 19);
            this.ceCheckAll.StyleController = this.layoutControl1;
            this.ceCheckAll.TabIndex = 6;
            this.ceCheckAll.CheckedChanged += new System.EventHandler(this.ceCheckAll_CheckedChanged);
            // 
            // btnPrint
            // 
            this.btnPrint.Image = global::RetirementCenter.Properties.Resources.Print;
            this.btnPrint.Location = new System.Drawing.Point(608, 12);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(328, 22);
            this.btnPrint.StyleController = this.layoutControl1;
            this.btnPrint.TabIndex = 5;
            this.btnPrint.Text = "طباعة";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // gridControlMain
            // 
            this.gridControlMain.DataSource = this.rep24ABindingSource;
            this.gridControlMain.Location = new System.Drawing.Point(12, 38);
            this.gridControlMain.MainView = this.gridViewMain;
            this.gridControlMain.Name = "gridControlMain";
            this.gridControlMain.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEditYMD});
            this.gridControlMain.Size = new System.Drawing.Size(924, 393);
            this.gridControlMain.TabIndex = 4;
            this.gridControlMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewMain});
            // 
            // rep24ABindingSource
            // 
            this.rep24ABindingSource.DataMember = "Rep24_A";
            this.rep24ABindingSource.DataSource = this.dsReports;
            // 
            // dsReports
            // 
            this.dsReports.DataSetName = "dsReports";
            this.dsReports.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridViewMain
            // 
            this.gridViewMain.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colamanatmony,
            this.colestktaa,
            this.colmostahek,
            this.colsefa,
            this.colDofatSarf,
            this.colSyndicate,
            this.coldatein,
            this.colsarfnumber,
            this.colMMashatName,
            this.colTotal,
            this.colSelected,
            this.colsarfcheek,
            this.colMMashatId,
            this.colRealName,
            this.colDofatSarfAId});
            this.gridViewMain.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridViewMain.GridControl = this.gridControlMain;
            this.gridViewMain.Name = "gridViewMain";
            this.gridViewMain.OptionsSelection.InvertSelection = true;
            this.gridViewMain.OptionsSelection.MultiSelect = true;
            this.gridViewMain.OptionsView.ColumnAutoWidth = false;
            this.gridViewMain.OptionsView.ShowAutoFilterRow = true;
            this.gridViewMain.OptionsView.ShowFooter = true;
            this.gridViewMain.OptionsView.ShowGroupPanel = false;
            // 
            // colamanatmony
            // 
            this.colamanatmony.AppearanceCell.Options.UseTextOptions = true;
            this.colamanatmony.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colamanatmony.AppearanceHeader.Options.UseTextOptions = true;
            this.colamanatmony.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colamanatmony.Caption = "مبلغ";
            this.colamanatmony.FieldName = "amanatmony";
            this.colamanatmony.Name = "colamanatmony";
            this.colamanatmony.Visible = true;
            this.colamanatmony.VisibleIndex = 10;
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
            this.colestktaa.VisibleIndex = 11;
            // 
            // colmostahek
            // 
            this.colmostahek.AppearanceCell.Options.UseTextOptions = true;
            this.colmostahek.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colmostahek.AppearanceHeader.Options.UseTextOptions = true;
            this.colmostahek.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colmostahek.Caption = "مستحق";
            this.colmostahek.FieldName = "mostahek";
            this.colmostahek.Name = "colmostahek";
            this.colmostahek.Visible = true;
            this.colmostahek.VisibleIndex = 5;
            // 
            // colsefa
            // 
            this.colsefa.AppearanceCell.Options.UseTextOptions = true;
            this.colsefa.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colsefa.AppearanceHeader.Options.UseTextOptions = true;
            this.colsefa.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colsefa.Caption = "صفة";
            this.colsefa.FieldName = "sefa";
            this.colsefa.Name = "colsefa";
            this.colsefa.Visible = true;
            this.colsefa.VisibleIndex = 9;
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
            this.colDofatSarf.VisibleIndex = 3;
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
            this.colSyndicate.VisibleIndex = 6;
            // 
            // coldatein
            // 
            this.coldatein.AppearanceCell.Options.UseTextOptions = true;
            this.coldatein.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coldatein.AppearanceHeader.Options.UseTextOptions = true;
            this.coldatein.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coldatein.Caption = "تاريخ البيان";
            this.coldatein.ColumnEdit = this.repositoryItemDateEditYMD;
            this.coldatein.FieldName = "datein";
            this.coldatein.Name = "coldatein";
            this.coldatein.Visible = true;
            this.coldatein.VisibleIndex = 7;
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
            // colsarfnumber
            // 
            this.colsarfnumber.AppearanceCell.Options.UseTextOptions = true;
            this.colsarfnumber.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colsarfnumber.AppearanceHeader.Options.UseTextOptions = true;
            this.colsarfnumber.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colsarfnumber.Caption = "رقم صرف";
            this.colsarfnumber.FieldName = "sarfnumber";
            this.colsarfnumber.Name = "colsarfnumber";
            this.colsarfnumber.Visible = true;
            this.colsarfnumber.VisibleIndex = 8;
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
            // colTotal
            // 
            this.colTotal.AppearanceCell.Options.UseTextOptions = true;
            this.colTotal.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTotal.AppearanceHeader.Options.UseTextOptions = true;
            this.colTotal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTotal.Caption = "الصافي";
            this.colTotal.FieldName = "Total";
            this.colTotal.Name = "colTotal";
            this.colTotal.OptionsColumn.ReadOnly = true;
            this.colTotal.Visible = true;
            this.colTotal.VisibleIndex = 12;
            // 
            // colSelected
            // 
            this.colSelected.AppearanceCell.Options.UseTextOptions = true;
            this.colSelected.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSelected.AppearanceHeader.Options.UseTextOptions = true;
            this.colSelected.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSelected.Caption = "اختر";
            this.colSelected.FieldName = "Selected";
            this.colSelected.Name = "colSelected";
            this.colSelected.Visible = true;
            this.colSelected.VisibleIndex = 0;
            // 
            // colsarfcheek
            // 
            this.colsarfcheek.AppearanceCell.Options.UseTextOptions = true;
            this.colsarfcheek.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colsarfcheek.AppearanceHeader.Options.UseTextOptions = true;
            this.colsarfcheek.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colsarfcheek.Caption = "تصرف بشيك";
            this.colsarfcheek.FieldName = "sarfcheek";
            this.colsarfcheek.Name = "colsarfcheek";
            this.colsarfcheek.Visible = true;
            this.colsarfcheek.VisibleIndex = 13;
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
            this.colMMashatId.VisibleIndex = 1;
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
            this.colRealName.VisibleIndex = 14;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.emptySpaceItem1,
            this.layoutControlItem3});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(948, 443);
            this.layoutControlGroup1.Text = "Root";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControlMain;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 26);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(928, 397);
            this.layoutControlItem1.Text = "layoutControlItem1";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextToControlDistance = 0;
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btnPrint;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem2.Location = new System.Drawing.Point(596, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(332, 26);
            this.layoutControlItem2.Text = "layoutControlItem2";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextToControlDistance = 0;
            this.layoutControlItem2.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(94, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(502, 26);
            this.emptySpaceItem1.Text = "emptySpaceItem1";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.ceCheckAll;
            this.layoutControlItem3.CustomizationFormText = "layoutControlItem3";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(94, 26);
            this.layoutControlItem3.Text = "layoutControlItem3";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextToControlDistance = 0;
            this.layoutControlItem3.TextVisible = false;
            // 
            // dsQueries
            // 
            this.dsQueries.DataSetName = "dsQueries";
            this.dsQueries.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rep24_ATableAdapter
            // 
            this.rep24_ATableAdapter.ClearBeforeFill = true;
            // 
            // colDofatSarfAId
            // 
            this.colDofatSarfAId.AppearanceCell.Options.UseTextOptions = true;
            this.colDofatSarfAId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDofatSarfAId.AppearanceHeader.Options.UseTextOptions = true;
            this.colDofatSarfAId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDofatSarfAId.Caption = "كود الدفعة";
            this.colDofatSarfAId.FieldName = "DofatSarfAId";
            this.colDofatSarfAId.Name = "colDofatSarfAId";
            this.colDofatSarfAId.Visible = true;
            this.colDofatSarfAId.VisibleIndex = 2;
            // 
            // TblMemberAmanatPrintFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 443);
            this.Controls.Add(this.layoutControl1);
            this.Name = "TblMemberAmanatPrintFrm";
            this.Text = "امانات الاعضاء";
            this.Load += new System.EventHandler(this.TBLDeathMembersPrintFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ceCheckAll.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rep24ABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReports)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditYMD.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditYMD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsQueries)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraGrid.GridControl gridControlMain;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewMain;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DataSources.dsQueries dsQueries;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.CheckEdit ceCheckAll;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DataSources.dsReports dsReports;
        private System.Windows.Forms.BindingSource rep24ABindingSource;
        private DataSources.dsReportsTableAdapters.Rep24_ATableAdapter rep24_ATableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colamanatmony;
        private DevExpress.XtraGrid.Columns.GridColumn colestktaa;
        private DevExpress.XtraGrid.Columns.GridColumn colmostahek;
        private DevExpress.XtraGrid.Columns.GridColumn colsefa;
        private DevExpress.XtraGrid.Columns.GridColumn colDofatSarf;
        private DevExpress.XtraGrid.Columns.GridColumn colSyndicate;
        private DevExpress.XtraGrid.Columns.GridColumn coldatein;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEditYMD;
        private DevExpress.XtraGrid.Columns.GridColumn colsarfnumber;
        private DevExpress.XtraGrid.Columns.GridColumn colMMashatName;
        private DevExpress.XtraGrid.Columns.GridColumn colTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colSelected;
        private DevExpress.XtraGrid.Columns.GridColumn colsarfcheek;
        private DevExpress.XtraGrid.Columns.GridColumn colMMashatId;
        private DevExpress.XtraGrid.Columns.GridColumn colRealName;
        private DevExpress.XtraGrid.Columns.GridColumn colDofatSarfAId;
    }
}