namespace RetirementCenter
{
    partial class Qry115AFrm
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
            this.vQry115ABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsQueries = new RetirementCenter.DataSources.dsQueries();
            this.panelControlMain = new DevExpress.XtraEditors.PanelControl();
            this.LueFilter = new DevExpress.XtraEditors.LookUpEdit();
            this.LSMSDof = new DevExpress.Data.Linq.LinqServerModeSource();
            this.vQry115ATableAdapter = new RetirementCenter.DataSources.dsQueriesTableAdapters.vQry115ATableAdapter();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.tbEstktaa = new DevExpress.XtraEditors.TextEdit();
            this.tbEshtrak = new DevExpress.XtraEditors.TextEdit();
            this.tbRasm = new DevExpress.XtraEditors.TextEdit();
            this.tbTotal = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.tbNet = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.vQry115ABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsQueries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlMain)).BeginInit();
            this.panelControlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LueFilter.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSDof)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbEstktaa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbEshtrak.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbRasm.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbNet.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            this.SuspendLayout();
            // 
            // vQry115ABindingSource
            // 
            this.vQry115ABindingSource.DataMember = "vQry115A";
            this.vQry115ABindingSource.DataSource = this.dsQueries;
            // 
            // dsQueries
            // 
            this.dsQueries.DataSetName = "dsQueries";
            this.dsQueries.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panelControlMain
            // 
            this.panelControlMain.Controls.Add(this.LueFilter);
            this.panelControlMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControlMain.Location = new System.Drawing.Point(0, 0);
            this.panelControlMain.Name = "panelControlMain";
            this.panelControlMain.Size = new System.Drawing.Size(365, 44);
            this.panelControlMain.TabIndex = 0;
            // 
            // LueFilter
            // 
            this.LueFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LueFilter.Location = new System.Drawing.Point(11, 13);
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
            this.LueFilter.Size = new System.Drawing.Size(342, 20);
            this.LueFilter.TabIndex = 1;
            this.LueFilter.EditValueChanged += new System.EventHandler(this.LueFilter_EditValueChanged);
            // 
            // LSMSDof
            // 
            this.LSMSDof.ElementType = typeof(RetirementCenter.DataSources.Linq.TBLDofatSarf);
            this.LSMSDof.KeyExpression = "[DofatSarfId]";
            // 
            // vQry115ATableAdapter
            // 
            this.vQry115ATableAdapter.ClearBeforeFill = true;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.tbNet);
            this.layoutControl1.Controls.Add(this.tbEstktaa);
            this.layoutControl1.Controls.Add(this.tbEshtrak);
            this.layoutControl1.Controls.Add(this.tbRasm);
            this.layoutControl1.Controls.Add(this.tbTotal);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 44);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(761, 277, 366, 481);
            this.layoutControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(365, 144);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // tbEstktaa
            // 
            this.tbEstktaa.Location = new System.Drawing.Point(12, 84);
            this.tbEstktaa.Name = "tbEstktaa";
            this.tbEstktaa.Properties.DisplayFormat.FormatString = "n2";
            this.tbEstktaa.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.tbEstktaa.Properties.EditFormat.FormatString = "n2";
            this.tbEstktaa.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.tbEstktaa.Properties.ReadOnly = true;
            this.tbEstktaa.Size = new System.Drawing.Size(272, 20);
            this.tbEstktaa.StyleController = this.layoutControl1;
            this.tbEstktaa.TabIndex = 7;
            // 
            // tbEshtrak
            // 
            this.tbEshtrak.Location = new System.Drawing.Point(12, 60);
            this.tbEshtrak.Name = "tbEshtrak";
            this.tbEshtrak.Properties.DisplayFormat.FormatString = "n2";
            this.tbEshtrak.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.tbEshtrak.Properties.EditFormat.FormatString = "n2";
            this.tbEshtrak.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.tbEshtrak.Properties.ReadOnly = true;
            this.tbEshtrak.Size = new System.Drawing.Size(272, 20);
            this.tbEshtrak.StyleController = this.layoutControl1;
            this.tbEshtrak.TabIndex = 6;
            // 
            // tbRasm
            // 
            this.tbRasm.Location = new System.Drawing.Point(12, 36);
            this.tbRasm.Name = "tbRasm";
            this.tbRasm.Properties.DisplayFormat.FormatString = "n2";
            this.tbRasm.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.tbRasm.Properties.EditFormat.FormatString = "n2";
            this.tbRasm.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.tbRasm.Properties.ReadOnly = true;
            this.tbRasm.Size = new System.Drawing.Size(272, 20);
            this.tbRasm.StyleController = this.layoutControl1;
            this.tbRasm.TabIndex = 5;
            // 
            // tbTotal
            // 
            this.tbTotal.Location = new System.Drawing.Point(12, 12);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.Properties.DisplayFormat.FormatString = "n2";
            this.tbTotal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.tbTotal.Properties.EditFormat.FormatString = "n2";
            this.tbTotal.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.tbTotal.Properties.ReadOnly = true;
            this.tbTotal.Size = new System.Drawing.Size(272, 20);
            this.tbTotal.StyleController = this.layoutControl1;
            this.tbTotal.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem3,
            this.layoutControlItem2,
            this.layoutControlItem4,
            this.layoutControlItem5});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(365, 144);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.tbTotal;
            this.layoutControlItem1.CustomizationFormText = "اجمالي الدفعة";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(345, 24);
            this.layoutControlItem1.Text = "اجمالي الدفعة";
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Right;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(66, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.tbEshtrak;
            this.layoutControlItem3.CustomizationFormText = "layoutControlItem3";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(345, 24);
            this.layoutControlItem3.Text = "اشتراك";
            this.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Right;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(66, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.tbRasm;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(345, 24);
            this.layoutControlItem2.Text = "رسم";
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Right;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(66, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.tbEstktaa;
            this.layoutControlItem4.CustomizationFormText = "layoutControlItem4";
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(345, 24);
            this.layoutControlItem4.Text = "استقطاع";
            this.layoutControlItem4.TextLocation = DevExpress.Utils.Locations.Right;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(66, 13);
            // 
            // tbNet
            // 
            this.tbNet.Location = new System.Drawing.Point(12, 108);
            this.tbNet.Name = "tbNet";
            this.tbNet.Properties.DisplayFormat.FormatString = "n2";
            this.tbNet.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.tbNet.Properties.EditFormat.FormatString = "n2";
            this.tbNet.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.tbNet.Properties.ReadOnly = true;
            this.tbNet.Size = new System.Drawing.Size(272, 20);
            this.tbNet.StyleController = this.layoutControl1;
            this.tbNet.TabIndex = 8;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.tbNet;
            this.layoutControlItem5.CustomizationFormText = "صافي";
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(345, 28);
            this.layoutControlItem5.Text = "صافي";
            this.layoutControlItem5.TextLocation = DevExpress.Utils.Locations.Right;
            this.layoutControlItem5.TextSize = new System.Drawing.Size(66, 13);
            // 
            // Qry115AFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 188);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.panelControlMain);
            this.Name = "Qry115AFrm";
            this.Text = "ارشيف صرف الاعضاء - احصاء مفصل";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Qry06Frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vQry115ABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsQueries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlMain)).EndInit();
            this.panelControlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LueFilter.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSDof)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbEstktaa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbEshtrak.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbRasm.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbNet.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControlMain;
        private DevExpress.Data.Linq.LinqServerModeSource LSMSDof;
        private DevExpress.XtraEditors.LookUpEdit LueFilter;
        private System.Windows.Forms.BindingSource vQry115ABindingSource;
        private DataSources.dsQueries dsQueries;
        private DataSources.dsQueriesTableAdapters.vQry115ATableAdapter vQry115ATableAdapter;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.TextEdit tbEstktaa;
        private DevExpress.XtraEditors.TextEdit tbEshtrak;
        private DevExpress.XtraEditors.TextEdit tbRasm;
        private DevExpress.XtraEditors.TextEdit tbTotal;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.TextEdit tbNet;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;

    }
}