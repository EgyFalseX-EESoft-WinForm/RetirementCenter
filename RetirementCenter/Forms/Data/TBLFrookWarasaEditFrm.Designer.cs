namespace RetirementCenter.Forms.Data
{
    partial class TBLFrookWarasaEditFrm
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
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            this.layoutControlMain = new DevExpress.XtraLayout.LayoutControl();
            this.tbfrookmony = new DevExpress.XtraEditors.TextEdit();
            this.luefrookid = new DevExpress.XtraEditors.LookUpEdit();
            this.LSMSfrookid = new DevExpress.Data.Linq.LinqServerModeSource();
            this.lueDofatSarfId = new DevExpress.XtraEditors.LookUpEdit();
            this.LSMSDofatSarfId = new DevExpress.Data.Linq.LinqServerModeSource();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.tbfrookreson = new DevExpress.XtraEditors.MemoEdit();
            this.luePersonId = new DevExpress.XtraEditors.GridLookUpEdit();
            this.LSMSPersonId = new DevExpress.Data.Linq.LinqServerModeSource();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colvisa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMMashatName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNameOnCard = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnewid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSyndicate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem11 = new DevExpress.XtraLayout.LayoutControlItem();
            this.dxVP = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlMain)).BeginInit();
            this.layoutControlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbfrookmony.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luefrookid.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSfrookid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueDofatSarfId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSDofatSarfId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbfrookreson.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luePersonId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSPersonId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxVP)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControlMain
            // 
            this.layoutControlMain.Controls.Add(this.tbfrookmony);
            this.layoutControlMain.Controls.Add(this.luefrookid);
            this.layoutControlMain.Controls.Add(this.lueDofatSarfId);
            this.layoutControlMain.Controls.Add(this.btnCancel);
            this.layoutControlMain.Controls.Add(this.btnSave);
            this.layoutControlMain.Controls.Add(this.tbfrookreson);
            this.layoutControlMain.Controls.Add(this.luePersonId);
            this.layoutControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControlMain.Location = new System.Drawing.Point(0, 0);
            this.layoutControlMain.Name = "layoutControlMain";
            this.layoutControlMain.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(757, 104, 250, 350);
            this.layoutControlMain.Root = this.layoutControlGroup1;
            this.layoutControlMain.Size = new System.Drawing.Size(439, 303);
            this.layoutControlMain.TabIndex = 0;
            this.layoutControlMain.Text = "layoutControl1";
            // 
            // tbfrookmony
            // 
            this.tbfrookmony.Location = new System.Drawing.Point(12, 84);
            this.tbfrookmony.Name = "tbfrookmony";
            this.tbfrookmony.Size = new System.Drawing.Size(371, 20);
            this.tbfrookmony.StyleController = this.layoutControlMain;
            this.tbfrookmony.TabIndex = 10;
            // 
            // luefrookid
            // 
            this.luefrookid.Location = new System.Drawing.Point(12, 60);
            this.luefrookid.Name = "luefrookid";
            this.luefrookid.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.luefrookid.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("frookname", "الاسم", 61, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.luefrookid.Properties.DataSource = this.LSMSfrookid;
            this.luefrookid.Properties.DisplayMember = "frookname";
            this.luefrookid.Properties.NullText = "";
            this.luefrookid.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.luefrookid.Properties.ValueMember = "frookid";
            this.luefrookid.Size = new System.Drawing.Size(371, 20);
            this.luefrookid.StyleController = this.layoutControlMain;
            this.luefrookid.TabIndex = 9;
            // 
            // LSMSfrookid
            // 
            this.LSMSfrookid.ElementType = typeof(RetirementCenter.DataSources.Linq.CDFrook);
            this.LSMSfrookid.KeyExpression = "[frookid]";
            // 
            // lueDofatSarfId
            // 
            this.lueDofatSarfId.Enabled = false;
            this.lueDofatSarfId.Location = new System.Drawing.Point(12, 36);
            this.lueDofatSarfId.Name = "lueDofatSarfId";
            this.lueDofatSarfId.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueDofatSarfId.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DofatSarf", "الاسم", 61, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.lueDofatSarfId.Properties.DataSource = this.LSMSDofatSarfId;
            this.lueDofatSarfId.Properties.DisplayMember = "DofatSarf";
            this.lueDofatSarfId.Properties.NullText = "";
            this.lueDofatSarfId.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lueDofatSarfId.Properties.ValueMember = "DofatSarfId";
            this.lueDofatSarfId.Size = new System.Drawing.Size(371, 20);
            this.lueDofatSarfId.StyleController = this.layoutControlMain;
            this.lueDofatSarfId.TabIndex = 8;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "يجب ادخال قيمة";
            conditionValidationRule1.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.dxVP.SetValidationRule(this.lueDofatSarfId, conditionValidationRule1);
            // 
            // LSMSDofatSarfId
            // 
            this.LSMSDofatSarfId.ElementType = typeof(RetirementCenter.DataSources.Linq.CDDofatSarfFrook);
            this.LSMSDofatSarfId.KeyExpression = "[DofatSarfId]";
            // 
            // btnCancel
            // 
            this.btnCancel.Image = global::RetirementCenter.Properties.Resources.cancel_16x16;
            this.btnCancel.Location = new System.Drawing.Point(319, 269);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(108, 22);
            this.btnCancel.StyleController = this.layoutControlMain;
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "الغاء";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = global::RetirementCenter.Properties.Resources.save_16x16;
            this.btnSave.Location = new System.Drawing.Point(12, 269);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(303, 22);
            this.btnSave.StyleController = this.layoutControlMain;
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "حفظ";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tbfrookreson
            // 
            this.tbfrookreson.Location = new System.Drawing.Point(12, 108);
            this.tbfrookreson.Name = "tbfrookreson";
            this.tbfrookreson.Size = new System.Drawing.Size(371, 157);
            this.tbfrookreson.StyleController = this.layoutControlMain;
            this.tbfrookreson.TabIndex = 1;
            // 
            // luePersonId
            // 
            this.luePersonId.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.luePersonId.Enabled = false;
            this.luePersonId.Location = new System.Drawing.Point(12, 12);
            this.luePersonId.Margin = new System.Windows.Forms.Padding(0);
            this.luePersonId.Name = "luePersonId";
            this.luePersonId.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.luePersonId.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.luePersonId.Properties.DataSource = this.LSMSPersonId;
            this.luePersonId.Properties.DisplayMember = "personName";
            this.luePersonId.Properties.NullText = "";
            this.luePersonId.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.luePersonId.Properties.ValueMember = "PersonId";
            this.luePersonId.Properties.View = this.gridLookUpEdit1View;
            this.luePersonId.Size = new System.Drawing.Size(371, 20);
            this.luePersonId.StyleController = this.layoutControlMain;
            this.luePersonId.TabIndex = 0;
            // 
            // LSMSPersonId
            // 
            this.LSMSPersonId.ElementType = typeof(RetirementCenter.DataSources.Linq.vTBLWarasa_TBLMashat);
            this.LSMSPersonId.KeyExpression = "[personid]";
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colvisa,
            this.colMMashatName,
            this.colNameOnCard,
            this.colnewid,
            this.colSyndicate});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ColumnAutoWidth = false;
            this.gridLookUpEdit1View.OptionsView.ShowAutoFilterRow = true;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colvisa
            // 
            this.colvisa.AppearanceCell.Options.UseTextOptions = true;
            this.colvisa.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colvisa.AppearanceHeader.Options.UseTextOptions = true;
            this.colvisa.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colvisa.Caption = "الاسم";
            this.colvisa.FieldName = "personName";
            this.colvisa.Name = "colvisa";
            this.colvisa.Visible = true;
            this.colvisa.VisibleIndex = 0;
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
            this.colMMashatName.VisibleIndex = 3;
            // 
            // colNameOnCard
            // 
            this.colNameOnCard.AppearanceCell.Options.UseTextOptions = true;
            this.colNameOnCard.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNameOnCard.AppearanceHeader.Options.UseTextOptions = true;
            this.colNameOnCard.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNameOnCard.Caption = "رقم الصرف";
            this.colNameOnCard.FieldName = "sarfnumber";
            this.colNameOnCard.Name = "colNameOnCard";
            this.colNameOnCard.Visible = true;
            this.colNameOnCard.VisibleIndex = 4;
            // 
            // colnewid
            // 
            this.colnewid.AppearanceCell.Options.UseTextOptions = true;
            this.colnewid.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colnewid.AppearanceHeader.Options.UseTextOptions = true;
            this.colnewid.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colnewid.Caption = "اللجنة";
            this.colnewid.FieldName = "SubCommitte";
            this.colnewid.Name = "colnewid";
            this.colnewid.Visible = true;
            this.colnewid.VisibleIndex = 2;
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
            this.colSyndicate.VisibleIndex = 1;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem9,
            this.layoutControlItem10,
            this.layoutControlItem11});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(439, 303);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem1.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.layoutControlItem1.Control = this.luePersonId;
            this.layoutControlItem1.CustomizationFormText = "الوريث";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(419, 24);
            this.layoutControlItem1.Text = "الوريث";
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Right;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(41, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem2.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.layoutControlItem2.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.layoutControlItem2.Control = this.tbfrookreson;
            this.layoutControlItem2.CustomizationFormText = "ملاحظات";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(419, 161);
            this.layoutControlItem2.Text = "ملاحظات";
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Right;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(41, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnSave;
            this.layoutControlItem3.CustomizationFormText = "layoutControlItem3";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 257);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(307, 26);
            this.layoutControlItem3.Text = "layoutControlItem3";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextToControlDistance = 0;
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btnCancel;
            this.layoutControlItem4.CustomizationFormText = "layoutControlItem4";
            this.layoutControlItem4.Location = new System.Drawing.Point(307, 257);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(112, 26);
            this.layoutControlItem4.Text = "layoutControlItem4";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextToControlDistance = 0;
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem9.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.layoutControlItem9.Control = this.lueDofatSarfId;
            this.layoutControlItem9.CustomizationFormText = "الدفعة";
            this.layoutControlItem9.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(419, 24);
            this.layoutControlItem9.Text = "الدفعة";
            this.layoutControlItem9.TextLocation = DevExpress.Utils.Locations.Right;
            this.layoutControlItem9.TextSize = new System.Drawing.Size(41, 13);
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem10.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.layoutControlItem10.Control = this.luefrookid;
            this.layoutControlItem10.CustomizationFormText = "النوع";
            this.layoutControlItem10.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.Size = new System.Drawing.Size(419, 24);
            this.layoutControlItem10.Text = "النوع";
            this.layoutControlItem10.TextLocation = DevExpress.Utils.Locations.Right;
            this.layoutControlItem10.TextSize = new System.Drawing.Size(41, 13);
            // 
            // layoutControlItem11
            // 
            this.layoutControlItem11.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem11.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.layoutControlItem11.Control = this.tbfrookmony;
            this.layoutControlItem11.CustomizationFormText = "المبلغ";
            this.layoutControlItem11.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem11.Name = "layoutControlItem11";
            this.layoutControlItem11.Size = new System.Drawing.Size(419, 24);
            this.layoutControlItem11.Text = "المبلغ";
            this.layoutControlItem11.TextLocation = DevExpress.Utils.Locations.Right;
            this.layoutControlItem11.TextSize = new System.Drawing.Size(41, 13);
            // 
            // TBLFrookWarasaEditFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 303);
            this.Controls.Add(this.layoutControlMain);
            this.Name = "TBLFrookWarasaEditFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اضافة";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlMain)).EndInit();
            this.layoutControlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbfrookmony.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luefrookid.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSfrookid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueDofatSarfId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSDofatSarfId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbfrookreson.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luePersonId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSPersonId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxVP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControlMain;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.MemoEdit tbfrookreson;
        public DevExpress.XtraEditors.GridLookUpEdit luePersonId;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.Data.Linq.LinqServerModeSource LSMSPersonId;
        private DevExpress.Data.Linq.LinqServerModeSource LSMSDofatSarfId;
        private DevExpress.XtraGrid.Columns.GridColumn colvisa;
        private DevExpress.XtraGrid.Columns.GridColumn colNameOnCard;
        private DevExpress.XtraGrid.Columns.GridColumn colnewid;
        private DevExpress.XtraGrid.Columns.GridColumn colMMashatName;
        private DevExpress.XtraGrid.Columns.GridColumn colSyndicate;
        private DevExpress.XtraEditors.LookUpEdit lueDofatSarfId;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraEditors.LookUpEdit luefrookid;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
        private DevExpress.XtraEditors.TextEdit tbfrookmony;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem11;
        private DevExpress.Data.Linq.LinqServerModeSource LSMSfrookid;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxVP;
    }
}