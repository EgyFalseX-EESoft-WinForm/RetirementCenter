namespace RetirementCenter
{
    partial class Qry31Frm
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
            DevExpress.XtraPivotGrid.PivotGridStyleFormatCondition pivotGridStyleFormatCondition1 = new DevExpress.XtraPivotGrid.PivotGridStyleFormatCondition();
            DevExpress.XtraPivotGrid.PivotGridStyleFormatCondition pivotGridStyleFormatCondition2 = new DevExpress.XtraPivotGrid.PivotGridStyleFormatCondition();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnPrintExport = new DevExpress.XtraEditors.SimpleButton();
            this.pivotGridControlMain = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.vQry31BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsQueries = new RetirementCenter.DataSources.dsQueries();
            this.fieldCountMMashatId = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldNID = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldNIDP = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldBankExport = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldBankExportP = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldBankExportBack = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldBankExportBackP = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldSyndicate1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.vQry31TableAdapter = new RetirementCenter.DataSources.dsQueriesTableAdapters.vQry31TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControlMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vQry31BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsQueries)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnPrintExport);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(817, 47);
            this.panelControl1.TabIndex = 3;
            // 
            // btnPrintExport
            // 
            this.btnPrintExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrintExport.Location = new System.Drawing.Point(671, 12);
            this.btnPrintExport.Name = "btnPrintExport";
            this.btnPrintExport.Size = new System.Drawing.Size(134, 23);
            this.btnPrintExport.TabIndex = 0;
            this.btnPrintExport.Text = "طباعه و تصدير";
            this.btnPrintExport.Click += new System.EventHandler(this.btnPrintExport_Click);
            // 
            // pivotGridControlMain
            // 
            this.pivotGridControlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pivotGridControlMain.DataSource = this.vQry31BindingSource;
            this.pivotGridControlMain.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldCountMMashatId,
            this.fieldNID,
            this.fieldNIDP,
            this.fieldBankExport,
            this.fieldBankExportP,
            this.fieldBankExportBack,
            this.fieldBankExportBackP,
            this.fieldSyndicate1});
            pivotGridStyleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.Green;
            pivotGridStyleFormatCondition1.Appearance.Options.UseForeColor = true;
            pivotGridStyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.GreaterOrEqual;
            pivotGridStyleFormatCondition1.FieldName = "calcMashHalaPer";
            pivotGridStyleFormatCondition1.Value1 = ".5";
            pivotGridStyleFormatCondition2.Appearance.ForeColor = System.Drawing.Color.Red;
            pivotGridStyleFormatCondition2.Appearance.Options.UseForeColor = true;
            pivotGridStyleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Less;
            pivotGridStyleFormatCondition2.FieldName = "calcMashHalaPer";
            pivotGridStyleFormatCondition2.Value1 = ".5";
            this.pivotGridControlMain.FormatConditions.AddRange(new DevExpress.XtraPivotGrid.PivotGridStyleFormatCondition[] {
            pivotGridStyleFormatCondition1,
            pivotGridStyleFormatCondition2});
            this.pivotGridControlMain.Location = new System.Drawing.Point(0, 53);
            this.pivotGridControlMain.Name = "pivotGridControlMain";
            this.pivotGridControlMain.Size = new System.Drawing.Size(817, 408);
            this.pivotGridControlMain.TabIndex = 4;
            // 
            // vQry31BindingSource
            // 
            this.vQry31BindingSource.DataMember = "vQry31";
            this.vQry31BindingSource.DataSource = this.dsQueries;
            // 
            // dsQueries
            // 
            this.dsQueries.DataSetName = "dsQueries";
            this.dsQueries.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fieldCountMMashatId
            // 
            this.fieldCountMMashatId.Appearance.Cell.Options.UseTextOptions = true;
            this.fieldCountMMashatId.Appearance.Cell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.fieldCountMMashatId.Appearance.Header.Options.UseTextOptions = true;
            this.fieldCountMMashatId.Appearance.Header.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.fieldCountMMashatId.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldCountMMashatId.AreaIndex = 0;
            this.fieldCountMMashatId.Caption = "العدد";
            this.fieldCountMMashatId.EmptyCellText = "0";
            this.fieldCountMMashatId.EmptyValueText = "0";
            this.fieldCountMMashatId.FieldName = "CountMMashatId";
            this.fieldCountMMashatId.Name = "fieldCountMMashatId";
            this.fieldCountMMashatId.Width = 61;
            // 
            // fieldNID
            // 
            this.fieldNID.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldNID.AreaIndex = 1;
            this.fieldNID.Caption = "عدد الارقام القومية";
            this.fieldNID.EmptyCellText = "0";
            this.fieldNID.EmptyValueText = "0";
            this.fieldNID.FieldName = "NID";
            this.fieldNID.Name = "fieldNID";
            // 
            // fieldNIDP
            // 
            this.fieldNIDP.Appearance.CellGrandTotal.ForeColor = System.Drawing.Color.Red;
            this.fieldNIDP.Appearance.CellGrandTotal.Options.UseForeColor = true;
            this.fieldNIDP.Appearance.Value.ForeColor = System.Drawing.Color.Red;
            this.fieldNIDP.Appearance.Value.Options.UseForeColor = true;
            this.fieldNIDP.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldNIDP.AreaIndex = 2;
            this.fieldNIDP.Caption = "نسبة الرقم القومي";
            this.fieldNIDP.CellFormat.FormatString = "p2";
            this.fieldNIDP.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldNIDP.EmptyCellText = "0";
            this.fieldNIDP.EmptyValueText = "0";
            this.fieldNIDP.FieldName = "NID_P";
            this.fieldNIDP.GrandTotalCellFormat.FormatString = "p2";
            this.fieldNIDP.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldNIDP.Name = "fieldNIDP";
            this.fieldNIDP.Options.ShowUnboundExpressionMenu = true;
            this.fieldNIDP.RunningTotal = true;
            this.fieldNIDP.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Average;
            this.fieldNIDP.TotalCellFormat.FormatString = "p2";
            this.fieldNIDP.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldNIDP.TotalValueFormat.FormatString = "p2";
            this.fieldNIDP.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldNIDP.ValueFormat.FormatString = "p2";
            this.fieldNIDP.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            // 
            // fieldBankExport
            // 
            this.fieldBankExport.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldBankExport.AreaIndex = 3;
            this.fieldBankExport.Caption = "عدد المصدر للبنك";
            this.fieldBankExport.EmptyCellText = "0";
            this.fieldBankExport.EmptyValueText = "0";
            this.fieldBankExport.FieldName = "BankExport";
            this.fieldBankExport.Name = "fieldBankExport";
            // 
            // fieldBankExportP
            // 
            this.fieldBankExportP.Appearance.CellGrandTotal.ForeColor = System.Drawing.Color.Red;
            this.fieldBankExportP.Appearance.CellGrandTotal.Options.UseForeColor = true;
            this.fieldBankExportP.Appearance.Value.ForeColor = System.Drawing.Color.Red;
            this.fieldBankExportP.Appearance.Value.Options.UseForeColor = true;
            this.fieldBankExportP.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldBankExportP.AreaIndex = 4;
            this.fieldBankExportP.Caption = "نسبة المصدر للبنك";
            this.fieldBankExportP.CellFormat.FormatString = "p1";
            this.fieldBankExportP.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldBankExportP.EmptyCellText = "0";
            this.fieldBankExportP.EmptyValueText = "0";
            this.fieldBankExportP.FieldName = "BankExport_P";
            this.fieldBankExportP.GrandTotalCellFormat.FormatString = "p1";
            this.fieldBankExportP.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldBankExportP.Name = "fieldBankExportP";
            this.fieldBankExportP.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Average;
            this.fieldBankExportP.TotalCellFormat.FormatString = "p1";
            this.fieldBankExportP.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldBankExportP.TotalValueFormat.FormatString = "p1";
            this.fieldBankExportP.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldBankExportP.ValueFormat.FormatString = "p1";
            this.fieldBankExportP.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            // 
            // fieldBankExportBack
            // 
            this.fieldBankExportBack.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldBankExportBack.AreaIndex = 5;
            this.fieldBankExportBack.Caption = "من اتي من البنك";
            this.fieldBankExportBack.EmptyCellText = "0";
            this.fieldBankExportBack.EmptyValueText = "0";
            this.fieldBankExportBack.FieldName = "BankExportBack";
            this.fieldBankExportBack.Name = "fieldBankExportBack";
            // 
            // fieldBankExportBackP
            // 
            this.fieldBankExportBackP.Appearance.CellGrandTotal.ForeColor = System.Drawing.Color.Red;
            this.fieldBankExportBackP.Appearance.CellGrandTotal.Options.UseForeColor = true;
            this.fieldBankExportBackP.Appearance.Value.ForeColor = System.Drawing.Color.Red;
            this.fieldBankExportBackP.Appearance.Value.Options.UseForeColor = true;
            this.fieldBankExportBackP.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldBankExportBackP.AreaIndex = 6;
            this.fieldBankExportBackP.Caption = "نسبة من اتي من البنك";
            this.fieldBankExportBackP.CellFormat.FormatString = "p1";
            this.fieldBankExportBackP.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldBankExportBackP.EmptyCellText = "0";
            this.fieldBankExportBackP.EmptyValueText = "0";
            this.fieldBankExportBackP.FieldName = "BankExportBack_P";
            this.fieldBankExportBackP.GrandTotalCellFormat.FormatString = "p1";
            this.fieldBankExportBackP.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldBankExportBackP.Name = "fieldBankExportBackP";
            this.fieldBankExportBackP.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Average;
            this.fieldBankExportBackP.TotalCellFormat.FormatString = "p1";
            this.fieldBankExportBackP.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldBankExportBackP.TotalValueFormat.FormatString = "p1";
            this.fieldBankExportBackP.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldBankExportBackP.ValueFormat.FormatString = "p1";
            this.fieldBankExportBackP.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            // 
            // fieldSyndicate1
            // 
            this.fieldSyndicate1.Appearance.Cell.Options.UseTextOptions = true;
            this.fieldSyndicate1.Appearance.Cell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.fieldSyndicate1.Appearance.Header.Options.UseTextOptions = true;
            this.fieldSyndicate1.Appearance.Header.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.fieldSyndicate1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldSyndicate1.AreaIndex = 0;
            this.fieldSyndicate1.Caption = "فرعية";
            this.fieldSyndicate1.EmptyCellText = "0";
            this.fieldSyndicate1.EmptyValueText = "0";
            this.fieldSyndicate1.FieldName = "Syndicate";
            this.fieldSyndicate1.Name = "fieldSyndicate1";
            this.fieldSyndicate1.Width = 154;
            // 
            // vQry31TableAdapter
            // 
            this.vQry31TableAdapter.ClearBeforeFill = true;
            // 
            // Qry31Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 462);
            this.Controls.Add(this.pivotGridControlMain);
            this.Controls.Add(this.panelControl1);
            this.Name = "Qry31Frm";
            this.Text = "احصائيات الاعضاء";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Qry06Frm_Load);
            this.Shown += new System.EventHandler(this.Qry31Frm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControlMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vQry31BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsQueries)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnPrintExport;
        private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControlMain;
        private DevExpress.XtraPivotGrid.PivotGridField fieldSyndicate1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldCountMMashatId;
        private DataSources.dsQueries dsQueries;
        private System.Windows.Forms.BindingSource vQry31BindingSource;
        private DataSources.dsQueriesTableAdapters.vQry31TableAdapter vQry31TableAdapter;
        private DevExpress.XtraPivotGrid.PivotGridField fieldBankExport;
        private DevExpress.XtraPivotGrid.PivotGridField fieldNID;
        private DevExpress.XtraPivotGrid.PivotGridField fieldBankExportBack;
        private DevExpress.XtraPivotGrid.PivotGridField fieldNIDP;
        private DevExpress.XtraPivotGrid.PivotGridField fieldBankExportP;
        private DevExpress.XtraPivotGrid.PivotGridField fieldBankExportBackP;

    }
}