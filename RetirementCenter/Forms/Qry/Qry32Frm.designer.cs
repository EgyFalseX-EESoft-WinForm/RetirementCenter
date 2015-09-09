namespace RetirementCenter
{
    partial class Qry32Frm
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
            DevExpress.XtraPivotGrid.PivotGridStyleFormatCondition pivotGridStyleFormatCondition1 = new DevExpress.XtraPivotGrid.PivotGridStyleFormatCondition();
            DevExpress.XtraPivotGrid.PivotGridStyleFormatCondition pivotGridStyleFormatCondition2 = new DevExpress.XtraPivotGrid.PivotGridStyleFormatCondition();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnPrintExport = new DevExpress.XtraEditors.SimpleButton();
            this.pivotGridControlMain = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.vQry32BindingSource = new System.Windows.Forms.BindingSource();
            this.dsQueries = new RetirementCenter.DataSources.dsQueries();
            this.fieldSyndicate1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldYasref1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldNoYasref1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldYasrefNID1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldYasrefNONID1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldNOYasrefNID1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldNOYasrefNONID1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldYasrefBankExport1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldYasrefBankExportBack1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldYasrefActivate1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldNOYasrefBankExport1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldNOYasrefBankExportBack1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldNOYasrefActivate1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.vQry32TableAdapter = new RetirementCenter.DataSources.dsQueriesTableAdapters.vQry32TableAdapter();
            this.fieldTotalActivate = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldTotalBack = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldTotalBackActive = new DevExpress.XtraPivotGrid.PivotGridField();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControlMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vQry32BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsQueries)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnPrintExport);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1104, 47);
            this.panelControl1.TabIndex = 3;
            // 
            // btnPrintExport
            // 
            this.btnPrintExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrintExport.Location = new System.Drawing.Point(958, 12);
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
            this.pivotGridControlMain.DataSource = this.vQry32BindingSource;
            this.pivotGridControlMain.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldSyndicate1,
            this.fieldYasref1,
            this.fieldNoYasref1,
            this.fieldYasrefNID1,
            this.fieldYasrefNONID1,
            this.fieldNOYasrefNID1,
            this.fieldNOYasrefNONID1,
            this.fieldYasrefBankExport1,
            this.fieldYasrefBankExportBack1,
            this.fieldYasrefActivate1,
            this.fieldNOYasrefBankExport1,
            this.fieldNOYasrefBankExportBack1,
            this.fieldNOYasrefActivate1,
            this.fieldTotalActivate,
            this.fieldTotalBack,
            this.fieldTotalBackActive});
            pivotGridStyleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.Green;
            pivotGridStyleFormatCondition1.Appearance.Options.UseForeColor = true;
            pivotGridStyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.GreaterOrEqual;
            pivotGridStyleFormatCondition1.FieldName = "";
            pivotGridStyleFormatCondition1.Value1 = ".5";
            pivotGridStyleFormatCondition2.Appearance.ForeColor = System.Drawing.Color.Red;
            pivotGridStyleFormatCondition2.Appearance.Options.UseForeColor = true;
            pivotGridStyleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Less;
            pivotGridStyleFormatCondition2.FieldName = "";
            pivotGridStyleFormatCondition2.Value1 = ".5";
            this.pivotGridControlMain.FormatConditions.AddRange(new DevExpress.XtraPivotGrid.PivotGridStyleFormatCondition[] {
            pivotGridStyleFormatCondition1,
            pivotGridStyleFormatCondition2});
            this.pivotGridControlMain.Location = new System.Drawing.Point(0, 53);
            this.pivotGridControlMain.Name = "pivotGridControlMain";
            this.pivotGridControlMain.Size = new System.Drawing.Size(1104, 408);
            this.pivotGridControlMain.TabIndex = 4;
            // 
            // vQry32BindingSource
            // 
            this.vQry32BindingSource.DataMember = "vQry32";
            this.vQry32BindingSource.DataSource = this.dsQueries;
            // 
            // dsQueries
            // 
            this.dsQueries.DataSetName = "dsQueries";
            this.dsQueries.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fieldSyndicate1
            // 
            this.fieldSyndicate1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldSyndicate1.AreaIndex = 0;
            this.fieldSyndicate1.Caption = "الفرعية";
            this.fieldSyndicate1.FieldName = "Syndicate";
            this.fieldSyndicate1.Name = "fieldSyndicate1";
            // 
            // fieldYasref1
            // 
            this.fieldYasref1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldYasref1.AreaIndex = 0;
            this.fieldYasref1.Caption = "يصرف";
            this.fieldYasref1.FieldName = "Yasref";
            this.fieldYasref1.Name = "fieldYasref1";
            // 
            // fieldNoYasref1
            // 
            this.fieldNoYasref1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldNoYasref1.AreaIndex = 1;
            this.fieldNoYasref1.Caption = "لا يصرف";
            this.fieldNoYasref1.FieldName = "No_Yasref";
            this.fieldNoYasref1.Name = "fieldNoYasref1";
            // 
            // fieldYasrefNID1
            // 
            this.fieldYasrefNID1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldYasrefNID1.AreaIndex = 2;
            this.fieldYasrefNID1.Caption = "يصرف له رقم قومي";
            this.fieldYasrefNID1.FieldName = "Yasref_NID";
            this.fieldYasrefNID1.Name = "fieldYasrefNID1";
            // 
            // fieldYasrefNONID1
            // 
            this.fieldYasrefNONID1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldYasrefNONID1.AreaIndex = 3;
            this.fieldYasrefNONID1.Caption = "يصرف بدون رقم قومي";
            this.fieldYasrefNONID1.FieldName = "Yasref_NO_NID";
            this.fieldYasrefNONID1.Name = "fieldYasrefNONID1";
            // 
            // fieldNOYasrefNID1
            // 
            this.fieldNOYasrefNID1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldNOYasrefNID1.AreaIndex = 4;
            this.fieldNOYasrefNID1.Caption = "لا يصرف له رقم قومي";
            this.fieldNOYasrefNID1.FieldName = "NO_Yasref_NID";
            this.fieldNOYasrefNID1.Name = "fieldNOYasrefNID1";
            this.fieldNOYasrefNID1.Width = 147;
            // 
            // fieldNOYasrefNONID1
            // 
            this.fieldNOYasrefNONID1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldNOYasrefNONID1.AreaIndex = 5;
            this.fieldNOYasrefNONID1.Caption = "لا يصرف بدون رقم قومي";
            this.fieldNOYasrefNONID1.FieldName = "NO_Yasref_NO_NID";
            this.fieldNOYasrefNONID1.Name = "fieldNOYasrefNONID1";
            // 
            // fieldYasrefBankExport1
            // 
            this.fieldYasrefBankExport1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldYasrefBankExport1.AreaIndex = 6;
            this.fieldYasrefBankExport1.Caption = "يصرف تم التصدير";
            this.fieldYasrefBankExport1.FieldName = "Yasref_BankExport";
            this.fieldYasrefBankExport1.Name = "fieldYasrefBankExport1";
            // 
            // fieldYasrefBankExportBack1
            // 
            this.fieldYasrefBankExportBack1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldYasrefBankExportBack1.AreaIndex = 7;
            this.fieldYasrefBankExportBack1.Caption = "يصرف مرتجع";
            this.fieldYasrefBankExportBack1.FieldName = "Yasref_BankExportBack";
            this.fieldYasrefBankExportBack1.Name = "fieldYasrefBankExportBack1";
            // 
            // fieldYasrefActivate1
            // 
            this.fieldYasrefActivate1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldYasrefActivate1.AreaIndex = 8;
            this.fieldYasrefActivate1.Caption = "يصرف تم تفعيل";
            this.fieldYasrefActivate1.FieldName = "Yasref_Activate";
            this.fieldYasrefActivate1.Name = "fieldYasrefActivate1";
            // 
            // fieldNOYasrefBankExport1
            // 
            this.fieldNOYasrefBankExport1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldNOYasrefBankExport1.AreaIndex = 9;
            this.fieldNOYasrefBankExport1.Caption = "لا يصرف تم التصدير";
            this.fieldNOYasrefBankExport1.FieldName = "NO_Yasref_BankExport";
            this.fieldNOYasrefBankExport1.Name = "fieldNOYasrefBankExport1";
            // 
            // fieldNOYasrefBankExportBack1
            // 
            this.fieldNOYasrefBankExportBack1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldNOYasrefBankExportBack1.AreaIndex = 10;
            this.fieldNOYasrefBankExportBack1.Caption = "لا يصرف مرتجع";
            this.fieldNOYasrefBankExportBack1.FieldName = "NO_Yasref_BankExportBack";
            this.fieldNOYasrefBankExportBack1.Name = "fieldNOYasrefBankExportBack1";
            // 
            // fieldNOYasrefActivate1
            // 
            this.fieldNOYasrefActivate1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldNOYasrefActivate1.AreaIndex = 11;
            this.fieldNOYasrefActivate1.Caption = "لا يصرف تم تفعيل";
            this.fieldNOYasrefActivate1.FieldName = "NO_Yasref_Activate";
            this.fieldNOYasrefActivate1.Name = "fieldNOYasrefActivate1";
            // 
            // vQry32TableAdapter
            // 
            this.vQry32TableAdapter.ClearBeforeFill = true;
            // 
            // fieldTotalActivate
            // 
            this.fieldTotalActivate.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldTotalActivate.AreaIndex = 12;
            this.fieldTotalActivate.Caption = "اجمالي التفعيل";
            this.fieldTotalActivate.FieldName = "Total_Activate";
            this.fieldTotalActivate.Name = "fieldTotalActivate";
            // 
            // fieldTotalBack
            // 
            this.fieldTotalBack.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldTotalBack.AreaIndex = 13;
            this.fieldTotalBack.Caption = "اجمالي الوارد";
            this.fieldTotalBack.FieldName = "Total_Back";
            this.fieldTotalBack.Name = "fieldTotalBack";
            // 
            // fieldTotalBackActive
            // 
            this.fieldTotalBackActive.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldTotalBackActive.AreaIndex = 14;
            this.fieldTotalBackActive.Caption = "نسبة المفعل للوارد";
            this.fieldTotalBackActive.CellFormat.FormatString = "p1";
            this.fieldTotalBackActive.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldTotalBackActive.FieldName = "Total_BackActive";
            this.fieldTotalBackActive.GrandTotalCellFormat.FormatString = "p1";
            this.fieldTotalBackActive.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldTotalBackActive.Name = "fieldTotalBackActive";
            this.fieldTotalBackActive.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Average;
            // 
            // Qry32Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 462);
            this.Controls.Add(this.pivotGridControlMain);
            this.Controls.Add(this.panelControl1);
            this.Name = "Qry32Frm";
            this.Text = "احصائيات الورثة";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_Load);
            this.Shown += new System.EventHandler(this.Frm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControlMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vQry32BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsQueries)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnPrintExport;
        private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControlMain;
        private DataSources.dsQueries dsQueries;
        private System.Windows.Forms.BindingSource vQry32BindingSource;
        private DataSources.dsQueriesTableAdapters.vQry32TableAdapter vQry32TableAdapter;
        private DevExpress.XtraPivotGrid.PivotGridField fieldSyndicate1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldYasref1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldNoYasref1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldYasrefNID1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldYasrefNONID1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldNOYasrefNID1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldNOYasrefNONID1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldYasrefBankExport1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldYasrefBankExportBack1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldYasrefActivate1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldNOYasrefBankExport1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldNOYasrefBankExportBack1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldNOYasrefActivate1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldTotalActivate;
        private DevExpress.XtraPivotGrid.PivotGridField fieldTotalBack;
        private DevExpress.XtraPivotGrid.PivotGridField fieldTotalBackActive;

    }
}