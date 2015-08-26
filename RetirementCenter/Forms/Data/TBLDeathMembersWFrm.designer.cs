namespace RetirementCenter
{
    partial class TBLDeathMembersWFrm
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
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtpGeneral = new DevExpress.XtraTab.XtraTabPage();
            this.ceYasref = new DevExpress.XtraEditors.CheckEdit();
            this.tbmosthhekmony = new DevExpress.XtraEditors.TextEdit();
            this.tbmosthhekNid = new DevExpress.XtraEditors.TextEdit();
            this.lueMMashatId = new DevExpress.XtraEditors.GridLookUpEdit();
            this.LSMSTBLMashat = new DevExpress.Data.Linq.LinqServerModeSource();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsarfnumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSyndicate1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubCommitte = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lueSyn = new DevExpress.XtraEditors.GridLookUpEdit();
            this.LSMSSyn = new DevExpress.Data.Linq.LinqServerModeSource();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSyndicate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tbmosthhek = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.lblMemType = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dedeathdate = new DevExpress.XtraEditors.DateEdit();
            this.BindingSourceData = new System.Windows.Forms.BindingSource(this.components);
            this.dsRetirementCenter = new RetirementCenter.DataSources.dsRetirementCenter();
            this.colMonthName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYearName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMonthName1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.adp = new RetirementCenter.DataSources.dsRetirementCenterTableAdapters.TBLDeathMembersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtpGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ceYasref.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbmosthhekmony.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbmosthhekNid.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueMMashatId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSTBLMashat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueSyn.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSSyn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbmosthhek.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedeathdate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedeathdate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSourceData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRetirementCenter)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl2.Location = new System.Drawing.Point(390, 49);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(72, 19);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "اسم العضو";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl4.Location = new System.Drawing.Point(406, 224);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(56, 19);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "مستحق";
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.panelControl1.Controls.Add(this.btnClose);
            this.panelControl1.Location = new System.Drawing.Point(5, 383);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(520, 44);
            this.panelControl1.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Image = global::RetirementCenter.Properties.Resources.Delete;
            this.btnClose.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btnClose.Location = new System.Drawing.Point(7, 7);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(90, 30);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "اغلاق";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = global::RetirementCenter.Properties.Resources.Save;
            this.btnSave.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btnSave.Location = new System.Drawing.Point(316, 276);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 30);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "حفـــــــــــــــــــــــــظ";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Location = new System.Drawing.Point(5, 12);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.xtraTabControl1.SelectedTabPage = this.xtpGeneral;
            this.xtraTabControl1.Size = new System.Drawing.Size(525, 365);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtpGeneral});
            // 
            // xtpGeneral
            // 
            this.xtpGeneral.Controls.Add(this.ceYasref);
            this.xtpGeneral.Controls.Add(this.tbmosthhekmony);
            this.xtpGeneral.Controls.Add(this.tbmosthhekNid);
            this.xtpGeneral.Controls.Add(this.btnSave);
            this.xtpGeneral.Controls.Add(this.lueMMashatId);
            this.xtpGeneral.Controls.Add(this.lueSyn);
            this.xtpGeneral.Controls.Add(this.tbmosthhek);
            this.xtpGeneral.Controls.Add(this.labelControl6);
            this.xtpGeneral.Controls.Add(this.labelControl5);
            this.xtpGeneral.Controls.Add(this.labelControl2);
            this.xtpGeneral.Controls.Add(this.labelControl3);
            this.xtpGeneral.Controls.Add(this.lblMemType);
            this.xtpGeneral.Controls.Add(this.labelControl1);
            this.xtpGeneral.Controls.Add(this.labelControl4);
            this.xtpGeneral.Controls.Add(this.dedeathdate);
            this.xtpGeneral.Image = global::RetirementCenter.Properties.Resources.Edit;
            this.xtpGeneral.Name = "xtpGeneral";
            this.xtpGeneral.Size = new System.Drawing.Size(519, 318);
            this.xtpGeneral.Text = "بيانات أساسيه";
            // 
            // ceYasref
            // 
            this.ceYasref.Enabled = false;
            this.ceYasref.Location = new System.Drawing.Point(53, 77);
            this.ceYasref.Name = "ceYasref";
            this.ceYasref.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ceYasref.Properties.Appearance.ForeColor = System.Drawing.Color.Green;
            this.ceYasref.Properties.Appearance.Options.UseFont = true;
            this.ceYasref.Properties.Appearance.Options.UseForeColor = true;
            this.ceYasref.Properties.Caption = "يصرف";
            this.ceYasref.Size = new System.Drawing.Size(75, 19);
            this.ceYasref.TabIndex = 99;
            this.ceYasref.TabStop = false;
            // 
            // tbmosthhekmony
            // 
            this.tbmosthhekmony.Location = new System.Drawing.Point(53, 187);
            this.tbmosthhekmony.Name = "tbmosthhekmony";
            this.tbmosthhekmony.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.tbmosthhekmony.Properties.Appearance.Options.UseFont = true;
            this.tbmosthhekmony.Properties.Mask.EditMask = "f2";
            this.tbmosthhekmony.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.tbmosthhekmony.Size = new System.Drawing.Size(233, 26);
            this.tbmosthhekmony.TabIndex = 4;
            // 
            // tbmosthhekNid
            // 
            this.tbmosthhekNid.Location = new System.Drawing.Point(53, 149);
            this.tbmosthhekNid.Name = "tbmosthhekNid";
            this.tbmosthhekNid.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.tbmosthhekNid.Properties.Appearance.Options.UseFont = true;
            this.tbmosthhekNid.Properties.MaxLength = 14;
            this.tbmosthhekNid.Size = new System.Drawing.Size(233, 26);
            this.tbmosthhekNid.TabIndex = 3;
            // 
            // lueMMashatId
            // 
            this.lueMMashatId.EditValue = "";
            this.lueMMashatId.Location = new System.Drawing.Point(53, 46);
            this.lueMMashatId.Name = "lueMMashatId";
            this.lueMMashatId.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lueMMashatId.Properties.Appearance.Options.UseFont = true;
            this.lueMMashatId.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueMMashatId.Properties.DataSource = this.LSMSTBLMashat;
            this.lueMMashatId.Properties.DisplayMember = "MMashatName";
            this.lueMMashatId.Properties.NullText = "";
            this.lueMMashatId.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lueMMashatId.Properties.ValueMember = "MMashatId";
            this.lueMMashatId.Properties.View = this.gridView1;
            this.lueMMashatId.Size = new System.Drawing.Size(233, 26);
            this.lueMMashatId.TabIndex = 1;
            this.lueMMashatId.EditValueChanged += new System.EventHandler(this.lueMMashatId_EditValueChanged);
            // 
            // LSMSTBLMashat
            // 
            this.LSMSTBLMashat.ElementType = typeof(RetirementCenter.DataSources.Linq.vTBLMashat);
            this.LSMSTBLMashat.KeyExpression = "MMashatId";
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.colsarfnumber,
            this.colSyndicate1,
            this.colSubCommitte});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.Caption = "الاسم";
            this.gridColumn1.FieldName = "MMashatName";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
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
            this.colsarfnumber.Visible = true;
            this.colsarfnumber.VisibleIndex = 1;
            // 
            // colSyndicate1
            // 
            this.colSyndicate1.AppearanceCell.Options.UseTextOptions = true;
            this.colSyndicate1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSyndicate1.AppearanceHeader.Options.UseTextOptions = true;
            this.colSyndicate1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSyndicate1.Caption = "فرعية";
            this.colSyndicate1.FieldName = "Syndicate";
            this.colSyndicate1.Name = "colSyndicate1";
            this.colSyndicate1.Visible = true;
            this.colSyndicate1.VisibleIndex = 3;
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
            this.colSubCommitte.VisibleIndex = 2;
            // 
            // lueSyn
            // 
            this.lueSyn.EditValue = "";
            this.lueSyn.Location = new System.Drawing.Point(53, 10);
            this.lueSyn.Name = "lueSyn";
            this.lueSyn.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lueSyn.Properties.Appearance.Options.UseFont = true;
            this.lueSyn.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueSyn.Properties.DataSource = this.LSMSSyn;
            this.lueSyn.Properties.DisplayMember = "Syndicate";
            this.lueSyn.Properties.NullText = "";
            this.lueSyn.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lueSyn.Properties.ValueMember = "SyndicateId";
            this.lueSyn.Properties.View = this.gridLookUpEdit1View;
            this.lueSyn.Size = new System.Drawing.Size(233, 26);
            this.lueSyn.TabIndex = 0;
            this.lueSyn.EditValueChanged += new System.EventHandler(this.lueDofatSarfAId_EditValueChanged);
            // 
            // LSMSSyn
            // 
            this.LSMSSyn.ElementType = typeof(RetirementCenter.DataSources.Linq.CDSyndicate);
            this.LSMSSyn.KeyExpression = "[SyndicateId]";
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSyndicate});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colSyndicate
            // 
            this.colSyndicate.Caption = "الفرعية";
            this.colSyndicate.FieldName = "Syndicate";
            this.colSyndicate.Name = "colSyndicate";
            this.colSyndicate.Visible = true;
            this.colSyndicate.VisibleIndex = 0;
            // 
            // tbmosthhek
            // 
            this.tbmosthhek.Location = new System.Drawing.Point(53, 226);
            this.tbmosthhek.Name = "tbmosthhek";
            this.tbmosthhek.Properties.MaxLength = 75;
            this.tbmosthhek.Size = new System.Drawing.Size(233, 80);
            this.tbmosthhek.TabIndex = 5;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl6.Location = new System.Drawing.Point(414, 13);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(48, 19);
            this.labelControl6.TabIndex = 0;
            this.labelControl6.Text = "الفرعية";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl5.Location = new System.Drawing.Point(384, 190);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(78, 19);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "قيمة الاعانة";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl3.Location = new System.Drawing.Point(385, 152);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(77, 19);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "الرقم قومي";
            // 
            // lblMemType
            // 
            this.lblMemType.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemType.Appearance.ForeColor = System.Drawing.Color.Green;
            this.lblMemType.Location = new System.Drawing.Point(215, 78);
            this.lblMemType.Name = "lblMemType";
            this.lblMemType.Size = new System.Drawing.Size(12, 14);
            this.lblMemType.TabIndex = 0;
            this.lblMemType.Text = "...";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl1.Location = new System.Drawing.Point(391, 114);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(71, 19);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "تاريخ الوفاة";
            // 
            // dedeathdate
            // 
            this.dedeathdate.EditValue = null;
            this.dedeathdate.Location = new System.Drawing.Point(53, 111);
            this.dedeathdate.Name = "dedeathdate";
            this.dedeathdate.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.dedeathdate.Properties.Appearance.Options.UseFont = true;
            this.dedeathdate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dedeathdate.Properties.DisplayFormat.FormatString = "d/M/yyyy";
            this.dedeathdate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dedeathdate.Properties.EditFormat.FormatString = "d/M/yyyy";
            this.dedeathdate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.dedeathdate.Properties.Mask.EditMask = "d/M/yyyy";
            this.dedeathdate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dedeathdate.Size = new System.Drawing.Size(233, 26);
            this.dedeathdate.TabIndex = 2;
            // 
            // BindingSourceData
            // 
            this.BindingSourceData.DataMember = "CdDofaatAmanat";
            this.BindingSourceData.DataSource = this.dsRetirementCenter;
            // 
            // dsRetirementCenter
            // 
            this.dsRetirementCenter.DataSetName = "dsRetirementCenter";
            this.dsRetirementCenter.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // colMonthName
            // 
            this.colMonthName.AppearanceCell.Options.UseTextOptions = true;
            this.colMonthName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMonthName.AppearanceHeader.Options.UseTextOptions = true;
            this.colMonthName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMonthName.Caption = "اسم الشهر";
            this.colMonthName.FieldName = "MonthName";
            this.colMonthName.Name = "colMonthName";
            this.colMonthName.Visible = true;
            this.colMonthName.VisibleIndex = 0;
            // 
            // colYearName
            // 
            this.colYearName.AppearanceCell.Options.UseTextOptions = true;
            this.colYearName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colYearName.AppearanceHeader.Options.UseTextOptions = true;
            this.colYearName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colYearName.Caption = "اسم السنه";
            this.colYearName.FieldName = "YearName";
            this.colYearName.Name = "colYearName";
            this.colYearName.Visible = true;
            this.colYearName.VisibleIndex = 0;
            // 
            // colMonthName1
            // 
            this.colMonthName1.AppearanceCell.Options.UseTextOptions = true;
            this.colMonthName1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMonthName1.AppearanceHeader.Options.UseTextOptions = true;
            this.colMonthName1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMonthName1.Caption = "اسم الشهر";
            this.colMonthName1.FieldName = "MonthName";
            this.colMonthName1.Name = "colMonthName1";
            this.colMonthName1.Visible = true;
            this.colMonthName1.VisibleIndex = 0;
            // 
            // adp
            // 
            this.adp.ClearBeforeFill = true;
            // 
            // TBLDeathMembersWFrm
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(542, 436);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "TBLDeathMembersWFrm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تحرير";
            this.Load += new System.EventHandler(this.FormWFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtpGeneral.ResumeLayout(false);
            this.xtpGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ceYasref.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbmosthhekmony.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbmosthhekNid.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueMMashatId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSTBLMashat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueSyn.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSSyn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbmosthhek.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedeathdate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedeathdate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSourceData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRetirementCenter)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtpGeneral;
        private DevExpress.XtraGrid.Columns.GridColumn colMonthName;
        private DevExpress.XtraGrid.Columns.GridColumn colYearName;
        private DevExpress.XtraGrid.Columns.GridColumn colMonthName1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.MemoEdit tbmosthhek;
        private DevExpress.XtraEditors.GridLookUpEdit lueSyn;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageDetails;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private DevExpress.XtraEditors.GridLookUpEdit lueMMashatId;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DataSources.dsRetirementCenter dsRetirementCenter;
        private System.Windows.Forms.BindingSource BindingSourceData;
        private DevExpress.XtraGrid.Columns.GridColumn colsarfnumber;
        private DevExpress.XtraGrid.Columns.GridColumn colSyndicate1;
        private DevExpress.XtraGrid.Columns.GridColumn colSubCommitte;
        private DevExpress.Data.Linq.LinqServerModeSource LSMSTBLMashat;
        private DevExpress.Data.Linq.LinqServerModeSource LSMSSyn;
        private DevExpress.XtraGrid.Columns.GridColumn colSyndicate;
        private DevExpress.XtraEditors.DateEdit dedeathdate;
        private DataSources.dsRetirementCenterTableAdapters.TBLDeathMembersTableAdapter adp;
        private DevExpress.XtraEditors.TextEdit tbmosthhekmony;
        private DevExpress.XtraEditors.TextEdit tbmosthhekNid;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.CheckEdit ceYasref;
        private DevExpress.XtraEditors.LabelControl lblMemType;
    }
}