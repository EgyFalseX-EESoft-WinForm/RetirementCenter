namespace RetirementCenter.Forms.Data
{
    partial class TBLHafzaTasleemAddFrm
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
            this.layoutControlMain = new DevExpress.XtraLayout.LayoutControl();
            this.detasleemdate = new DevExpress.XtraEditors.DateEdit();
            this.lueMandoopId = new DevExpress.XtraEditors.GridLookUpEdit();
            this.tBLMandoopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsRetirementCenter = new RetirementCenter.DataSources.dsRetirementCenter();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMandoopName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMandoopMOBIL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tbcountrealy = new DevExpress.XtraEditors.TextEdit();
            this.lueSyndicateId = new DevExpress.XtraEditors.LookUpEdit();
            this.cDSyndicateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsQueries = new RetirementCenter.DataSources.dsQueries();
            this.luetasleemtype = new DevExpress.XtraEditors.LookUpEdit();
            this.cDMashHalaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.luehafza = new DevExpress.XtraEditors.GridLookUpEdit();
            this.LSMSDATA = new DevExpress.Data.Linq.LinqServerModeSource();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colhafza = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.cDMashHalaTableAdapter = new RetirementCenter.DataSources.dsQueriesTableAdapters.CDMashHalaTableAdapter();
            this.cDSyndicateTableAdapter = new RetirementCenter.DataSources.dsQueriesTableAdapters.CDSyndicateTableAdapter();
            this.tBLMandoopTableAdapter = new RetirementCenter.DataSources.dsRetirementCenterTableAdapters.TBLMandoopTableAdapter();
            this.tbcountindata = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlMain)).BeginInit();
            this.layoutControlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detasleemdate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detasleemdate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueMandoopId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLMandoopBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRetirementCenter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbcountrealy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueSyndicateId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDSyndicateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsQueries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luetasleemtype.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDMashHalaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luehafza.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSDATA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbcountindata.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControlMain
            // 
            this.layoutControlMain.Controls.Add(this.tbcountindata);
            this.layoutControlMain.Controls.Add(this.detasleemdate);
            this.layoutControlMain.Controls.Add(this.lueMandoopId);
            this.layoutControlMain.Controls.Add(this.tbcountrealy);
            this.layoutControlMain.Controls.Add(this.lueSyndicateId);
            this.layoutControlMain.Controls.Add(this.luetasleemtype);
            this.layoutControlMain.Controls.Add(this.btnCancel);
            this.layoutControlMain.Controls.Add(this.btnSave);
            this.layoutControlMain.Controls.Add(this.luehafza);
            this.layoutControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControlMain.Location = new System.Drawing.Point(0, 0);
            this.layoutControlMain.Name = "layoutControlMain";
            this.layoutControlMain.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(757, 104, 250, 350);
            this.layoutControlMain.Root = this.layoutControlGroup1;
            this.layoutControlMain.Size = new System.Drawing.Size(439, 216);
            this.layoutControlMain.TabIndex = 0;
            this.layoutControlMain.Text = "layoutControl1";
            // 
            // detasleemdate
            // 
            this.detasleemdate.EditValue = null;
            this.detasleemdate.Location = new System.Drawing.Point(12, 156);
            this.detasleemdate.Name = "detasleemdate";
            this.detasleemdate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.detasleemdate.Properties.DisplayFormat.FormatString = "d/M/yyyy";
            this.detasleemdate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.detasleemdate.Properties.EditFormat.FormatString = "d/M/yyyy";
            this.detasleemdate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.detasleemdate.Properties.Mask.EditMask = "d/M/yyyy";
            this.detasleemdate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.detasleemdate.Size = new System.Drawing.Size(346, 20);
            this.detasleemdate.StyleController = this.layoutControlMain;
            this.detasleemdate.TabIndex = 8;
            // 
            // lueMandoopId
            // 
            this.lueMandoopId.Location = new System.Drawing.Point(12, 132);
            this.lueMandoopId.Name = "lueMandoopId";
            this.lueMandoopId.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueMandoopId.Properties.DataSource = this.tBLMandoopBindingSource;
            this.lueMandoopId.Properties.DisplayMember = "MandoopName";
            this.lueMandoopId.Properties.NullText = "";
            this.lueMandoopId.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lueMandoopId.Properties.ValueMember = "MandoopId";
            this.lueMandoopId.Properties.View = this.gridView1;
            this.lueMandoopId.Size = new System.Drawing.Size(346, 20);
            this.lueMandoopId.StyleController = this.layoutControlMain;
            this.lueMandoopId.TabIndex = 7;
            // 
            // tBLMandoopBindingSource
            // 
            this.tBLMandoopBindingSource.DataMember = "TBLMandoop";
            this.tBLMandoopBindingSource.DataSource = this.dsRetirementCenter;
            // 
            // dsRetirementCenter
            // 
            this.dsRetirementCenter.DataSetName = "dsRetirementCenter";
            this.dsRetirementCenter.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMandoopName,
            this.colMandoopMOBIL});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colMandoopName
            // 
            this.colMandoopName.AppearanceCell.Options.UseTextOptions = true;
            this.colMandoopName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMandoopName.AppearanceHeader.Options.UseTextOptions = true;
            this.colMandoopName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMandoopName.Caption = "الاسم";
            this.colMandoopName.FieldName = "MandoopName";
            this.colMandoopName.Name = "colMandoopName";
            this.colMandoopName.Visible = true;
            this.colMandoopName.VisibleIndex = 0;
            // 
            // colMandoopMOBIL
            // 
            this.colMandoopMOBIL.AppearanceCell.Options.UseTextOptions = true;
            this.colMandoopMOBIL.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMandoopMOBIL.AppearanceHeader.Options.UseTextOptions = true;
            this.colMandoopMOBIL.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMandoopMOBIL.Caption = "الموبيل";
            this.colMandoopMOBIL.FieldName = "MandoopMOBIL";
            this.colMandoopMOBIL.Name = "colMandoopMOBIL";
            this.colMandoopMOBIL.Visible = true;
            this.colMandoopMOBIL.VisibleIndex = 1;
            // 
            // tbcountrealy
            // 
            this.tbcountrealy.Location = new System.Drawing.Point(12, 108);
            this.tbcountrealy.Name = "tbcountrealy";
            this.tbcountrealy.Size = new System.Drawing.Size(346, 20);
            this.tbcountrealy.StyleController = this.layoutControlMain;
            this.tbcountrealy.TabIndex = 6;
            // 
            // lueSyndicateId
            // 
            this.lueSyndicateId.Location = new System.Drawing.Point(12, 36);
            this.lueSyndicateId.Name = "lueSyndicateId";
            this.lueSyndicateId.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueSyndicateId.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Syndicate", "الفرعية", 57, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.lueSyndicateId.Properties.DataSource = this.cDSyndicateBindingSource;
            this.lueSyndicateId.Properties.DisplayMember = "Syndicate";
            this.lueSyndicateId.Properties.NullText = "";
            this.lueSyndicateId.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lueSyndicateId.Properties.ValueMember = "SyndicateId";
            this.lueSyndicateId.Size = new System.Drawing.Size(346, 20);
            this.lueSyndicateId.StyleController = this.layoutControlMain;
            this.lueSyndicateId.TabIndex = 5;
            this.lueSyndicateId.EditValueChanged += new System.EventHandler(this.lue_EditValueChanged);
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
            // luetasleemtype
            // 
            this.luetasleemtype.Location = new System.Drawing.Point(12, 12);
            this.luetasleemtype.Name = "luetasleemtype";
            this.luetasleemtype.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.luetasleemtype.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MashHala", "النوع", 59, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.luetasleemtype.Properties.DataSource = this.cDMashHalaBindingSource;
            this.luetasleemtype.Properties.DisplayMember = "MashHala";
            this.luetasleemtype.Properties.NullText = "";
            this.luetasleemtype.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.luetasleemtype.Properties.ValueMember = "MashHalaId";
            this.luetasleemtype.Size = new System.Drawing.Size(346, 20);
            this.luetasleemtype.StyleController = this.layoutControlMain;
            this.luetasleemtype.TabIndex = 4;
            this.luetasleemtype.EditValueChanged += new System.EventHandler(this.lue_EditValueChanged);
            // 
            // cDMashHalaBindingSource
            // 
            this.cDMashHalaBindingSource.DataMember = "CDMashHala";
            this.cDMashHalaBindingSource.DataSource = this.dsQueries;
            // 
            // btnCancel
            // 
            this.btnCancel.Image = global::RetirementCenter.Properties.Resources.cancel_16x16;
            this.btnCancel.Location = new System.Drawing.Point(319, 180);
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
            this.btnSave.Location = new System.Drawing.Point(12, 180);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(303, 22);
            this.btnSave.StyleController = this.layoutControlMain;
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "حفظ";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // luehafza
            // 
            this.luehafza.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.luehafza.Location = new System.Drawing.Point(12, 60);
            this.luehafza.Margin = new System.Windows.Forms.Padding(0);
            this.luehafza.Name = "luehafza";
            this.luehafza.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.luehafza.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.luehafza.Properties.DataSource = this.LSMSDATA;
            this.luehafza.Properties.DisplayMember = "hafza";
            this.luehafza.Properties.NullText = "";
            this.luehafza.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.luehafza.Properties.ValueMember = "hafza";
            this.luehafza.Properties.View = this.gridLookUpEdit1View;
            this.luehafza.Size = new System.Drawing.Size(346, 20);
            this.luehafza.StyleController = this.layoutControlMain;
            this.luehafza.TabIndex = 0;
            this.luehafza.EditValueChanged += new System.EventHandler(this.luehafza_EditValueChanged);
            // 
            // LSMSDATA
            // 
            this.LSMSDATA.ElementType = typeof(RetirementCenter.DataSources.Linq.vQry81);
            this.LSMSDATA.KeyExpression = "[hafza]";
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colhafza,
            this.colNum});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ColumnAutoWidth = false;
            this.gridLookUpEdit1View.OptionsView.ShowAutoFilterRow = true;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colhafza
            // 
            this.colhafza.AppearanceCell.Options.UseTextOptions = true;
            this.colhafza.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colhafza.AppearanceHeader.Options.UseTextOptions = true;
            this.colhafza.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colhafza.Caption = "الحافظة";
            this.colhafza.FieldName = "hafza";
            this.colhafza.Name = "colhafza";
            this.colhafza.Visible = true;
            this.colhafza.VisibleIndex = 0;
            // 
            // colNum
            // 
            this.colNum.AppearanceCell.Options.UseTextOptions = true;
            this.colNum.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNum.AppearanceHeader.Options.UseTextOptions = true;
            this.colNum.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNum.Caption = "العدد";
            this.colNum.FieldName = "Num";
            this.colNum.Name = "colNum";
            this.colNum.Visible = true;
            this.colNum.VisibleIndex = 1;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem7,
            this.layoutControlItem8,
            this.layoutControlItem9,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(439, 216);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem1.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.layoutControlItem1.Control = this.luehafza;
            this.layoutControlItem1.CustomizationFormText = "العضو";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(419, 24);
            this.layoutControlItem1.Text = "الحافظة";
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Right;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(66, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnSave;
            this.layoutControlItem3.CustomizationFormText = "layoutControlItem3";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 168);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(307, 28);
            this.layoutControlItem3.Text = "layoutControlItem3";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextToControlDistance = 0;
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btnCancel;
            this.layoutControlItem4.CustomizationFormText = "layoutControlItem4";
            this.layoutControlItem4.Location = new System.Drawing.Point(307, 168);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(112, 28);
            this.layoutControlItem4.Text = "layoutControlItem4";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextToControlDistance = 0;
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem7.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.layoutControlItem7.Control = this.tbcountrealy;
            this.layoutControlItem7.CustomizationFormText = "العدد الفعلي";
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(419, 24);
            this.layoutControlItem7.Text = "العدد الفعلي";
            this.layoutControlItem7.TextLocation = DevExpress.Utils.Locations.Right;
            this.layoutControlItem7.TextSize = new System.Drawing.Size(66, 13);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem8.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.layoutControlItem8.Control = this.lueMandoopId;
            this.layoutControlItem8.CustomizationFormText = "المندوب";
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 120);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(419, 24);
            this.layoutControlItem8.Text = "المندوب";
            this.layoutControlItem8.TextLocation = DevExpress.Utils.Locations.Right;
            this.layoutControlItem8.TextSize = new System.Drawing.Size(66, 13);
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem9.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.layoutControlItem9.Control = this.detasleemdate;
            this.layoutControlItem9.CustomizationFormText = "تاريخ التسليم";
            this.layoutControlItem9.Location = new System.Drawing.Point(0, 144);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(419, 24);
            this.layoutControlItem9.Text = "تاريخ التسليم";
            this.layoutControlItem9.TextLocation = DevExpress.Utils.Locations.Right;
            this.layoutControlItem9.TextSize = new System.Drawing.Size(66, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem5.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.layoutControlItem5.Control = this.luetasleemtype;
            this.layoutControlItem5.CustomizationFormText = "النوع";
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(419, 24);
            this.layoutControlItem5.Text = "النوع";
            this.layoutControlItem5.TextLocation = DevExpress.Utils.Locations.Right;
            this.layoutControlItem5.TextSize = new System.Drawing.Size(66, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem6.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.layoutControlItem6.Control = this.lueSyndicateId;
            this.layoutControlItem6.CustomizationFormText = "الفرعية";
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(419, 24);
            this.layoutControlItem6.Text = "الفرعية";
            this.layoutControlItem6.TextLocation = DevExpress.Utils.Locations.Right;
            this.layoutControlItem6.TextSize = new System.Drawing.Size(66, 13);
            // 
            // cDMashHalaTableAdapter
            // 
            this.cDMashHalaTableAdapter.ClearBeforeFill = true;
            // 
            // cDSyndicateTableAdapter
            // 
            this.cDSyndicateTableAdapter.ClearBeforeFill = true;
            // 
            // tBLMandoopTableAdapter
            // 
            this.tBLMandoopTableAdapter.ClearBeforeFill = true;
            // 
            // tbcountindata
            // 
            this.tbcountindata.Location = new System.Drawing.Point(12, 84);
            this.tbcountindata.Name = "tbcountindata";
            this.tbcountindata.Properties.ReadOnly = true;
            this.tbcountindata.Size = new System.Drawing.Size(346, 20);
            this.tbcountindata.StyleController = this.layoutControlMain;
            this.tbcountindata.TabIndex = 9;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.tbcountindata;
            this.layoutControlItem2.CustomizationFormText = "العدد المسجل";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(419, 24);
            this.layoutControlItem2.Text = "العدد المسجل";
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Right;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(66, 13);
            // 
            // TBLHafzaTasleemAddFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 216);
            this.Controls.Add(this.layoutControlMain);
            this.Name = "TBLHafzaTasleemAddFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اضافة";
            this.Load += new System.EventHandler(this.TBLHafzaTasleemAddFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlMain)).EndInit();
            this.layoutControlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.detasleemdate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detasleemdate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueMandoopId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLMandoopBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRetirementCenter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbcountrealy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueSyndicateId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDSyndicateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsQueries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luetasleemtype.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDMashHalaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luehafza.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSDATA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbcountindata.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControlMain;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        public DevExpress.XtraEditors.GridLookUpEdit luehafza;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.Data.Linq.LinqServerModeSource LSMSDATA;
        private DevExpress.XtraEditors.LookUpEdit luetasleemtype;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraEditors.LookUpEdit lueSyndicateId;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraEditors.TextEdit tbcountrealy;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraEditors.GridLookUpEdit lueMandoopId;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraEditors.DateEdit detasleemdate;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DataSources.dsQueries dsQueries;
        private System.Windows.Forms.BindingSource cDMashHalaBindingSource;
        private DataSources.dsQueriesTableAdapters.CDMashHalaTableAdapter cDMashHalaTableAdapter;
        private System.Windows.Forms.BindingSource cDSyndicateBindingSource;
        private DataSources.dsQueriesTableAdapters.CDSyndicateTableAdapter cDSyndicateTableAdapter;
        private DataSources.dsRetirementCenter dsRetirementCenter;
        private System.Windows.Forms.BindingSource tBLMandoopBindingSource;
        private DataSources.dsRetirementCenterTableAdapters.TBLMandoopTableAdapter tBLMandoopTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colMandoopName;
        private DevExpress.XtraGrid.Columns.GridColumn colMandoopMOBIL;
        private DevExpress.XtraGrid.Columns.GridColumn colhafza;
        private DevExpress.XtraGrid.Columns.GridColumn colNum;
        private DevExpress.XtraEditors.TextEdit tbcountindata;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    }
}