namespace RetirementCenter.Forms.Data
{
    partial class VerifyMemberFrm
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
            this.gridControlData = new DevExpress.XtraGrid.GridControl();
            this.tBLMashatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsRetirementCenter = new RetirementCenter.DataSources.dsRetirementCenter();
            this.gridViewData = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMMashatId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMMashatName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSyndicate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEditSyn = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.LSMSCDSyndicate = new DevExpress.Data.Linq.LinqServerModeSource();
            this.colSubCommitte = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEditSub = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.LSMSCDSubCommitte = new DevExpress.Data.Linq.LinqServerModeSource();
            this.colMashHalaId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEditMashHalaId = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.LSMSCDMashHala = new DevExpress.Data.Linq.LinqServerModeSource();
            this.colMMashatNId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsarfnumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldatein = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEditDMY = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEditUser = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.LSMSUser = new DevExpress.Data.Linq.LinqServerModeSource();
            this.colverify_member = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEditTransferSave = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.tBLMashatTableAdapter = new RetirementCenter.DataSources.dsRetirementCenterTableAdapters.TBLMashatTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLMashatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRetirementCenter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditSyn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSCDSyndicate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditSub)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSCDSubCommitte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditMashHalaId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSCDMashHala)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDMY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDMY.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditTransferSave)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlData
            // 
            this.gridControlData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlData.DataSource = this.tBLMashatBindingSource;
            this.gridControlData.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gridControlData.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControlData.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControlData.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControlData.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gridControlData.Location = new System.Drawing.Point(0, 12);
            this.gridControlData.MainView = this.gridViewData;
            this.gridControlData.Name = "gridControlData";
            this.gridControlData.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEditTransferSave,
            this.repositoryItemCheckEdit1,
            this.repositoryItemDateEditDMY,
            this.repositoryItemLookUpEditSyn,
            this.repositoryItemLookUpEditSub,
            this.repositoryItemLookUpEditMashHalaId,
            this.repositoryItemLookUpEditUser});
            this.gridControlData.Size = new System.Drawing.Size(965, 375);
            this.gridControlData.TabIndex = 2;
            this.gridControlData.UseEmbeddedNavigator = true;
            this.gridControlData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewData});
            // 
            // tBLMashatBindingSource
            // 
            this.tBLMashatBindingSource.DataMember = "TBLMashat";
            this.tBLMashatBindingSource.DataSource = this.dsRetirementCenter;
            // 
            // dsRetirementCenter
            // 
            this.dsRetirementCenter.DataSetName = "dsRetirementCenter";
            this.dsRetirementCenter.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridViewData
            // 
            this.gridViewData.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMMashatId,
            this.colMMashatName,
            this.colSyndicate,
            this.colSubCommitte,
            this.colMashHalaId,
            this.colMMashatNId,
            this.colsarfnumber,
            this.coldatein,
            this.gridColumn1,
            this.colverify_member,
            this.gridColumn4});
            this.gridViewData.GridControl = this.gridControlData;
            this.gridViewData.Name = "gridViewData";
            this.gridViewData.NewItemRowText = "اضغط لاضافة جديد";
            this.gridViewData.OptionsView.ShowAutoFilterRow = true;
            this.gridViewData.OptionsView.ShowDetailButtons = false;
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
            this.colMMashatId.OptionsColumn.ReadOnly = true;
            this.colMMashatId.Visible = true;
            this.colMMashatId.VisibleIndex = 0;
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
            this.colMMashatName.OptionsColumn.ReadOnly = true;
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
            this.colSyndicate.ColumnEdit = this.repositoryItemLookUpEditSyn;
            this.colSyndicate.FieldName = "SyndicateId";
            this.colSyndicate.Name = "colSyndicate";
            this.colSyndicate.OptionsColumn.ReadOnly = true;
            this.colSyndicate.Visible = true;
            this.colSyndicate.VisibleIndex = 2;
            // 
            // repositoryItemLookUpEditSyn
            // 
            this.repositoryItemLookUpEditSyn.AutoHeight = false;
            this.repositoryItemLookUpEditSyn.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEditSyn.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Syndicate", "Syndicate", 57, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.repositoryItemLookUpEditSyn.DataSource = this.LSMSCDSyndicate;
            this.repositoryItemLookUpEditSyn.DisplayMember = "Syndicate";
            this.repositoryItemLookUpEditSyn.Name = "repositoryItemLookUpEditSyn";
            this.repositoryItemLookUpEditSyn.NullText = "";
            this.repositoryItemLookUpEditSyn.ValueMember = "SyndicateId";
            // 
            // LSMSCDSyndicate
            // 
            this.LSMSCDSyndicate.ElementType = typeof(RetirementCenter.DataSources.Linq.CDSyndicate);
            this.LSMSCDSyndicate.KeyExpression = "[SyndicateId]";
            // 
            // colSubCommitte
            // 
            this.colSubCommitte.AppearanceCell.Options.UseTextOptions = true;
            this.colSubCommitte.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSubCommitte.AppearanceHeader.Options.UseTextOptions = true;
            this.colSubCommitte.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSubCommitte.Caption = "اللجنة";
            this.colSubCommitte.ColumnEdit = this.repositoryItemLookUpEditSub;
            this.colSubCommitte.FieldName = "SubCommitteId";
            this.colSubCommitte.Name = "colSubCommitte";
            this.colSubCommitte.OptionsColumn.ReadOnly = true;
            this.colSubCommitte.Visible = true;
            this.colSubCommitte.VisibleIndex = 3;
            // 
            // repositoryItemLookUpEditSub
            // 
            this.repositoryItemLookUpEditSub.AutoHeight = false;
            this.repositoryItemLookUpEditSub.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEditSub.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SubCommitte", "Sub Committe", 76, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.repositoryItemLookUpEditSub.DataSource = this.LSMSCDSubCommitte;
            this.repositoryItemLookUpEditSub.DisplayMember = "SubCommitte";
            this.repositoryItemLookUpEditSub.Name = "repositoryItemLookUpEditSub";
            this.repositoryItemLookUpEditSub.NullText = "";
            this.repositoryItemLookUpEditSub.ValueMember = "SubCommitteId";
            // 
            // LSMSCDSubCommitte
            // 
            this.LSMSCDSubCommitte.ElementType = typeof(RetirementCenter.DataSources.Linq.CDSubCommitte);
            this.LSMSCDSubCommitte.KeyExpression = "[SubCommitteId]";
            // 
            // colMashHalaId
            // 
            this.colMashHalaId.AppearanceCell.Options.UseTextOptions = true;
            this.colMashHalaId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMashHalaId.AppearanceHeader.Options.UseTextOptions = true;
            this.colMashHalaId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMashHalaId.Caption = "النوع";
            this.colMashHalaId.ColumnEdit = this.repositoryItemLookUpEditMashHalaId;
            this.colMashHalaId.FieldName = "MashHalaId";
            this.colMashHalaId.Name = "colMashHalaId";
            this.colMashHalaId.Visible = true;
            this.colMashHalaId.VisibleIndex = 4;
            // 
            // repositoryItemLookUpEditMashHalaId
            // 
            this.repositoryItemLookUpEditMashHalaId.AutoHeight = false;
            this.repositoryItemLookUpEditMashHalaId.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEditMashHalaId.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MashHala", "Mash Hala", 59, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.repositoryItemLookUpEditMashHalaId.DataSource = this.LSMSCDMashHala;
            this.repositoryItemLookUpEditMashHalaId.DisplayMember = "MashHala";
            this.repositoryItemLookUpEditMashHalaId.Name = "repositoryItemLookUpEditMashHalaId";
            this.repositoryItemLookUpEditMashHalaId.NullText = "";
            this.repositoryItemLookUpEditMashHalaId.ValueMember = "MashHalaId";
            // 
            // LSMSCDMashHala
            // 
            this.LSMSCDMashHala.ElementType = typeof(RetirementCenter.DataSources.Linq.CDMashHala);
            this.LSMSCDMashHala.KeyExpression = "[MashHalaId]";
            // 
            // colMMashatNId
            // 
            this.colMMashatNId.AppearanceCell.Options.UseTextOptions = true;
            this.colMMashatNId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMMashatNId.AppearanceHeader.Options.UseTextOptions = true;
            this.colMMashatNId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMMashatNId.Caption = "رقم قومي";
            this.colMMashatNId.FieldName = "MMashatNId";
            this.colMMashatNId.Name = "colMMashatNId";
            this.colMMashatNId.OptionsColumn.ReadOnly = true;
            this.colMMashatNId.Visible = true;
            this.colMMashatNId.VisibleIndex = 5;
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
            this.colsarfnumber.OptionsColumn.ReadOnly = true;
            this.colsarfnumber.Visible = true;
            this.colsarfnumber.VisibleIndex = 6;
            // 
            // coldatein
            // 
            this.coldatein.AppearanceCell.Options.UseTextOptions = true;
            this.coldatein.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coldatein.AppearanceHeader.Options.UseTextOptions = true;
            this.coldatein.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coldatein.Caption = "تاريخ الادخال";
            this.coldatein.ColumnEdit = this.repositoryItemDateEditDMY;
            this.coldatein.FieldName = "datein";
            this.coldatein.Name = "coldatein";
            this.coldatein.OptionsColumn.ReadOnly = true;
            this.coldatein.Visible = true;
            this.coldatein.VisibleIndex = 7;
            this.coldatein.Width = 89;
            // 
            // repositoryItemDateEditDMY
            // 
            this.repositoryItemDateEditDMY.AutoHeight = false;
            this.repositoryItemDateEditDMY.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEditDMY.DisplayFormat.FormatString = "d/M/yyyy";
            this.repositoryItemDateEditDMY.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEditDMY.EditFormat.FormatString = "d/M/yyyy";
            this.repositoryItemDateEditDMY.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEditDMY.Mask.EditMask = "d/M/yyyy";
            this.repositoryItemDateEditDMY.Name = "repositoryItemDateEditDMY";
            this.repositoryItemDateEditDMY.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.Caption = "مسئول الادخال";
            this.gridColumn1.ColumnEdit = this.repositoryItemLookUpEditUser;
            this.gridColumn1.FieldName = "userin";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.ReadOnly = true;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 8;
            this.gridColumn1.Width = 88;
            // 
            // repositoryItemLookUpEditUser
            // 
            this.repositoryItemLookUpEditUser.AutoHeight = false;
            this.repositoryItemLookUpEditUser.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEditUser.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("RealName", "Real Name", 61, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.repositoryItemLookUpEditUser.DataSource = this.LSMSUser;
            this.repositoryItemLookUpEditUser.DisplayMember = "RealName";
            this.repositoryItemLookUpEditUser.Name = "repositoryItemLookUpEditUser";
            this.repositoryItemLookUpEditUser.NullText = "";
            this.repositoryItemLookUpEditUser.ValueMember = "UserID";
            // 
            // LSMSUser
            // 
            this.LSMSUser.ElementType = typeof(RetirementCenter.DataSources.Linq.User);
            this.LSMSUser.KeyExpression = "[UserID]";
            // 
            // colverify_member
            // 
            this.colverify_member.AppearanceCell.Options.UseTextOptions = true;
            this.colverify_member.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colverify_member.AppearanceHeader.Options.UseTextOptions = true;
            this.colverify_member.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colverify_member.Caption = "مراجعة العضو";
            this.colverify_member.ColumnEdit = this.repositoryItemCheckEdit1;
            this.colverify_member.FieldName = "verify_member";
            this.colverify_member.Name = "colverify_member";
            this.colverify_member.Visible = true;
            this.colverify_member.VisibleIndex = 9;
            this.colverify_member.Width = 84;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // gridColumn4
            // 
            this.gridColumn4.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn4.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn4.Caption = "حفظ";
            this.gridColumn4.ColumnEdit = this.repositoryItemButtonEditTransferSave;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 10;
            this.gridColumn4.Width = 70;
            // 
            // repositoryItemButtonEditTransferSave
            // 
            this.repositoryItemButtonEditTransferSave.AutoHeight = false;
            this.repositoryItemButtonEditTransferSave.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.OK)});
            this.repositoryItemButtonEditTransferSave.Name = "repositoryItemButtonEditTransferSave";
            this.repositoryItemButtonEditTransferSave.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemButtonEditTransferSave.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositoryItemButtonEditTransferSave_ButtonClick);
            // 
            // tBLMashatTableAdapter
            // 
            this.tBLMashatTableAdapter.ClearBeforeFill = true;
            // 
            // VerifyMemberFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 399);
            this.Controls.Add(this.gridControlData);
            this.Name = "VerifyMemberFrm";
            this.Text = "مراجعة الاعضاء";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DofatSarfActivityFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLMashatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRetirementCenter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditSyn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSCDSyndicate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditSub)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSCDSubCommitte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditMashHalaId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSCDMashHala)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDMY.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDMY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditTransferSave)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlData;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewData;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEditTransferSave;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colSyndicate;
        private DevExpress.XtraGrid.Columns.GridColumn colSubCommitte;
        private DevExpress.XtraGrid.Columns.GridColumn colMMashatId;
        private DevExpress.XtraGrid.Columns.GridColumn colMMashatName;
        private DevExpress.XtraGrid.Columns.GridColumn colMMashatNId;
        private DevExpress.XtraGrid.Columns.GridColumn colsarfnumber;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEditDMY;
        private DevExpress.Data.Linq.LinqServerModeSource LSMSCDSubCommitte;
        private DevExpress.Data.Linq.LinqServerModeSource LSMSCDSyndicate;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditSyn;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditSub;
        private DevExpress.XtraGrid.Columns.GridColumn coldatein;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn colverify_member;
        private DevExpress.Data.Linq.LinqServerModeSource LSMSCDMashHala;
        private DevExpress.XtraGrid.Columns.GridColumn colMashHalaId;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditMashHalaId;
        private DevExpress.Data.Linq.LinqServerModeSource LSMSUser;
        private DataSources.dsRetirementCenter dsRetirementCenter;
        private System.Windows.Forms.BindingSource tBLMashatBindingSource;
        private DataSources.dsRetirementCenterTableAdapters.TBLMashatTableAdapter tBLMashatTableAdapter;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditUser;
    }
}