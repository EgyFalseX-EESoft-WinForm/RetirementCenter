namespace RetirementCenter.Forms.Data
{
    partial class TBLReprintMemberAddFrm
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
            this.dewaredbankdate = new DevExpress.XtraEditors.DateEdit();
            this.desendbankdate = new DevExpress.XtraEditors.DateEdit();
            this.luereprintresonid = new DevExpress.XtraEditors.LookUpEdit();
            this.LSMSCDreprintreson = new DevExpress.Data.Linq.LinqServerModeSource();
            this.dereprintdate = new DevExpress.XtraEditors.DateEdit();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.tbreprintremark = new DevExpress.XtraEditors.MemoEdit();
            this.lueMMashatId = new DevExpress.XtraEditors.GridLookUpEdit();
            this.LSMSDATA = new DevExpress.Data.Linq.LinqServerModeSource();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMMashatName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSyndicate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsarfnumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMashHala = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colyasref = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMMashatNId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.colvisa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMMashatId = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlMain)).BeginInit();
            this.layoutControlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dewaredbankdate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dewaredbankdate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.desendbankdate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.desendbankdate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luereprintresonid.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSCDreprintreson)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dereprintdate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dereprintdate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbreprintremark.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueMMashatId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSDATA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControlMain
            // 
            this.layoutControlMain.Controls.Add(this.dewaredbankdate);
            this.layoutControlMain.Controls.Add(this.desendbankdate);
            this.layoutControlMain.Controls.Add(this.luereprintresonid);
            this.layoutControlMain.Controls.Add(this.dereprintdate);
            this.layoutControlMain.Controls.Add(this.btnCancel);
            this.layoutControlMain.Controls.Add(this.btnSave);
            this.layoutControlMain.Controls.Add(this.tbreprintremark);
            this.layoutControlMain.Controls.Add(this.lueMMashatId);
            this.layoutControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControlMain.Location = new System.Drawing.Point(0, 0);
            this.layoutControlMain.Name = "layoutControlMain";
            this.layoutControlMain.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(757, 104, 250, 350);
            this.layoutControlMain.Root = this.layoutControlGroup1;
            this.layoutControlMain.Size = new System.Drawing.Size(439, 303);
            this.layoutControlMain.TabIndex = 0;
            this.layoutControlMain.Text = "layoutControl1";
            // 
            // dewaredbankdate
            // 
            this.dewaredbankdate.EditValue = null;
            this.dewaredbankdate.Location = new System.Drawing.Point(12, 245);
            this.dewaredbankdate.Name = "dewaredbankdate";
            this.dewaredbankdate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dewaredbankdate.Properties.DisplayFormat.FormatString = "d/M/yyyy";
            this.dewaredbankdate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dewaredbankdate.Properties.EditFormat.FormatString = "d/M/yyyy";
            this.dewaredbankdate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dewaredbankdate.Properties.Mask.EditMask = "d/M/yyyy";
            this.dewaredbankdate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dewaredbankdate.Size = new System.Drawing.Size(353, 20);
            this.dewaredbankdate.StyleController = this.layoutControlMain;
            this.dewaredbankdate.TabIndex = 7;
            // 
            // desendbankdate
            // 
            this.desendbankdate.EditValue = null;
            this.desendbankdate.Location = new System.Drawing.Point(12, 221);
            this.desendbankdate.Name = "desendbankdate";
            this.desendbankdate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.desendbankdate.Properties.DisplayFormat.FormatString = "d/M/yyyy";
            this.desendbankdate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.desendbankdate.Properties.EditFormat.FormatString = "d/M/yyyy";
            this.desendbankdate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.desendbankdate.Properties.Mask.EditMask = "d/M/yyyy";
            this.desendbankdate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.desendbankdate.Size = new System.Drawing.Size(353, 20);
            this.desendbankdate.StyleController = this.layoutControlMain;
            this.desendbankdate.TabIndex = 6;
            // 
            // luereprintresonid
            // 
            this.luereprintresonid.Location = new System.Drawing.Point(12, 60);
            this.luereprintresonid.Name = "luereprintresonid";
            this.luereprintresonid.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.luereprintresonid.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("reprintreson", "الاسم", 69, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.luereprintresonid.Properties.DataSource = this.LSMSCDreprintreson;
            this.luereprintresonid.Properties.DisplayMember = "reprintreson";
            this.luereprintresonid.Properties.NullText = "";
            this.luereprintresonid.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.luereprintresonid.Properties.ValueMember = "reprintresonid";
            this.luereprintresonid.Size = new System.Drawing.Size(353, 20);
            this.luereprintresonid.StyleController = this.layoutControlMain;
            this.luereprintresonid.TabIndex = 5;
            // 
            // LSMSCDreprintreson
            // 
            this.LSMSCDreprintreson.ElementType = typeof(RetirementCenter.DataSources.Linq.CDreprintreson);
            this.LSMSCDreprintreson.KeyExpression = "[reprintresonid]";
            // 
            // dereprintdate
            // 
            this.dereprintdate.EditValue = null;
            this.dereprintdate.Location = new System.Drawing.Point(12, 36);
            this.dereprintdate.Name = "dereprintdate";
            this.dereprintdate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dereprintdate.Properties.DisplayFormat.FormatString = "d/M/yyyy";
            this.dereprintdate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dereprintdate.Properties.EditFormat.FormatString = "d/M/yyyy";
            this.dereprintdate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dereprintdate.Properties.Mask.EditMask = "d/M/yyyy";
            this.dereprintdate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dereprintdate.Size = new System.Drawing.Size(353, 20);
            this.dereprintdate.StyleController = this.layoutControlMain;
            this.dereprintdate.TabIndex = 4;
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
            // tbreprintremark
            // 
            this.tbreprintremark.Location = new System.Drawing.Point(12, 84);
            this.tbreprintremark.Name = "tbreprintremark";
            this.tbreprintremark.Size = new System.Drawing.Size(353, 133);
            this.tbreprintremark.StyleController = this.layoutControlMain;
            this.tbreprintremark.TabIndex = 1;
            // 
            // lueMMashatId
            // 
            this.lueMMashatId.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lueMMashatId.Location = new System.Drawing.Point(12, 12);
            this.lueMMashatId.Margin = new System.Windows.Forms.Padding(0);
            this.lueMMashatId.Name = "lueMMashatId";
            this.lueMMashatId.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.lueMMashatId.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueMMashatId.Properties.DataSource = this.LSMSDATA;
            this.lueMMashatId.Properties.DisplayMember = "MMashatName";
            this.lueMMashatId.Properties.NullText = "";
            this.lueMMashatId.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lueMMashatId.Properties.ValueMember = "MMashatId";
            this.lueMMashatId.Properties.View = this.gridLookUpEdit1View;
            this.lueMMashatId.Size = new System.Drawing.Size(353, 20);
            this.lueMMashatId.StyleController = this.layoutControlMain;
            this.lueMMashatId.TabIndex = 0;
            // 
            // LSMSDATA
            // 
            this.LSMSDATA.ElementType = typeof(RetirementCenter.DataSources.Linq.vTBLMashat);
            this.LSMSDATA.KeyExpression = "MMashatId";
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMMashatId,
            this.colMMashatName,
            this.colSyndicate,
            this.colvisa,
            this.colsarfnumber,
            this.colMashHala,
            this.colyasref,
            this.colMMashatNId});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ColumnAutoWidth = false;
            this.gridLookUpEdit1View.OptionsView.ShowAutoFilterRow = true;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
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
            this.colMMashatName.VisibleIndex = 1;
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
            this.colSyndicate.VisibleIndex = 2;
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
            this.colsarfnumber.VisibleIndex = 4;
            // 
            // colMashHala
            // 
            this.colMashHala.AppearanceCell.Options.UseTextOptions = true;
            this.colMashHala.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMashHala.AppearanceHeader.Options.UseTextOptions = true;
            this.colMashHala.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMashHala.Caption = "نوع البيان";
            this.colMashHala.FieldName = "MashHala";
            this.colMashHala.Name = "colMashHala";
            this.colMashHala.Visible = true;
            this.colMashHala.VisibleIndex = 5;
            // 
            // colyasref
            // 
            this.colyasref.AppearanceCell.Options.UseTextOptions = true;
            this.colyasref.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colyasref.AppearanceHeader.Options.UseTextOptions = true;
            this.colyasref.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colyasref.Caption = "يصرف";
            this.colyasref.FieldName = "yasref";
            this.colyasref.Name = "colyasref";
            this.colyasref.Visible = true;
            this.colyasref.VisibleIndex = 6;
            // 
            // colMMashatNId
            // 
            this.colMMashatNId.AppearanceCell.Options.UseTextOptions = true;
            this.colMMashatNId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMMashatNId.AppearanceHeader.Options.UseTextOptions = true;
            this.colMMashatNId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMMashatNId.Caption = "الرقم القومي";
            this.colMMashatNId.FieldName = "MMashatNId";
            this.colMMashatNId.Name = "colMMashatNId";
            this.colMMashatNId.Visible = true;
            this.colMMashatNId.VisibleIndex = 7;
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
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.layoutControlItem8});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(439, 303);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.lueMMashatId;
            this.layoutControlItem1.CustomizationFormText = "العضو";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(419, 24);
            this.layoutControlItem1.Text = "العضو";
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Right;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(59, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem2.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.layoutControlItem2.Control = this.tbreprintremark;
            this.layoutControlItem2.CustomizationFormText = "الطلب     ";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(419, 137);
            this.layoutControlItem2.Text = "ملاحظات";
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Right;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(59, 13);
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
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.dereprintdate;
            this.layoutControlItem5.CustomizationFormText = "التاريخ";
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(419, 24);
            this.layoutControlItem5.Text = "التاريخ";
            this.layoutControlItem5.TextLocation = DevExpress.Utils.Locations.Right;
            this.layoutControlItem5.TextSize = new System.Drawing.Size(59, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.luereprintresonid;
            this.layoutControlItem6.CustomizationFormText = "السبب";
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(419, 24);
            this.layoutControlItem6.Text = "السبب";
            this.layoutControlItem6.TextLocation = DevExpress.Utils.Locations.Right;
            this.layoutControlItem6.TextSize = new System.Drawing.Size(59, 13);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.desendbankdate;
            this.layoutControlItem7.CustomizationFormText = "تاريخ الارسال";
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 209);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(419, 24);
            this.layoutControlItem7.Text = "تاريخ الارسال";
            this.layoutControlItem7.TextLocation = DevExpress.Utils.Locations.Right;
            this.layoutControlItem7.TextSize = new System.Drawing.Size(59, 13);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.dewaredbankdate;
            this.layoutControlItem8.CustomizationFormText = "تاريخ الورود";
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 233);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(419, 24);
            this.layoutControlItem8.Text = "تاريخ الورود";
            this.layoutControlItem8.TextLocation = DevExpress.Utils.Locations.Right;
            this.layoutControlItem8.TextSize = new System.Drawing.Size(59, 13);
            // 
            // colvisa
            // 
            this.colvisa.AppearanceCell.Options.UseTextOptions = true;
            this.colvisa.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colvisa.AppearanceHeader.Options.UseTextOptions = true;
            this.colvisa.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colvisa.Caption = "فيزا";
            this.colvisa.FieldName = "visa";
            this.colvisa.Name = "colvisa";
            this.colvisa.Visible = true;
            this.colvisa.VisibleIndex = 3;
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
            this.colMMashatId.VisibleIndex = 0;
            // 
            // TBLReprintMemberAddFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 303);
            this.Controls.Add(this.layoutControlMain);
            this.Name = "TBLReprintMemberAddFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اضافة";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlMain)).EndInit();
            this.layoutControlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dewaredbankdate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dewaredbankdate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.desendbankdate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.desendbankdate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luereprintresonid.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSCDreprintreson)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dereprintdate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dereprintdate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbreprintremark.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueMMashatId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSDATA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControlMain;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.MemoEdit tbreprintremark;
        public DevExpress.XtraEditors.GridLookUpEdit lueMMashatId;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colMMashatName;
        private DevExpress.XtraGrid.Columns.GridColumn colSyndicate;
        private DevExpress.XtraGrid.Columns.GridColumn colsarfnumber;
        private DevExpress.XtraGrid.Columns.GridColumn colMashHala;
        private DevExpress.XtraGrid.Columns.GridColumn colyasref;
        private DevExpress.XtraGrid.Columns.GridColumn colMMashatNId;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.Data.Linq.LinqServerModeSource LSMSDATA;
        private DevExpress.XtraEditors.DateEdit dereprintdate;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraEditors.LookUpEdit luereprintresonid;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.Data.Linq.LinqServerModeSource LSMSCDreprintreson;
        private DevExpress.XtraEditors.DateEdit dewaredbankdate;
        private DevExpress.XtraEditors.DateEdit desendbankdate;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraGrid.Columns.GridColumn colMMashatId;
        private DevExpress.XtraGrid.Columns.GridColumn colvisa;
    }
}