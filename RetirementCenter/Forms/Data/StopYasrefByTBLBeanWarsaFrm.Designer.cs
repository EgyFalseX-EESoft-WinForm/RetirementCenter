namespace RetirementCenter.Forms.Data
{
    partial class StopYasrefByTBLBeanWarsaFrm
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
            this.btnStart = new DevExpress.XtraEditors.SimpleButton();
            this.lueSyn = new DevExpress.XtraEditors.LookUpEdit();
            this.cDSyndicateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsQueries = new RetirementCenter.DataSources.dsQueries();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lueDof = new DevExpress.XtraEditors.LookUpEdit();
            this.tBLDofatSarfBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lblCount = new DevExpress.XtraEditors.LabelControl();
            this.cDSyndicateTableAdapter = new RetirementCenter.DataSources.dsQueriesTableAdapters.CDSyndicateTableAdapter();
            this.tBLDofatSarfTableAdapter = new RetirementCenter.DataSources.dsQueriesTableAdapters.TBLDofatSarfTableAdapter();
            this.lueSub = new DevExpress.XtraEditors.LookUpEdit();
            this.cDSubCommitteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.cDSubCommitteTableAdapter = new RetirementCenter.DataSources.dsQueriesTableAdapters.CDSubCommitteTableAdapter();
            this.gridControlMain = new DevExpress.XtraGrid.GridControl();
            this.vQry65BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewMain = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPersonId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpersonName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSyndicate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubCommitte = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMMashatId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMMashatName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsarfnumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.vQry65TableAdapter = new RetirementCenter.DataSources.dsQueriesTableAdapters.vQry65TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.lueSyn.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDSyndicateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsQueries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueDof.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLDofatSarfBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueSub.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDSubCommitteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vQry65BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnStart.Image = global::RetirementCenter.Properties.Resources.save_16x16;
            this.btnStart.Location = new System.Drawing.Point(333, 96);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(130, 23);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "ايقاف";
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lueSyn
            // 
            this.lueSyn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lueSyn.Location = new System.Drawing.Point(255, 12);
            this.lueSyn.Name = "lueSyn";
            this.lueSyn.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lueSyn.Properties.Appearance.Options.UseFont = true;
            this.lueSyn.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueSyn.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Syndicate", "الاسم", 65, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.lueSyn.Properties.DataSource = this.cDSyndicateBindingSource;
            this.lueSyn.Properties.DisplayMember = "Syndicate";
            this.lueSyn.Properties.NullText = "";
            this.lueSyn.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lueSyn.Properties.ValueMember = "SyndicateId";
            this.lueSyn.Size = new System.Drawing.Size(208, 22);
            this.lueSyn.TabIndex = 0;
            this.lueSyn.EditValueChanged += new System.EventHandler(this.lue_EditValueChanged);
            // 
            // cDSyndicateBindingSource
            // 
            this.cDSyndicateBindingSource.DataMember = "CDSyndicate";
            this.cDSyndicateBindingSource.DataSource = this.dsQueries;
            // 
            // dsQueries
            // 
            this.dsQueries.DataSetName = "dsQueries";
            this.dsQueries.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl1.Location = new System.Drawing.Point(469, 15);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(41, 17);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "الفرعية";
            // 
            // lueDof
            // 
            this.lueDof.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lueDof.Location = new System.Drawing.Point(255, 68);
            this.lueDof.Name = "lueDof";
            this.lueDof.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lueDof.Properties.Appearance.Options.UseFont = true;
            this.lueDof.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueDof.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DofatSarf", "الاسم", 69, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.lueDof.Properties.DataSource = this.tBLDofatSarfBindingSource;
            this.lueDof.Properties.DisplayMember = "DofatSarf";
            this.lueDof.Properties.NullText = "";
            this.lueDof.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lueDof.Properties.ValueMember = "DofatSarfId";
            this.lueDof.Size = new System.Drawing.Size(208, 22);
            this.lueDof.TabIndex = 2;
            this.lueDof.EditValueChanged += new System.EventHandler(this.lue_EditValueChanged);
            // 
            // tBLDofatSarfBindingSource
            // 
            this.tBLDofatSarfBindingSource.DataMember = "TBLDofatSarf";
            this.tBLDofatSarfBindingSource.DataSource = this.dsQueries;
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl2.Location = new System.Drawing.Point(482, 71);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(28, 17);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "دفعة";
            // 
            // lblCount
            // 
            this.lblCount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCount.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblCount.Location = new System.Drawing.Point(255, 96);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(7, 16);
            this.lblCount.TabIndex = 2;
            this.lblCount.Text = "0";
            // 
            // cDSyndicateTableAdapter
            // 
            this.cDSyndicateTableAdapter.ClearBeforeFill = true;
            // 
            // tBLDofatSarfTableAdapter
            // 
            this.tBLDofatSarfTableAdapter.ClearBeforeFill = true;
            // 
            // lueSub
            // 
            this.lueSub.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lueSub.Location = new System.Drawing.Point(255, 40);
            this.lueSub.Name = "lueSub";
            this.lueSub.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lueSub.Properties.Appearance.Options.UseFont = true;
            this.lueSub.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueSub.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SubCommitte", "الاسم", 91, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.lueSub.Properties.DataSource = this.cDSubCommitteBindingSource;
            this.lueSub.Properties.DisplayMember = "SubCommitte";
            this.lueSub.Properties.NullText = "";
            this.lueSub.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lueSub.Properties.ValueMember = "SubCommitteId";
            this.lueSub.Size = new System.Drawing.Size(208, 22);
            this.lueSub.TabIndex = 1;
            this.lueSub.EditValueChanged += new System.EventHandler(this.lue_EditValueChanged);
            // 
            // cDSubCommitteBindingSource
            // 
            this.cDSubCommitteBindingSource.DataMember = "CDSubCommitte";
            this.cDSubCommitteBindingSource.DataSource = this.dsQueries;
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl3.Location = new System.Drawing.Point(475, 43);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(35, 17);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "اللجنة";
            // 
            // cDSubCommitteTableAdapter
            // 
            this.cDSubCommitteTableAdapter.ClearBeforeFill = true;
            // 
            // gridControlMain
            // 
            this.gridControlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlMain.DataSource = this.vQry65BindingSource;
            this.gridControlMain.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gridControlMain.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControlMain.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControlMain.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControlMain.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gridControlMain.Location = new System.Drawing.Point(12, 125);
            this.gridControlMain.MainView = this.gridViewMain;
            this.gridControlMain.Name = "gridControlMain";
            this.gridControlMain.Size = new System.Drawing.Size(750, 300);
            this.gridControlMain.TabIndex = 4;
            this.gridControlMain.UseEmbeddedNavigator = true;
            this.gridControlMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewMain});
            // 
            // vQry65BindingSource
            // 
            this.vQry65BindingSource.DataMember = "vQry65";
            this.vQry65BindingSource.DataSource = this.dsQueries;
            // 
            // gridViewMain
            // 
            this.gridViewMain.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPersonId,
            this.colpersonName,
            this.colSyndicate,
            this.colSubCommitte,
            this.colMMashatId,
            this.colMMashatName,
            this.colsarfnumber});
            this.gridViewMain.GridControl = this.gridControlMain;
            this.gridViewMain.Name = "gridViewMain";
            this.gridViewMain.OptionsBehavior.ReadOnly = true;
            this.gridViewMain.OptionsView.ColumnAutoWidth = false;
            this.gridViewMain.OptionsView.ShowGroupPanel = false;
            // 
            // colPersonId
            // 
            this.colPersonId.AppearanceCell.Options.UseTextOptions = true;
            this.colPersonId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPersonId.AppearanceHeader.Options.UseTextOptions = true;
            this.colPersonId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPersonId.Caption = "كود";
            this.colPersonId.FieldName = "PersonId";
            this.colPersonId.Name = "colPersonId";
            this.colPersonId.Visible = true;
            this.colPersonId.VisibleIndex = 0;
            // 
            // colpersonName
            // 
            this.colpersonName.AppearanceCell.Options.UseTextOptions = true;
            this.colpersonName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colpersonName.AppearanceHeader.Options.UseTextOptions = true;
            this.colpersonName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colpersonName.Caption = "الاسم";
            this.colpersonName.FieldName = "personName";
            this.colpersonName.Name = "colpersonName";
            this.colpersonName.Visible = true;
            this.colpersonName.VisibleIndex = 1;
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
            this.colSyndicate.Visible = true;
            this.colSyndicate.VisibleIndex = 2;
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
            this.colSubCommitte.Visible = true;
            this.colSubCommitte.VisibleIndex = 3;
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
            this.colMMashatId.VisibleIndex = 4;
            // 
            // colMMashatName
            // 
            this.colMMashatName.AppearanceCell.Options.UseTextOptions = true;
            this.colMMashatName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMMashatName.AppearanceHeader.Options.UseTextOptions = true;
            this.colMMashatName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMMashatName.Caption = "اسم الاب";
            this.colMMashatName.FieldName = "MMashatName";
            this.colMMashatName.Name = "colMMashatName";
            this.colMMashatName.Visible = true;
            this.colMMashatName.VisibleIndex = 5;
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
            this.colsarfnumber.VisibleIndex = 6;
            // 
            // vQry65TableAdapter
            // 
            this.vQry65TableAdapter.ClearBeforeFill = true;
            // 
            // StopYasrefByTBLBeanWarsaFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 437);
            this.Controls.Add(this.gridControlMain);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.lueDof);
            this.Controls.Add(this.lueSub);
            this.Controls.Add(this.lueSyn);
            this.Controls.Add(this.btnStart);
            this.Name = "StopYasrefByTBLBeanWarsaFrm";
            this.Text = "ايقاف الصرف طبقا لبيان المعاش";
            this.Load += new System.EventHandler(this.StopYasrefByTBLBeanWarsaFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lueSyn.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDSyndicateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsQueries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueDof.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLDofatSarfBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueSub.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDSubCommitteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vQry65BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnStart;
        private DevExpress.XtraEditors.LookUpEdit lueSyn;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LookUpEdit lueDof;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl lblCount;
        private DataSources.dsQueries dsQueries;
        private System.Windows.Forms.BindingSource cDSyndicateBindingSource;
        private DataSources.dsQueriesTableAdapters.CDSyndicateTableAdapter cDSyndicateTableAdapter;
        private System.Windows.Forms.BindingSource tBLDofatSarfBindingSource;
        private DataSources.dsQueriesTableAdapters.TBLDofatSarfTableAdapter tBLDofatSarfTableAdapter;
        private DevExpress.XtraEditors.LookUpEdit lueSub;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.BindingSource cDSubCommitteBindingSource;
        private DataSources.dsQueriesTableAdapters.CDSubCommitteTableAdapter cDSubCommitteTableAdapter;
        private DevExpress.XtraGrid.GridControl gridControlMain;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewMain;
        private System.Windows.Forms.BindingSource vQry65BindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colPersonId;
        private DevExpress.XtraGrid.Columns.GridColumn colpersonName;
        private DevExpress.XtraGrid.Columns.GridColumn colSyndicate;
        private DevExpress.XtraGrid.Columns.GridColumn colSubCommitte;
        private DevExpress.XtraGrid.Columns.GridColumn colMMashatId;
        private DevExpress.XtraGrid.Columns.GridColumn colMMashatName;
        private DevExpress.XtraGrid.Columns.GridColumn colsarfnumber;
        private DataSources.dsQueriesTableAdapters.vQry65TableAdapter vQry65TableAdapter;
    }
}