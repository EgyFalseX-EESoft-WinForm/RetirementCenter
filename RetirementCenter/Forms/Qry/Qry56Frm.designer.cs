namespace RetirementCenter
{
    partial class Qry56Frm
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
            this.vQry56BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsQueries = new RetirementCenter.DataSources.dsQueries();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnPrintExport = new DevExpress.XtraEditors.SimpleButton();
            this.vQry56TableAdapter = new RetirementCenter.DataSources.dsQueriesTableAdapters.vQry56TableAdapter();
            this.pivotGridControlMain = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.fieldSyndicate1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldWarasaType1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldAgeState1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldNUM1 = new DevExpress.XtraPivotGrid.PivotGridField();
            ((System.ComponentModel.ISupportInitialize)(this.vQry56BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsQueries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControlMain)).BeginInit();
            this.SuspendLayout();
            // 
            // vQry56BindingSource
            // 
            this.vQry56BindingSource.DataMember = "vQry56";
            this.vQry56BindingSource.DataSource = this.dsQueries;
            // 
            // dsQueries
            // 
            this.dsQueries.DataSetName = "dsQueries";
            this.dsQueries.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnPrintExport);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(969, 47);
            this.panelControl1.TabIndex = 3;
            // 
            // btnPrintExport
            // 
            this.btnPrintExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrintExport.Location = new System.Drawing.Point(823, 12);
            this.btnPrintExport.Name = "btnPrintExport";
            this.btnPrintExport.Size = new System.Drawing.Size(134, 23);
            this.btnPrintExport.TabIndex = 0;
            this.btnPrintExport.Text = "طباعه و تصدير";
            this.btnPrintExport.Click += new System.EventHandler(this.btnPrintExport_Click);
            // 
            // vQry56TableAdapter
            // 
            this.vQry56TableAdapter.ClearBeforeFill = true;
            // 
            // pivotGridControlMain
            // 
            this.pivotGridControlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pivotGridControlMain.DataSource = this.vQry56BindingSource;
            this.pivotGridControlMain.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldSyndicate1,
            this.fieldWarasaType1,
            this.fieldAgeState1,
            this.fieldNUM1});
            this.pivotGridControlMain.Location = new System.Drawing.Point(0, 53);
            this.pivotGridControlMain.Name = "pivotGridControlMain";
            this.pivotGridControlMain.Size = new System.Drawing.Size(969, 409);
            this.pivotGridControlMain.TabIndex = 4;
            // 
            // fieldSyndicate1
            // 
            this.fieldSyndicate1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldSyndicate1.AreaIndex = 0;
            this.fieldSyndicate1.Caption = "الفرعية";
            this.fieldSyndicate1.FieldName = "Syndicate";
            this.fieldSyndicate1.Name = "fieldSyndicate1";
            // 
            // fieldWarasaType1
            // 
            this.fieldWarasaType1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldWarasaType1.AreaIndex = 1;
            this.fieldWarasaType1.Caption = "نوع الوريث";
            this.fieldWarasaType1.FieldName = "WarasaType";
            this.fieldWarasaType1.Name = "fieldWarasaType1";
            // 
            // fieldAgeState1
            // 
            this.fieldAgeState1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldAgeState1.AreaIndex = 0;
            this.fieldAgeState1.Caption = "الفئة العمرية";
            this.fieldAgeState1.FieldName = "AgeState";
            this.fieldAgeState1.Name = "fieldAgeState1";
            // 
            // fieldNUM1
            // 
            this.fieldNUM1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldNUM1.AreaIndex = 0;
            this.fieldNUM1.Caption = "العدد";
            this.fieldNUM1.FieldName = "NUM";
            this.fieldNUM1.Name = "fieldNUM1";
            // 
            // Qry56Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 462);
            this.Controls.Add(this.pivotGridControlMain);
            this.Controls.Add(this.panelControl1);
            this.Name = "Qry56Frm";
            this.Text = "الفئات العمرية للورثة";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Qry06Frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vQry56BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsQueries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControlMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnPrintExport;
        private DataSources.dsQueries dsQueries;
        private System.Windows.Forms.BindingSource vQry56BindingSource;
        private DataSources.dsQueriesTableAdapters.vQry56TableAdapter vQry56TableAdapter;
        private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControlMain;
        private DevExpress.XtraPivotGrid.PivotGridField fieldSyndicate1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldWarasaType1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldAgeState1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldNUM1;

    }
}