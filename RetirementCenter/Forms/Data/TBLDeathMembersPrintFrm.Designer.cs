namespace RetirementCenter.Forms.Data
{
    partial class TBLDeathMembersPrintFrm
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
            this.vQry84BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsQueries = new RetirementCenter.DataSources.dsQueries();
            this.gridViewMain = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSelected = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMMashatName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsarfnumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSyndicate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubCommitte = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMMashatNId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmosthhekmony = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmosthhek = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRealName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldatein = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldeathdate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.vQry84TableAdapter = new RetirementCenter.DataSources.dsQueriesTableAdapters.vQry84TableAdapter();
            this.colsarf = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsheekno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsheekdate = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ceCheckAll.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vQry84BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsQueries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
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
            this.layoutControl1.Size = new System.Drawing.Size(893, 443);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // ceCheckAll
            // 
            this.ceCheckAll.Location = new System.Drawing.Point(12, 12);
            this.ceCheckAll.Name = "ceCheckAll";
            this.ceCheckAll.Properties.Caption = "اختيار الكل";
            this.ceCheckAll.Size = new System.Drawing.Size(87, 19);
            this.ceCheckAll.StyleController = this.layoutControl1;
            this.ceCheckAll.TabIndex = 6;
            this.ceCheckAll.CheckedChanged += new System.EventHandler(this.ceCheckAll_CheckedChanged);
            // 
            // btnPrint
            // 
            this.btnPrint.Image = global::RetirementCenter.Properties.Resources.Print;
            this.btnPrint.Location = new System.Drawing.Point(727, 12);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(154, 22);
            this.btnPrint.StyleController = this.layoutControl1;
            this.btnPrint.TabIndex = 5;
            this.btnPrint.Text = "طباعة";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // gridControlMain
            // 
            this.gridControlMain.DataSource = this.vQry84BindingSource;
            this.gridControlMain.Location = new System.Drawing.Point(12, 38);
            this.gridControlMain.MainView = this.gridViewMain;
            this.gridControlMain.Name = "gridControlMain";
            this.gridControlMain.Size = new System.Drawing.Size(869, 393);
            this.gridControlMain.TabIndex = 4;
            this.gridControlMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewMain});
            // 
            // vQry84BindingSource
            // 
            this.vQry84BindingSource.DataMember = "vQry84";
            this.vQry84BindingSource.DataSource = this.dsQueries;
            // 
            // dsQueries
            // 
            this.dsQueries.DataSetName = "dsQueries";
            this.dsQueries.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridViewMain
            // 
            this.gridViewMain.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSelected,
            this.colMMashatName,
            this.colsarfnumber,
            this.colSyndicate,
            this.colSubCommitte,
            this.colMMashatNId,
            this.colmosthhekmony,
            this.colmosthhek,
            this.colRealName,
            this.coldatein,
            this.coldeathdate,
            this.colsarf,
            this.colsheekno,
            this.colsheekdate});
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
            this.colSelected.Width = 55;
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
            this.colMMashatName.OptionsColumn.ReadOnly = true;
            this.colMMashatName.Visible = true;
            this.colMMashatName.VisibleIndex = 1;
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
            this.colsarfnumber.OptionsColumn.ReadOnly = true;
            this.colsarfnumber.Visible = true;
            this.colsarfnumber.VisibleIndex = 2;
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
            this.colSyndicate.OptionsColumn.ReadOnly = true;
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
            this.colSubCommitte.OptionsColumn.ReadOnly = true;
            this.colSubCommitte.Visible = true;
            this.colSubCommitte.VisibleIndex = 4;
            // 
            // colMMashatNId
            // 
            this.colMMashatNId.AppearanceCell.Options.UseTextOptions = true;
            this.colMMashatNId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMMashatNId.AppearanceHeader.Options.UseTextOptions = true;
            this.colMMashatNId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMMashatNId.Caption = "رقم قومي";
            this.colMMashatNId.FieldName = "MMashatNId";
            this.colMMashatNId.Name = "colMMashatNId";
            this.colMMashatNId.OptionsColumn.ReadOnly = true;
            this.colMMashatNId.Visible = true;
            this.colMMashatNId.VisibleIndex = 6;
            // 
            // colmosthhekmony
            // 
            this.colmosthhekmony.AppearanceCell.Options.UseTextOptions = true;
            this.colmosthhekmony.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colmosthhekmony.AppearanceHeader.Options.UseTextOptions = true;
            this.colmosthhekmony.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colmosthhekmony.Caption = "قيمة";
            this.colmosthhekmony.FieldName = "mosthhekmony";
            this.colmosthhekmony.Name = "colmosthhekmony";
            this.colmosthhekmony.OptionsColumn.ReadOnly = true;
            this.colmosthhekmony.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "mosthhekmony", "{0:0.##}")});
            this.colmosthhekmony.Visible = true;
            this.colmosthhekmony.VisibleIndex = 8;
            // 
            // colmosthhek
            // 
            this.colmosthhek.AppearanceCell.Options.UseTextOptions = true;
            this.colmosthhek.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colmosthhek.AppearanceHeader.Options.UseTextOptions = true;
            this.colmosthhek.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colmosthhek.Caption = "مستحق";
            this.colmosthhek.FieldName = "mosthhek";
            this.colmosthhek.Name = "colmosthhek";
            this.colmosthhek.OptionsColumn.ReadOnly = true;
            this.colmosthhek.Visible = true;
            this.colmosthhek.VisibleIndex = 7;
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
            this.colRealName.VisibleIndex = 13;
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
            this.coldatein.VisibleIndex = 12;
            // 
            // coldeathdate
            // 
            this.coldeathdate.AppearanceCell.Options.UseTextOptions = true;
            this.coldeathdate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coldeathdate.AppearanceHeader.Options.UseTextOptions = true;
            this.coldeathdate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coldeathdate.Caption = "تاريخ الوفاة";
            this.coldeathdate.FieldName = "deathdate";
            this.coldeathdate.Name = "coldeathdate";
            this.coldeathdate.Visible = true;
            this.coldeathdate.VisibleIndex = 5;
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
            this.layoutControlGroup1.Size = new System.Drawing.Size(893, 443);
            this.layoutControlGroup1.Text = "Root";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControlMain;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 26);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(873, 397);
            this.layoutControlItem1.Text = "layoutControlItem1";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextToControlDistance = 0;
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btnPrint;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem2.Location = new System.Drawing.Point(715, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(158, 26);
            this.layoutControlItem2.Text = "layoutControlItem2";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextToControlDistance = 0;
            this.layoutControlItem2.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(75, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(514, 26);
            this.emptySpaceItem1.Text = "emptySpaceItem1";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.ceCheckAll;
            this.layoutControlItem3.CustomizationFormText = "layoutControlItem3";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(91, 26);
            this.layoutControlItem3.Text = "layoutControlItem3";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextToControlDistance = 0;
            this.layoutControlItem3.TextVisible = false;
            // 
            // vQry84TableAdapter
            // 
            this.vQry84TableAdapter.ClearBeforeFill = true;
            // 
            // colsarf
            // 
            this.colsarf.AppearanceCell.Options.UseTextOptions = true;
            this.colsarf.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colsarf.AppearanceHeader.Options.UseTextOptions = true;
            this.colsarf.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colsarf.Caption = "صرف";
            this.colsarf.FieldName = "sarf";
            this.colsarf.Name = "colsarf";
            this.colsarf.Visible = true;
            this.colsarf.VisibleIndex = 9;
            // 
            // colsheekno
            // 
            this.colsheekno.AppearanceCell.Options.UseTextOptions = true;
            this.colsheekno.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colsheekno.AppearanceHeader.Options.UseTextOptions = true;
            this.colsheekno.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colsheekno.Caption = "رقم الشيك";
            this.colsheekno.FieldName = "sheekno";
            this.colsheekno.Name = "colsheekno";
            this.colsheekno.Visible = true;
            this.colsheekno.VisibleIndex = 10;
            // 
            // colsheekdate
            // 
            this.colsheekdate.AppearanceCell.Options.UseTextOptions = true;
            this.colsheekdate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colsheekdate.AppearanceHeader.Options.UseTextOptions = true;
            this.colsheekdate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colsheekdate.Caption = "تاريخ الشيك";
            this.colsheekdate.FieldName = "sheekdate";
            this.colsheekdate.Name = "colsheekdate";
            this.colsheekdate.Visible = true;
            this.colsheekdate.VisibleIndex = 11;
            // 
            // TBLDeathMembersPrintFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 443);
            this.Controls.Add(this.layoutControl1);
            this.Name = "TBLDeathMembersPrintFrm";
            this.Text = "طباعة الوفيات";
            this.Load += new System.EventHandler(this.TBLDeathMembersPrintFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ceCheckAll.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vQry84BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsQueries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraGrid.GridControl gridControlMain;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewMain;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.Columns.GridColumn colMMashatName;
        private DevExpress.XtraGrid.Columns.GridColumn colsarfnumber;
        private DevExpress.XtraGrid.Columns.GridColumn colSyndicate;
        private DevExpress.XtraGrid.Columns.GridColumn colSubCommitte;
        private DevExpress.XtraGrid.Columns.GridColumn colMMashatNId;
        private DevExpress.XtraGrid.Columns.GridColumn colmosthhekmony;
        private DevExpress.XtraGrid.Columns.GridColumn colmosthhek;
        private DataSources.dsQueries dsQueries;
        private System.Windows.Forms.BindingSource vQry84BindingSource;
        private DataSources.dsQueriesTableAdapters.vQry84TableAdapter vQry84TableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colSelected;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.CheckEdit ceCheckAll;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraGrid.Columns.GridColumn colRealName;
        private DevExpress.XtraGrid.Columns.GridColumn coldatein;
        private DevExpress.XtraGrid.Columns.GridColumn coldeathdate;
        private DevExpress.XtraGrid.Columns.GridColumn colsarf;
        private DevExpress.XtraGrid.Columns.GridColumn colsheekno;
        private DevExpress.XtraGrid.Columns.GridColumn colsheekdate;
    }
}