namespace RetirementCenter.Forms.Main
{
    partial class ImportBankDataFrm
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
            this.layoutControlMain = new DevExpress.XtraLayout.LayoutControl();
            this.btnImportWarasaBank = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciBtnImportWarasaBank = new DevExpress.XtraLayout.LayoutControlItem();
            this.btnImportMemberBank = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlMain)).BeginInit();
            this.layoutControlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciBtnImportWarasaBank)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControlMain
            // 
            this.layoutControlMain.Controls.Add(this.btnImportMemberBank);
            this.layoutControlMain.Controls.Add(this.btnImportWarasaBank);
            this.layoutControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControlMain.Location = new System.Drawing.Point(0, 0);
            this.layoutControlMain.Name = "layoutControlMain";
            this.layoutControlMain.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(751, 118, 250, 350);
            this.layoutControlMain.OptionsView.UseDefaultDragAndDropRendering = false;
            this.layoutControlMain.Root = this.layoutControlGroup1;
            this.layoutControlMain.Size = new System.Drawing.Size(492, 316);
            this.layoutControlMain.TabIndex = 0;
            this.layoutControlMain.Text = "layoutControl1";
            // 
            // btnImportWarasaBank
            // 
            this.btnImportWarasaBank.Location = new System.Drawing.Point(12, 38);
            this.btnImportWarasaBank.Name = "btnImportWarasaBank";
            this.btnImportWarasaBank.Size = new System.Drawing.Size(468, 22);
            this.btnImportWarasaBank.StyleController = this.layoutControlMain;
            this.btnImportWarasaBank.TabIndex = 4;
            this.btnImportWarasaBank.Text = "Import Warasa Data";
            this.btnImportWarasaBank.Click += new System.EventHandler(this.btnImportWarasaBank_Click);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.lciBtnImportWarasaBank});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(492, 316);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // lciBtnImportWarasaBank
            // 
            this.lciBtnImportWarasaBank.Control = this.btnImportWarasaBank;
            this.lciBtnImportWarasaBank.CustomizationFormText = "layoutControlItem1";
            this.lciBtnImportWarasaBank.Location = new System.Drawing.Point(0, 26);
            this.lciBtnImportWarasaBank.Name = "lciBtnImportWarasaBank";
            this.lciBtnImportWarasaBank.Size = new System.Drawing.Size(472, 270);
            this.lciBtnImportWarasaBank.Text = "lciBtnImportWarasaBank";
            this.lciBtnImportWarasaBank.TextSize = new System.Drawing.Size(0, 0);
            this.lciBtnImportWarasaBank.TextToControlDistance = 0;
            this.lciBtnImportWarasaBank.TextVisible = false;
            // 
            // btnImportMemberBank
            // 
            this.btnImportMemberBank.Location = new System.Drawing.Point(12, 12);
            this.btnImportMemberBank.Name = "btnImportMemberBank";
            this.btnImportMemberBank.Size = new System.Drawing.Size(468, 22);
            this.btnImportMemberBank.StyleController = this.layoutControlMain;
            this.btnImportMemberBank.TabIndex = 4;
            this.btnImportMemberBank.Text = "Import Member Data";
            this.btnImportMemberBank.Click += new System.EventHandler(this.btnImportMemberBank_Click);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.btnImportMemberBank;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(472, 26);
            this.layoutControlItem1.Text = "layoutControlItem1";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextToControlDistance = 0;
            this.layoutControlItem1.TextVisible = false;
            // 
            // ImportBankDataFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 316);
            this.Controls.Add(this.layoutControlMain);
            this.Name = "ImportBankDataFrm";
            this.Text = "Import Bank Data";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlMain)).EndInit();
            this.layoutControlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciBtnImportWarasaBank)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControlMain;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.SimpleButton btnImportWarasaBank;
        private DevExpress.XtraLayout.LayoutControlItem lciBtnImportWarasaBank;
        private DevExpress.XtraEditors.SimpleButton btnImportMemberBank;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    }
}