namespace RetirementCenter
{
    partial class ImportFrombamanatFrm
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
            DevExpress.XtraEditors.DXErrorProvider.CompareAgainstControlValidationRule compareAgainstControlValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.CompareAgainstControlValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.CompareAgainstControlValidationRule compareAgainstControlValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.CompareAgainstControlValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule3 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            this.deGetback = new DevExpress.XtraEditors.DateEdit();
            this.deSendbankDate = new DevExpress.XtraEditors.DateEdit();
            this.groupControlInfo = new DevExpress.XtraEditors.GroupControl();
            this.lueDof = new DevExpress.XtraEditors.LookUpEdit();
            this.cdDofaatAmanatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsRetirementCenter = new RetirementCenter.DataSources.dsRetirementCenter();
            this.btnImport = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.lblCounter = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControlOp = new DevExpress.XtraEditors.GroupControl();
            this.pbc = new DevExpress.XtraEditors.ProgressBarControl();
            this.dsdatam = new RetirementCenter.DataSources.dsdatam();
            this.cdDofaatAmanatTableAdapter = new RetirementCenter.DataSources.dsRetirementCenterTableAdapters.CdDofaatAmanatTableAdapter();
            this.dxvp_NotBlank = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.dxvpIsBigerDate = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.dsbamanat = new RetirementCenter.DataSources.dsbamanat();
            ((System.ComponentModel.ISupportInitialize)(this.deGetback.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deGetback.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deSendbankDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deSendbankDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlInfo)).BeginInit();
            this.groupControlInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueDof.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cdDofaatAmanatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRetirementCenter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlOp)).BeginInit();
            this.groupControlOp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsdatam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxvp_NotBlank)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxvpIsBigerDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsbamanat)).BeginInit();
            this.SuspendLayout();
            // 
            // deGetback
            // 
            this.deGetback.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deGetback.EditValue = null;
            this.deGetback.Location = new System.Drawing.Point(37, 50);
            this.deGetback.Name = "deGetback";
            this.deGetback.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deGetback.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.deGetback.Size = new System.Drawing.Size(192, 20);
            this.deGetback.TabIndex = 1;
            compareAgainstControlValidationRule1.CompareControlOperator = DevExpress.XtraEditors.DXErrorProvider.CompareControlOperator.Greater;
            compareAgainstControlValidationRule1.Control = this.deSendbankDate;
            compareAgainstControlValidationRule1.ErrorText = "يجب ان يكون تاريخ الارسال اقل من تاريخ الوصول";
            this.dxvpIsBigerDate.SetValidationRule(this.deGetback, compareAgainstControlValidationRule1);
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "This value is not valid";
            this.dxvp_NotBlank.SetValidationRule(this.deGetback, conditionValidationRule2);
            // 
            // deSendbankDate
            // 
            this.deSendbankDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deSendbankDate.EditValue = null;
            this.deSendbankDate.Location = new System.Drawing.Point(37, 24);
            this.deSendbankDate.Name = "deSendbankDate";
            this.deSendbankDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deSendbankDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.deSendbankDate.Size = new System.Drawing.Size(192, 20);
            this.deSendbankDate.TabIndex = 0;
            compareAgainstControlValidationRule2.CompareControlOperator = DevExpress.XtraEditors.DXErrorProvider.CompareControlOperator.Less;
            compareAgainstControlValidationRule2.Control = this.deGetback;
            compareAgainstControlValidationRule2.ErrorText = "يجب ان يكون تاريخ الارسال اقل من تاريخ الوصول";
            this.dxvpIsBigerDate.SetValidationRule(this.deSendbankDate, compareAgainstControlValidationRule2);
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "This value is not valid";
            this.dxvp_NotBlank.SetValidationRule(this.deSendbankDate, conditionValidationRule1);
            // 
            // groupControlInfo
            // 
            this.groupControlInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControlInfo.AppearanceCaption.Options.UseTextOptions = true;
            this.groupControlInfo.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.groupControlInfo.Controls.Add(this.lueDof);
            this.groupControlInfo.Controls.Add(this.deGetback);
            this.groupControlInfo.Controls.Add(this.deSendbankDate);
            this.groupControlInfo.Controls.Add(this.btnImport);
            this.groupControlInfo.Controls.Add(this.labelControl4);
            this.groupControlInfo.Controls.Add(this.labelControl3);
            this.groupControlInfo.Controls.Add(this.lblCounter);
            this.groupControlInfo.Controls.Add(this.labelControl2);
            this.groupControlInfo.Controls.Add(this.labelControl1);
            this.groupControlInfo.Location = new System.Drawing.Point(345, 12);
            this.groupControlInfo.Name = "groupControlInfo";
            this.groupControlInfo.Size = new System.Drawing.Size(327, 142);
            this.groupControlInfo.TabIndex = 0;
            this.groupControlInfo.Text = "استيراد بيانات";
            // 
            // lueDof
            // 
            this.lueDof.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lueDof.Location = new System.Drawing.Point(37, 76);
            this.lueDof.Name = "lueDof";
            this.lueDof.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueDof.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DofatSarfA", "الاسم", 70, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.lueDof.Properties.DataSource = this.cdDofaatAmanatBindingSource;
            this.lueDof.Properties.DisplayMember = "DofatSarfA";
            this.lueDof.Properties.NullText = "";
            this.lueDof.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lueDof.Properties.ValueMember = "DofatSarfAId";
            this.lueDof.Size = new System.Drawing.Size(192, 20);
            this.lueDof.TabIndex = 2;
            conditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule3.ErrorText = "This value is not valid";
            this.dxvp_NotBlank.SetValidationRule(this.lueDof, conditionValidationRule3);
            // 
            // cdDofaatAmanatBindingSource
            // 
            this.cdDofaatAmanatBindingSource.DataMember = "CdDofaatAmanat";
            this.cdDofaatAmanatBindingSource.DataSource = this.dsRetirementCenter;
            // 
            // dsRetirementCenter
            // 
            this.dsRetirementCenter.DataSetName = "dsRetirementCenter";
            this.dsRetirementCenter.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnImport
            // 
            this.btnImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImport.Location = new System.Drawing.Point(37, 111);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(100, 23);
            this.btnImport.TabIndex = 3;
            this.btnImport.Text = "بدء اللاستيراد";
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl4.Location = new System.Drawing.Point(262, 79);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(59, 13);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "دفعة الامانات";
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl3.Location = new System.Drawing.Point(235, 53);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(87, 13);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "تاريخ وصول الامانات";
            // 
            // lblCounter
            // 
            this.lblCounter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCounter.Location = new System.Drawing.Point(212, 121);
            this.lblCounter.Name = "lblCounter";
            this.lblCounter.Size = new System.Drawing.Size(6, 13);
            this.lblCounter.TabIndex = 0;
            this.lblCounter.Text = "0";
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl2.Location = new System.Drawing.Point(235, 27);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(86, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "تاريخ الارسال للبنك";
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Location = new System.Drawing.Point(281, 121);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(23, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "العدد";
            // 
            // groupControlOp
            // 
            this.groupControlOp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControlOp.AppearanceCaption.Options.UseTextOptions = true;
            this.groupControlOp.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.groupControlOp.Controls.Add(this.pbc);
            this.groupControlOp.Location = new System.Drawing.Point(12, 164);
            this.groupControlOp.Name = "groupControlOp";
            this.groupControlOp.Size = new System.Drawing.Size(660, 47);
            this.groupControlOp.TabIndex = 1;
            this.groupControlOp.Text = "العمليات";
            // 
            // pbc
            // 
            this.pbc.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pbc.Location = new System.Drawing.Point(2, 27);
            this.pbc.Name = "pbc";
            this.pbc.Size = new System.Drawing.Size(656, 18);
            this.pbc.TabIndex = 1;
            // 
            // dsdatam
            // 
            this.dsdatam.DataSetName = "dsdatam";
            this.dsdatam.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cdDofaatAmanatTableAdapter
            // 
            this.cdDofaatAmanatTableAdapter.ClearBeforeFill = true;
            // 
            // dsbamanat
            // 
            this.dsbamanat.DataSetName = "dsbamanat";
            this.dsbamanat.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ImportFrombamanatFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 223);
            this.Controls.Add(this.groupControlOp);
            this.Controls.Add(this.groupControlInfo);
            this.Name = "ImportFrombamanatFrm";
            this.Text = "استيراد";
            this.Load += new System.EventHandler(this.ImportFromWebFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.deGetback.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deGetback.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deSendbankDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deSendbankDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlInfo)).EndInit();
            this.groupControlInfo.ResumeLayout(false);
            this.groupControlInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueDof.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cdDofaatAmanatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRetirementCenter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlOp)).EndInit();
            this.groupControlOp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsdatam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxvp_NotBlank)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxvpIsBigerDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsbamanat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControlInfo;
        private DevExpress.XtraEditors.GroupControl groupControlOp;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl lblCounter;
        private DevExpress.XtraEditors.ProgressBarControl pbc;
        private DevExpress.XtraEditors.SimpleButton btnImport;
        private DataSources.dsdatam dsdatam;
        private DataSources.dsRetirementCenter dsRetirementCenter;
        private DevExpress.XtraEditors.DateEdit deSendbankDate;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.DateEdit deGetback;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LookUpEdit lueDof;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.BindingSource cdDofaatAmanatBindingSource;
        private DataSources.dsRetirementCenterTableAdapters.CdDofaatAmanatTableAdapter cdDofaatAmanatTableAdapter;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxvp_NotBlank;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxvpIsBigerDate;
        private DataSources.dsbamanat dsbamanat;
    }
}